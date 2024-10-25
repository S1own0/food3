using food_core;
using food_core.DTO_s;
using food_core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_application.Users
{
    public class UserService(IRepository<User> repository) : IService
    {
        private IRepository<User> Repository { get; init; } = repository;

        public async Task<CaloreRequirement> CalculateNutritionalNeedsAsync(User user, CancellationToken cancellationToken = default)
        {
            // Расчет BMR
            double bmr;
            if (user.Gender.ToString() == "Male")
            {
                bmr = 88.362 + (13.397 * user.Weight) + (4.799 * user.Height) - (5.677 * user.Age);
            }
            else
            {
                bmr = 447.593 + (9.247 * user.Weight) + (3.098 * user.Height) - (4.330 * user.Age);
            }

            // Уровень активности
            double activityMultiplier = user.Activitylevel.ToString() switch
            {
                "Low" => 1.2,
                "Moderate" => 1.55,
                "High" => 1.9,
                _ => 1.2
            };

            // Расчет TDEE
            double tdee = bmr * activityMultiplier;

            // Коррекция калорий на основе цели
            double caloricIntake;
            switch (user.Goal.ToString())
            {
                case "Lose_weight":
                    caloricIntake = tdee - 500; // Уменьшаем на 500 ккал
                    break;
                case "Gain_weight":
                    caloricIntake = tdee + 500; // Увеличиваем на 500 ккал
                    break;
                case "Maintain_weight":
                default:
                    caloricIntake = tdee; // Поддерживаем текущий вес
                    break;
            }

            // Расчет БЖУ
            double proteinGrams = (caloricIntake * 0.3) / 4; // 30% белка
            double fatGrams = (caloricIntake * 0.3) / 9; // 30% жира
            double carbGrams = (caloricIntake * 0.4) / 4; // 40% углеводов

            var result = new CaloreRequirement
            {
                ProteinGoal = Math.Round(proteinGrams, 2),
                FatsGoal = Math.Round(fatGrams, 2),
                CarbGoal = Math.Round(carbGrams, 2),
                CalorieGoal = Math.Round(caloricIntake, 2)
            };

            return await Task.FromResult(result);
        }
    }
}

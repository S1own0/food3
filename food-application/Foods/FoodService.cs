using food_core;
using food_core.DTO_s;
using food_core.Entities;
using food_core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_application.Foods
{
    public class FoodService(IRepository<Food> repository) : IService
    {
        private IRepository<Food> Repository { get; init; } = repository;

        public async Task GetFoodById(Guid foodId, CancellationToken cancellationToken)
        {
            var food = (await Repository.Get(x => x.Id.Value == foodId, cancellationToken)).FirstOrDefault() ??
                throw new FoodNotFound(foodId);
        }

        public async Task CreateOrUpdateAsync(FoodDTO food, CancellationToken cancellationToken = default)
        {
            Food localFood;
            if (food.Id is not null)
            {
                localFood = (await Repository.Get(x => x.Id.Value == food.Id.Value, cancellationToken)).FirstOrDefault() ??
                    throw new FoodNotFound(food.Id.Value);
                localFood.Name = food.Name;
                localFood.CalorieAmount = food.CalorieAmount;
                localFood.ProteinAmount = food.ProteinAmount;
                localFood.FatAmount = food.FatAmount;
                localFood.CarbAmount = food.CarbAmount;
            }
            else
                localFood = new()
                {
                    Name = food.Name,
                    CalorieAmount = food.CalorieAmount,
                    ProteinAmount = food.ProteinAmount,
                    FatAmount = food.FatAmount,
                    CarbAmount = food.CarbAmount
                };

            if (localFood.Id is null)
                await Repository.Add(localFood, cancellationToken);
            else
                await Repository.Update(localFood, cancellationToken);
        }



        
    }
}

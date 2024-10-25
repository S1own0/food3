using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using food_core.Entities;

namespace food_core.DTO_s
{
    public class FoodDTO
    {
        public Id Id { get; set; }
        public string Name { get; set; }
        public double CalorieAmount { get; set; }
        public double ProteinAmount { get; set; }
        public double CarbAmount { get; set; }
        public double FatAmount { get; set; }

        public static implicit operator FoodDTO(Food other) =>
            new()
            {
                Id = other.Id,
                Name = other.Name,
                CalorieAmount = other.CalorieAmount,
                ProteinAmount = other.ProteinAmount,
                CarbAmount = other.CarbAmount,
               FatAmount = other.FatAmount


            };
    }
}

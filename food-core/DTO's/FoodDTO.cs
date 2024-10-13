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
        public int calorieAmount { get; set; }
        public double proteinAmount { get; set; }
        public double carbAmount { get; set; }
        public double fatAmount { get; set; }

        public static implicit operator FoodDTO(Food other) =>
            new()
            {
                Id = other.Id,
                Name = other.Name,
                calorieAmount = other.calorieAmount,
                proteinAmount = other.proteinAmount,
                carbAmount = other.carbAmount,
                fatAmount = other.fatAmount


            };
    }
}

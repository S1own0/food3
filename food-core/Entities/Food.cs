using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_core.Entities
{
    public class Food : IEntity
    {
        public Id Id { get; set; }
        public string Name { get; set; }
        public double CalorieAmount { get; set; }
        public double ProteinAmount { get; set; }
        public double CarbAmount { get; set; }
        public double FatAmount { get; set; }

        
        public virtual ICollection<UserFoodLog> UserFoodLog { get; set; }
        public virtual ICollection<UserFoodRecommendation> UserFoodRecommendation { get; set; }
    }
}

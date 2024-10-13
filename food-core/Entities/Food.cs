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
        public int calorieAmount { get; set; }
        public double proteinAmount { get; set; }
        public double carbAmount { get; set; }
        public double fatAmount { get; set; }

        

    }
}

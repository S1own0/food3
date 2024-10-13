using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_core.Entities
{
    public class User : IEntity
    {
        public Id Id {  get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public Gender Gender { get; set; }

        public Activitylevel Activitylevel { get; set; }
        public Goal Goal { get; set; } 

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_core.Entities
{
    public class CaloreRequirement : IEntity
    {
        public Id Id { get; set; }
        public double CalorieGoal {  get; set; }
        public double ProteinGoal { get; set; }
        public double FatsGoal { get; set; }
        public double CarbGoal { get; set; }

        public virtual User User { get; set; }
    }
}

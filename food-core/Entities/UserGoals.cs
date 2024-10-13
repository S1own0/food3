using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_core.Entities
{
   public class UserGoals : IEntity
    {
        public Id Id { get; set; }
        
        public Goal Goal { get; set; }

        public virtual User User { get; set; } 
    }
}


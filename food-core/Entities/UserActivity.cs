using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_core.Entities
{
    public class UserActivity : IEntity
    {
        public Id Id { get; set; }
        public virtual Activitylevel ActivityLevel { get; set; }

        public virtual User User { get; set; } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_core.Entities
{
    public class UserFoodLog : IEntity
    {
        public Id Id { get; set; }
        public DateTime DateTime { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Food> Food { get; set; }
    }
}

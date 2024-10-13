using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_core.Entities
{
    public class UserFoodRecommendation : IEntity
    {
        public Id Id { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection <Food> Food { get; set; }

    }
}

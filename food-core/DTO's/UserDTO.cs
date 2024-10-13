using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using food_core.Entities;

namespace food_core.DTO_s
{
    public class UserDTO
    {
        public Id Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public Gender Gender { get; set; }
        public Activitylevel Activitylevel { get; set; }
        public Goal Goal { get; set; }
        public static implicit operator UserDTO(User other) =>
            new()
            {
                Id = other.Id,
                Name = other.Name,
                Age = other.Age,
                Weight = other.Weight,
                Height = other.Height,
                Gender = other.Gender,
                Activitylevel = other.Activitylevel,
                Goal = other.Goal

            };

    }
}

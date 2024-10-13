using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_core.Exceptions
{
    public class UserNotFound(Guid wrongId) : Exception($"User {wrongId} is not found.") { }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1995 && gamer.FirstName == "Muhammed" && gamer.LastName == "Emen" && gamer.IdentityNumber == 54424)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

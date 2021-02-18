using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}

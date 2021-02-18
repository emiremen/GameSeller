using GameSeller.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller.Abstract
{
    public interface ICheckIdentityService
    {
        bool Check(Gamer gamer);
    }
}

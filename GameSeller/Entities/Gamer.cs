using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller.Entities
{
    public class Gamer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BirthYear { get; set; }
        public long IdentityNumber { get; set; }
    }
}

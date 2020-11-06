using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile :Animal
    {
        public bool IsScaly { get; set; } = true;
        public bool CanGrowTail { get; set; }
        public int LegsCount { get; set; }
        public bool IsColdBlooded { get; set; }

    }
}

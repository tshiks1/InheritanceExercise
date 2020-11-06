using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public bool HasWings { get; set; }
        public string Color(string name)
        {
            return name;
        }
        
public bool LaysEggs { get; set; }
        public int Legs { get; set; }


    }
}

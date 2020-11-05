using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Animal
    {

        public bool LivesOnLand { get; set; } 
        public string Name(string name)
        {
            return name;
        }
        public int Weight
        {
            get;set;
        }
        public bool CanFly { get; set; } = true;
    }

}

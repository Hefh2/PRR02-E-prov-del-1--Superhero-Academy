using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy
{
    class PowerLevel2 : Superhero
    {
        public override void PrintStats()
        {
            Console.Clear();
            Console.WriteLine("Name: " + name + "\nAbility 1: " + ability1 + "\nAbility 2: " + ability2);


        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy
{
    class PowerLevel1 : Superhero
    {
        public override void PrintStats()
        {
            Console.Clear();
            Console.WriteLine("Name: " + name + "\nAbility: " + ability1);


        }
    }


}

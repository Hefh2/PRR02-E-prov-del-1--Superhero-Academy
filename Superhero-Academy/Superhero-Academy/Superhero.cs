using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy
{
    abstract class Superhero
    {
        public string name;
        public string ability1; 
        public string ability2;

        public abstract void PrintStats();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Asks the player about what they want to do. Only option is make a new hero.
            Console.WriteLine("What do you want to do?\nOptions:\n1. Make a new hero");
            string answer;
            answer = Console.ReadLine();

            if (answer == "1")
            {
                //Prepares strings for answers and makes a new superhero to use.
                Superhero s = new PowerLevel1();
                string answer1;
                string answer3;

                //Asks for a name to give the superhero later.
                Console.Clear();
                Console.WriteLine("What's your new superheros name?");
                answer1 = Console.ReadLine();

                //Askas if the hero is powerlevel 1 or 2.
                Console.WriteLine("\nWhat power level is you hero?, 1 or 2?");
                answer3 = Console.ReadLine();
                //If the answer is not 1 or 2 it starts a loop.
                bool loop1 = true;
                if (answer3 == "1" || answer3 == "2")
                {
                    loop1 = false;
                }
                while (loop1 == true)
                {
                    Console.WriteLine("\n");
                    answer3 = Console.ReadLine();
                    //Exits the loop if the answer is suitable.
                    if (answer3 == "1"|| answer3 == "2")
                    {
                        loop1 = false;
                    }
                }

                //Adds the powerlevel and name that the player answered about earlier.
                if (answer3 == "1")
                {
                    s = new PowerLevel1();

                    s.name = answer1;
                    Console.WriteLine("What is " + s.name + "'s ability?");
                    s.ability1 = Console.ReadLine();

                    s.PrintStats();
                    Console.ReadLine();

                } else
                {
                    s = new PowerLevel2();

                    s.name = answer1;

                    Console.WriteLine("What is " + s.name + "'s first ability?");
                    s.ability1 = Console.ReadLine();
                    Console.WriteLine("What is " + s.name + "'s second ability?");
                    s.ability2 = Console.ReadLine();

                    s.PrintStats();
                    Console.ReadLine();
                }

            }

        }
    }
}

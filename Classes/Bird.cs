using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KESCHA.Classes
{
    public class Bird : Animal
    {
        public Bird(string name,int animalAge)
            :base(name,animalAge)
        {

        }
        public override void Greet(string userName)
        {
            System.Console.WriteLine($"Hello {userName}");
        }
    }
}
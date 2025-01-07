using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CombineMini1.Services
{
    public class SayHello : ISayHello
    {
        public string SayingHello(string nameInput)
        {
            return "Hello, " + nameInput + "!";
        }
    }
}
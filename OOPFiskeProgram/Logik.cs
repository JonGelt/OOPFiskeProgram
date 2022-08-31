using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFiskeProgram
{
    internal class Logik
    {
      
        

        public double HentVægt(string type)
        {
            Console.Write($"{type}");
            string input = Console.ReadLine();
            return double.Parse(input);
        }

        public double HentLængde(string type)
        {
            Console.Write($"{type}");
            string input = Console.ReadLine();
            return double.Parse(input);
        }

        public string HentFarve(string type)
        {
            Console.Write($"{type}");
            string input = Console.ReadLine();
            return input;
        }

        public string HentArt(string type)
        {
            Console.Write($"{type}");
            string input = Console.ReadLine();
            return input;
        }

        public string HentNavn(string type)
        {
            Console.Write($"{type}");
            string input = Console.ReadLine();
            return input;

        }

    }
}

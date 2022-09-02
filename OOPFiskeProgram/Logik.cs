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
            double value;
            do
            {
                Console.Write($"{type}");
              

            }while (!double.TryParse(Console.ReadLine(), out value));
          

            return value;
        }

        public double HentLængde(string type)
        {
            double value;
            do
            {
                Console.Write($"{type}");
                

            } while (!double.TryParse(Console.ReadLine(), out value));


            return value;
        }

        public string HentFarve(string type)
        {
            string? input;
            do
            {
                Console.Write(type);
                input = Console.ReadLine();
            }
            while (input == null || input == "" || input.All(char.IsDigit) || input.StartsWith(" "));
            return input;
        }

        public string HentArt(string type)
        {
            string? input;
            do
            {
                Console.Write(type);
                input = Console.ReadLine();
            }
            while (input == null || input == "" || input.All(char.IsDigit) || input.StartsWith(" "));
            return input;
        }

        public string HentNavn(string type)
        {
            string? input;
            do
            {
                Console.Write(type);
                input = Console.ReadLine();
            }
            while (input == null || input == "" || input.All(char.IsDigit) || input.StartsWith(" "));
            return input;

        }

    }
}

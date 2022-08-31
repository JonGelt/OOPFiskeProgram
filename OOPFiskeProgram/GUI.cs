using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFiskeProgram
{
    internal class GUI
    {
        DTO dto = new DTO();
        SaltvandsFisk kødædeneSaltvandsFisk = new SaltvandsFisk();
        Logik logik = new Logik();

        public GUI()
        {
            while(true)
            {
              
                Menu();
            }          

        }

        public void Menu()
        {
           
            Console.WriteLine("FISK DATABASE\n\n1. Ferskvand Fisk\n\n2. Saltvand Fisk");


            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    FerskvandMenu();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    SaltvandMenu();
                    break;
                default:
                    break;
            }
        }

        private void SaltvandMenu()
        {
            
            Console.WriteLine("FISK DATABASE\n\n1. Kødædene Saltvands Fisk\n\n2. Planteædene Saltvands Fisk");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    KødÆdeneSaltvandsFisk();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    //SaltvandMenu();
                    break;
                default:
                    break;
            }
        }

        private void KødÆdeneSaltvandsFisk()
        {
           
            Console.WriteLine("FISK DATABASE\n\n1. Se Kødædene Saltvands Fisk liste\n\n2. tilføj Kødædene Saltvands Fisk til liste");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    VisKødÆdeneSaltvandsFiskList();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    TilføjKødÆdeneSaltvandsFisk();
                    break;
                default:
                    break;
            }



        }

      
        private void TilføjKødÆdeneSaltvandsFisk()
        {
         
            
         
            kødædeneSaltvandsFisk.Navn = logik.HentNavn("Navn: ");
            kødædeneSaltvandsFisk.Art = logik.HentArt("Art: ");
            kødædeneSaltvandsFisk.Farve = logik.HentFarve("Farve: ");
            kødædeneSaltvandsFisk.Længde = logik.HentLængde("Længde: ");
            kødædeneSaltvandsFisk.Vægt = logik.HentVægt("Vægt: ");
            VisKødÆdeneSaltvandsFisk(kødædeneSaltvandsFisk);

            Console.WriteLine("\nTilføj til liste? (Y/N)");
            if (Console.ReadKey().Key == ConsoleKey.Y) dto.KødÆdeneSaltvandsFiskList.Add(kødædeneSaltvandsFisk);

        }

        private void VisKødÆdeneSaltvandsFiskList()
        {

            foreach (SaltvandsFisk saltvandsFisk in dto.KødÆdeneSaltvandsFiskList) 
            {
                VisKødÆdeneSaltvandsFisk(saltvandsFisk);

            }

            
        }

        private void VisKødÆdeneSaltvandsFisk(SaltvandsFisk saltvandsFisk)
        {
            Console.Clear();

            Console.WriteLine($"Navn: {saltvandsFisk.Navn}\nArt: {saltvandsFisk.Art}\nFarve: {saltvandsFisk.Farve}\nLængde: {saltvandsFisk.Længde}\nVægt: {saltvandsFisk.Vægt}  ");

        }

        private void FerskvandMenu()
        {
            Console.Clear();
            Console.WriteLine("FISK DATABASE\n\n1. Kødædene Fersksvand Fisk\n\n2. Planteædene Ferskvands Fisk");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    //FerskvandMenu();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    //SaltvandMenu();
                    break;
                default:
                    break;
            }

        }
    }


}


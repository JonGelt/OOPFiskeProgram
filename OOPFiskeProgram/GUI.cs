using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFiskeProgram
{
    internal class GUI
    {
        DTO dto = new DTO();              
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
            Console.Clear();
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
            Console.Clear();
            Console.WriteLine("FISK DATABASE\n\n1. Kødædene Saltvands Fisk\n\n2. Planteædene Saltvands Fisk");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    KødÆdeneSaltvandsFisk();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    PlanteÆdeneSaltvandsFisk();
                    break;
                default:
                    break;
            }
        }

        private void KødÆdeneSaltvandsFisk()
        {
            Console.Clear();
            Console.WriteLine("FISK DATABASE\n\n1. Se Kødædene Saltvands Fisk liste\n\n2. Tilføj Kødædene Saltvands Fisk til liste");

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
            Console.Clear();

            SaltvandsFisk kødædeneSaltvandsFisk = new SaltvandsFisk();

            kødædeneSaltvandsFisk.Navn = logik.HentNavn("Navn: ");
            kødædeneSaltvandsFisk.Art = logik.HentArt("Art: ");
            kødædeneSaltvandsFisk.Farve = logik.HentFarve("Farve: ");
            kødædeneSaltvandsFisk.Længde = logik.HentLængde("Længde: ");
            kødædeneSaltvandsFisk.Vægt = logik.HentVægt("Vægt: ");
            Console.Clear();
            VisKødÆdeneSaltvandsFisk(kødædeneSaltvandsFisk);

            Console.WriteLine("\nTilføj til liste? (Y/N)");
            if (Console.ReadKey().Key == ConsoleKey.Y) dto.KødÆdeneSaltvandsFiskList.Add(kødædeneSaltvandsFisk);

        }

        private void VisKødÆdeneSaltvandsFiskList()
        {

            int counter = 0;
            foreach (SaltvandsFisk kødædeneSaltvandsFisk in dto.KødÆdeneSaltvandsFiskList) 
            {
            
                counter++;

                Console.WriteLine($"{counter}.");
                VisKødÆdeneSaltvandsFisk(kødædeneSaltvandsFisk);
                

            }
            Console.WriteLine("\nTryk Y for at forsætte");
            Console.ReadKey();

        }

        private void VisKødÆdeneSaltvandsFisk(SaltvandsFisk saltvandsFisk)
        {
            

            Console.WriteLine($"Navn: {saltvandsFisk.Navn}\nArt: {saltvandsFisk.Art}\nFarve: {saltvandsFisk.Farve}\nLængde: {saltvandsFisk.Længde}\nVægt: {saltvandsFisk.Vægt}  ");

        }

        private void PlanteÆdeneSaltvandsFisk()
        {
            Console.Clear();
            Console.WriteLine("FISK DATABASE\n\n1. Se Planteædene Saltvands Fisk liste\n\n2. Tilføj Planteædene Saltvands Fisk til liste");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.Clear();
                    VisPlanteÆdeneSaltvandsFiskList();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    TilføjPlanteÆdeneSaltvandsFisk();
                    break;
                default:
                    break;
            }



        }


        private void TilføjPlanteÆdeneSaltvandsFisk()
        {
            Console.Clear();
            SaltvandsFisk planteædeneSaltvandsFisk = new SaltvandsFisk();

            planteædeneSaltvandsFisk.Navn = logik.HentNavn("Navn: ");
            planteædeneSaltvandsFisk.Art = logik.HentArt("Art: ");
            planteædeneSaltvandsFisk.Farve = logik.HentFarve("Farve: ");
            planteædeneSaltvandsFisk.Længde = logik.HentLængde("Længde: ");
            planteædeneSaltvandsFisk.Vægt = logik.HentVægt("Vægt: ");
            Console.Clear();
            VisPlanteÆdeneSaltvandsFisk(planteædeneSaltvandsFisk);

            Console.WriteLine("\nTilføj til liste? (Y/N)");
            if (Console.ReadKey().Key == ConsoleKey.Y) dto.PlanteÆdeneSaltvandsFiskList.Add(planteædeneSaltvandsFisk);

        }

        private void VisPlanteÆdeneSaltvandsFiskList()
        {
            Console.Clear();
            int counter = 0;
            foreach (SaltvandsFisk saltvandsFisk in dto.PlanteÆdeneSaltvandsFiskList)
            {
                counter++;
               
                Console.WriteLine($"{counter}.");
                VisPlanteÆdeneSaltvandsFisk(saltvandsFisk);
              

            }
            Console.WriteLine("\nTryk Y for at forsætte");
            Console.ReadKey();

        }

        private void VisPlanteÆdeneSaltvandsFisk(SaltvandsFisk saltvandsFisk)
        {
            

            Console.WriteLine($"Navn: {saltvandsFisk.Navn}\nArt: {saltvandsFisk.Art}\nFarve: {saltvandsFisk.Farve}\nLængde: {saltvandsFisk.Længde}\nVægt: {saltvandsFisk.Vægt}\n  ");

        }

        private void FerskvandMenu()
        {
            Console.Clear();
            Console.WriteLine("FISK DATABASE\n\n1. Kødædene Fersksvand Fisk\n\n2. Planteædene Ferskvands Fisk");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    KødÆdeneFerskvandsFisk();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    PlanteÆdeneFerskvandsFisk();
                    break;
                default:
                    break;
            }

        }

        private void KødÆdeneFerskvandsFisk()
        {
            Console.Clear();
            Console.WriteLine("FISK DATABASE\n\n1. Se Kødædene Ferskvands Fisk liste\n\n2. Tilføj Kødædene Ferskvands Fisk til liste");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    VisKødÆdeneFerskvandsFiskList();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    TilføjKødÆdeneFerskvandsFisk();
                    break;
                default:
                    break;
            }



        }


        private void TilføjKødÆdeneFerskvandsFisk()
        {
            Console.Clear();

            FersksvandFisk kødædeneFerskvandsFisk = new FersksvandFisk();

            kødædeneFerskvandsFisk.Navn = logik.HentNavn("Navn: ");
            kødædeneFerskvandsFisk.Art = logik.HentArt("Art: ");
            kødædeneFerskvandsFisk.Farve = logik.HentFarve("Farve: ");
            kødædeneFerskvandsFisk.Længde = logik.HentLængde("Længde: ");
            kødædeneFerskvandsFisk.Vægt = logik.HentVægt("Vægt: ");
            Console.Clear();
            VisKødÆdeneFerskvandsFisk(kødædeneFerskvandsFisk);

            Console.WriteLine("\nTilføj til liste? (Y/N)");
            if (Console.ReadKey().Key == ConsoleKey.Y) dto.KødÆdeneFerskvandsFiskList.Add(kødædeneFerskvandsFisk);

        }

        private void VisKødÆdeneFerskvandsFiskList()
        {
            Console.Clear();
            int counter = 0;
            foreach (FersksvandFisk kødædeneFerskvandsFisk in dto.KødÆdeneFerskvandsFiskList)
            {

                counter++;

                Console.WriteLine($"{counter}.");
                VisKødÆdeneFerskvandsFisk(kødædeneFerskvandsFisk);


            }
            Console.WriteLine("\nTryk Y for at forsætte");
            Console.ReadKey();

        }

        private void VisKødÆdeneFerskvandsFisk(FersksvandFisk saltvandsFisk)
        {


            Console.WriteLine($"Navn: {saltvandsFisk.Navn}\nArt: {saltvandsFisk.Art}\nFarve: {saltvandsFisk.Farve}\nLængde: {saltvandsFisk.Længde}\nVægt: {saltvandsFisk.Vægt}  ");

        }

        private void PlanteÆdeneFerskvandsFisk()
        {
            Console.Clear();
            Console.WriteLine("FISK DATABASE\n\n1. Se Planteædene Saltvands Fisk liste\n\n2. Tilføj Planteædene Saltvands Fisk til liste");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.Clear();
                    VisPlanteÆdeneFerskvandsFiskList();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    TilføjPlanteÆdeneFerskvandsFisk();
                    break;
                default:
                    break;
            }



        }


        private void TilføjPlanteÆdeneFerskvandsFisk()
        {
            Console.Clear();
            FersksvandFisk planteædeneFerskvandsFisk = new FersksvandFisk();

            planteædeneFerskvandsFisk.Navn = logik.HentNavn("Navn: ");
            planteædeneFerskvandsFisk.Art = logik.HentArt("Art: ");
            planteædeneFerskvandsFisk.Farve = logik.HentFarve("Farve: ");
            planteædeneFerskvandsFisk.Længde = logik.HentLængde("Længde: ");
            planteædeneFerskvandsFisk.Vægt = logik.HentVægt("Vægt: ");
            Console.Clear();
            VisPlanteÆdeneFerskvandsFisk(planteædeneFerskvandsFisk);

            Console.WriteLine("\nTilføj til liste? (Y/N)");
            if (Console.ReadKey().Key == ConsoleKey.Y) dto.PlanteÆdeneFerskvandsFiskList.Add(planteædeneFerskvandsFisk);

        }

        private void VisPlanteÆdeneFerskvandsFiskList()
        {
            Console.Clear();
            int counter = 0;
            foreach (FersksvandFisk ferskvandsFisk in dto.PlanteÆdeneFerskvandsFiskList)
            {
                counter++;

                Console.WriteLine($"{counter}.");
                VisPlanteÆdeneFerskvandsFisk(ferskvandsFisk);


            }
            Console.WriteLine("\nTryk Y for at forsætte");
            Console.ReadKey();

        }

        private void VisPlanteÆdeneFerskvandsFisk(FersksvandFisk ferskvandsFisk)
        {


            Console.WriteLine($"Navn: {ferskvandsFisk.Navn}\nArt: {ferskvandsFisk.Art}\nFarve: {ferskvandsFisk.Farve}\nLængde: {ferskvandsFisk.Længde}\nVægt: {ferskvandsFisk.Vægt}\n  ");

        }
    }


}


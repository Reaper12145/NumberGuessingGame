using System;
namespace NumberG
{ class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool znova = true;
            int min = 1;
            int max = 100;
            int pokus;
            int cislo;
            int pokusy;
            String odpoved;

            while (znova)
            {
                pokus = 0;
                pokusy = 0;
                odpoved = "";
                cislo = random.Next(min, max + 1);
                while (pokus != cislo)
                {

                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Hádané číslo je mezi " + min + " - " + max + " : ");
                        pokus = Convert.ToInt32(Console.ReadLine());
                        if (pokus > cislo)
                        {
                            Console.WriteLine(pokus + " Moc vysoké číslo!");
                        }
                        else if (pokus < cislo)
                        {
                            Console.WriteLine(pokus + " Moc nízké číslo!");
                        }
                        pokusy++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Musíš zadat číslo!!!");
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bylo to číslo: " + cislo);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Pokusy: " + pokusy);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pro ukončení zadej (N/2) ");
                Console.WriteLine("Pro pokračování zadej cokoli jiného");
                odpoved = Console.ReadLine();
                odpoved = odpoved.ToUpper();

                if (odpoved == "N")
                {
                    znova = false;
                }
                else
                {
                    znova = true;
                }
                if (odpoved == "2")
                {
                    znova = false;
                }
                else
                {
                    znova = true;
                }
            }
        }
    }
}
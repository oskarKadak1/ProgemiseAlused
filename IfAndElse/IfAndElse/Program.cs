namespace IfAndElse
{
    //Projekt nimetusega IfAndElse, mille sees asub
    //class nimega Program. See class sisaldab Main meetodit,
    //mis on programmi sisenemispunkt.

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda nimi:");

            //muutuja nimega name, kuhu salvestatakse kasutaja
            //sisestatud tekst 
            string name = Console.ReadLine();

            //! Tähendab "ei ole" ja == tähendab "on võrdne"
            if (name != " ")
            {
                //Kui kasutaja sisestab midagi, siis muudetakse taustavärv
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Sisestasid enda nime");
                Console.WriteLine(name);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ERROR. Nime ei sisestanud");
                //kui kasuaja ei sisesta midagi, siis kostub 2 piiksu
                Console.Beep();
                //Ja oodatakse 1 sekund enne programmi lõppu
                Thread.Sleep(1000);
                Console.Beep();
            }
        }
    }
}


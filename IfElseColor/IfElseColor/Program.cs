using System.Drawing;

namespace IfElseColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta värv");
            //Kirjuta konsooli tekst ja vajuta enter
            //kui kasutad if ja else, siis esimene kontroll on if
            //ja järgneb else if ning kõige viimane on alati else
            String Color = Console.ReadLine();
            if (Color == "Red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sisestasite Red");
            }
            else if (Color == "Blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Sisestasite Blue");
            }
            else if (Color == "Green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sisestasite Green");
            }
            else if (Color == "White")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Sisestasite White");
            }
            else
            {
                Console.WriteLine("Vale värv");
            }

        }
    }
}

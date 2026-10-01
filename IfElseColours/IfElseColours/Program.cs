namespace IfElseColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta värv");
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
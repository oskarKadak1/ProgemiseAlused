namespace IfElseAutod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali automark");
            String auto = Console.ReadLine();

            if (auto == "BMW")
            {
                Console.WriteLine("Valisite BMW");
            }
            else if (auto == "Audi")
            {
                Console.WriteLine("Valisite Audi");
            }
            else if (auto == "Porsche")
            {
                Console.WriteLine("Valisite Porsche");
            }
            else if (auto == "Fiat")
            {
                Console.WriteLine("Valisite Fiat");
            }
            else if (auto == "Skoda")
            {

                Console.WriteLine("Valisite Skoda");
                Console.WriteLine("Milline mudel?");
                String mudel = Console.ReadLine();

                if (mudel == "Kodiaq")
                {
                    Console.WriteLine("Valisite Kodiaq");
                }
                else if (mudel == "Octavia")
                {
                    Console.WriteLine("Valisita Octavia");
                }
                else
                {
                    Console.WriteLine("Vale mudel");
                }
            }
            else
            {
                Console.WriteLine("Vale automark");
            }
        }
    }
}

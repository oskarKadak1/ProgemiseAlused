namespace ForLoopTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tährnidest kolmnurk e poolik püramiid");
            Console.WriteLine("-------------------------------------");
            // \n tähendab uut rida
            Console.WriteLine("\n\n");

            Console.WriteLine("sisesta ridade arv: ");

            int i, j, rows;

            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }

        }
    }
}

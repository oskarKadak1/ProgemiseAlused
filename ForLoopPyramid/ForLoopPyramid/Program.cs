namespace ForLoopPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tärnidest teemant");
            Console.WriteLine("-------------------------------------");
            // \n tähendab uut rida
            Console.WriteLine("\n\n");

            Console.WriteLine("sisesta ridade arv: ");

            int i, j, rows;
            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                    Console.Write(" ");

                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.Write("\n");
            }

            for (i = rows - 1; i >= 1; i--)
            {
                for (j = 1; j <= rows - i; j++)
                    Console.Write(" ");

                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.Write("\n");
            }
        }
    }
}

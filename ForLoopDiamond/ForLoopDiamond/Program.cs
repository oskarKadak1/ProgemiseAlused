namespace ForLoopDiamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teemant");
            Console.WriteLine("-------");
            Console.WriteLine("\n\n");

            //teha for loopiga püramiid

            Console.WriteLine("sisesta ridade arv: ");

            int i, j, rida;
            rida = Convert.ToInt32(Console.ReadLine());

            //Teemandi esimene pool
            for (i = 0; i <= rida; i++)
            {
                for (j = 1; j <= rida - i; j++)
                    Console.Write(" ");

                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.Write("\n");
            }

            //Teemandi teine pool (tagurpidi püramiid), mis teeb selle teemandiks
            for (i = rida - 1; i >= 1; i--)
            {
                for (j = 1; j <= rida - i; j++)
                    Console.Write(" ");

                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.Write("\n");
            }
        }
    }
}

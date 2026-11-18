namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Korrutustabel");

            int j, i, n;

            Console.WriteLine("Sisesta tabelisse number, mis on viimane korrutis");

            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Korrutustabel 1 kuni {0} \n", n);

            //kaks for loopi ja üks on teise sees

            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if (j <= n - 1)
                        Console.Write("{0}x{1} = {2}, ", j, i, i * j);
                    else
                        Console.Write("{0}x{1} = {2}", j, i, i * j);
                }
                Console.Write("\n");
            }
        }
    }
}
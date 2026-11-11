namespace ForKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //eelnevaid teadmisi kasutades kirjuta program, mis väljastaks:
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll

            //iga kord, kui hakkab väljundit kordama, siis näitab rea numbrit
            Console.WriteLine("Mitu korda soovid väljundit korrata?");
            int loop = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= loop; i++)
            {
                Console.WriteLine("See on rida nr {0}", i);
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("kill - koll");
                }
                Console.WriteLine("killadi - koll");
            }
        }
    }
}

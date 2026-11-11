namespace ForLoopHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //teha konsoolirakendus, kus kasutad for loopi
            //kolm korda näidatakse Tere tulemast ja lõpus on reanumber
            //kasutaja ei tohi sisestada midagi

            int loop = 3;

            for (int i = 0; i < loop; i++)
            {
                Console.WriteLine("Tere tulemast " + i);
            }
        }
    }
}

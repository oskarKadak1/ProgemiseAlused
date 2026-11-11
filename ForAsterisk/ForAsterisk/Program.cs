namespace ForAsterisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tuleb kasutada for loopi
            //sisestan konsooli ridade arvu ja pridib vastavalt ridade arvule tärne
            //kasutada for loopi
            //teha vooskeem
            Console.WriteLine("Sisesta mitu asteriski soovid panna");
            int asterisk = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < asterisk; i++)
            {
                Console.WriteLine("*");
            }
        }
    }
}

namespace SwitchLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali meetod (1-3)");
            //Tee kolm meetodit, mis teevad järgmist:
            //esimene ütleb: auh
            //teine ütleb: tahan magada
            //kolmas ütleb: tahan õppida
            //need tuleb esile kutsuda numbri valikuga
            //Tuleb kasutada switchi
            //Tuleb teha menüü, kus kasutaja saab valida, millist meetodit ta tahab esile kutsuda

            Console.WriteLine("1. valik: auh");
            Console.WriteLine("2. valik: tahan magada");
            Console.WriteLine("3. valik: tahan õppida");

            int valik = int.Parse(Console.ReadLine());
            switch (valik)
            {
                case 1:
                    Auh();
                    break;
                case 2:
                    Magamine();
                    break;
                case 3:
                    Õppimine();
                    break;
                default:
                    Console.WriteLine("Sisestasite vale numbri");
                    break;
            }
        }
        static void Auh()
        {
            Console.WriteLine("Auh");
        }
        static void Magamine()
        {
            Console.WriteLine("Tahan magada");
        }
        static void Õppimine()
        {
            Console.WriteLine("Tahan õppida");
        }
    }
}
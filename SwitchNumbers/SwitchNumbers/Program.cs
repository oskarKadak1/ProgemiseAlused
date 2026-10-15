namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjutage number 10, 20 või 30");
            //tuleb teha switch, kus esimene case on 10,
            //teine on 20 ja kolmas on 30

            string number = Console.ReadLine();

            switch (number)
            {
                case "10":
                    Console.WriteLine("valisite 10");
                    break;
                case "20":
                    Console.WriteLine("valisite 20");
                    break;
                case "30":
                    Console.WriteLine("valisite 30");
                    break;
                default:
                    Console.WriteLine("Kahtlased numbrid");
                    break;
            }
        }
    }
}

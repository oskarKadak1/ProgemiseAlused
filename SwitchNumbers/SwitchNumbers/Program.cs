namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjutage number 10, 20 või 30");
            //tuleb teha switch, kus esimene case on 10,
            //teine on 20 ja kolmas on 30

            int input = int.Parse(Console.ReadLine());
            
            switch (input)
            {
                case 10:
                    Console.WriteLine("valisite 10");
                    break;

                case 20:
                    Console.WriteLine("valisite 20");
                    break;

                case 30:
                    Console.WriteLine("valisite 30");
                    break;

                default:
                    Console.WriteLine("mingid Kahtlased numbrid on: " + input);
                    break;
            }
        }
    }
}

namespace SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");
            //esimese koondtulemuse puhul on number vahemikus
            //0 kuni sada
            //Teisel puhul 101 kuni 200 ja
            //kolmanda puhul 201 kuni 300
            //kasutada switchi
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case <= 100 and >= 0:
                    Console.WriteLine("Number on 0 kuni 100");
                    break;
                case <= 200 and >= 101:
                    Console.WriteLine("Number on 101 kuni 200");
                    break;
                case <= 300 and >= 201:
                    Console.WriteLine("Number on 201 kuni 300");
                    break;
                default:
                    Console.WriteLine("Mingi kahtlane number");
                    break;
            }
        }
    }
}

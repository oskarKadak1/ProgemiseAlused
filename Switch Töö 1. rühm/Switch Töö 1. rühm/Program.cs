namespace Switch_Töö_1._rühm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esimeses tehakse liitmine (Sisend küsitakse konsoolis)
            // teisele kutsutakse meetod esile ja see kuvab teksti auh
            // kolmas küsib nime ja kuvab tulemuse konsoolis
            
            Console.WriteLine("Vali tegevus");
            Console.WriteLine("1. kahe numbri liitmine");
            Console.WriteLine("2. Kuva tekst auh");
            Console.WriteLine("3. Sisesta nimi");
            Console.WriteLine("Sisesta number, kas 1, 2 või 3");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Sisesta esimene number");
                    float input1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Sisesta teine number");
                    float input2 = float.Parse(Console.ReadLine());

                    Console.WriteLine(input1 + " + " + input2 + " = " + (input1 + input2));
                    break;

                case 2:
                    Auh();
                    break;

                case 3:
                    Console.WriteLine("Sisesta nimi");
                    string nimi = Console.ReadLine();
                    Console.WriteLine("Sisestatud nimi on " + nimi);
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
    }
}

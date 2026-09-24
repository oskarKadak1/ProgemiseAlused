namespace IfElseOddAndEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");
            //konsool küsib numbrit
            //number tuleb ära parsida

            //if ja eöse juures toimub kontroll, et
            //kas on paaris või paaritu nr
            string input = Console.ReadLine();
            int number = int.Parse(input);

            //% jagab muutujat number 2
            //kui 2 asemel panna 3, siis jagab 3-ga
            if (number %2 == 0)
            {
                Console.WriteLine("See on paarisarv " + input);
                PaarisArv();
                //siia tuleb välja kutsuda meetod,
                //mis ütleb, et see on paarisarv
            }
            else
            {
                Console.WriteLine("See on paaritu number " + input);
                PaarituArv();
                //siia tuleb välja kutsuda meetod,
                //mis ütleb, et see on paaritu arv
            }

        }

        static void PaarituArv()
        {
            Console.WriteLine("Antud number on paaritu arv");
        }
        static void PaarisArv()
        {
            Console.WriteLine("Antud number on paarisarv");
        }
    }
}

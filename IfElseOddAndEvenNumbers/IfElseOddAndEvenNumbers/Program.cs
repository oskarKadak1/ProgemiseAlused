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
            if (float.TryParse(input, out float number))
            {
                if (float.IsInteger(number / 2))
                {
                    Console.WriteLine("Number on Even");
                }
                else
                {
                    Console.WriteLine("Number on odd");
                }

            }
            
        }
    }
}

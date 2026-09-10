namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");

            //konsoolis sisestame numbri
            //see number salvestatakse stringi andmetüüpi
            //toimub kontroll, kas sisestatud väärtus on number
            //kasutada if ja else lauseid

            string input Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                Console.WriteLine($"Sisestatud number on: {number}");
            }
            else
            {
                Console.WriteLine("Sisestatud väärtus pole number");
            }
        }
    }
}

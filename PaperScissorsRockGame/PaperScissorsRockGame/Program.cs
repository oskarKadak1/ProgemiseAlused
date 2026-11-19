namespace PaperScissorsRockGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string PLayerChoice = "";
            int playerPoints = 0;
            int computerPoints = 0;

            while (PLayerChoice != "lõpeta")
            {
                Console.WriteLine("Vali: kivi, paper või käärid");
                Console.WriteLine("Mängu lõpetamiseks kirjuta: lõpeta");
                //ToLower muudab sinu kirjutatud teksti väikesteks tähtedeks
                PLayerChoice = Console.ReadLine().ToLower();

                if (PLayerChoice == "lõpeta")
                {
                    break;
                }

                if (PLayerChoice != "kivi" && 
                    PLayerChoice != "paber" &&
                    PLayerChoice != "käärid")
                {
                    Console.WriteLine("Sellist valikut pole, Proovi uuesti.");
                    continue;
                }

                int computerNumber = random.Next(1, 4);
                string computerChoice = "";

                if (computerNumber == 1)
                {
                    computerChoice = "kivi";
                }
                else if (computerNumber == 2)
                {
                    computerChoice = "paber";
                }
                else
                {
                    computerChoice = "käärid";
                }

                Console.WriteLine($"Arvuti valis: {computerChoice}");

                if (PLayerChoice == computerChoice)
                {
                    Console.WriteLine("Viik!");
                }
                else if ((PLayerChoice == "kivi" && computerChoice == "käärid") ||
                        (PLayerChoice == "paber" && computerChoice == "kivi") ||
                        (PLayerChoice == "käärid" && computerChoice == "paber"))
                {
                    Console.WriteLine("Sina võitsid!");
                    playerPoints++;
                }
                else
                {
                    Console.WriteLine("Arvuti võitis!");
                    computerPoints++;
                }

                Console.WriteLine($"Punktid: sina {playerPoints} -- arvuti {computerPoints}");
                Console.WriteLine();
            }

            Console.WriteLine("Mäng on läbi!");
            Console.WriteLine($"Lõpptulemus: sina {playerPoints} -- arvuti {computerPoints}");
        }
    }
}

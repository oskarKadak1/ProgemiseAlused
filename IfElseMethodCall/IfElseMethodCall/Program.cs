namespace IfElseMethodCall
{
    internal class Program
    {
        //Main on meetod, mis läheb alati esimesena tööle
        static void Main(string[] args)
        {
            Console.WriteLine("Soovid meetodi välja kutsuda?");
            //Kasutada if ja else.
            //kui kasutaja soovib, siis saab ta meetodi välja kutsuda
            Console.WriteLine("Vajuta Y, kui soovid meetodi välja kutsuda");
            string qs = Console.ReadLine();
            if (qs == "Y")
            {
                //Kui kirjutan meetodi nime, siis seda nimetatakse
                //meetodi välja kutsumiseks
                HelloMethod();
            }
            else
            {
                Console.WriteLine("Ei vajutanud Y");
            }
        }

        //teha teine meetod siia ja nimeks on sellel HelloMethod

        static void HelloMethod()
        {
            Console.WriteLine("Hello Kitty");
        }
    }
}

namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MaaKalkulaator");
            //Meil on münt, mille diameeter on 25.75 mm
            //Arvutada välja maa ümbermõõt ja mitu münti
            //mahub järjestikku ümber maa
            //arvutuses tohib kasutada ainult mündi diameetrit ja Maa raadiust

            double coinDiameter = 25.75; //mm
            double earthRadius = 6378000000;

            Console.WriteLine("Maa ümbermõõt");
            double calculation1 = 2 * Math.PI * earthRadius;
            Console.WriteLine("2 * 3.14 * " + earthRadius + " = " + calculation1);
            Console.WriteLine(" ");

            //Mitu münti
            double calculation2 = calculation1 / coinDiameter;
            Console.WriteLine(calculation1 + " / " + coinDiameter + " = " + calculation2);
            Console.WriteLine("Kahe euroseid läheb ümber maa {0:0}", calculation2);
            

        }
    }
}

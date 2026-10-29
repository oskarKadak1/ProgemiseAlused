namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kujundi kalkulaator");

            //Ruudu sees asub ring. Ringi raadius on 3 ühikut
            //Leia ja väljasta ekraanile ruudu pindala ja ümbermõõt

            int roundRadius = 3;
            Console.WriteLine("Ringi raadius on " + roundRadius);
            Console.WriteLine(" ");

            int roundDiamater = roundRadius * 2;
            Console.WriteLine("Ringi diameeter on " + roundDiamater);
            Console.WriteLine(" ");

            int squareArea = roundDiamater * roundDiamater;
            Console.WriteLine("Ruudu pindala on " + squareArea);
            Console.WriteLine(" ");
            
            int squareCircumfrence = roundDiamater * 4;
            Console.WriteLine("Ruudu ümbermõõt on " + squareCircumfrence);
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            //Arvuti ringi pindala ja ümbermõõt

            double roundCircumfrence = 2 * Math.PI * roundRadius;
            Console.WriteLine("Ringi ümbermõõt on " + roundCircumfrence);
            Console.WriteLine("");


            double roundArea = Math.PI * (roundRadius * roundRadius);
            Console.WriteLine("Ringi pindala on " + roundArea);
        }
    }
}
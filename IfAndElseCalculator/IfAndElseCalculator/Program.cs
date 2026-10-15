namespace IfAndElseCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number");
            float input1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta teine number");
            float input2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Kasuta tingimärki: *, /, +, -");
            string symbol = Console.ReadLine();

            if (symbol is "*")
            {
                Console.WriteLine(input1 + " korda " + input2 + " võrdub " + (input1 * input2));
            }
            else if (symbol is "/")
            {
                Console.WriteLine(input1 + " jagatud " + input2 + " võrdub " + (input1 / input2));
                if (input1 is 0)
                {
                    Console.Clear();
                    Console.WriteLine("Nulliga ei saa jagada");
                    Console.Beep();
                }
                else if (input2 is 0)
                {
                    Console.Clear();
                    Console.WriteLine("Nulliga ei saa jagada");
                    Console.Beep();
                }
            }
            else if (symbol is "+")
            {
                Console.WriteLine(input1 + " pluss " + input2 + " võrdub " + (input1 + input2));
            }
            else if (symbol is "-")
            {
                Console.WriteLine(input1 + " miinus " + input2 + " võrdub " + (input1 - input2));
            }
            else
            {
                Console.WriteLine("Vale sümbol");
            }
        }
    }
}

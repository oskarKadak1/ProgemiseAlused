namespace SwitchCalculator
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

            //nüüd tuleb teha switchi valik, kas *. /, +. -
            //tuleb teha neli case, kus toimub soovitud tehe
            //peab näitama tehte tulemust
            //kasutage floati

            switch (symbol)
            {
                case "*":
                    Console.WriteLine(input1 + " korda " + input2 + " võrdub " + (input1 * input2));
                    break;
                case "/":
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
                    else
                        break;
                    break;
                case "+":
                    Console.WriteLine(input1 + " pluss " + input2 + " võrdub " + (input1 + input2));
                    break;
                case "-":
                    Console.WriteLine(input1 + " miinus " + input2 + " võrdub " + (input1 - input2));
                    break;
                default:
                    Console.WriteLine("Vale sümbol");
                    break;
            }

        }
    }
}

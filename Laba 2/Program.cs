using static System.Console;

namespace Laba_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Another one");
            int A, B;
            WriteLine("Give me an A");
            string strA = ReadLine();
            if (!Int32.TryParse(strA, out A)) {
                WriteLine("A must be a number!");
                return;
            }
            WriteLine("Give me a 'B'");
            string strB = ReadLine();
            if (!Int32.TryParse(strB, out B)) {
                WriteLine("B must be a number!");
                return;
            }
            WriteLine("Choose the action:\n1 : +\n2 : -\n3 : *\n4 : /");
            string action = ReadLine();
            switch (action) {
            case "1":
            case "+":

                WriteLine($"{A} + {B} = {Addition.Add(A, B)}");
                break;

            case "2":
            case "-":
                WriteLine($"{A} - {B} = {A - B}");
                break;

            case "3":
            case "*":
                WriteLine($"{A} * {B} = {A * B}");
                break;

            case "4":
            case "/":
                if (B == 0) {
                    WriteLine("You can't divide by zero!");
                    return;
                }
                WriteLine($"{A} / {B} = {A / B}");
                break;

            default:
                WriteLine("You picked the wrong action!");
                return;
            }
        }
    }
}
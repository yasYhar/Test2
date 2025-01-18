using System.Security.Cryptography.X509Certificates;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc Equ = new Calc();
            Console.WriteLine("Enter integer1 :");
            Equ.Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer2 :");
            Equ.Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select Op :");
            String ?Op = Console.ReadLine();
            switch (Op)
            {
                case "+" :
                    Console.WriteLine(Equ.calcAdd(Equ.Num1 , Equ.Num2));
                    break;
                case "-" :
                    Console.WriteLine(Equ.calcMinus(Equ.Num1, Equ.Num2));
                    break;
                case "*":
                    Console.WriteLine(Equ.calcMulti(Equ.Num1, Equ.Num2));
                    break;
                case "/":
                    Console.WriteLine(Equ.calcDiv(Equ.Num1, Equ.Num2));
                    break;
                default :
                    Console.WriteLine("Invalid Op");
                    break;
            }

        }

    }
    interface Icalc {
        int Num1 { get; set; }
        int Num2 { get; set;}
        int calcAdd(int Num1 , int Num2);
        int calcMinus(int Num1 , int Num2);
        int calcMulti(int Num1 , int Num2);
        string calcDiv(int Num1 , int Num2);

    }

    public class Calc : Icalc {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int calcAdd(int Num1, int Num2) { return Num1 + Num2; }
        public int calcMinus(int Num1, int Num2) {return Num1 - Num2; }
        public string calcDiv(int Num1, int Num2)
        {
                try
                {
                    string str = Convert.ToString(Num1 / Num2);
                    return str;
            }
                catch (DivideByZeroException)
                {
                    return "Divided By Zero";
                }      
        }
        public int calcMulti(int Num1, int Num2) {return Num1 * Num2; }  
    }
}


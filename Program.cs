using System.Security.Cryptography.X509Certificates;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalc calc = new CalcMinus();
            Console.WriteLine("Enter integer1 :");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer2 :");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Equ Result = new Equ(calc, Num1, Num2);
            Console.WriteLine(Result.Ops());
        }

    }
    public interface ICalc
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int CalcOps(int Num1, int Num2);

    }

    public class CalcAdd : ICalc
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int CalcOps(int Num1, int Num2) { return Num1 + Num2; }
    }

    public class CalcMinus : ICalc
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int CalcOps(int Num1, int Num2) { return Num1 - Num2; }
    }

    public class CalcMulti : ICalc
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int CalcOps(int Num1, int Num2) { return Num1 * Num2; }
    }

    public class CalcDiv : ICalc
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int CalcOps(int Num1, int Num2) { 
            if (Num2 == 0) {
                return 0;
            }
            else
                return Num1 / Num2;
        }
    }

    public class Equ {
        public ICalc ?Int;
        public int Int1 { get; set; }
        public int Int2 { get; set; }
        public Equ( ICalc Int , int Int1 , int Int2) {
            this.Int = Int;  
            this.Int1 = Int1;
            this.Int2 = Int2;
        }

        public int Ops () {
            if (Int == null)
            {
                throw new InvalidOperationException("Dependency not injected.");
            }

            return Int.CalcOps(Int1, Int2);
        }
    }

}





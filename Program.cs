using System.Security.Cryptography.X509Certificates;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalc calc = new CalcDiv();
            List<int> Numbers = [10, 2, 5];
            Equ Result = new Equ(calc , Numbers);
            Console.WriteLine(Result.Ops());
        }

    }
    public interface ICalc
    {
        public int CalcOps(List<int> Numbers);

    }

    public class CalcAdd : ICalc
    {
        public int CalcOps(List<int> Numbers) {  
            int result = 0;
            foreach (var i in Numbers)
            {
                result += i;
            }
            return result;
    }}

    public class CalcMinus : ICalc
    {
        public int CalcOps(List<int> Numbers) {  
            int result = Numbers[0];
            Numbers.RemoveAt(0);
            foreach (var i in Numbers)
            {
                result -= i;
            }
            return result;
    }}

    public class CalcMulti : ICalc
    {
        public int CalcOps(List<int> Numbers) {  
            int result = 1;
            foreach (var i in Numbers)
            {
                result *= i;
            }
            return result;
        }
    }

    public class CalcDiv : ICalc
    {
        public int CalcOps(List<int> Numbers) { 
            int result1 = 1;
            int result2 = Numbers[0];
            foreach (var i in Numbers)
            {
                result1 *= i;
            }
            if (result1 == 0) {
                    return 0;
                }
            else
                Numbers.RemoveAt(0);
                foreach (var i in Numbers)
                    {
                        result2 /= i;
                    }
                return result2;
        }
    }

    public class Equ {
        public ICalc ?Int;
        public List<int> Numbers;
        public Equ(ICalc Int, List<int> Numbers) {
            this.Int = Int; 
            this.Numbers = Numbers;
        }

        public int Ops () {
            if (Int == null)
            {
                throw new InvalidOperationException("Dependency not injected.");
            }

            return Int.CalcOps(Numbers);
        }
    }

}





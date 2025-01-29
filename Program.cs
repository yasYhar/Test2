using System.Security.Cryptography.X509Certificates;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalc calc = new CalcDiv();
            List<int> Numbers = [10, 1, 5];
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
        private readonly ICalc _int;
        private readonly List<int> _numbers;
        public Equ(ICalc Int, List<int> Numbers) {
            _int = Int; 
            _numbers = Numbers;
        }

        public int Ops () {
            if (_int == null)
            {
                throw new InvalidOperationException("Dependency not injected.");
            }

            return _int.CalcOps(_numbers);
        }
    }
}





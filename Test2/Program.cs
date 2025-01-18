using System.Security.Cryptography.X509Certificates;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
        }

    }
    interface Icalc {
        public int Num1 { get; set; }
        public int Num2 { get; set;}
        public int calcAdd(int Num1 , int Num2);
        public int calcMinus(int Num1 , int Num2);
        public int calcMulti(int Num1 , int Num2);
        public string calcDiv(int Num1 , int Num2);

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


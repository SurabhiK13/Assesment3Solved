using System.Security.Cryptography.X509Certificates;

namespace Q2_MethodOverLoad_
{
    public class Program
    {
        public  int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.Add(10, 20, 30));
            Console.WriteLine(p.Add(10.234, 20.765, 30.098));
        }
    }
}

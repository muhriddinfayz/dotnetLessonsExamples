
namespace Rekursiya
{
    class Rekursiya
    {
        static void Main(string[] args)
        {
            //int s=Summa(5);
            //Console.WriteLine(s);

            // int f=Factorial(5);
            // int f2=Factorial2(5);
            // Console.WriteLine(f);
            // Console.WriteLine(f2);

            bool b;
            b= EqualStrings("Hello", "HELLO", 0);
            Console.WriteLine(b);
        }
        
        //5+10+15+...5*n    
        private static int Summa(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return 5*n + Summa(n - 1);
            }
        }

        //n factorial
        private static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        //n! by for cycle
        private static int Factorial2(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        //equal two strings
        private static bool EqualStrings(string s1, string s2, int pos)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }
            else if (pos < s1.Length)
            {
                if (s1[pos] == s2[pos])
                {
                    return EqualStrings(s1, s2, pos + 1);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
    }
}
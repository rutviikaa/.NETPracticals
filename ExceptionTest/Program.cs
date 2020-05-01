using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 0;
            Console.WriteLine(Divide(x, y));
        }

        public static int Divide(int x, int y)
        {
            int result = 0;
            try
            {
                result = x / y;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Arithmetic Exception Handler: {0}", e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Generic Exception Handler : {0}", e.ToString());
            }
            return result;
        }
    }
}

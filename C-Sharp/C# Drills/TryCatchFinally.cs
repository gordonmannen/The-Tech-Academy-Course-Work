using System;

namespace TryCatchFinally
{
    class TCFExample
    {
        int result;
        TCFExample()
        {
            result = 0;
        }
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                .WriteLine("Result: {0}", result);
            }
        }
        static void Main(string[] args)
        {
            TCFExample d = new TCFExample();
            d.division(25, 0);
            Console.ReadKey();
        }
    }
}
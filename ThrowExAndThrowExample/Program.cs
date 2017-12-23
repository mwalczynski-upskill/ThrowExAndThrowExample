using System;

namespace ThrowExAndThrowExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Throw();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Throw");
                Console.WriteLine(ex.StackTrace);
            }

            try
            {
                ThrowEx();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Throw Ex");
                Console.WriteLine(ex.StackTrace);
            }

            Console.ReadKey();
        }

        public static void ThrowEx()
        {
            try
            {
                DeivideByZero();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Throw()
        {
            try
            {
                DeivideByZero();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void DeivideByZero()
        {
            FinallyDivideByZero();
        }

        public static void FinallyDivideByZero()
        {
            int x = 0;
            var y = 1 / x;
        }
    }
}

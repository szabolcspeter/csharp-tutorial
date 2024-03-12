namespace Unsafe2
{
    internal class Program
    {
        private static unsafe void Fibonacci()
        {
            const int meddig = 40;
            int* fib = stackalloc int[meddig];
            int* p = fib;
            *p++ = *p++ = 1; // első két elem 1-esre állítása

            for (int i = 2; i < meddig; ++i, ++p)
            {
                *p = p[-1] + p[-2];
                Console.WriteLine("{0} ", fib[i]);
            }
        }

        static void Main(string[] args)
        {
            Fibonacci();
        }
    }
}

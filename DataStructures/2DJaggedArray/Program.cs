namespace _2DJaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var jagged = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };

            foreach (var sor in jagged)
            {
                foreach (var oszlop in sor)
                {
                    Console.Write("{0} ", oszlop);
                }
                Console.WriteLine();
            }
        }
    }
}

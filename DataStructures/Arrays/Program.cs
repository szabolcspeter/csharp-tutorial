namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gyumolcsok = new string[]
            {
                "alma", "körte", "szilva"
            };

            var bevitelek = new string[3];

            for (int i=0; i<bevitelek.Length; i++)
            {
                Console.Write("{0}. bevitel: ", i);
                bevitelek[i] = Console.ReadLine();
            }

            foreach (var gyumolcs in gyumolcsok)
            {
                Console.WriteLine(gyumolcs);
            }

            foreach (var bevitel in bevitelek)
            {
                Console.WriteLine(bevitel);
            }
        }
    }
}

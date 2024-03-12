namespace ArrayInit
{
    internal class Program
    {
        class Demo
        {
            public string Szoveg { get; set; }
            public int Szam { get; set; }

            public Demo()
            {
                Szoveg = "";
                Szam = -1;
            }

            public Demo(string szoveg, int szam)
            {
                Szoveg = szoveg;
                Szam = szam;
            }
        }

        static void Main(string[] args)
        {
            var tomb = new Demo[4];
            tomb[0] = new Demo("Teszt", 42);
            tomb[3] = new Demo
            {
                Szoveg = "Masik",
                Szam = 11
            };

            foreach (var elem in tomb)
            {
                if (elem == null)
                {
                    Console.WriteLine("null");
                }
                else
                {
                    Console.WriteLine("{0} ; {1}", elem.Szoveg, elem.Szam);
                }
            }
        }
    }
}

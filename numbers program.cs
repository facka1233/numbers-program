namespace numbersprogram
{
    public class numbers
    {
        public int Findminimum(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
                return b;

        }
        public int Findminimum(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < c && b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        public int Findmax(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > c && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        public int Findmax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }

    namespace numbersprogram
    {
        class program
        {
            static void Main(string[] args)
            {
                numbers numbers = new numbers();
                int a, b, c, bil;

                Console.WriteLine("2 atau 3 angka?");
                bil = Convert.ToInt32(Console.ReadLine());


                if (bil == 2)
                {
                    Console.WriteLine("Masukan angka ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukan angka ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Angka terkecil adalah " + numbers.Findminimum(a, b));
                    Console.WriteLine("Angka terbesar adalah " + numbers.Findmax(a, b));
                }
                if (bil == 3)
                {
                    Console.WriteLine("Masukan angka ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukan angka ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukan angka ");
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Angka terkecil adalah " + numbers.Findminimum(a, b, c));
                    Console.WriteLine("Angka terbesar adalah " + numbers.Findmax(a, b, c));
                }
                Console.ReadKey();
            }
        }
    }
}
using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static int HammingDistance(int x, int y) {
            int r = x ^ y;
            int c = 0;
            while (r > 0) {
                if ((r & 1) == 1) {
                    c++;
                }
                r >>= 1;
            }
            return c;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(HammingDistance(1, 4));
        }
    }
}

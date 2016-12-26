using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static int BinarySearch(int[] heaters, int target) {
            int i = 0;
            int j = heaters.Length - 1;
            if (j == 0) {
                return Math.Abs(heaters[0] - target);
            }
            int m = 0;
            while (i < j) {
                m = i + (j - i) / 2;
                if (heaters[m] == target) {
                    return 0;
                } else if (heaters[m] < target) {
                    i = m + 1;
                } else {
                    j = m - 1;
                }                
            }

            return Math.Min(Math.Min(Math.Abs(heaters[i>=0?i:0] - target), Math.Abs(heaters[i<heaters.Length-1?i+1:heaters.Length-1]-target)), Math.Abs(heaters[i>0?i-1:0] - target));
        }

        public static int FindRadius(int[] houses, int[] heaters) {
            Array.Sort(heaters);
            var maxDis = 0;
            foreach(var h in houses) {
                var dis = BinarySearch(heaters, h);
                if (dis > maxDis) {
                    maxDis = dis;
                }
            }
            return maxDis;
        }
        public static void Main(string[] args)
        {
            int[] houses = {1,2,3,5,15};
            int[] heaters = {2, 30};
            Console.WriteLine(FindRadius(houses, heaters));
        }
    }
}

using System;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        // increase n - 1 by 1 equals decrease One element by 1
        public static int MinMoves(int[] nums) {
            var min = nums.Min();
            return nums.Sum(n => n - min);

        }
        public static void Main(string[] args)
        {
            Console.WriteLine(MinMoves(new int[]{1, 2, 3, 4}));
        }
    }
}

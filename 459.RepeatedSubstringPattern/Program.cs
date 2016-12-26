using System;

namespace ConsoleApplication
{
    
    public class Program
    {
        // public static bool RepeatedSubstringPattern(string str) {
        //     int[] prime = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};
        //     int length = str.Length;
        //     for (int i = 0; i < prime.Length && prime[i] <= length; i++) {
        //         if (length % prime[i] == 0) {
        //             string pattern = str.Substring(0, length / prime[i]);
        //             bool succ = true;
        //             for (int s = 1; s < prime[i]; s++) {
        //                 if (str.Substring(length / prime[i] * s, length / prime[i]) != pattern) {
        //                     succ = false;
        //                     break;
        //                 }
        //             }
        //             if (succ) {
        //                 return true;
        //             }
        //         }
        //     }
        //     return false;
        // }

        // O(l)
        // P : pattern
        // s = PP
        // s2 = P`PPP`
        // true when s2 contains s
        // false: s = P, s2=P`P`, s2 doesn't contain s
        public static bool RepeatedSubstringPattern(string str) {
            return (str + str).Substring(1, str.Length * 2 - 2).Contains(str);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(RepeatedSubstringPattern("aaaa"));
        }
    }
}

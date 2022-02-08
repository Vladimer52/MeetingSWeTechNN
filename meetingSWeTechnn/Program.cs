using System;
using System.Collections.Generic;
using System.Linq;

namespace meetingSWeTechnn
{
    internal class Program
    {
        static void minSumStore(int[] arr, out int sum)
        {
            List<int> arrList = arr.ToList();
            arrList.OrderByDescending(i => i).ToList();
            int sumdecr = (from i in arrList where arrList.IndexOf(i) % 3 == 0 select i).Sum();
            sum = (from i in arrList select i).Sum() - sumdecr;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 9,5,6,7,2,2,4 };
            int sum = 0;
            int sumdecr = 0;
            minSumStore(arr, out sum);
            Console.WriteLine(sumdecr);
            Console.WriteLine(sum);
        }
    }
}

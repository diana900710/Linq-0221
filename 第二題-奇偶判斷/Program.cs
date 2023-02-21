using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二題_奇偶判斷
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一串正整數(用 , 分隔) : ");
            var result = Console.ReadLine().Split(',');
            var nums = Array.ConvertAll(result, (x) => int.Parse(x)); //轉成數字陣列
            var cardinality = nums.Where((x) => x % 2 == 1).OrderBy((x) => x);
            var even = nums.Except(cardinality).OrderBy((x) => x);
            Console.Write($"奇數 : ");
            //foreach(var item in cardinality) { Console.Write("{0},", item);}
            Console.WriteLine(string.Join(",", cardinality));
            Console.WriteLine();
            Console.Write($"偶數 : ");
            //foreach (var item in even) { Console.Write("{0},", item); }
            Console.WriteLine(string.Join(",", even));

            Console.ReadKey();
        }
    }
}

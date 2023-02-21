using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一題_序列倒置
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一組數字(用 , 分隔) : ");
            string result = Console.ReadLine();
            var nums = result.Split(',');
            var swap = nums.OrderByDescending((x) => x); //排序(遞減)
            foreach ( var i in swap )
            {
                Console.Write("{0},", i);
            }

            Console.ReadKey();
        }
    }
}

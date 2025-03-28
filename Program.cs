using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            string str = obj.getSum(1, 2, 3, 4, 5, 6);
            Console.WriteLine(str);
            int[] arr = { 2, 4, 6, 8, 10 };
            string str2 = obj.getSum(arr);
            Console.WriteLine(str2);
            Console.ReadLine();
        }
        public string getSum(params int[] arr)
        {
            int sum = 0;
            string str = " ";
            foreach (int i in arr)
            {
                sum += i;
                str += "+" + i + " ";
            }
            str = str.Trim('+');
            str += "=" + sum;
            return str;
        }
    }

}

 111111111111111111111
    11111111111
    111111111111
    11111111
    111111111111
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rdppractice5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(UserProgramCode.findLargestNumber(num));

            Console.ReadKey();
        }
    }

    class UserProgramCode
    {
        public static int findLargestNumber(int num)
        {
            int[] digits = num.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();

            int max = digits[0];
            for(int i = 0; i < digits.Length; i++)
            {
                if (digits[i] > max)
                {
                    max = digits[i];
                }
            }

            return max;
        }
    }
}

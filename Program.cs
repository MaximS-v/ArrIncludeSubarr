using System;

namespace ArrIncludeSubarr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите меньший массив:");
            var strSmallArr = Console.ReadLine().Split(' ');
            Console.WriteLine("Введите больший массив:");
            var strBigArr = Console.ReadLine().Split(' ');
            int currSmallArrNum = 0;
            for (int i = 0; i < strBigArr.Length; i++)
            {
                if (currSmallArrNum < strSmallArr.Length)
                {
                    if (strBigArr[i] == strSmallArr[currSmallArrNum])
                        currSmallArrNum++;
                }
                else
                    break;
            }
            if (currSmallArrNum == strSmallArr.Length)
                Console.WriteLine("Меньший массив входит в больший как подпоследовательность");
            else
                Console.WriteLine("Меньший массив не входит в больший как подпоследовательность");
        }
    }
}

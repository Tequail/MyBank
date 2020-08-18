using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank.HomeWork
{
    class Work
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("请输入六位数字:");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "位数字");
                arr[i] = int.Parse(Console.ReadLine());
            }
            // 进行冒泡排序
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-1-i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp;
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }
            //排序互进行遍历
            foreach (var a in arr)
            {
                Console.Write(a+" ");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank.demo1
{
    /// <summary>
    /// 交换两个数的值
    /// </summary>
    class Demo
    {

        static void Main(string[] args)
        {
            int number1 = 5, number2 = 10;

            Console.WriteLine("交换前number1的值是:" + number1);
            Console.WriteLine("交换前number2的值是:" + number2);
            // 只有变量传入的是当前变量的值 5 10   相当于 赵瑞 10岁 别人怎么说我都是10岁
            // 变量相当于是在内存中开辟了一块空间  那么如果想要传入地址空间
            // 在参数前面添加关键帧 ref (reference)  引用  相当于引用了变量的地址空间
            Exchange(ref number1,ref number2);
            Console.WriteLine("交换后number1的值是:" + number1);
            Console.WriteLine("交换后number2的值是:" + number2);



        }

        public static void Exchange(ref int number1,ref int number2)
        {
            //交换两个变量的值
            int temp;
            temp = number1;
            number1 = number2;
            number2 = temp;

           
        }

    }
}

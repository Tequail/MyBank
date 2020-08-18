using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank.demo1
{
    class Test
    {

        static void Main(string[] args)
        {
            Salary salary = new Salary();
           /* Console.WriteLine("请输入您的工资");
            int pay = int.Parse(Console.ReadLine());
            Console.WriteLine("您的税后工资是:"+salary.GetPay(pay));*/
            // 有返回值的带参方法:1.方法规定的入参类型为形参-形式参数  调用方法所传入的参数为实参 -实际参数
            // 方法的返回值类型规定了整个方法最后返回的结果必须是其规定的类型  float   返回值必须是float类型

            Test1(salary);
            Console.WriteLine(salary.texRate);

            // 对象是引用数据类型 引用传递
            // ref 引用传递
        }

        public static void Test1(Salary salary)
        {
              salary.texRate += 0.1f;

        }
    }
}

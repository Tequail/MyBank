using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank.HomeWork_8_18
{
    class Test
    {
        static void Main(string[] args)
        {
            Persion persion = new Persion();
            Console.WriteLine("请输入身份证号:");
            persion.IdCardNo = Console.ReadLine();
            Console.WriteLine("身份证号:{0}",persion.IdCardNo);
        }
    }
}

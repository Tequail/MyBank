using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank.demo
{
    class Test
    {
        static void Main(string[] args)
        {
            Student guojiaqi = new Student();
            guojiaqi.Name = "郭珈圻";
           // guojiaqi.name = "老郭";
           // student.sex = "";
           Console.WriteLine(guojiaqi.Name);

            Student huangtianshuang = new Student();
            huangtianshuang.Name="黄天双";
            /*huangtianshuang.SetAge(30);*/
            Console.WriteLine(huangtianshuang.Name);
            // 微软提供的一种属性  来对字段进行赋值和获取
            huangtianshuang.Age = 17;
            Console.WriteLine(huangtianshuang.Age);

            /*构造器:创建对象的同时给属性赋值*/
            Student duanmingzhe = new Student() {Name = "段名泽",Age = 15 };
            Console.WriteLine("我的姓名是:"+duanmingzhe.Name+",我的年龄是:{0}",duanmingzhe.Age);


        }
    }
}

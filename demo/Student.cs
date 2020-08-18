using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank.demo
{
    class Student
    {
        private string _name;
       
        //1.将属性设置为私有属性
        private int _age;


        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 100 || value < 0)
                {
                    //不合理赋值 默认设置为18
                    _age = 18;
                }
                else
                {
                    _age = value;
                }

            }
        }

        public string Name
        {
            //get { return name; }
            //C语言中的位运算
            get => _name; 
            set => _name = value;
        }

       /* public void SetName(string name)
        {
           *//*就近原则    如果想要访问成员变量 */
           /*this:这个  当前对象   */
           /*哪个对象过来调用这个方法  name这个this 就代表哪个对象*//*
           this.Name = name;
        }*/
        //2.给这个属性提供可访问的方法
       /* public int GetAge()
        {
            return age;
        }*/
        /*3.使用判断来限制不合理赋值*/
       /* public void SetAge(int age)
        {
            if (age < 0 || age > 100)
            {
                Console.WriteLine("年龄不能小于0岁或者大于100");
                *//*默认设置一个初始值*//*
                this.age = 18;
            }
            else
            {
                *//*如果是合理赋值那么久直接赋值到属性中*//*
                this.age = age;
            }
            
        }*/
    }
}

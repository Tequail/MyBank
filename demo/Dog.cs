using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MyBank.demo
{
    class Dog
    {
        /*字段*/
        private string _dog_name;

        private string _color;

        private int _age;

        // 封装: 1.属性私有化   2. 提供get和set方法
        public string Dog_name 
        { 
            get => _dog_name;
            set => _dog_name = value; 
        }
        public string Color {
            get => _color;
            set => _color = value; 
            
        }
        public int Age
        { 
            get => _age;
            set {
                
                if (value > 20 || value < 0)
                {
                    _age = 1;
                }
                else
                {
                    _age = value;
                }
            
            }
        }

       


    }
}

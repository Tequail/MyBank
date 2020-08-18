using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank.demo1
{
    class Salary
    {
        private int pay;        // 税前工资
        public float texRate = 0.1f;  //税率
        private float afterTax;  //税后工资

        /*计算方式: 低于2000不交税,高于2000 超出的按照10%交税*/
        public float GetPay(int pay)
        {
            if (pay < 2000)
            {
                afterTax = pay;
            }
            else
            {
                afterTax = pay - (pay - 2000) * texRate;
            }
            return afterTax;
        }
    }
}

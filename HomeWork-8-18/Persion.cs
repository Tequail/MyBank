using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank.HomeWork_8_18
{
    class Persion
    {
        private string _idCardNo;

        public string IdCardNo
        {
            get { return _idCardNo; }
            set 
            {
                /*判断身份证号是否是18位*/
                if (value.Length != 18)
                {
                    _idCardNo = "0000 - 0000 - 0000 - 0000 - 00";
                }
                else
                {
                    _idCardNo = value;
                }
            }
        }
    }
}

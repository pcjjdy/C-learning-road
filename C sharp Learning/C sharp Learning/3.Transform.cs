using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Learning
{
    class Transform
    {
        double Unknown =10.5;
        int i=10;

        public void GetTransformResult(int whichType)
        {
          
            switch (whichType) { 
                case 1:  //强制转换
                    Unknown = (int)Unknown;
                    break;
                case 2:
                    Unknown = i;
                    break;
                default:    //隐式转换
                    break;
            }               

        }
        public void  Get() {
            Console.WriteLine(Unknown);
        }

    }
}


//c# 内置换换类型
//ToBoolean()
//ToByte()
//ToChar()  单个Unicode字符类型
//ToDateTime() 日期-时间结构
//ToDecimal() 十进制类型
//ToDouble()
//ToInt16/32/64()
//ToSbyte()  有符号字节类型
//ToSingle() 小浮点数类型
//ToString() 
//ToType()
//ToUInt16/32/64() 无符号整数类型

//类成员函数默认私有 公有的话需要public
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Learning
{
    class Transform
    {
        Type Unknown;


        void GetTransformResult(int whichType)
        {
          
            switch (whichType) { 
                case 1:  //强制转换
                    break;
                case 2:     
                    break;
                default:    //隐式转换
                    break;
            }
               

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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Learning
{
    class Operator
    {
        int a = 10;
        public int d;
        public int c;

        public int Operators() {
            c = a++;
            d = ++a;
            return c;
        }

    }
}


//a^b 表示 相同的位相同0，相同的位不同1
//typeof() 返回类的类型
//&返回变量的地址
//is  对象是否为某一类型 "baoma is Car"
//as 强制转化 失败也不会抛出异常
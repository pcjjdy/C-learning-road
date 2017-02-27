using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Learning
{
    class ConstantVariable
    {
        public void GetVariable(bool ifinput) {
            short a;
            int b;
            double c;

            /*实际初始化*/
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a={0}, b={1},c={2}",a,b,c);

            if (ifinput) {
                int userinput;
                userinput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("user input: {0}",userinput);
            }
        }

        public void GetConstant() {
            const double PI = 3.14159;
            Console.WriteLine("3的面积是： {0}", PI * 3 * 3);
        }
    }
}

//两种表达式
//lvalue 表达式可以出现在赋值语句的左边或右边
//rvalue 表达式可以出现在赋值语句的右边，不能出现在赋值语句的左边
//变量是 lvalue 的，所以可以出现在赋值语句的左边。数值是 rvalue 的，因此不能被赋值，不能出现在赋值语句的左边

//进制：0x 或 0X 表示十六进制，0 表示八进制，没有前缀则表示十进制。

//后缀：后缀，可以是 U 和 L 的组合，其中，U 和 L 分别表示 unsigned 和 long。

//使用小数形式表示时，必须包含小数点、指数或同时包含两者。
//使用指数形式表示时，必须包含整数部分、小数部分或同时包含两者。有符号的指数是用 e 或 E 表示的。
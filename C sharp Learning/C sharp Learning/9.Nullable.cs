using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Learning
{
    class Nullable
    {
        int? num1 = null;    //类型后面跟?
        int? num2 = 45;
        double? num3 = new double?();
        double? num4 = 3.14157;
        bool? boolval = new bool?();

        double? a = null;
        double? b = 3.14157;

        public void NullableFunc() {
            Console.WriteLine("显示可空类型的值： {0}, {1}, {2}, {3}",
                            num1, num2, num3, num4);
            Console.WriteLine("一个可空的布尔值： {0}", boolval);
        }

        public void NullableMerge() {
            double c;
            c = a ?? 3.14;                  //可空的合并运算符只能在方法里使用 不能直接在类开头定义, ??符号两侧的数值不能全为null
            double d = b ?? 5.34;                       
            Console.WriteLine("合并运算符第一个数为空： {0}",c);
            Console.WriteLine("合并运算符第一个数不为空： {0}", d);
        }
    }
}

//nullable 类型（可空类型），可空类型可以表示其基础值类型正常范围内的值，再加上一个 null 值。
//Nullable< Int32 >，读作"可空的 Int32"，可以被赋值为 -2,147,483,648 到 2,147,483,647 之间的任意值，也可以被赋值为 null 值。
//类似的，Nullable< bool > 变量可以被赋值为 true 或 false 或 null。

//例 int? a =null;   或者int? a =new int?();
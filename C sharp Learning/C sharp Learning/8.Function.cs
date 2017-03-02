using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Learning
{
    class Function
    {


        public void fun1() {
            Console.WriteLine("This is function 1 ");
        }

        public void fun2() {
            fun1();
        }

        public void swapVar(int x, int y)
        {
            int temp;

            temp = x; /* 保存 x 的值 */
            x = y;    /* 把 y 赋值给 x */
            y = temp; /* 把 temp 赋值给 y */
        }

        public void swapRef(ref int x, ref int y)
        {
            int temp;

            temp = x; /* 保存 x 的值 */
            x = y;    /* 把 y 赋值给 x */
            y = temp; /* 把 temp 赋值给 y */
        }

        public void Outfunc(out int x, out int y) {
            x = 20;
            y = 30;
        }

        public void fun3() {               //值参数
            int x = 10, a = 9;
            Console.WriteLine("x操作前： {0}", x);
            Console.WriteLine("a操作前： {0}", a);
            swapVar(x,a);

            Console.WriteLine("x操作后： {0}", x);
            Console.WriteLine("a操作后： {0}", a);
        }

        public void fun4()              //引用参数, 里面的参数必须是变量 不能是常量
        {
            int xx = 100, b = 99;
            Console.WriteLine("xx操作前： {0}", xx);
            Console.WriteLine("b操作前： {0}", b);
            swapRef(ref xx, ref b);

            Console.WriteLine("xx操作后： {0}", xx);
            Console.WriteLine("b操作后： {0}", b);
        }

        public void fun5()           //输出参数，里面的参数必须是变量 不能是常量
        {
            int m, n;
            Outfunc(out m,out n);
            Console.WriteLine("m,n的值分别为：{0},{1}",m, n);
        }
    }

    class recursive
    {           //递归调用
        public int factorial(int num)
        {
            /* 局部变量定义 */
            int result;

            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }

        public void call_factorial() {
            recursive n = new recursive();
            //调用 factorial 方法
            Console.WriteLine("6 的阶乘是： {0}", n.factorial(6));
            Console.WriteLine("7 的阶乘是： {0}", n.factorial(7));
            Console.WriteLine("8 的阶乘是： {0}", n.factorial(8));
        }
    }

}


//三种传递参数的方法：

//值参数	这种方式复制参数的实际值给函数的形式参数，
//实参和形参使用的是两个不同内存中的值。在这种情况下，当形参的值发生改变时，不会影响实参的值，从而保证了实参数据的安全。

//引用参数 这种方式复制参数的内存位置的引用给形式参数。
//这意味着，当形参的值发生改变时，同时也改变实参的值。   使用 ref 关键字声明引用参数
//输出参数 这种方式可以返回多个值。             关键字out



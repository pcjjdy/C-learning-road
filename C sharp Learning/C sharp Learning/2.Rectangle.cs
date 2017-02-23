using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Learning
{

    class Rectangle
    {
        //成员变量
        double length ;
        double width;
        public void Acceptdetails() {
            length= 10;
            width = 5;
        }

        public double GetArea() {
            return length * width;
        }

        public void Display() {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }

    }

    class ExecuteRectangle {
        public void  ShowRectangle() {              //原来的main函数
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}



//在 C# 中，变量分为以下几种类型：
//值类型（Value types）
//引用类型（Reference types）
//指针类型（Pointer types）


//引用类型不包含存储在变量中的实际数据，但它们包含对变量的引用。
//换句话说，它们指的是一个内存位置。使用多个变量时，引用类型可以指向一个内存位置。如果内存位置的数据是由一个变量改变的，其他变量会自动反映这种值的变化。内置的 引用类型有：object、dynamic 和 string。
//对象（Object）类型
//对象（Object）类型 是 C# 通用类型系统（Common Type System - CTS）中所有数据类型的终极基类。Object 是 System.Object 类的别名。所以对象（Object）类型可以被分配任何其他类型（值类型、引用类型、预定义类型或用户自定义类型）的值。但是，在分配值之前，需要先进行类型转换。
//当一个值类型转换为对象类型时，则被称为 装箱；另一方面，当一个对象类型转换为值类型时，则被称为 拆箱。
//object obj;
//obj = 100; // 这是装箱


//动态（Dynamic）类型
//存储任何类型的值在动态数据类型变量中。这些变量的类型检查是在运行时发生的。
//如 dynamic d =20;

//字符串（String）类型的值可以通过两种形式进行分配：引号和 @引号。
//例如：String str = "w3cschool.cc";  或者 String str = @"w3cschool.cc";

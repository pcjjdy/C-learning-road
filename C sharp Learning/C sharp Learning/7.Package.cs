using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Learning
{
    class GetRectangle
    {
        //成员变量
        public double length;
        public double width;

        private int x = 10;  //private
        protected int y = 100; //protected
        internal int z = 1000; //internal

        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", GetArea());

        }
    }

    class CallClass {
        public void Callfunction() {
            GetRectangle demo = new GetRectangle();
            //  demo.x = 100; 非法  
        }

    }


    class ChildClass : GetRectangle{
        public void Childfunction() {
            y=10;    //父类的y
        }
        
    }

    class externalClass
    {
        public void externalfunction()
        {
            GetRectangle demo2 = new GetRectangle();
            demo2.z = 10;    //外部的z
        }
    }



}

//Public 任何公有成员可以被外部的类访问。
//Private 只有同一个类中的函数可以访问它的私有成员。即使是类的实例也不能访问它的私有成员。
//Protected 访问修饰符允许子类访问它的基类的成员变量和成员函数。这样有助于实现继承。
//internal 带有 internal 访问修饰符的任何成员可以被定义在该成员所定义的应用程序内的任何类或方法访问。
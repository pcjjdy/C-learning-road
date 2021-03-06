﻿using System;  /*调用标准库*/
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//命名域
namespace C_sharp_Learning
{
    class HelloWorld
    {
        static void Main(string[] arr)    //string[] args是main函数的形式参数,可以用来获取命令行用户输入进去的参数。
                                            //可以去掉
        {
            
            //第一个C#程序
            Console.WriteLine("HelloWorld");
            String str = @"woshitiancai";
            Console.WriteLine(str);

            //2. Rectangle
            ExecuteRectangle rea = new ExecuteRectangle();
            rea.ShowRectangle();

            //3. Transform
            Transform tra = new Transform();
            tra.GetTransformResult(2);
            tra.Get();


            //4. Constant and Varibale
            ConstantVariable cv = new ConstantVariable();
            cv.GetVariable(false);    //是否输入
            cv.GetConstant();

            //5. Operators
            Operator op = new Operator();
            op.Operators();
            Console.WriteLine(op.c);

            //6. Loop and Judgment
            LoopJudgment lj = new LoopJudgment();
            lj.grade = 'D';
            lj.Switch();
            lj.WhileLoop();
            lj.DoWhileLoop();
            lj.ForLoop();
            lj.NestLoop();  //找质数

            //7. Package
            GetRectangle r = new GetRectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();

            //8.Function
            Function f = new Function();
            f.fun2();
            f.fun3();
            f.fun4();
            f.fun5();
            recursive rr = new recursive();
            rr.call_factorial();


            //9.Nullable
            Nullable n = new Nullable(); 
            n.NullableFunc();
            n.NullableMerge();


            //10.Array
            MyArray array1 = new MyArray();
            array1.AssignArray();
            array1.SpecialArray1();
            array1.SpecialArray2();
            array1.SpecialArray3();
            array1.SpecialArray4();
           


            //11.Array 转化值的格氏方法
            DateTime waiting = new DateTime(2015, 3, 17, 17, 31, 1);
            string chat = String.Format("Message sent {0:t} on {0:D}", waiting);

            MyString mystr = new MyString();
            mystr.StringFunc();
            Console.Write("{0}",chat);




            //12.Struct
             MyStruct abook = new MyStruct();
            abook.testStructFunc();
             // abook.


            //13. Class
            MyEnum enum1 = new MyEnum();
            enum1.myTestFunc();
            Console.ReadKey();    //将按下的键打印出来
        }
    }
}


//一个 C# 程序主要包括以下部分：
//命名空间声明（Namespace declaration）
//一个 class
//Class 方法
//Class 属性
//一个 Main 方法
//语句（Statements）& 表达式（Expressions）
//注释


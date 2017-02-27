using System;  /*调用标准库*/
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
            lj.LoopSwitch();

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


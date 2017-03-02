using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Learning
{

    class LoopJudgment
    {
        public char grade;
        public void Switch() {
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("很棒！");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("做得好");
                    break;
                case 'D':
                    Console.WriteLine("您通过了");
                    break;
                case 'F':
                    Console.WriteLine("最好再试一下");
                    break;
                default:
                    Console.WriteLine("无效的成绩");
                    break;
            }
            Console.WriteLine("您的成绩是 {0}", grade);
        }

        public void WhileLoop() {
            int a=0;
            while (a < 5)
            {
                Console.WriteLine("while a 的值： {0}", a);
                a++;
            }
        }

        public void DoWhileLoop()
        {
            int b = 0;
            do
            {
                Console.WriteLine("dowhile a 的值： {0}", b);
                b = b + 1;
            } while (b < 5);
        }

        public void ForLoop() {
            for (int a = 10; a < 15; a = a + 1)
            {
                Console.WriteLine("forloop a 的值： {0}", a);
            }
        }

        public void NestLoop() {   //找质数
            int i, j;

            for (i = 2; i < 100; i++)
            {
                for (j = 2; j <= (i / j); j++)
                { 
                    if ((i % j) == 0)
                        break; // 如果找到，则不是质数
                }
                    if (j > (i / j))
                        Console.WriteLine("{0} 是质数", i);
            }
        }

    }
}

//switch 语句中的 expression 必须是一个整型或枚举类型，
//或者是一个 class 类型，其中 class 有一个单一的转换函数将其转换为整型或枚举类型。
//不是每一个 case 都需要包含 break。如果 case 语句为空，则可以不包含 break，控制流将会 继续 后续的 case，直到遇到 break 为止。
//一个 switch 语句可以有一个可选的 default case。default case 中的 break 语句不是必需的。
//for (; ; ) 代表无线循环
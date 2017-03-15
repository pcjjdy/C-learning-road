using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//所有的数组都是由连续的内存位置组成的

//声明一个数组不会在内存中初始化数组

//数组是一个引用类型，所以您需要使用 new 关键字来创建数组的实例。

namespace C_sharp_Learning
{
    class MyArray
    {
        double[] demo;  //声明数组
        double[] demo2 = new double[10]; //初始化数组

        public void AssignArray()
        {
            demo2[1] = 12.0;   //使用索引号赋值给一个单独的数组元素
            double[] balance = { 2340.0, 4523.69, 3421.0 };  //在声明数组的同时给数组赋值
            int[] marks = new int[5] { 99, 98, 92, 97, 95 };//创建并初始化一个数组
            int[] marks2 = new int[] { 99, 98, 92, 97, 95 };//创建并初始化一个数组,省略数组大小

            int[] marks3 = new int[] { 99, 98, 92, 97, 95 };
            int[] score = marks3;  //赋值一个数组变量到另一个目标数组变量中。在这种情况下，目标和源会指向相同的内存位置

            double index3 = demo2[3]; //访问数组元素

            ///////////和FOREACH结合////////////
            int[] tenLength = new int[10];
            for (int i = 0; i < 10; i++)
            {
                tenLength[i] = i + 100;
            }

            foreach (int j in tenLength)   //foreach 调用, j为数组中的值
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] = {1}", i, j);
            }
        }

        public void SpecialArray1()
        {
            //多维数组
            string[,] array2;
            int[,,] array3;
            int[,] a = new int[2, 4] {
                {0, 1, 2, 3} ,   /*  初始化索引号为 0 的行 */
                {4, 5, 6, 7}    /*  初始化索引号为 1 的行 */
            };

            //交错数组，是数组的数组，声明一个数组不会在内存中创建数组。
            //初始化一个交错数组，scores 是一个由两个整型数组组成的数组，scores[0] 是一个带有 3 个整数的数组，scores[1] 是一个带有 4 个整数的数组。
            int[][] scores = new int[2][] { new int[] { 92, 93, 94 }, new int[] { 85, 66, 87, 88 } };

            //交错数组例子
            /* 一个由 5 个整型数组组成的交错数组 */
            int[][] jiaocuo = new int[][]{new int[]{0,0},new int[]{1,2},new int[]{2,4},new int[]{ 3, 6 }, new int[]{ 4, 8 } };
            int i, j;

            /* 输出数组中每个元素的值 */
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, jiaocuo[i][j]);
                }
            }            
        }

        double getAverage(int[] arr, int size)
        {
            int i;
            double avg;
            int sum = 0;

            for (i = 0; i < size; ++i)
            {
                sum += arr[i];
            }

            avg = (double)sum / size;
            return avg;
        }

        public void SpecialArray2()
        {
            //传递数组给函数,可以传递数组作为函数的参数。您可以通过指定不带索引的数组名称来给函数传递一个指向数组的指针。
  
            /* 一个带有 5 个元素的 int 数组 */
            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            double avg;
            /* 传递数组的指针作为参数 */
            avg = getAverage(balance, 5);
            /* 输出返回值 */
            Console.WriteLine("平均值是： {0} ", avg);

        }

        public int AddElements(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }

        public void SpecialArray3()
        {
            //参数数组,参数数组通常用于传递未知数量的参数给函数。
            //关键字：params
            int sum = AddElements(512, 720, 250, 567, 889);
            Console.WriteLine("总和是： {0}", sum);

        }

        //array类,关键字：
        //IsFixedSize
        //获取一个值，该值指示数组是否带有固定大小。
        //IsReadOnly
        //获取一个值，该值指示数组是否只读。
        //Length
        //获取一个 32 位整数，该值表示所有维度的数组中的元素总数。
        //LongLength
        //获取一个 64 位整数，该值表示所有维度的数组中的元素总数。
        //Rank
        //获取数组的秩（维度）。

        //array类 常用方法：
        //Clear
        //根据元素的类型，设置数组中某个范围的元素为零、为 false 或者为 null。
        //Copy(Array, Array, Int32)
        //从数组的第一个元素开始复制某个范围的元素到另一个数组的第一个元素位置。长度由一个 32 位整数指定。
        //CopyTo(Array, Int32)
        //从当前的一维数组中复制所有的元素到一个指定的一维数组的指定索引位置。索引由一个 32 位整数指定。
        //GetLength
        //获取一个 32 位整数，该值表示指定维度的数组中的元素总数。
        //GetLongLength
        //获取一个 64 位整数，该值表示指定维度的数组中的元素总数。
        //GetLowerBound
        //获取数组中指定维度的下界。
        //GetType
        //获取当前实例的类型。从对象（Object）继承。
        //GetUpperBound
        //获取数组中指定维度的上界。
        //GetValue(Int32)
        //获取一维数组中指定位置的值。索引由一个 32 位整数指定。
        //IndexOf(Array, Object)
        //搜索指定的对象，返回整个一维数组中第一次出现的索引。
        //Reverse(Array)
        //逆转整个一维数组中元素的顺序。
        //SetValue(Object, Int32)
        //给一维数组中指定位置的元素设置值。索引由一个 32 位整数指定。
        //Sort(Array)
        //使用数组的每个元素的 IComparable 实现来排序整个一维数组中的元素。
        //ToString
        //返回一个表示当前对象的字符串。从对象（Object）继承。
        public void SpecialArray4() { 
        int[] list = { 34, 72, 13, 44, 25, 30, 10 };
        int[] temp = list;

            Console.Write("原始数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
           
            // 逆转数组
            Array.Reverse(temp);
            Console.Write("逆转数组： ");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            
            // 排序数组
            Array.Sort(list);
            Console.Write("排序数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}


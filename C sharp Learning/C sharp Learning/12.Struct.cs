using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//结构可带有方法、字段、索引、属性、运算符方法和事件。
//结构可定义构造函数，但不能定义析构函数。但是，您不能为结构定义默认的构造函数。默认的构造函数是自动定义的，且不能被改变。
//与类不同，结构不能继承其他的结构或类。
//结构不能作为其他结构或类的基础结构。
//结构可实现一个或多个接口。
//结构成员不能指定为 abstract、virtual 或 protected。
//当您使用 New 操作符创建一个结构对象时，会调用适当的构造函数来创建结构。与类不同，结构可以不使用 New 操作符即可被实例化。
//如果不使用 New 操作符，只有在所有的字段都被初始化之后，字段才被赋值，对象才被使用。


//类和结构有以下几个基本的不同点：
//类是引用类型，结构是值类型。
//结构不支持继承。
//结构不能声明默认的构造函数


//C#的类可以嵌套

namespace C_sharp_Learning
{
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;
    };

    class MyStruct
    {
        public void testStructFunc() {
            Books Book1;
            Books Book2;

            /* book 1 详述 */
            Book1.title = "C Programming";
            Book1.author = "Nuha Ali";
            Book1.subject = "C Programming Tutorial";
            Book1.book_id = 6495407;

            /* book 2 详述 */
            Book2.title = "Telecom Billing";
            Book2.author = "Zara Ali";
            Book2.subject = "Telecom Billing Tutorial";
            Book2.book_id = 6495700;

            /* 打印 Book1 信息 */
            Console.WriteLine("Book 1 title : {0}", Book1.title);
            Console.WriteLine("Book 1 author : {0}", Book1.author);
            Console.WriteLine("Book 1 subject : {0}", Book1.subject);
            Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

            /* 打印 Book2 信息 */
            Console.WriteLine("Book 2 title : {0}", Book2.title);
            Console.WriteLine("Book 2 author : {0}", Book2.author);
            Console.WriteLine("Book 2 subject : {0}", Book2.subject);
            Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);

        }

        struct Books2
        {
            private string title;
            private string author;
            private string subject;
            private int book_id;
            public void getValues(string t, string a, string s, int id)
            {
                title = t;
                author = a;
                subject = s;
                book_id = id;
            }
            public void display()
            {
                Console.WriteLine("Title : {0}", title);
                Console.WriteLine("Author : {0}", author);
                Console.WriteLine("Subject : {0}", subject);
                Console.WriteLine("Book_id :{0}", book_id);
            }

        };

        public class NewTestStruct{
            public void NewtestFunc() {
                Books2 Book1 = new Books2(); /* 声明 Book1，类型为 Book */
                Books2 Book2 = new Books2(); /* 声明 Book2，类型为 Book */

                /* book 1 详述 */
                Book1.getValues("C Programming",
                "Nuha Ali", "C Programming Tutorial", 6495407);

                /* book 2 详述 */
                Book2.getValues("Telecom Billing",
                "Zara Ali", "Telecom Billing Tutorial", 6495700);

                /* 打印 Book1 信息 */
                Book1.display();
                /* 打印 Book2 信息 */
                Book2.display();
            }
        };



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Learning
{
    enum Days { Sun, Mon, Tue, Wed,Thu, Fri, Sat };

    class MyEnum
    {
        public void myTestFunc()
        {
            int firstMon = (int)Days.Sun;
            float firstFri = (float)Days.Sun;
            Console.WriteLine("Monday: {0}", firstMon);
            Console.WriteLine("Friday: {0}", firstFri);
        }

    };
}

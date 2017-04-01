using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//使用以下方法之一来创建 string 对象：
//通过给 String 变量指定一个字符串
//通过使用 String 类构造函数
//通过使用字符串串联运算符（ + ）
//通过检索属性或调用一个返回字符串的方法
//通过格式化方法来转换一个值或对象为它的字符串表示形式


//2个属性
//Chars
//在当前 String 对象中获取 Char 对象的指定位置。
//Length
//在当前的 String 对象中获取字符数。



namespace C_sharp_Learning
{
    class MyString
    {
        public void StringFunc()
        {
            //字符串连接
            string a = "first";
            string b = "second";
            string c = a + b;

            //使用string构造函数
            char[] letters = { 'H','e','l','l','o'};
            string greeting = new string(letters);  //里面的必须为char

            //返回字符串
            string[] arr = {"Hello","C#" };
            string message = String.Join("Added",arr);  //Join,在string的每一个char之间加插入的字符（Addded）

            //转化值的格式化方法
            // DataTime waiting = new DataTime(2015,3,17,17,31,1);  DataTime只能在main函数内调用

            Console.Write("字符串连接：{0}", c);
            Console.Write("构造函数：{0}", greeting);
            Console.Write("返回字符串：{0}", message);
        }

        //string的常见方法

        //比较两个指定的 string 对象，并返回一个表示它们在排列顺序中相对位置的整数。该方法区分大小写。 
        static char[] Achar= { 'H', 'E' }; 
        const string a = "aaa";
        const string Fakea = "aaab";
        const string aa = "a";
        const string Thisb = "bbbb";
        const string Along = "BBBaaa";
        const string UpperA = "AAA";
        const string UpperB = "BBB";
        int result = string.Compare(a, Thisb);    //如果后面加的是2个变量，必须是静态的。
        //result 小于0，a<b。 为0，a=b。 大于0，a>b。

        //比较两个指定的 string 对象，并返回一个表示它们在排列顺序中相对位置的整数。但是，如果布尔参数为真时，该方法不区分大小写。
        int result2 = string.Compare(a, UpperA, true);

        //连接两个 string 对象。
        string result3 = string.Concat(a, UpperA);

        //连接三个 string 对象。
        string result4 = string.Concat(a,Thisb,UpperA);


        //连接四个 string 对象。
        string result5 = string.Concat(a, Thisb, UpperA, UpperB);

        //返回一个表示指定 string 对象是否出现在字符串中的值。
        bool isHas = a.Contains(Thisb);

        //创建一个与指定字符串具有相同值的新的 String 对象。
        string CopyA = string.Copy(a);

        //从 string 对象的指定位置开始复制指定数量的字符到 Unicode 字符数组中的指定位置。 
        public void CopyFunc() {
            Thisb.CopyTo(1, Achar, 1, 2);     //复制b的第二位（1）开始的长度（2）， 到Achar的第二位（1）  { 'H',‘b'，'b'，'E' }
            Console.WriteLine(Achar);
        }

        //判断 string 对象的结尾是否匹配指定的字符串。
        bool isEndTrue = Along.EndsWith(a);

        //判断当前的 string 对象是否与指定的 string 对象具有相同的值。
        bool isEqual = Fakea.Equals(a);

        //判断两个指定的 string 对象是否具有相同的值。        
        bool ifEqual = bool.Equals(Fakea,a);

        //把指定字符串中一个或多个格式项替换为指定对象的字符串表示形式。
        string replaceformat = string.Format(a, Achar);

        //返回指定 Unicode 字符在当前字符串中第一次出现的索引，索引从 0 开始。        
        int IndexNum = Thisb.IndexOf(Fakea);

        //返回指定字符串在该实例中第一次出现的索引，索引从 0 开始。        
        int FirstIndex =aa.IndexOf(a);

        //返回指定 Unicode 字符从该字符串中指定字符位置开始搜索第一次出现的索引，索引从 0 开始。       ??
        //int FirstIndex2 = IndexOf(char value, int startIndex);

        //返回指定字符串从该实例中指定字符位置开始搜索第一次出现的索引，索引从 0 开始。        ??
        public int IndexOf(string value, int startIndex) { return startIndex; }

        //返回某一个指定的 Unicode 字符数组中任意字符在该实例中第一次出现的索引，索引从 0 开始。       ??
        public int IndexOfAny(char[] anyOf) { return 0; }

        //返回某一个指定的 Unicode 字符数组中任意字符从该实例中指定字符位置开始搜索第一次出现的索引，索引从 0 开始。  ??      
        public int IndexOfAny(char[] anyOf, int startIndex) { return 0; }

        //返回一个新的字符串，其中，指定的字符串被插入在当前 string 对象的指定索引位置。       
        public string Insert(int startIndex, string value) { return "hello"; }

        //指示指定的字符串是否为 null 或者是否为一个空的字符串。       
        public static bool IsNullOrEmpty(string value) { return true; }

        //连接一个字符串数组中的所有元素，使用指定的分隔符分隔每个元素。        
        public static string Join(string separator, string[] value) { return "hello"; }

        //连接接一个字符串数组中的指定位置开始的指定元素，使用指定的分隔符分隔每个元素。        
        public static string Join(string separator, string[] value, int startIndex, int count) { return "hello"; }

        //返回指定 Unicode 字符在当前 string 对象中最后一次出现的索引位置，索引从 0 开始。       
        public int LastIndexOf(char value) { return 0; }

        //返回指定字符串在当前 string 对象中最后一次出现的索引位置，索引从 0 开始。        
        public int LastIndexOf(string value) { return 0; }

        //移除当前实例中的所有字符，从指定位置开始，一直到最后一个位置为止，并返回字符串。        
        public string Remove(int startIndex) { return "hello"; }

        //从当前字符串的指定位置开始移除指定数量的字符，并返回字符串。        
        public string Remove(int startIndex, int count) { return "hello"; }

        //把当前 string 对象中，所有指定的 Unicode 字符替换为另一个指定的 Unicode 字符，并返回新的字符串。        
        public string Replace(char oldChar, char newChar) { return "hello"; }

        //把当前 string 对象中，所有指定的字符串替换为另一个指定的字符串，并返回新的字符串。       
        public string Replace(string oldValue, string newValue) { return "hello"; }

        //返回一个字符串数组，包含当前的 string 对象中的子字符串，子字符串是使用指定的 Unicode 字符数组中的元素进行分隔的。       
      //  public string[] Split(params char[] separator) { return a[]; }
        //返回一个字符串数组，包含当前的 string 对象中的子字符串，子字符串是使用指定的 Unicode 字符数组中的元素进行分隔的。int 参数指定要返回的子字符串的最大数目。        
    //    public string[] Split(char[] separator, int count) { return "hello"; }
        //判断字符串实例的开头是否匹配指定的字符串。        
        public bool StartsWith(string value) { return true; }
        //返回一个带有当前 string 对象中所有字符的 Unicode 字符数组。       
       // public char[] ToCharArray()
        //返回一个带有当前 string 对象中所有字符的 Unicode 字符数组，从指定的索引开始，直到指定的长度为止。        
       // public char[] ToCharArray(int startIndex, int length)
        //把字符串转换为小写并返回。        
      //  public string ToLower() { return "hello"; }
        //把字符串转换为大写并返回。        
       // public string ToUpper() { return "hello"; }
        //移除当前 String 对象中的所有前导空白字符和后置空白字符。        
        public string Trim() { return "hello"; }

    }
}

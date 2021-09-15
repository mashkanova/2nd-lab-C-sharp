using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 5;
            Console.WriteLine(a);
            bool variable = false;
            Console.WriteLine(variable);
            double b = 1.44;
            Console.WriteLine(b);
            string line = "hello world";
            Console.WriteLine(line);
            char c = '#';
            Console.WriteLine(c);
            float f = 134.45E-2f;
            Console.WriteLine(f);
            decimal m = 1.5E6m;
            Console.WriteLine(m);
            byte d = 199;
            Console.WriteLine(d);
            sbyte e = -127;
            Console.WriteLine(e);
            short s = -3672;
            Console.WriteLine(s);
            ushort t = 6473;
            Console.WriteLine(t);
            uint u = 64288239;
            Console.WriteLine(u);
            long l = -64389428474658;
            Console.WriteLine(l);
            ulong ul = 34268529995;
            Console.WriteLine(ul);
            object obj = -434.43;
            Console.WriteLine(obj);
            //явные преобразования
            //1
            byte first = (byte)a;
            //2
            int a1 = 6;
            byte a2 = (byte)(a + a1);
            //3
            decimal c2 = (decimal)b;
            //4
            long d1 = (long)f;
            //5
            float e1 = (float)b;
            // неявные преобразования
            ushort a3 = d;
            short b3 = d;
            int c3 = d;
            long d3 = d;
            float e3 = d;
            // boxing and unboxing
            object box = a;
            int unb = (int)b;
            //работа с неявно типизированной переменной
            var sum = (c3 + a);
            Console.WriteLine("Рвбота с неявно типизорованной переменной "+ sum);
            //пример работы с Nullable переменной
            int? str = null;
            int? strr = 133;
            Console.WriteLine(str.HasValue);
            Console.WriteLine(strr.HasValue);

            //string
            string string1 = "Hello World!!";
            Console.WriteLine(String.Compare(string1, "Hello World!"));
            string line1 = "i like kitties ";
            string line2 = "and puppies";
            string line3 = "Also i like learning C#!";
            string line4 = String.Concat(line1," ", line2);
            Console.WriteLine(line4);
            string line5 = String.Copy(line3);
            Console.WriteLine(line5);
            int startIndex = 2;
            int length = 4;
            //выделение подстроки
            String substring = line1.Substring(startIndex, length);
            Console.WriteLine(substring);
            //разделение строкии на слова
            string[] words = line3.Split(' ');

            foreach (var sub in words)
            {
                Console.WriteLine($"Substring: {sub}");
            }
            //вставка подстроки в заданную позицию
            string line6 = line1.Insert(15, line2);
            Console.WriteLine(line6);
            //удаление подстроки
            string line7 = line3.Remove(0, 5);
            Console.WriteLine(line7);
            //null or empty
            bool TestForNullOrEmpty(string st)
            {
                bool result;
                result = st == null || st == string.Empty;
                return result;
            }
            string line8 = "";
            string line9 = null;

            Console.WriteLine(TestForNullOrEmpty(line8));
            Console.WriteLine(TestForNullOrEmpty(line9));
            // string based on stringBuilder
            StringBuilder sb = new StringBuilder(" my brain just like $^&*& *^%$#$%^&* ");
            sb.Remove(20, 6);
            Console.WriteLine(sb);
            sb.Insert(0, "Hello!");
            Console.WriteLine(sb);
            sb.AppendFormat("(it's alright)");
            Console.WriteLine(sb);
        }
    }
}

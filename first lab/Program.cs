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
            Console.WriteLine("Рвбота с неявно типизорованной переменной " + sum);
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
            string line4 = String.Concat(line1, " ", line2);
            Console.WriteLine(line4);
            string line5 = String.Copy(line3);
            Console.WriteLine(line5);
            //выделение подстроки
            int startIndex = 2;
            int length = 4;
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
            //Arrays
            int[,] MyArray = new int[2, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            //          int height = MyArray.GetLength(0);
            //          int width = MyArray.GetLength(1);
            for (int i = 0; i < MyArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyArray.GetLength(1); j++)
                {
                    Console.Write(MyArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            string[] Arr = new string[3] { "i like", "small kittens", "lovely puppies" };
            foreach (string num in Arr)
            {
                Console.Write(num + " " + "\t");
            }
            Console.WriteLine();
            // длина массива
            int lengthOfArr = Arr.Length;
            Console.WriteLine(lengthOfArr);
            // меняем значение элемента массива и выводим массив
            Arr[1] = "<3";
            foreach (string num in Arr)
            {
                Console.Write(num + " " + "\t");
            }
            Console.WriteLine();
            // ступенчатый массив

            int tr = int.Parse(Console.ReadLine());
            int tr1 = int.Parse(Console.ReadLine());
            int tr2 = int.Parse(Console.ReadLine());
            int tr3 = int.Parse(Console.ReadLine());
            int tr4 = int.Parse(Console.ReadLine());
            int tr5 = int.Parse(Console.ReadLine());
            int tr6 = int.Parse(Console.ReadLine());
            int tr7 = int.Parse(Console.ReadLine());
            int tr8 = int.Parse(Console.ReadLine());
            int[][] zub = new int[3][];

            zub[0] = new int[2] { tr, tr1 };
            zub[1] = new int[3] { tr2, tr3, tr4 };
            zub[2] = new int[4] { tr5, tr6, tr7, tr8 };

            for (int i12 = 0; i12 < zub.Length; i12++)
            {
                for (int j12 = 0; j12 < zub[i12].Length; j12++)
                {

                    Console.Write($"{zub[i12][j12]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine(zub);
            //кортежи 
            (int, string, char, string, ulong) Wer = (4, "My name is Sasha", '#', "i like cats", 10);
            Console.WriteLine(Wer.ToString());
            Console.WriteLine($"The 1st, 3rd and 4th elements {Wer.Item1}, {Wer.Item3}, {Wer.Item4} .");
            (int, string, char, string, ulong) Wer1 = ((int, string, char, string, ulong))Wer;

            Func < int[], string, Tuple< int, int, int, char>> fun = (arr, strrr) => arr.Aggregate(Tuple.Create(Int32.MinValue, Int32.MaxValue, 0, strrr[0]), (y, x) => Tuple.Create(Math.Max(y.Item1, x), Math.Min(y.Item2, x), y.Item3 + x, y.Item4));
            Console.WriteLine(fun(new int[] { 1, -2, 3, -4, 5, -6, 7, -8, 9, 0 }, "Abracadabra"));

            void checkedFunction()
            {
                int ch = checked(int.MaxValue);
            }

            void uncheckedFunction()
            {
                int unch = checked(int.MinValue);

            }
           

        }
    }
}

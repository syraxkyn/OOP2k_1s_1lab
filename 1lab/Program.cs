using System;
using System.Text;

namespace _1lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.1
            //bool zz1 = true;
            //byte zz2 = 242;
            //sbyte zz3 = 62;
            //char l1 = 'a';
            //decimal d2 = 42;
            //double dd2 = 1.7;
            //float df1 = 30.6f;
            //int il2 = 4;
            //uint ui2 = 323;
            //long ul2 = 0xFF;
            //ulong ll3 = 0b101;
            //string ss3 = "1lab";
            //object b = 3.14;
            //Console.WriteLine(zz1);
            //Console.WriteLine(zz2);
            //Console.WriteLine(zz3);
            //Console.WriteLine(l1);
            //Console.WriteLine(d2);
            //Console.WriteLine(dd2);
            //Console.WriteLine(df1);
            //Console.WriteLine(il2);
            //Console.WriteLine(ui2);
            //Console.WriteLine(ul2);
            //Console.WriteLine(ll3);
            //Console.WriteLine(ss3);
            //Console.WriteLine(b);
            ////1.2
            //int num = 2147483647;
            //long bigNum = num;
            //float num1 = 5.4f;
            //double bigNum1 = num1;
            //byte a = 4;           
            //ushort b11 = a;
            //sbyte a1 = 4;            
            //short b1 = a1;
            //sbyte a11 = -4;          
            //short b12 = a11;

            //int a2 = 4;
            //byte c2 = (byte)a2;
            //double a12 = 4.0;
            //decimal b21 = (decimal)a12;
            //int x = 50;
            //byte y = (byte)x;
            //uint x2 = 32323232;
            //ulong y2 = x2;
            //char z4 = '3';
            //int z3 =(int)z4;
            ////1.3
            //int zk2 = 123;
            //object obj1 = zk2;
            //int zk1 = (int)obj1;
            ////1.4
            //var name = "Andrey Shulakov";
            //var age = 18;
            //var isProgrammer = true;
            //Type nameType = name.GetType();
            //Type ageType = age.GetType();
            //Type isProgrammerType = isProgrammer.GetType();
            //Console.WriteLine("Тип name: {0}", nameType);
            //Console.WriteLine("Тип age {0}", ageType);
            //Console.WriteLine("Тип isProgrammer {0}", isProgrammerType);
            ////1.5
            //int? zf1 = 9;
            //Console.WriteLine(zf1.Value);
            //Console.WriteLine(zf1.HasValue);
            //double? ff1 = null;
            //if (ff1.HasValue)
            //    Console.WriteLine(ff1.Value);
            //else
            //    Console.WriteLine("ff1 is equal to null");
            ////1.6
            //var dj1 = 5;
            ////dj1 = 5.5;//т.к тип dj1 - int;
            ////2.1
            //string str1 = "s";
            //string str2 = "s";
            //Console.WriteLine("==: " + (str1 == str2));
            ////2.2
            //string un1 = "Belarussian";
            //string un2 = "State";
            //string un3 = "Technological University";
            //string unsc = String.Concat(un1, un2, un3);
            //string un3c = String.Copy(un3);
            //string un3s = un3.Substring(14);
            //string[] words = un3.Split(' ');
            //string un13 = un3.Insert(0, un1);
            //string un3r = un3.Remove(0, 11);
            //long number = 375259017240;
            //Console.WriteLine($"{number:+### ## #######}");
            ////2.3
            //string s1 = "";
            //string s2 = null;
            //string s3 = "           ";
            //Console.WriteLine(String.IsNullOrEmpty(s1));
            //Console.WriteLine(String.IsNullOrEmpty(s2));
            //Console.WriteLine(String.IsNullOrWhiteSpace(s3));
            ////2.4
            //StringBuilder sb = new StringBuilder("Привет мир");
            //sb.Remove(7,3);
            //sb.Append("!");
            //sb.Insert(7, "компьютер");
            ////3.1
            //int[,] array = new int[3, 3];
            //Random rnd = new Random();
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for(int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = rnd.Next(0, 10);
            //        Console.Write("{0} ", array[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //string[] arrstr = new string[3];
            //for (int i = 0; i < arrstr.GetLength(0); i++)
            //{
            //    Console.Write($"Введите элемент {i}: ");
            //    arrstr[i] = Console.ReadLine();
            //}
            //Console.Write($"Длина массива:{arrstr.Length}\n");
            //Console.Write($"Введите номер элемента ");
            //int f = Convert.ToInt16(Console.ReadLine());
            //Console.Write($"Новое значение элемента {f}: ");
            //arrstr[f] = Console.ReadLine();
            //Console.Write($"Обновленный массив:");
            //for (int i = 0; i < arrstr.GetLength(0); i++)
            //{
            //    Console.Write($"{arrstr[i]} ");
            //}
            //double[][] myArr = new double[3][];
            //myArr[0] = new double[2];
            //myArr[1] = new double[3];
            //myArr[2] = new double[4];
            //for(int i = 0;i < myArr.Length; i++)
            //{
            //    for(int j = 0;j < myArr[i].GetLength(0); j++)
            //    {
            //Console.Write($"Введите значение элемента {i} {j}: ");
            //        myArr[i][j] = Convert.ToDouble(Console.ReadLine());
            //    }
            //    Console.WriteLine("");
            //}
            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    for (int j = 0; j < myArr[i].GetLength(0); j++)
            //    {
            //        Console.Write($"{myArr[i][j]} ");
            //    }
            //    Console.WriteLine("");
            //}
            //var array22 = new object[0];
            //var str31 = "";
            //4.1
            //var tuple = new Tuple<int, string, char, string, ulong>(5,"vasya",'A',"petya",3213);
            //Console.WriteLine(tuple);
            //Console.WriteLine($"1 элемент:{tuple.Item1} \n3 элемент:{tuple.Item3}\n4 элемент:{tuple.Item4} ");
            //(int, string) box = (1, "abc");
            //var t = box;//(int, string) t = ((int, string))box;
            //Console.WriteLine(t);

            //(string, string, string) LookupName(long id) // tuple return type
            //{
            //string first = Console.ReadLine();
            //string middle = Console.ReadLine();
            //string last = Console.ReadLine();
            //return (first, middle, last); // tuple literal
            //}
            //var names = LookupName(1);
            //Console.Write($"found {names.Item1} {names.Item3}.\n");
            //var names2 = LookupName(2);
            //Console.Write($"found {names2.Item1} {names2.Item3}.");
            //var (first1, middle1, last1) = names;
            //Console.Write(names == names2);
            //5.1
            //static(int,int,int,char) Localfunction(int[] numbers,string str1)
            //{
            //    int d = 0;
            //    int z = Int32.MaxValue;
            //    int sum = 0;
            //    Random rnd = new Random();
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        if (numbers[i] > d)
            //        {
            //            d = numbers[i];
            //        }
            //        if (numbers[i] < z)
            //        {
            //            z = numbers[i];
            //        }
            //        sum += numbers[i];
            //    }
            //    char smb = str1[0];
            //    var tuple1 = (d, z, sum, smb);
            //    return tuple1;
            //}
            //int[] nums = new int[4];
            //nums[0] = 20;
            //nums[1] = 30;
            //nums[2] = 40;
            //nums[3] = 100;
            //string str2 = "petya";
            //Console.WriteLine(Localfunction(nums, str2));
            //6.1
//            int z22 = 15;
//            int localfunction2()
//            {
//                int z = Int32.MaxValue;
//                unchecked
//                {
//                    z = z + z22;
//                    Console.WriteLine(z);
//                }
//                return z;
//            }
//            int localfunction1()
//            {
//                int z = Int32.MaxValue;
//                checked
//                {
//                    z = z + z22;
//                    Console.WriteLine(z);
//                }
//                return z;
//            }
//            Console.WriteLine(localfunction2());
//            Console.WriteLine(localfunction1());
//        }
//    }
//}

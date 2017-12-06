using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Tasks
    {
        static int num = 2;

        static void Main(string[] args)
        {
            int[] a = { 2, 5, 8, -3, 0, -1, 4, -6 };

            GetSumPositiveNumbers(a);
            ShowArrayValues(a);
            GetSumNumbers(a);
            GetAmtSumPositiveNumbers(a);
            PrintArray(a);
            GetMinNumber(a);
            PrintArray(a);
            GetMaxNumber(a);
            PrintArray(a);
            GetAmtNegativeNumbers(a); //3
            GetAmtPositiveOddNumber(a); //1
            GetAmtPositiveEvenNumber(a); //3
            MultiplyPositiveNumbers(a); //320
            GetAmtNumberEqualFour(a, num);
            GetAmtNumberLessFour(a, num);
            MergeArrays();
            MergeArrays1();
            MinMax();
            MinPositiveEvenNum();
            MinNegativeNumber();
            MaxNumber(a);
        }

        static void PrintArray(int[] a)
        {
            Console.WriteLine("Print array");
            for (int i=0; i < a.Length; i++)
            {
                Console.Write(a[i]+"; ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("_____________");
        }

        static void GetSumPositiveNumbers(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0)
                {
                    sum = a[i] + sum;
                }

            }
            Console.WriteLine("sum of positive numbers is {0}", sum);
            Console.ReadKey();
        }

        static void ShowArrayValues(int[] a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }

        //Найти сумму всех элементов массива
        static void GetSumNumbers(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }



        //1.Дан массив А(5). Найти сумму и количество положительных элементов.
        static void GetAmtSumPositiveNumbers(int[] a)
        {
            int sum = 0;
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    sum = sum + a[i];
                    k = k + 1;

                }
            }
            Console.WriteLine("sum of positive numbers =" + "" + sum);
            Console.WriteLine("amount of positive numbers =" + "" + k);
            Console.ReadKey();

        }

        //2.Дан массив А(6). Найти минимальный элемент массива и его порядковый номер.
        static void GetMinNumber(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("min array number is" + min);
            Console.ReadKey();
        }

        //3.Дан массив А(4). Найти максимальный элемент массива и его порядковый номер.
        static void GetMaxNumber(int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)  //если текущий элемент больше максимального, то он становится максимальным.
                {
                    max = a[i];
                }
            }
            Console.WriteLine("max array number is {0}", max);
            Console.ReadKey();
        }

        //10.Дан массив А(5). Определить количество отрицательных элементов.
        static void GetAmtNegativeNumbers(int[] a)
        {
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    k = k + 1;
                }
            }
            Console.WriteLine("amount of negative numbers is {0}", k);
            Console.ReadKey();
        }

        //12.Дан массив А(5).  Найти количество нечетных положительных элементов.
        static void GetAmtPositiveOddNumber(int[] a)
        {
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] > 0) && (a[i] % 2 != 0))
                {
                    k = k + 1;
                }
            }
            Console.WriteLine("amount of odd positive numbers is {0}", k);
            Console.ReadKey();
        }

        //13.Дан массив А(7).  Найти количество четных положительных элементов.
        static void GetAmtPositiveEvenNumber(int[] a)
        {
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] > 0) && (a[i] % 2 == 0))
                {
                    k = k + 1;
                }
            }
            Console.WriteLine("amount of positive even numbers is {0}", k);
            Console.ReadKey();
        }
        //16.Дан массив А(5). Найти произведение положительных элементов.
        static void MultiplyPositiveNumbers(int[] a)
        {
            int m = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    m = a[i] * m;
                }
            }
            Console.WriteLine("multiplication of positive numbers = {0}", m);
            Console.ReadKey();
        }
        //17.Дан массив А(6). Найти  количество элементов, равных 4.
        static void GetAmtNumberEqualFour(int[] a, int num)
        {
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == num)
                {
                    k = k + 1;
                }
            }
            Console.WriteLine("amount of elements equal {0} = {1}", num, k);
            Console.ReadKey();

        }
        //20.Дан массив А(5). Определить количество элементов, меньших 4.
        static void GetAmtNumberLessFour(int[] a, int num )
        {
            
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < num)
                {
                    k = k + 1;
                }
            }
            Console.WriteLine("amount of elements less {0} = {1}", num, k);
            Console.ReadKey();

        }
        //18.Даны массивы А(5) и В(10). Вычислить суммы соответствующих элементов массивов (первый с первым. второй со вторым и т.д.).
        //Записать значения в третий массив и вывести его
        static void MergeArrays()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 1, 2, 3 };

            int[] c = new int[3];
            for (int i = 0; i < b.Length; i++)
            {
                c[i] = a[i] + b[i];
                Console.Write(c[i]);
            }
            Console.ReadKey();
        }

        //19.Даны массивы А(5) и В(10). Вычислить разность соответствующих элементов массивов.
        static void MergeArrays1()
        {
            int[] a = { 2, 3, 4 };
            int[] b = { 1, 2, 3, 4, 5 };

            int[] c = new int[b.Length];

            for (int i = 0; i < b.Length; i++)
            {
                if (i < a.Length)
                    c[i] = a[i] - b[i];
                Console.Write(c[i]);
            }
            Console.ReadKey();
        }
        //5.Дан массив А(6). Найти сумму и количество положительных элементов, расположенных между минимальным и максимальным элементами.
        static void MinMax()
        {
            int[] a = { 0, 1, 2, 3, 4, 5, 6 };
            int min = a[0];
            int max = a[0];
            int sum = 0;
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
                else if (a[i] > max)
                {
                    max = a[i];
                }
            }
            for (int i = min; i < max; i++)
            {
                sum = sum + a[i];
                k = k + 1;
            }
            Console.WriteLine("sum and amount between max and min = {0} and {1}", sum, k);
            Console.ReadKey();

        }

        //23.Дан массив А(5). Найти наименьший положительный элемента среди
        //элементов с четными номерами массива.
        static void MinPositiveEvenNum()
        {
            int[] a = { 2, 5, 1, -3, 0, -1, 4, -6 };
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0 && a[i] % 2 == 0)
                {
                    if (a[i] < min)
                    {
                        min = a[0];
                    }
                }
            }
            Console.WriteLine("minimal positive number between even elements is {0} ", min);
            Console.ReadKey();
        }

        //24.Составить программу для нахождения наименьшего из отрицательных
        //элементов массива А(10).

        static void MinNegativeNumber()
        {
            int[] a = { 2, 5, 1, -3, 0, -1, 4, -6 };
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                    }
                }
            }
            Console.WriteLine("minimal negative number is {0} ", min);
            Console.ReadKey();
        }

        //25.Найти наибольший среди элементов массива А(10),  остальные обнулить.

        static void MaxNumber(int[] a)
        {
            int max = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                else
                {
                    a[i] = 0;
                    Console.WriteLine(a[i]);
                }

            }
            Console.WriteLine("max=" + " " + max);
            Console.ReadKey();
        }



        //Тебе передается массив в функцию, нужно вывести каждый четный элемент
        //int[] a = { 2, 5, 8, 0, 1, 7, 9 };
        //for (int i = 0; i < a.Length; i++)
        //{
        //    if (a[i] % 2 == 0)
        //    {
        //        Console.WriteLine(a[i]);
        //    }
        //}
        //Console.ReadKey();

        /*Создать массив из 15 элементов и заполнить его числами от 1 до 15:
          а) по возрастанию*/

        //int[] array = new int[15];

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        array[i] = i + 1;
        //        Console.WriteLine(array[i] + " " + i);

        //    }
        //    Console.ReadKey();

        /*б) по убыванию*/

        // int[] array = new int[15];


        //for (int i = 0; i <array.Length; i++)
        // {
        //    array[i] = 15 - i;
        //     Console.WriteLine(array[i]+" " +i);
        // }
        // Console.ReadKey();

        //в) случайным образом

        //result: 1. ты не должна определять массив, только указать его длину 2. программа работает некорректно, ошибка System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'

        //int[] array = new int[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };  
        //Random rand = new Random();
        //for (int i = 0; i <= 15; i++)
        //{
        //    array[i] = rand.Next(0, 15);
        //    Console.WriteLine(array[i]);
        //}
        //Console.ReadKey();

        //8.Дан массив А(9). Упорядочить элементы, массива по убыванию.
        //9.Дан массив А(10). Упорядочить элементы, массива по возрастанию.
        //25.Найти наибольший среди элементов массива А(10),  остальные обнулить.

    }
}


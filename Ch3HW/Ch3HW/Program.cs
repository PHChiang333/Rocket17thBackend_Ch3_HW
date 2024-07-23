using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Ch3HW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ch3 for迴圈
            //1.ch.3例題3-1~3-7、習題3-1~3-7、補充習題1~3
            //例題3-1
            //讀入五個整數，求這五個整數的和。(for迴圈)

            //int sum = 0;
            //int x = 0;

            //Console.WriteLine("例題3-1");
            //Console.WriteLine("讀入五個整數，求這五個整數的和。");
            //Console.WriteLine("請輸入五個整數");

            //for (int i = 0; i <= 4; i++)
            //{
            //    Console.WriteLine("請輸入一個數字");
            //    x = Convert.ToInt32(Console.ReadLine());

            //    sum += x;
            //    Console.WriteLine($"這是第{i+1}個數字{x}");
            //    Console.WriteLine($"新的總和為{sum}");
            //}
            //Console.WriteLine($"\n 加了五個數字後的總合={sum}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //例題3-2
            //求N個整數的和，N由使用者輸入。(for迴圈)

            //int N = 0;
            //int tmp;
            //int sum = 0;

            //Console.WriteLine("例題3-2");
            //Console.WriteLine("求N個整數的和，N由使用者輸入。");

            //Console.WriteLine("請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < N; i++)
            //{
            //    Console.WriteLine($"這是第{i + 1}個數字，請輸入整數");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    sum = sum + tmp;
            //    Console.WriteLine($"你輸入的是{tmp}, 新的總和為{sum}");
            //}
            //Console.WriteLine($"\n 加了{N}個數字後的總合={sum}");

            //Console.ReadKey();


            //-----------------------------------------------------
            //例題3-3
            //假設有N個正整數，求其中的最大值。(for迴圈)

            //int N = 0;
            //int Max = 0, tmp;

            //Console.WriteLine("例題3-3");
            //Console.WriteLine("假設有N個正整數，求其中的最大值。");

            //Console.Write("請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write($"請輸入第{i + 1}個正整數，請輸入一個正整數=");
            //    tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp > Max)
            //    {
            //        Max = tmp;
            //    }
            //}
            //Console.WriteLine($"輸入{N}個數字後的最大值={Max}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //例題3-4
            //假設有N個正整數，求最大奇數值。(for迴圈)

            //int N = 0;
            //int odd = int.MinValue, tmp;

            //Console.WriteLine("例題3-4");
            //Console.WriteLine("假設有N個正整數，求最大奇數值。");

            //Console.Write("請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write($"第{i+1}個正整數=");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    //Console.WriteLine($"你輸入的是{tmp}");
            //    if (tmp % 2 == 1 && tmp > odd)
            //    {
            //        odd = tmp;
            //    }
            //    //Console.WriteLine($"新的最大奇數值為{odd}");
            //}
            //Console.WriteLine($"輸入{N}個數字後的最大奇數值={odd}");


            //Console.ReadKey();


            //-----------------------------------------------------
            //例題3-5
            //求N階層，即求1×2×3×…×N。(for迴圈)

            //int N;
            //int VAL = 1;

            //Console.WriteLine("例題3-5");
            //Console.WriteLine("求N階層，即求1×2×3×…×N。");


            //Console.Write("請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //for (int i = 2; i < N + 1; i++)  //i從i=2開始，結束條件要記得補次數回去變i<N+1
            //{
            //    VAL = VAL * i;
            //}

            //Console.WriteLine($"{N}階層 = {VAL}");

            //Console.ReadKey();


            //-----------------------------------------------------
            //例題3-6
            //輸出一個九九乘法表。(for迴圈)

            //int product;

            //Console.WriteLine("例題3-6");
            //Console.WriteLine("輸出一個九九乘法表");

            //Console.WriteLine($"99乘法表：");

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        product = i * j;
            //        Console.WriteLine($"{i}*{j}={product}");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey();


            //-----------------------------------------------------
            //例題3-7
            //輸出一個九九乘法表，排列成三欄三列。(for迴圈)

            //Console.WriteLine("例題3-7");
            //Console.WriteLine("輸出一個九九乘法表，排列成三欄三列。");

            //Console.WriteLine($"99乘法表：");

            //for (int i = 1; i < 10; i+=3)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.WriteLine($"{i}*{j}={i*j} \t {i+1}*{j}={(i+1) * j}\t {i + 2}*{j}={(i + 2) * j}");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey();

            //-----------------------------------------------------
            //習題3-1
            //寫一程式，輸入10個整數，求其最小值。(for迴圈)

            //Console.WriteLine("習題3-1");
            //Console.WriteLine("寫一程式，輸入10個整數，求其最小值。");

            //int min=int.MaxValue;
            //int tmp;

            //for (int i= 0; i<10; i++)
            //{
            //    Console.Write($"請輸入第{i+1}個整數=");
            //    tmp = Convert.ToInt32( Console.ReadLine() );
            //    if (tmp < min) {
            //        min = tmp;
            //    }
            //}
            //Console.WriteLine($"輸入的10個數字中最小的數={min}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //習題3-2
            //寫一程式，輸入N個整數，求其最小值。(for迴圈)

            //Console.WriteLine("習題3-2");
            //Console.WriteLine("寫一程式，輸入N個整數，求其最小值。");


            //int min = int.MaxValue,N;
            //int tmp;

            //Console.Write($"請輸入N=");
            //N = Convert.ToInt32( Console.ReadLine() );

            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write($"請輸入第{i + 1}個整數=");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp < min)
            //    {
            //        min = tmp;
            //    }
            //}
            //Console.WriteLine($"輸入的{N}個數字中最小的數={min}");


            //Console.ReadKey();
            //-----------------------------------------------------
            //習題3-3
            //寫一程式，輸入10個整數，列出其中所有大於12的數字。(for迴圈)

            //Console.WriteLine("習題3-3");
            //Console.WriteLine("寫一程式，輸入10個整數，列出其中所有大於12的數字。");

            //string OUT = "";

            //Console.WriteLine("請輸入10個整數");

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"請輸入{i + 1}個數字: ");
            //    int tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp > 12)
            //    {
            //        OUT += tmp + " ";
            //    }
            //}

            //Console.WriteLine($"輸入的數字中比12大的有:{OUT}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //習題3-4
            //寫一程式，輸入10個整數，列出其中所有大於12的數字的總和。(for迴圈)

            //Console.WriteLine("習題3-4");
            //Console.WriteLine("寫一程式，輸入10個整數，列出其中所有大於12的數字的總和。");

            //int Sum=0;

            //Console.WriteLine("請輸入10個整數");

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"請輸入第{i + 1}個整數: ");
            //    int tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp > 12)
            //    {
            //        Sum += tmp;
            //        Console.WriteLine($"目前總和為:{Sum}");
            //    }
            //}

            //Console.WriteLine($"輸入的數字中比12大的整數總和:{Sum}");


            //Console.ReadKey();


            //-----------------------------------------------------
            //習題3-5
            //寫一程式，輸入N個數字，求其所有奇數中的最大值。例如輸入11,12,3,24,15，答案是15。(for迴圈)

            //Console.WriteLine("習題3-5");
            //Console.WriteLine("寫一程式，輸入N個數字，求其所有奇數中的最大值。例如輸入11,12,3,24,15，答案是15。");

            //int N, MaxOdd = int.MinValue;
            //int tmp;

            //Console.Write("請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < N; i++)
            //{

            //    Console.WriteLine($"請輸入第{i + 1}個整數=");
            //    tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp % 2 == 1 && tmp > MaxOdd)
            //    {
            //        MaxOdd = tmp;
            //    }
            //}

            //Console.WriteLine($"輸入{N}個整數中最大的奇數={MaxOdd}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //習題3-6
            //寫一程式，輸入N個數字，求其所有正數之平方的加總。例如輸入1,-2,3,-4,5五個數字，得到 1^2  + 3^2 + 5^2 = 1 + 9 + 25 = 35 (for迴圈)

            //Console.WriteLine("習題3-6");
            //Console.WriteLine("寫一程式，輸入N個數字，求其所有正數之平方的加總。例如輸入1,-2,3,-4,5五個數字，得到 1^2  + 3^2 + 5^2 = 1 + 9 + 25 = 35");

            //int N;
            //int tmp;
            //double sum=0;

            //Console.Write($"請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < N; i++)
            //{

            //    Console.Write($"請輸入第{i + 1}個整數=");
            //    tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp > 0 )
            //    {
            //        sum += Math.Pow(tmp, 2);
            //    }
            //}
            //Console.WriteLine($"輸入{N}個整數中所有正數之平方的加總={sum}");

            //Console.ReadKey();


            //-----------------------------------------------------
            //習題3-7
            //寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，例如 - 7會被轉換成7。 (for迴圈)

            //Console.WriteLine("習題3-7");
            //Console.WriteLine("寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，例如 - 7會被轉換成7。");


            //string OUT = "";
            //int N;

            //Console.Write("請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write($"請輸入{i + 1}個數字: ");
            //    int tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp < 0)
            //    {
            //        tmp = Math.Abs(tmp);

            //    }
            //    OUT += tmp + " ";
            //}

            //Console.WriteLine($"將輸入的數字接轉換為正數後:{OUT}");

            //Console.ReadKey();


            //-----------------------------------------------------
            //補充習題1
            //判斷101-200之間有多少個質數，並輸出所有質數。(for迴圈)

            //Console.WriteLine("補充習題1");
            //Console.WriteLine("判斷101-200之間有多少個質數，並輸出所有質數。");

            //Console.WriteLine("補充習題1");
            //Console.WriteLine("判斷101-200之間有多少個質數，並輸出所有質數。");

            //int count = 0;
            //string OUT = "";
            //bool isPrime = true;

            //for (int i = 101; i <= 200; i++)
            //{
            //    if (i <= 1) //檢驗isPrime
            //    {
            //        isPrime = false;//排除負數和1,0
            //    }
            //    else
            //    {
            //        for (int j = 2; j < i; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //            else
            //            {
            //                isPrime = true;
            //            }
            //        }
            //    }

            //    if (isPrime == true)
            //    {
            //        count++;
            //        OUT += i + ", ";
            //    }
            //}

            //Console.WriteLine($"101-200之間有{count}個質數，所有質數為{OUT}");
            //Console.ReadKey();

            //-----------------------------------------------------
            //補充習題2
            //輸入一個數，輸出其質因數 (for迴圈)

            //Console.WriteLine("補充習題2");
            //Console.WriteLine("輸入一個數，輸出其質因數");

            //int num;
            //string OUT = "";

            //Console.Write("請輸入一個數字=");
            //num = Convert.ToInt32(Console.ReadLine());

            //for(int i = 1; i < num; i++)
            //{
            //    if(num % i == 0)
            //    {
            //        //i是num的因數
            //        bool isPrime=true;
            //        if (i <= 1) //檢驗isPrime
            //        {
            //            isPrime = false;//排除負數和1,0
            //        }
            //        else
            //        {
            //            for (int j = 2; j < i; j++)
            //            {
            //                if (i % j == 0)
            //                {
            //                    isPrime = false;
            //                    break;
            //                }
            //                else
            //                {
            //                    isPrime = true;
            //                }
            //            }
            //            if (isPrime == true)
            //            {
            //                OUT += i + ", ";
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine($"{num}有質因數={OUT}");

            //Console.ReadKey();


            //-----------------------------------------------------
            //補充習題3
            //求100到300中可以被3與7整除的個數。 (for迴圈)

            //Console.WriteLine("補充習題3");
            //Console.WriteLine("求100到300中可以被3與7整除的個數。");

            //int count = 0;

            //for (int i = 100; i <= 300; i++)
            //{
            //    if (i % 3 == 0 && i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine($"100到300中可以被3與7整除的個數={count}");

            //Console.ReadKey();

            //-----------------------------------------------------

            //Ch4 while迴圈
            //2.ch.3作業改為While寫法
            //-----------------------------------------------------
            //例題3-1
            //讀入五個整數，求這五個整數的和。(while迴圈)

            //int sum = 0;
            //int x = 0;

            //Console.WriteLine("例題3-1");
            //Console.WriteLine("讀入五個整數，求這五個整數的和。");
            //Console.WriteLine("請輸入五個整數");
            //Console.WriteLine("使用while迴圈");

            //int i = 1;
            //while (i <= 5)
            //{
            //    Console.Write($"請輸入第{i}個數字");
            //    x = Convert.ToInt32(Console.ReadLine());
            //    sum += x;
            //    i++;
            //}

            //Console.WriteLine($"\n 加了五個數字後的總合={sum}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //例題3-2
            //求N個整數的和，N由使用者輸入。(while迴圈)

            //Console.WriteLine("習題3-2");
            //Console.WriteLine("寫一程式，輸入N個整數，求其最小值。");
            //Console.WriteLine("使用while迴圈");

            //int min = int.MaxValue, N;
            //int tmp;

            //Console.Write($"請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //int i = 0;
            //while (i < N)
            //{
            //    Console.Write($"請輸入第{i + 1}個整數=");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp < min)
            //    {
            //        min = tmp;
            //    }
            //    i++;
            //}

            //Console.WriteLine($"輸入的{N}個數字中最小的數={min}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //例題3-3
            //假設有N個正整數，求其中的最大值。(while迴圈)

            //int N = 0;
            //int Max = 0, tmp;

            //Console.WriteLine("例題3-3");
            //Console.WriteLine("假設有N個正整數，求其中的最大值。");
            //Console.WriteLine("使用while迴圈");

            //Console.Write("請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //int i=0;
            //while (i < N)
            //{
            //    Console.Write($"請輸入第{i + 1}個正整數，請輸入一個正整數=");
            //    tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp > Max)
            //    {
            //        Max = tmp;
            //    }
            //    i++;
            //}

            //Console.WriteLine($"輸入{N}個數字後的最大值={Max}");

            //Console.ReadKey();


            //-----------------------------------------------------
            //例題3-4
            //假設有N個正整數，求最大奇數值。(while迴圈)

            //int N = 0;
            //int odd = int.MinValue, tmp;

            //Console.WriteLine("例題3-4");
            //Console.WriteLine("假設有N個正整數，求最大奇數值。");
            //Console.WriteLine("使用while迴圈");

            //Console.Write("請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //int i=0;

            //while (i<N)
            //{
            //    Console.Write($"第{i + 1}個正整數=");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    //Console.WriteLine($"你輸入的是{tmp}");
            //    if (tmp % 2 == 1 && tmp > odd)
            //    {
            //        odd = tmp;
            //    }
            //    //Console.WriteLine($"新的最大奇數值為{odd}");
            //    i++;
            //}

            //Console.WriteLine($"輸入{N}個數字後的最大奇數值={odd}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //例題3-5
            //求N階層，即求1×2×3×…×N。(while迴圈)

            //int N;
            //int VAL = 1;

            //Console.WriteLine("例題3-5");
            //Console.WriteLine("求N階層，即求1×2×3×…×N。");
            //Console.WriteLine("使用while迴圈");

            //Console.Write("請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //int i = 2;
            //while (i < (N+1))
            //{
            //    VAL = VAL * i;
            //    i++;
            //}

            //Console.WriteLine($"{N}階層 = {VAL}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //例題3-6
            //輸出一個九九乘法表。(while迴圈)

            //int product;

            //Console.WriteLine("例題3-6");
            //Console.WriteLine("輸出一個九九乘法表");
            //Console.WriteLine("使用while迴圈");

            //Console.WriteLine($"99乘法表：");

            //int i = 1;

            //while (i < 10)
            //{
            //    int j = 1;
            //    while (j < 10)
            //    {
            //        product = i * j;
            //        Console.WriteLine($"{i}*{j}={product}");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}

            //Console.ReadKey();

            //-----------------------------------------------------
            //例題3-7
            //輸出一個九九乘法表，排列成三欄三列。(while迴圈)

            //Console.WriteLine("例題3-7");
            //Console.WriteLine("輸出一個九九乘法表，排列成三欄三列。");
            //Console.WriteLine("使用while迴圈");

            //Console.WriteLine($"99乘法表：");

            //int product;

            //int i = 1;
            //while (i < 10)
            //{
            //    int j = 1;
            //    while (j < 10)
            //    {
            //        Console.WriteLine($"{i}*{j}={i * j} \t {i + 1}*{j}={(i + 1) * j}\t {i + 2}*{j}={(i + 2) * j}");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i += 3;
            //}

            //Console.ReadKey();


            //-----------------------------------------------------
            //習題3-1
            //寫一程式，輸入10個整數，求其最小值。(while迴圈)

            //Console.WriteLine("習題3-1");
            //Console.WriteLine("寫一程式，輸入10個整數，求其最小值。");
            //Console.WriteLine("使用while迴圈");

            //int min = int.MaxValue;
            //int tmp;

            //int i = 0;

            //while (i<10)
            //{
            //    Console.Write($"請輸入第{i + 1}個整數=");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp < min)
            //    {
            //        min = tmp;
            //    }
            //    i++;
            //}

            //Console.WriteLine($"輸入的10個數字中最小的數={min}");

            //Console.ReadKey();


            //-----------------------------------------------------
            //習題3-2
            //寫一程式，輸入N個整數，求其最小值。(while迴圈)

            //Console.WriteLine("習題3-2");
            //Console.WriteLine("寫一程式，輸入N個整數，求其最小值。");
            //Console.WriteLine("使用while迴圈");

            //int min = int.MaxValue, N;
            //int tmp;

            //Console.Write($"請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //int i = 0;
            //while (i < N)
            //{
            //    Console.Write($"請輸入第{i + 1}個整數=");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp < min)
            //    {
            //        min = tmp;
            //    }
            //    i++;
            //}

            //Console.WriteLine($"輸入的{N}個數字中最小的數={min}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //習題3-3
            //寫一程式，輸入10個整數，列出其中所有大於12的數字。(while迴圈)

            //Console.WriteLine("習題3-3");
            //Console.WriteLine("寫一程式，輸入10個整數，列出其中所有大於12的數字。");
            //Console.WriteLine("使用while迴圈");

            //string OUT = "";

            //Console.WriteLine("請輸入10個整數");

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.Write($"請輸入{i + 1}個數字: ");
            //    int tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp > 12)
            //    {
            //        OUT += tmp + " ";
            //    }
            //    i++;
            //}

            //Console.WriteLine($"輸入的數字中比12大的有:{OUT}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //習題3-4
            //寫一程式，輸入10個整數，列出其中所有大於12的數字的總和。(while迴圈)

            //Console.WriteLine("習題3-4");
            //Console.WriteLine("寫一程式，輸入10個整數，列出其中所有大於12的數字的總和。");
            //Console.WriteLine("使用while迴圈");

            //int Sum = 0;

            //Console.WriteLine("請輸入10個整數");

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine($"請輸入第{i + 1}個整數: ");
            //    int tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp > 12)
            //    {
            //        Sum += tmp;
            //        Console.WriteLine($"目前總和為:{Sum}");
            //    }
            //    i++;
            //}

            //Console.WriteLine($"輸入的數字中比12大的整數總和:{Sum}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //習題3-5
            //寫一程式，輸入N個數字，求其所有奇數中的最大值。例如輸入11,12,3,24,15，答案是15。(while迴圈)

            //Console.WriteLine("習題3-5");
            //Console.WriteLine("寫一程式，輸入N個數字，求其所有奇數中的最大值。例如輸入11,12,3,24,15，答案是15。");
            //Console.WriteLine("使用while迴圈");

            //int N, MaxOdd = int.MinValue;
            //int tmp;

            //Console.Write("請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //int i = 0;
            //while (i < N)
            //{
            //    Console.WriteLine($"請輸入第{i + 1}個整數=");
            //    tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp % 2 == 1 && tmp > MaxOdd)
            //    {
            //        MaxOdd = tmp;
            //    }
            //    i++;
            //}

            //Console.WriteLine($"輸入{N}個整數中最大的奇數={MaxOdd}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //習題3-6
            //寫一程式，輸入N個數字，求其所有正數之平方的加總。例如輸入1,-2,3,-4,5五個數字，得到 1^2  + 3^2 + 5^2 = 1 + 9 + 25 = 35 (while迴圈)

            //Console.WriteLine("習題3-6");
            //Console.WriteLine("寫一程式，輸入N個數字，求其所有正數之平方的加總。例如輸入1,-2,3,-4,5五個數字，得到 1^2  + 3^2 + 5^2 = 1 + 9 + 25 = 35");
            //Console.WriteLine("使用while迴圈");

            //int N;
            //int tmp;
            //double sum = 0;

            //Console.Write($"請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //int i = 0;
            //while (i < N)
            //{
            //    Console.Write($"請輸入第{i + 1}個整數=");
            //    tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp > 0)
            //    {
            //        sum += Math.Pow(tmp, 2);
            //    }
            //    i++;
            //}

            //Console.WriteLine($"輸入{N}個整數中所有正數之平方的加總={sum}");

            //Console.ReadKey();


            //-----------------------------------------------------
            //習題3-7
            //寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，例如 - 7會被轉換成7。(while迴圈)

            //Console.WriteLine("習題3-7");
            //Console.WriteLine("寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，例如 - 7會被轉換成7。");
            //Console.WriteLine("使用while迴圈");


            //string OUT = "";
            //int N;

            //Console.Write("請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //int i = 0;
            //while (i<N)
            //{
            //    Console.Write($"請輸入{i + 1}個數字: ");
            //    int tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp < 0)
            //    {
            //        tmp = Math.Abs(tmp);

            //    }
            //    OUT += tmp + " ";
            //    i++;
            //}

            //Console.WriteLine($"將輸入的數字接轉換為正數後:{OUT}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //補充習題1
            //判斷101-200之間有多少個質數，並輸出所有質數。(while迴圈)

            //Console.WriteLine("補充習題1");
            //Console.WriteLine("判斷101-200之間有多少個質數，並輸出所有質數。");
            //Console.WriteLine("使用while迴圈");

            //int count = 0;
            //string OUT = "";
            //bool isPrime = true;

            //int i = 101;
            //while (i <= 200)
            //{
            //    if (i <= 1) //檢驗isPrime
            //    {
            //        isPrime = false;//排除負數和1,0
            //    }
            //    else
            //    {
            //        int j = 2;
            //        while (j < i)
            //        {
            //            if (i % j == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //            else
            //            {
            //                isPrime = true;
            //            }
            //            j++;
            //        }
            //    }
            //    if (isPrime == true)
            //    {
            //        count++;
            //        OUT += i + ", ";
            //    }
            //    i++;
            //}

            //Console.WriteLine($"101-200之間有{count}個質數，所有質數為{OUT}");
            //Console.ReadKey();


            //-----------------------------------------------------
            //補充習題2
            //輸入一個數，輸出其質因數(while迴圈)

            //Console.WriteLine("補充習題2");
            //Console.WriteLine("輸入一個數，輸出其質因數");
            //Console.WriteLine("使用while迴圈");

            //int num;
            //string OUT = "";

            //Console.Write("請輸入一個數字=");
            //num = Convert.ToInt32(Console.ReadLine());

            //int i = 1;
            //while (i < num)
            //{
            //    if (num % i == 0)
            //    {
            //        //i是num的因數
            //        bool isPrime = true;
            //        if (i <= 1) //檢驗isPrime
            //        {
            //            isPrime = false;//排除負數和1,0
            //        }
            //        else
            //        {
            //            int j = 2;
            //            while (j < i)
            //            {
            //                if (i % j == 0)
            //                {
            //                    isPrime = false;
            //                    break;
            //                }
            //                else
            //                {
            //                    isPrime = true;
            //                }
            //                j++;
            //            }
            //        }
            //        if (isPrime == true)
            //        {
            //            OUT += i + ", ";
            //        }
            //    }
            //    i++;
            //}
            //Console.WriteLine($"{num}有質因數={OUT}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //補充習題3
            //求100到300中可以被3與7整除的個數。(while迴圈)

            //Console.WriteLine("補充習題3");
            //Console.WriteLine("求100到300中可以被3與7整除的個數。");
            //Console.WriteLine("使用while迴圈");

            //int count = 0;

            //int i = 100;
            //while(i <= 300)
            //{
            //    if (i % 3 == 0 && i % 7 == 0)
            //    {
            //        count++;
            //    }
            //    i++;
            //}

            //Console.WriteLine($"100到300中可以被3與7整除的個數={count}");

            //Console.ReadKey();


            //-----------------------------------------------------
            //Ch4 while迴圈
            //3.ch.4例題4-1~4-3、習題4-1~4-5、補充習題1~3
            //(如果題目文字與流程圖不一樣，以文字為主)
            //(如果題目題意不清楚，請隨時發問)

            //例題4-1
            //讀入一連串的數字，但事先不知道數字的數目。(while迴圈)
            //假設輸入的都是正數，一旦讀到負數就終止。

            //Console.WriteLine("例題4-1");
            //Console.WriteLine("讀入一連串的數字，但事先不知道數字的數目。");
            //Console.WriteLine("假設輸入的都是正數，一旦讀到負數就終止。");

            //int x;

            //Console.Write("請輸入數字(整數)=");
            //x = Convert.ToInt32(Console.ReadLine());

            ////輸入負數就結束
            //while (x>=0)
            //{
            //    Console.Write($"數字為{x}，沒猜中，繼續猜，數字=");
            //    x = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("猜到負數，結束");


            //Console.ReadKey();

            //-----------------------------------------------------
            //例題4-2
            //求最大公約數(Greatest Common Divisor，簡寫G.C.D.，或稱最大公因數)。(while迴圈)

            //Console.WriteLine("例題4-2");
            //Console.WriteLine("求最大公約數(Greatest Common Divisor，簡寫G.C.D.，或稱最大公因數)。");

            //int x, y;

            //Console.WriteLine("請輸入2個數字求最大公約數(Greatest Common Divisor，簡寫G.C.D.，或稱最大公因數)");

            //Console.Write("請輸入第1個數字=");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入第2個數字=");
            //y = Convert.ToInt32(Console.ReadLine());

            //int tmp = 1;//tmp=GCD
            //int x_abs = Math.Abs(x);
            //int y_abs = Math.Abs(y);

            //if (x_abs >= y_abs)
            //{
            //    if (x_abs % y_abs == 0)
            //    {
            //        tmp = y_abs;
            //    }
            //    else
            //    {
            //        while (x_abs % y_abs != 0)
            //        {
            //            tmp = (x_abs % y_abs);
            //            x_abs = y_abs;
            //            y_abs = tmp;
            //        }
            //    }
            //}
            //else
            //{
            //    if (y_abs % x_abs == 0)
            //    {
            //        tmp = x_abs;
            //    }
            //    else
            //    {
            //        while (y_abs % x_abs != 0)
            //        {
            //            tmp = (y_abs % x_abs);
            //            y_abs = x_abs;
            //            x_abs = tmp;
            //        }
            //    }
            //}

            //Console.WriteLine($"{x}和{y}最大公約數 = {tmp}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //例題4-3
            //計算N個數字的和。(while迴圈)

            //Console.WriteLine("例題4-3");
            //Console.WriteLine("計算N個數字的和");
            //Console.WriteLine("檢查i有沒有超過N，超過就不做了");

            //int N;
            //int sum=0;

            //Console.Write("請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //int i = 1;
            //while (i <= N)
            //{
            //    Console.Write($"請輸入第{i}個數字=");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    sum += x;
            //    i++;
            //}

            //Console.WriteLine($"加總{N}個數字後的總合為{sum}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //習題4-1
            //利用while寫一程式求N個數字的最大值。(while迴圈)

            //Console.WriteLine("習題4-1");
            //Console.WriteLine("利用while寫一程式求N個數字的最大值。");

            //int N;
            //int Max = int.MinValue;

            //Console.WriteLine("求N個數字的最大值");
            //Console.Write("請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //int i = 1;
            //while (i <= N)
            //{
            //    Console.Write($"請輸入第{i}個數字=");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    if (x > Max)
            //    {
            //        Max = x;
            //    }
            //    i++;
            //}

            //Console.WriteLine($"輸入{N}個數字中最大的數字為{Max}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //習題4-2
            //利用while寫一程式求一個等差級數數字的和，一共有N個數字，程式應該輸入最小的起始值以及數字間的差。(即從起始值開始，間格差，共N個 的總和)(while迴圈)

            //Console.WriteLine("習題4-2");
            //Console.WriteLine("利用while寫一程式求一個等差級數數字的和，一共有N個數字，程式應該輸入最小的起始值以及數字間的差。(即從起始值開始，間格差，共N個 的總和)");

            //int N;
            //int start, interval, sum = 0;
            //int i = 1;
            //string OUT = "";

            //Console.WriteLine("計算N個等差數列的和");
            //Console.WriteLine("請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("請輸入起始值=");
            //start = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("請輸入等差級數的差值=");
            //interval = Convert.ToInt32(Console.ReadLine());

            //while (N > 0)
            //{
            //    sum = sum + start;
            //    start = start + interval;
            //    N--;
            //}

            //Console.WriteLine($"等差級數總和={sum}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //習題4-3
            //利用while寫一程式，讀入N個數字，然後找出所有小於13的數，再求這些數字的和。(while迴圈)

            //Console.WriteLine("習題4-3");
            //Console.WriteLine("利用while寫一程式，讀入N個數字，然後找出所有小於13的數，再求這些數字的和。");

            //int N;
            //int sum = 0;
            //int i = 1;
            //string OUT = "";

            //Console.WriteLine("請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //while (i <= N)
            //{
            //    Console.Write($"請輸入第{i}個數字=");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    if (x < 13)
            //    {
            //        sum += x;
            //        OUT += x + " ";
            //        Console.WriteLine($"目前總和={sum}");
            //    }
            //    i++;
            //}

            //Console.WriteLine($"輸入的數字<13者為:{OUT},這些數字的總合={sum}");

            //Console.WriteLine();

            //Console.ReadKey();

            //-----------------------------------------------------
            //習題4-4
            //利用while寫一程式，讀入N個數字，找到第一個大於7而小於10的數字就停止，而且列印出這個數字。(while迴圈)

            //Console.WriteLine("習題4-4");
            //Console.WriteLine("利用while寫一程式，讀入N個數字，找到第一個大於7而小於10的數字就停止，而且列印出這個數字。");

            //int N;
            //string OUT="";

            //Console.WriteLine("請輸入N=");
            //N = Convert.ToInt32(Console.ReadLine());

            //while (N > 0)
            //{
            //    Console.Write($"請輸入數字=");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    if (x > 7 && x < 10)
            //    {
            //        OUT = "輸入的數字裡找到第一個大於7而小於10的數字="+Convert.ToString(x);
            //        break;
            //    }
            //    else
            //    {
            //        OUT = "輸入的數字裡沒有滿足「大於7而小於10的數字」";
            //    }
            //    N--;
            //}

            //Console.WriteLine($"{OUT}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //習題4-5
            //利用while寫一程式，讀入a1,a2,…,a5和b1,b2,…,b5。找到第一個ai>bi，即停止，並列印出ai及bi。(while迴圈)

            //Console.WriteLine("習題4-5");
            //Console.WriteLine("利用while寫一程式，讀入a1,a2,…,a5和b1,b2,…,b5。找到第一個ai>bi，即停止，並列印出ai及bi。");

            //int[] a = new int[5];
            //int[] b = new int[5];
            //int i = 0, j = 0;

            //while (i < 5)
            //{
            //    Console.Write($"請輸入a{i+1}=");
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //    i++;
            //}

            //Console.WriteLine("---------");

            //while (j < 5)
            //{
            //    Console.Write($"請輸入b{j+1}=");
            //    b[j] = Convert.ToInt32(Console.ReadLine());
            //    j++;
            //}

            //Console.WriteLine("---------");

            //i = 0;//重設為0
            //j = 0;//重設為0

            //while (i <= 5)
            //{

            //    if (a[i] > b[j])
            //    {
            //        Console.Write("找到第一個ai>bi為:");
            //        Console.WriteLine($"a{i + 1}={a[i]} > b{j+1}={b[j]}");
            //        break;
            //    }
            //    i++;
            //    j++;
            //}

            //Console.ReadKey();

            //-----------------------------------------------------
            //補充習題1
            //Eric覺得麥蒂勞的39元漢堡實在太便宜、太好吃了，因此他決定晚餐要把口袋裡所有錢通通拿來吃39元漢堡。假設他每5分鐘就能吃一個漢堡，請隨意輸入一個時間，輸出這段時間吃漢堡的紀錄。(while迴圈)

            //Console.WriteLine("補充習題1");
            //Console.WriteLine("Eric覺得麥蒂勞的39元漢堡實在太便宜、太好吃了，因此他決定晚餐要把口袋裡所有錢通通拿來吃39元漢堡。假設他每5分鐘就能吃一個漢堡，請隨意輸入一個時間，輸出這段時間吃漢堡的紀錄。");

            //int time, count = 0;
            //int timeAccumulated = 0;
            //int money;

            //Console.Write("請輸入Eric吃漢堡的時間(分鐘)=");
            //time = Convert.ToInt32(Console.ReadLine());

            //while (time >= 5)
            //{
            //    time -= 5;
            //    //timeAccumulated += 5;
            //    timeAccumulated += 5;
            //    count++;
            //}

            //Console.WriteLine($"Eric吃了{count}個漢堡，共花了{timeAccumulated}分鐘，還剩下{time}分鐘");

            //Console.ReadKey();

            //-----------------------------------------------------
            //補充習題2
            //小明貸款買房花560萬，每個月可還4萬，每還12個月，因為年終獎金可以多還一萬，請問需要幾個月還清。(while迴圈)

            //Console.WriteLine("補充習題2");
            //Console.WriteLine("小明貸款買房花560萬，每個月可還4萬，每還12個月，因為年終獎金可以多還一萬，請問需要幾個月還清。");

            //int count=0;
            //int loan = 560;//萬元

            //while (loan > 0)
            //{
            //    loan -= 4;
            //    count++;
            //    if (count % 12 == 0)
            //    {
            //        loan--;
            //    }
            //}

            //Console.WriteLine($"共需{count}個月");

            //Console.ReadKey();

            //-----------------------------------------------------
            //補充習題3
            //系統隨機產生一個數字，讓使用者數入數字，直到猜中才離開程式！，猜錯時，要提示是比較大還是比較小。(while迴圈)

            //Console.WriteLine("補充習題3");
            //Console.WriteLine("系統隨機產生一個數字，讓使用者數入數字，直到猜中才離開程式！，猜錯時，要提示是比較大還是比較小。");
            //Console.WriteLine("輸入上下限版本");

            //int Max, Min;

            //Console.WriteLine("請輸入隨機數字上限=");
            //Max = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入隨機數字下限=");
            //Min = Convert.ToInt32(Console.ReadLine());

            //int guess=Min-1;

            //Random myObject = new Random();
            //int ans = myObject.Next(Min,Max);
            //Console.WriteLine($"答案為{ ans}");

            //while (guess != ans)
            //{
            //    Console.Write($"請在範圍{Min}<___<{Max}猜一個數字=");
            //    guess = Convert.ToInt32(Console.ReadLine());

            //    if (guess > ans)
            //    {
            //        Console.WriteLine("猜錯了，猜太大了");
            //    }
            //    else if(guess < ans)
            //    {
            //        Console.WriteLine("猜錯了，猜太小了");
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine("恭喜答對");

            //Console.ReadKey();

            //---------------------------------------

            //Console.WriteLine("補充習題3");
            //Console.WriteLine("系統隨機產生一個數字，讓使用者數入數字，直到猜中才離開程式！，猜錯時，要提示是比較大還是比較小。");
            //Console.WriteLine("不設上下限版本");

            //Random myObject = new Random();
            //int ans = myObject.Next();

            //int guess = ans - 1;

            //Console.WriteLine($"答案為{ans}");

            //while (guess != ans)
            //{
            //    Console.Write($"請猜一個數字=");
            //    guess = Convert.ToInt32(Console.ReadLine());

            //    if (guess > ans)
            //    {
            //        Console.WriteLine("猜錯了，猜太大了 \n");
            //    }
            //    else if (guess < ans)
            //    {
            //        Console.WriteLine("猜錯了，猜太小了\n");
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine("恭喜答對");

            //Console.ReadKey();

            //-----------------------------------------------------


            //Bonus1：P.34附圖的依據輸入客製化的聖誕樹



            //-----------------------------------------------------
            //Bonus2：用遞迴(Recursion)方式寫出費波那契數列：輸入整數N，輸出fibonacci(N)[費氏數列的第N個數]
            //因超過範圍，刪除bonus2.。
            //(要用函數function(又稱方法method)來做)






        }
    }
}

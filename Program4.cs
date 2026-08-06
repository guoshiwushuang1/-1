using System.Diagnostics.CodeAnalysis;

namespace homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //计算100以内偶数的和
            //int sum = 0;
            //for (int j = 0; j <= 100; j+=2)
            //{
            //    sum = sum + j;
            //}
            //Console.WriteLine(sum);



            //显示出1000 - 2000年中所有的闰年，并以每行四个数的形式输出
            //int count = 0;
            //for (int year = 1000; year <= 2000; year++)
            //{
            //    if(year % 4 == 0 || year % 400 == 0)
            //    {
            //        Console.Write(year + " ");
            //        count++;
            //    } 
            //    if(count == 4)
            //    {
            //        Console.WriteLine();
            //        count = 0;
            //    }
            //}




            //输出一个倒三角形，如下
            //for (int j = 9; j >= 1; j--)
            //{
            //    for (int i = j; i >= 1; i--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            //用循环计算下面的结果
            //1 - 1 / 2 + 1 / 3 - 1 / 4 + ... -1 / 100
            //double k = 2;
            //double l = 0;
            //double m = 0;
            //double n = 3;
            //while (n <= 99)
            //{
            //    m = m + 1.0 / n;
            //    n += 2;
            //}
            //while (k <= 100)
            //{
            //    l = l + 1.0 / k;
            //    k += 2;
            //}
            //Console.WriteLine(1-l+m);



            //求10以内所有数字的阶乘的和
            //1*1+2*1+3*2*1+4*3*2*1+5*4*3*2*1...
            //int sum = 0;
            //for(int i = 1; i <= 10; i++)
            //{
            //    int n = 1;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        n *= j;
            //    }
            //    sum += n;
            //}
            //Console.WriteLine(sum);




            //篮球从5米高的地方掉下来，每次弹起的高度是原来的30 %，经过几次弹起，篮球的高度小于0.1米。
            //double n = 5;
            //int count = 0;
            //while (n >= 0.1)
            //{
            //    n *= 0.3;
            //    count++;
            //}
            //Console.WriteLine(count);



            //有一个棋盘，有64个方格，在第一个方格里面放1粒芝麻重量是0.00001kg，第二个里面放2粒，第三个里面放4，棋盘上放的所有芝麻的重量
            //decimal n = 0;
            //decimal sum = 1;
            //for(int i = 1; i <= 64; i++)
            //{
            //    n += sum;
            //    sum *= 2;
            //}
            //decimal m = n * 0.00001m;
            //Console.WriteLine(m);




            //某人在银行有50000元存款。银行每月都要收取服务费，存款大于5000元时每个月收取总额的5 %，总额不大于5000元的时候不收服务费；假设这个人存了以后从来都不用，用循环计算银行要扣这个人的手续费能扣多少次？每次扣取后剩余多少钱？
            //double money = 50000;
            //int count = 0;
            //while(money > 5000)
            //{
            //    money = money * 0.95;
            //    count++;
            //    Console.WriteLine($"第{count}次扣费后剩余：{money:F2}元");
            //}
            //Console.WriteLine($"共扣{count}次，最终剩余{money:F2}元");



            //猴子摘桃，猴子摘了x个桃，每天吃一半，再多吃一个，第7天吃的时候剩下一个了，猴子摘了多少桃子？
            //int n = 1;
            //for(int day = 6; day >= 1; day--)
            //{
            //    n = (n + 1) * 2;
            //    Console.WriteLine($"第{day}天有{n}个桃子");
            //}
            //Console.WriteLine($"猴子共摘了{n}个桃子");



            //有个皮球，每次落地弹起都是高度的一半，如果从10米高的地方丢下，第十次弹起时，皮球总过经历了多少距离。
            double n = 10;
            double sum = 0;
            for(int i = 1; i <= 10; i++)
            {
                n = n * 0.5 ;
                sum += n;
            }
            sum = sum * 2 + 10;
            Console.WriteLine(sum);
























        }
    }
}

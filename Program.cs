namespace homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //1.计算任意两个输入数字的和
            Console.WriteLine("请输入数字：");
            double s1 = double.Parse(Console.ReadLine());
            double s2 = double.Parse(Console.ReadLine());
            double s3 = s1 + s2;
            Console.WriteLine($"输入的数字是:{s1},{s2} 两个数字的和:{s3}");

            /*2.小明要到美国旅游，可是那里的温度是以华氏度为单位记录的。他需要一个程序将华氏温度（80度）转换为摄氏度，
            并以华氏度和摄氏度为单位分别显示该温度（提示：摄氏度与芈氏度的转换公式为：摄氏度 = 5/9.0*(华氏度-32)保留3位小数*/
            Console.WriteLine("请输入摄氏度：");
            double a = double.Parse(Console.ReadLine());
            double b = 5 / 9.0 * (a - 32);
            Console.WriteLine($"华氏度：{a}°F");
            Console.WriteLine($"摄氏度：{b.ToString("F3")}°C");

            //3.通过数学运算交换两个整型变量的值
            Console.WriteLine("请输入数字num1：");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入数字num2：");
            int num2 = int.Parse(Console.ReadLine());
            int temp = num1 + num2;
            num1 = temp - num1;
            num2 = temp - num2;
            Console.WriteLine($"运算后：num1 = {num1}, num2 = {num2}");

            //4.为抵抗洪水，战士连续作战89小时，编程计算共多少天零多少小时？
            Console.WriteLine("请输入作战时间：");
            int x = int.Parse(Console.ReadLine());
            int y = x / 24;
            int z = x % 24;
            Console.WriteLine($"共{y}天零{z}小时");








        }
    }
}

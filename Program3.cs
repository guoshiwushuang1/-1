namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //账号密码验证（练习分支嵌套）：账号规定是"admin"，密码规定是"123456"。让用户输入账号和密码，判断账号和密码是否正确，
            //账号和密码都正确就输出登入成功；账号不对，就输出账号不存在；密码不对，就输出密码错误。
            //Console.WriteLine("请输入账号：");
            //string n1 = Console.ReadLine();
            //Console.WriteLine("请输入密码：");
            //string n2 = Console.ReadLine();
            //if (n1 == "admin" && n2 == "123456")
            //{
            //    Console.WriteLine("登入成功");
            //}
            //else if (n2 == "123456")
            //{
            //    Console.WriteLine("账号不存在");
            //}
            //else if (n1 == "admin")
            //{
            //    Console.WriteLine("密码错误");
            //}
            //else
            //{
            //    Console.WriteLine("输入有误");
            //}


            //选择菜单（add / edit / del）执行操作（练习多分支和switch）：提示用户选择菜单（add / edit / del），判断输入的是add，
            //就输出新增成功；输入的是edit，就输出编辑成功；输入的是del，就输出删除成功。
            //Console.WriteLine("请选择菜单(add / edit / del)：");
            //string s = Console.ReadLine();
            //if(s == "add" || s == "edit" || s == "del")
            //{
            //    string res = s switch
            //    {
            //        "add" => "新增成功",
            //        "edit" => "编辑成功",
            //        "del" => "删除成功",
            //    };
            //    Console.WriteLine(res);
            //}
            //else
            //{
            //    Console.WriteLine("输入有误");
            //}


            //会员打折满1000打9折，普通用户满2000打9.5折（练习多分支和分支嵌套）：让用户输入自己的类型（VIP / USER）和消费金额，如果是VIP，
            //判断消费金额是否达到1000，如果达到了，就输出他应该支付的金额，如果没有达到，也输出他应该支付的金额；如果是USER，
            //判断消费金额是否达到2000，如果达到了和没有达到，都输出他应该支付的金额。
            //Console.WriteLine("请输入会员类型(VIP/USER)：");
            //string n = Console.ReadLine();
            //Console.WriteLine("请输入金额：");
            //double m = double.Parse(Console.ReadLine());
            //if(n == "VIP")
            //{
            //    if(m < 1000)
            //    {
            //        Console.WriteLine($"应支付{m}元");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"应支付{m * 0.9}元");
            //    }
            //}
            //else if(n == "USER")
            //{
            //    if(m < 2000)
            //    {
            //        Console.WriteLine($"应支付{m}元");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"应支付{m * 0.95}元");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("输入有误");
            //}



            //通过月份判断季节（练习switch的穿透写法）：用户输入月份，判断月份如果是3、4、5月份，就输出这是春季；如果是6、7、8月份，
            //就输出这是夏季；如果是9、10、11月份，就输出这是秋季，如果是12、1、2月份，就输出这是冬季。
            //Console.WriteLine("请输入月份：");
            //int s1 = int.Parse(Console.ReadLine());
            //switch (s1)
            //{
            //    case 3: 
            //    case 4: 
            //    case 5: Console.WriteLine("春季"); break;
            //    case 6: 
            //    case 7: 
            //    case 8: Console.WriteLine("夏季"); break;
            //    case 9: 
            //    case 10: 
            //    case 11: Console.WriteLine("秋季"); break;
            //    case 12:
            //    case 1:
            //    case 2: Console.WriteLine("冬季"); break;
            //    default: Console.WriteLine("输入有误");break;
            //}



            //快递运费（练习多分支）：输入快递重量，单位是Kg，如果重量小于1Kg，输出快递费10元；如果重量在1Kg~5Kg之间，就输出快递费20元；
            //如果重量超过5Kg，就输出快递费50元。
            //Console.WriteLine("请输入快递重量(Kg)：");
            //int s2 = int.Parse(Console.ReadLine());
            //if(s2 < 1)
            //{
            //    Console.WriteLine("输出快递费10元");
            //}
            //else if(s2 >= 1 && s2 <= 5)
            //{
            //    Console.WriteLine("输出快递费20元");
            //}
            //else
            //{
            //    Console.WriteLine("输出快递费50元");
            //}



            //会员等级优惠（练习多分支和switch）：输入会员等级，等级是3~5的整数，判断等级如果是5，输出终身免运费；等级是4，
            //输出每月可领优惠券；等级是3，输出购物打9折，否则没有福利。
            //Console.WriteLine("请输入会员等级：");
            //int s3 = int.Parse(Console.ReadLine());
            //if (s3 > 0)
            //{
            //    string res = s3 switch
            //    {
            //        5 => "终身免运费",
            //        4 => "每月可领优惠券",
            //        3 => "购物打9折",
            //        _ => "没有福利"
            //    };
            //    Console.WriteLine(res);
            //}



            //自动售货机选商品（练习多分支和switch）：输入商品编号整数，1就输出已购买可乐；2输出已购买雪碧；3输出已购买矿泉水；否则输出无此商品。
            //Console.WriteLine("请输入商品编号：");
            //int s4 = int.Parse(Console.ReadLine());
            //switch (s4)
            //{
            //    case 1: Console.WriteLine("已购买可乐");break;
            //    case 2: Console.WriteLine("已购买雪碧"); break;
            //    case 3: Console.WriteLine("已购买矿泉水"); break;
            //    default: Console.WriteLine("无此商品");break;
            //}


            //速度分级（练习多分支）：输入当前速度，如果在0~30，输出低速通过；30~60输出中速通过；60~100输出高速通过；100~120输出超速通过。
            //Console.WriteLine("当前速度：");
            //int s5 = int.Parse(Console.ReadLine());
            //if(s5 >= 0 && s5 < 30)
            //{
            //    Console.WriteLine("低速通过");
            //}
            //else if(s5 >= 30 && s5 < 60)
            //{
            //    Console.WriteLine("中速通过");
            //}
            //else if(s5 >= 60 && s5 < 100)
            //{
            //    Console.WriteLine("高速通过");
            //}
            //else if(s5 >= 100 && s5 <= 120)
            //{
            //    Console.WriteLine("超速通过");
            //}
            //else
            //{
            //    Console.WriteLine("输入有误");
            //}
        }
    }
}

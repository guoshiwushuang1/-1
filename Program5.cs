namespace homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 提示输入的 是price还是stock  排序类型 
            // 提示输入的是 ASC 还是DSC     排序顺序(ASC升序,DSC降序)
            // 根据输入完成数据排序
            //List<Dictionary<string, dynamic>> n = new()
            //{
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "机械键盘" },
            //        {"price", 299.99 },
            //        {"code", "G001" },
            //        {"stock", 120 }
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "无线鼠标" },
            //        {"price", 89.50 },
            //        {"code", "G002" },
            //        {"stock", 356 }
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "27寸显示器" },
            //        {"price", 1299.00 },
            //        {"code", "G003" },
            //        {"stock", 48 }
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "电竞耳机" },
            //        {"price", 199.00 },
            //        {"code", "G004" },
            //        {"stock", 85 }
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "电脑支架" },
            //        {"price", 69.90 },
            //        {"code", "G005" },
            //        {"stock", 210 }
            //    }
            //};
            //Console.WriteLine("请输入排序类型(price/stock)：");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("请输入排序顺序(ASC/DSC)：");
            //string s2 = Console.ReadLine();
            //for (int j = 0; j < n.Count - 1; j++)
            //{
            //    for (int i = 0; i < n.Count - 1 - j; i++)
            //    {
            //        if (s1 == "price")
            //        {
            //            if (s2 == "ASC")
            //            {
            //                if (n[i]["price"] > n[i + 1]["price"])
            //                {
            //                    dynamic m = n[i];
            //                    n[i] = n[i + 1];
            //                    n[i + 1] = m;
            //                }
            //            }
            //            else if (s2 == "DSC")
            //            {
            //                if (n[i]["price"] < n[i + 1]["price"])
            //                {
            //                    dynamic m = n[i];
            //                    n[i] = n[i + 1];
            //                    n[i + 1] = m;
            //                }
            //            }
            //        }
            //        else if (s1 == "stock")
            //        {
            //            if (s2 == "ASC")
            //            {
            //                if (n[i]["stock"] > n[i + 1]["stock"])
            //                {
            //                    dynamic m = n[i];
            //                    n[i] = n[i + 1];
            //                    n[i + 1] = m;
            //                }
            //            }
            //            else if (s2 == "DSC")
            //            {
            //                if (n[i]["stock"] < n[i + 1]["stock"])
            //                {
            //                    dynamic m = n[i];
            //                    n[i] = n[i + 1];
            //                    n[i + 1] = m;
            //                }
            //            }
            //        }

            //    }
            //}
            //foreach (dynamic a in n) Console.WriteLine($"{a["name"]}--价格：{a["price"]}--库存：{a["stock"]}");




            // 数据使用案例中的数据
            // 通过歌曲查找歌手
            List<Dictionary<string, dynamic>> singer = new()
            {
                new Dictionary<string, dynamic>
                    {
                        {"singerId", 1001},
                        {"singerName", "周杰伦"},
                        {"genre", "流行"}
                    },
                    new Dictionary<string, dynamic>
                    {
                        {"singerId", 1002},
                        {"singerName", "林俊杰"},
                        {"genre", "华语流行"}
                    },
                    new Dictionary<string, dynamic>
                    {
                        {"singerId", 1003},
                        {"singerName", "邓紫棋"},
                        {"genre", "流行、摇滚"}
                    },
                    new Dictionary<string, dynamic>
                    {
                        {"singerId", 1004},
                        {"singerName", "薛之谦"},
                        {"genre", "抒情流行"}
                    },
                    new Dictionary<string, dynamic>
                    {
                        {"singerId", 1005},
                        {"singerName", "毛不易"},
                        {"genre", "民谣流行"}
                    }
            };
            List<Dictionary<string, dynamic>> songList = new()
            {
                    new Dictionary<string, dynamic>
                    {
                        {"songId", 10001},
                        {"singerId", 1001},
                        {"songName", "青花瓷"},
                        {"duration", 239}
                    },
                    new Dictionary<string, dynamic>
                    {
                        {"songId", 10002},
                        {"singerId", 1001},
                        {"songName", "发如雪"},
                        {"duration", 253}
                    },
                    new Dictionary<string, dynamic>
                    {
                        {"songId", 10003},
                        {"singerId", 1001},
                        {"songName", "东风破"},
                        {"duration", 215}
                    },
                    new Dictionary<string, dynamic>
                    {
                        {"songId", 1004},
                        {"singerId", 3002},
                        {"songName", "不为谁而作的歌"},
                        {"duration", 296}
                    },
                    new Dictionary<string, dynamic>
                    {
                        {"songId", 1005},
                        {"singerId", 1002},
                        {"songName", "背对背拥抱"},
                        {"duration", 262}
                    }
            };
            Console.WriteLine("请输入歌曲名字：");
            string song = Console.ReadLine();
            int singerId = 0;
            foreach(Dictionary<string, dynamic> item in songList)
            {
                if (item["songName"] == song) singerId = item["singerId"];
            }

            var singers = new List<Dictionary<string, dynamic>>();
            foreach (Dictionary<string, dynamic> item in singer)
            {
                if (item["singerId"] == singerId) singers.Add(item);
            }

            foreach(dynamic item in singers)
            {
                Console.WriteLine(item["singerName"]);
            }



























        }
    }
}

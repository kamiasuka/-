using System;

namespace 飞行棋
{
    internal class Program
    {
        //静态字段模拟全局变量
        private static int[] Map = new int[100];

        //声明一个静态数组来存储玩家a和b的坐标
        private static int[] PlayPos = new int[2];

        //PlayerName();
        private static string[] Name = new string[2];

        private static bool[] flag = new bool[2];//bool数组默认都是false

        private static void Main(string[] args)
        {
            GameShow();

            Console.WriteLine("请输入玩家1姓名：");
            Name[0] = Console.ReadLine();
            while (Name[0] == " ")
            {
                Console.WriteLine("玩家1姓名不能为空，请重新输入：");
                Name[0] = Console.ReadLine();
            }

            Console.WriteLine("请输入玩家2姓名：");
            Name[1] = Console.ReadLine();
            while (Name[0] == " " || Name[0] == Name[1])
            {
                if (Name[0] == " ")
                {
                    Console.WriteLine("玩家2姓名不能为空，请重新输入：");
                    Name[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家姓名不能相同，请重新输入：");
                    Name[1] = Console.ReadLine();
                }
            }

            //输入完姓名后清屏
            Console.Clear();

            GameShow();
            Console.WriteLine("玩家{0}用A表示", Name[0]);
            Console.WriteLine("玩家{0}用B表示", Name[1]);
            Console.WriteLine();

            InitailMap();
            DrawMap();

            while (PlayPos[0] <= 99 && PlayPos[1] <= 99)
            {
                if (flag[0] == false)
                {
                    PlayGame(0);
                }
                else
                {
                    flag[0] = true;
                }
                if (PlayPos[0] >= 99)
                {
                    Console.WriteLine("玩家{0}赢了", Name[0]);
                }

                if (flag[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    flag[1] = true;
                }
                if (PlayPos[1] >= 99)
                {
                    Console.WriteLine();
                    Console.WriteLine("玩家{0}赢了", Name[1]);
                    break;
                }
            }//wjile

            Win();
            Console.ReadKey();
        }

        public static void Win()
        {
            Console.WriteLine();
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }

        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*****飞行棋游戏 v1.0*******");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("图例......");
        }

        public static void InitailMap()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
            int[] pause = { 9, 27, 60, 93 };
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };

            for (int i = 0; i < luckyturn.Length; i++)
            {
                Map[luckyturn[i]] = 1;
            }

            for (int i = 0; i < landMine.Length; i++)
            {
                Map[landMine[i]] = 2;
            }

            for (int i = 0; i < pause.Length; i++)
            {
                Map[pause[i]] = 3;
            }

            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Map[timeTunnel[i]] = 4;
            }
        }

        public static void DrawMap()
        {
            Console.WriteLine("图例：幸运轮盘⊙  地雷：★   暂停：▲     隧道：卐");
            Console.WriteLine();

            //第一横行
            for (int i = 0; i <= 29; i++)
            {
                //玩家坐标相同显示<>
                Console.Write(DrawRowMap(i));
            }
            Console.WriteLine();

            //第一竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j <= 28; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(DrawRowMap(i));
                Console.WriteLine();
            }

            //第二横行
            for (int i = 64; i >= 35; i--)
            {
                Console.Write(DrawRowMap(i));
            }
            Console.WriteLine();

            //第二竖行
            for (int i = 65; i <= 69; i++)
            {
                Console.Write(DrawRowMap(i));
                Console.WriteLine();
            }

            //最后一行
            for (int i = 70; i <= 99; i++)
            {
                Console.Write(DrawRowMap(i));
            }
            Console.WriteLine();
        }

        public static string DrawRowMap(int i)
        {
            string str = " ";
            if (PlayPos[0] == PlayPos[1] && PlayPos[0] == i)
            {
                str = "<>";
            }
            else if (PlayPos[0] == i)
            {
                str = "Ａ";
            }
            else if (PlayPos[1] == i)
            {
                str = "Ｂ";
            }
            else
            {
                switch (Map[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.White;
                        str = "□";
                        break;

                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "⊙";
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str = "★";
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        str = "▲";
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "卐";
                        break;
                }
            }

            return str;
        }

        public static void PlayGame(int playNumber)
        {
            Random r = new Random();
            int rNumber = r.Next(1, 7);
            Console.WriteLine("{0}按任意键开始掷骰子", Name[playNumber]);
            Console.ReadKey(true);

            Console.WriteLine("{0}掷出了{1}", Name[playNumber], rNumber);
            PlayPos[playNumber] += rNumber;
            ChangePos();
            Console.ReadKey(true);

            Console.WriteLine("{0}按任意键开始行动", Name[playNumber]);
            Console.ReadKey(true);

            Console.WriteLine("{0}行动完了", Name[playNumber]);
            Console.ReadKey(true);

            //玩家可能踩到6钟情况
            if (PlayPos[playNumber] == PlayPos[1 - playNumber])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1}，玩家{2}退6格", Name[playNumber], Name[1 - playNumber], Name[playNumber]);
                PlayPos[1 - playNumber] -= 6;
                Console.ReadKey(true);
            }
            else
            {
                switch (Map[PlayPos[playNumber]])
                {
                    case 0:
                        Console.WriteLine("玩家{0}踩到方块，安全", Name[playNumber]);
                        Console.ReadKey(true);
                        break;

                    case 1:
                        Console.WriteLine("玩家{0}踩到幸运轮盘，按1---交换位置，按2---轰炸对方", Name[playNumber]);
                        int input = Convert.ToInt32(Console.ReadLine());
                        while (true)
                        {
                            if (input == 1)
                            {
                                Console.WriteLine("玩家{0}选择和玩家{1}交换位置", Name[playNumber], Name[1 - playNumber]);
                                Console.ReadKey(true);
                                int temp = PlayPos[playNumber];
                                PlayPos[playNumber] = PlayPos[1 - playNumber];
                                PlayPos[1 - playNumber] = temp;
                                Console.WriteLine("交换完成！！按任意键继续游戏");
                                Console.ReadKey(true);
                                break;
                            }
                            else if (input == 2)
                            {
                                Console.WriteLine("玩家{0}选择轰炸玩家{1}，玩家{2}退6格", Name[playNumber], Name[1 - playNumber], Name[1 - playNumber]);
                                Console.ReadKey(true);
                                PlayPos[1 - playNumber] -= 6;
                                Console.WriteLine("玩家{0}退了6格", Name[1 - playNumber]);
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("只能输入1或2   按1---交换位置，按2---轰炸对方");
                                input = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("玩家踩到了地雷,退6格", Name[playNumber]);
                        Console.ReadKey(true);
                        PlayPos[playNumber] -= 6;
                        break;

                    case 3:
                        Console.WriteLine("玩家踩到了暂停,暂停一回合", Name[playNumber]);
                        flag[playNumber] = true;
                        Console.ReadKey(true);

                        break;

                    case 4:
                        Console.WriteLine("玩家踩到了时空隧道,前进10格", Name[playNumber]);
                        PlayPos[playNumber] += 10;
                        Console.ReadKey(true);
                        break;
                }//switch
            }//else

            ChangePos();
            Console.Clear();
            DrawMap();
        }

        public static void ChangePos()
        {
            if (PlayPos[0] < 0)
            {
                PlayPos[0] = 0;
            }
            if (PlayPos[0] >= 99)
            {
                PlayPos[0] = 99;
            }

            if (PlayPos[1] < 0)
            {
                PlayPos[1] = 0;
            }
            if (PlayPos[1] >= 99)
            {
                PlayPos[1] = 99;
            }
        }
    }
}
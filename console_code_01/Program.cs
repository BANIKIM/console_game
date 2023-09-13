using System;
using System.Collections.Generic;
using System.Linq;
using System.Media; // 효과음을 위해서 wav 파일 사용을 위한 헤더
using System.Text;
using System.Threading.Tasks;
using System.Threading;// 슬립을 사용하기 위한 헤더

namespace console_code_01
{
    class Program
    {
        //타이틀 도트
        public void Title()
        {
            Console.WriteLine("                                                                                                 ");
            Console.WriteLine("                                 /$$                 /$$       /$$ /$$ /$$   /$$                 ");
            Console.WriteLine("                                | $$                | $$      |__/| $$|__/  | $$                 ");
            Console.WriteLine("    /$$$$$$   /$$$$$$   /$$$$$$ | $$$$$$$   /$$$$$$ | $$$$$$$  /$$| $$ /$$ /$$$$$$   /$$   /$$   ");
            Console.WriteLine("   /$$__  $$ /$$__  $$ /$$__  $$| $$__  $$ |____  $$| $$__  $$| $$| $$| $$|_  $$_/  | $$  | $$   ");
            Console.WriteLine("  | $$    $$| $$   __/| $$    $$| $$    $$  /$$$$$$$| $$    $$| $$| $$| $$  | $$    | $$  | $$   ");
            Console.WriteLine("  | $$  | $$| $$      | $$  | $$| $$  | $$ /$$__  $$| $$  | $$| $$| $$| $$  | $$ /$$| $$  | $$   ");
            Console.WriteLine("  | $$$$$$$/| $$      |  $$$$$$/| $$$$$$$/|  $$$$$$$| $$$$$$$/| $$| $$| $$  |  $$$$/|  $$$$$$$   ");
            Console.WriteLine("  | $$____/ |__/        ______/ |_______/   _______/|_______/ |__/|__/|__/    ___/    ____  $$   ");
            Console.WriteLine("  | $$                            /$$$$$$                                            /$$  | $$   ");
            Console.WriteLine("  | $$                           /$$__  $$                                          |  $$$$$$/   ");
            Console.WriteLine("  |__/                          | $$   __/  /$$$$$$  /$$$$$$/$$$$   /$$$$$$           ______/    ");
            Console.WriteLine("                                | $$ /$$$$ |____  $$| $$_  $$_  $$ /$$__  $$                     ");
            Console.WriteLine("                                | $$|_  $$  /$$$$$$$| $$   $$   $$| $$$$$$$$                     ");
            Console.WriteLine("                                | $$    $$ /$$__  $$| $$ | $$ | $$| $$_____/                     ");
            Console.WriteLine("                     /$$   /$$  |  $$$$$$/|  $$$$$$$| $$ | $$ | $$|  $$$$$$$                     ");
            Console.WriteLine("                    | $$  | $$    ______/   _______/|__/ |__/ |__/  _______/                     ");
            Console.WriteLine("                    | $$  | $$  /$$$$$$   /$$$$$$  /$$    /$$ /$$$$$$  /$$$$$$$                  ");
            Console.WriteLine("                    | $$$$$$$$ /$$__  $$ |____  $$|  $$  /$$//$$__  $$| $$__  $$                 ");
            Console.WriteLine("                    | $$__  $$| $$$$$$$$  /$$$$$$$    $$/$$/| $$$$$$$$| $$    $$                 ");
            Console.WriteLine("                    | $$  | $$| $$_____/ /$$__  $$     $$$/ | $$_____/| $$  | $$                 ");
            Console.WriteLine("                    | $$  | $$|  $$$$$$$|  $$$$$$$      $/  |  $$$$$$$| $$  | $$                 ");
            Console.WriteLine("                    |__/  |__/  _______/  _______/     _/     _______/|__/  |__/                 ");
            Console.WriteLine("                                                                                                 ");
            Console.WriteLine("                                                                                                 ");
            Console.WriteLine("                                                                                                 ");
            Console.WriteLine("                                 아무키나 눌러서 게임을 시작 해주세요.                                     ");
        }
        //게임 오버도트
        public void game_over()
        {
            Console.WriteLine("                                                                             ");
            Console.WriteLine("                              /$$$$$$                                        ");
            Console.WriteLine("                             /$$__  $$                                       ");
            Console.WriteLine("                            | $$   __/  /$$$$$$  /$$$$$$/$$$$   /$$$$$$      ");
            Console.WriteLine("                            | $$ /$$$$ |____  $$| $$_  $$_  $$ /$$__  $$     ");
            Console.WriteLine("                            | $$|_  $$  /$$$$$$$| $$   $$   $$| $$$$$$$$     ");
            Console.WriteLine("                            | $$    $$ /$$__  $$| $$ | $$ | $$| $$_____/     ");
            Console.WriteLine("                            |  $$$$$$/|  $$$$$$$| $$ | $$ | $$|  $$$$$$$     ");
            Console.WriteLine("                              ______/   _______/|__/ |__/ |__/  _______/     ");
            Console.WriteLine("                                                                             ");
            Console.WriteLine("                                                                             ");
            Console.WriteLine("                                                                             ");
            Console.WriteLine("                              /$$$$$$                                        ");
            Console.WriteLine("                             /$$__  $$                                       ");
            Console.WriteLine("                            | $$    $$ /$$    /$$ /$$$$$$   /$$$$$$          ");
            Console.WriteLine("                            | $$  | $$|  $$  /$$//$$__  $$ /$$__  $$         ");
            Console.WriteLine("                            | $$  | $$    $$/$$/| $$$$$$$$| $$   __/         ");
            Console.WriteLine("                            | $$  | $$     $$$/ | $$_____/| $$               ");
            Console.WriteLine("                            |  $$$$$$/      $/  |  $$$$$$$| $$               ");
            Console.WriteLine("                              ______/      _/     _______/|__/               ");
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Game g = new Game();
            Player player = new Player();
            SoundPlayer selet = new SoundPlayer("C:\\Users\\ajtwj\\source\\repos\\console_code_01\\console_code_01\\Music\\mococo.wav");//선택
            player.money = 10000;
            p.Title();
            Console.ReadKey();

            while (player.money > 0)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                            _______________________________________________ ");
                Console.WriteLine("                           |                                               |");
                Console.WriteLine("                           |                                               |");
                Console.WriteLine("                           |                          1 . 강화의 달인      |");
                Console.WriteLine("                           |                                               |");
                Console.WriteLine("                           |                          2 . 경마의 달인      |");
                Console.WriteLine("                           |      게임을 선택                              |");
                Console.WriteLine("                           |                          3 . 홀짝의 달인      |");
                Console.WriteLine("                           |                                               |");
                Console.WriteLine("                           |                          4 . 31숫자게임       |");
                Console.WriteLine("                           |                                               |");
                Console.WriteLine("                           |_______________________________________________|");
                int input = int.Parse(Console.ReadLine());
                selet.PlaySync();
                switch (input)
                {
                    case 1:
                        g.Tempered(player);
                        break;
                    case 2:
                        g.horse_race(player);
                        break;
                    case 3:
                        g.sniffling(player);                        
                        break;
                    case 4:
                        g.number_G();
                        break;
                    default:
                        Console.WriteLine("1, 2, 3, 4번만 가능해요");
                        break;
                }

                if (player.money <= 0)
                {
                    Console.Clear();
                    p.game_over();
                    Console.ReadKey();

                }


            }
            

        }
    }
}

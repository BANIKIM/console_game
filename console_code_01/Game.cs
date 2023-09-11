using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;

namespace console_code_01
{
    class Game
    {

        Random rand = new Random();

        public void AA()
        {
            Console.WriteLine("                      ;@=                       ");
            Console.WriteLine("                      @ @                       ");
            Console.WriteLine("                     $: @                       ");
            Console.WriteLine("                    ;* .!                       ");
            Console.WriteLine("                   .@, *:,                      ");
            Console.WriteLine("                   ,@  @@@@@@#,                 ");
            Console.WriteLine("                   ,;  @.  ,--~@@#==!           ");
            Console.WriteLine("                   =. .@!;:       :;;=@@!;;,    ");
            Console.WriteLine("                   @. ~@,=$#@*,,.       ,=$$@@: ");
            Console.WriteLine("                   @~ ~#     .*@@@@#,         @    ");
            Console.WriteLine("                   ~~#@.         .~~;@@$**:  ,~                                                   ");
            Console.WriteLine("                                        :!!$@@-                                                   ");
            Console.WriteLine("                                                                   강화의 달인                   ");
            Console.WriteLine("               .~~~~~~~~#$====================@                                                 ");
            Console.WriteLine("               @@#######@.                  ..@   ");
            Console.WriteLine("               ~#       $.                 $@=. ");
            Console.WriteLine("                :#~     $.              .*@:    ");
            Console.WriteLine("                 :$*,   $.             ~@!      ");
            Console.WriteLine("                   ~@@- $,            @@        ");
            Console.WriteLine("                     ,;@@#=          $!         ");
            Console.WriteLine("                          !;        :#          ");
            Console.WriteLine("                          -$        $           ");
            Console.WriteLine("                          -$        $           ");
            Console.WriteLine("                         .@,  ;==~  ;$          ");
            Console.WriteLine("                        -$: ~@;;;*@. *=.        ");
            Console.WriteLine("                       -@: ,#,    ,@. =@,       ");
            Console.WriteLine("                      #@@@@@,      -@@@@@$      ");
            Console.WriteLine("                      @,,,-@  -!;,  @,,,;#      ");
            Console.WriteLine("                      @:::;@##!!!!@$@:::*#      ");
            Console.WriteLine("                      :#####        #####~      ");

        }
        public void AB(Player player)
        {
            Console.WriteLine("                      ;@=                       ");
            Console.WriteLine("                      @ @                       ");
            Console.WriteLine("                     $: @                       ");
            Console.WriteLine("                    ;* .!                       ");
            Console.WriteLine("                   .@, *:,                      ");
            Console.WriteLine("                   ,@  @@@@@@#,                 ");
            Console.WriteLine("                   ,;  @.  ,--~@@#==!                  _______________________________________________ ");
            Console.WriteLine("                   =. .@!;:       :;;=@@!;;,          |                                               |");
            Console.WriteLine("                   @. ~@,=$#@*,,.       ,=$$@@:       |                                               |");
            Console.WriteLine("                   @~ ~#     .*@@@@#,         @       |                                               |");
            Console.WriteLine("                   ~~#@.         .~~;@@$**:  ,~       |                   1. 무기                     |");
            Console.WriteLine("                                        :!!$@@-       |                                               |");
            Console.WriteLine("                                                      |                   2. 반지                     |");
            Console.WriteLine("               .~~~~~~~~#$====================@       |                                               |");
            Console.WriteLine("               @@#######@.                  ..@       |                   3. XXXX                     |");
            Console.WriteLine("               ~#       $.                 $@=.       |                                               |");
            Console.WriteLine("                :#~     $.              .*@:          |                   4. 메뉴                     |");
            Console.WriteLine("                 :$*,   $.             ~@!            |                                               |");
            Console.WriteLine("                   ~@@- $,            @@              |                                               |");
            Console.WriteLine("                     ,;@@#=          $!               |                                               |");
            Console.WriteLine("                          !;        :#                |_______________________________________________|");
            Console.WriteLine("                          -$        $           ");
            Console.WriteLine("                          -$        $           ");
            Console.WriteLine("                         .@,  ;==~  ;$          ");
            Console.WriteLine("                        -$: ~@;;;*@. *=.        ");
            Console.WriteLine($"                       -@: ,#,    ,@. =@,                                   {player.money}원   ");
            Console.WriteLine("                      #@@@@@,      -@@@@@$      ");
            Console.WriteLine("                      @,,,-@  -!;,  @,,,;#      ");
            Console.WriteLine("                      @:::;@##!!!!@$@:::*#      ");
            Console.WriteLine("                      :#####        #####~      ");
        }
        //강화의 달인
        public void Tempered(Player player)
        {
            Console.Clear();
            AA();

            Console.ReadKey();
            int equipment = 0; //장비 구매시 
            int count = 1;
            //사운드 팩
            SoundPlayer Musical = new SoundPlayer("C:\\Users\\ajtwj\\source\\repos\\console_code_01\\console_code_01\\Music\\Musical.wav");//선택
            SoundPlayer success = new SoundPlayer("C:\\Users\\ajtwj\\source\\repos\\console_code_01\\console_code_01\\Music\\강화성공.wav");
            SoundPlayer failure = new SoundPlayer("C:\\Users\\ajtwj\\source\\repos\\console_code_01\\console_code_01\\Music\\강화실패.wav");
            SoundPlayer atmosphere = new SoundPlayer("C:\\Users\\ajtwj\\source\\repos\\console_code_01\\console_code_01\\Music\\강화대기소리.wav");

            //구매리스트 있는데 일단 칼만
            Console.Clear();
            while (player.money > 0)
            {
                AB(player);
                if (player.money < 1000)
                {
                    Console.WriteLine("너 칼 하나도 못사..");
                    Thread.Sleep(2000);
                    break;
                }
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        if(player.money>=1000)
                        {
                            Console.WriteLine("무기 구매");
                            player.money -= 1000;
                            equipment = 1000;
                            Console.WriteLine($"남은금액 {player.money}");
                        }
                        else
                        {
                            Console.WriteLine("돈이 없어");
                        }
                        
                        break;
                    case 2:
                        if (player.money >= 2000)
                        {
                            Console.WriteLine("반지 구매");
                            player.money -= 2000;
                            equipment = 2000;
                            Console.WriteLine($"남은금액 {player.money}");
                        }
                        else
                        {
                            Console.WriteLine("돈이 없어");
                        }
                        break;
                    case 3:
                        Console.WriteLine("xxx xx");
                        Console.WriteLine("버프걸어 드렸어요");
                        Musical.PlaySync();
                        break;
                    case 4:
                        Console.WriteLine("게임 선택 메뉴로 돌아 갑니다.");
                        break;
                }
                if (input == 4)//4번 입력받으면 강화의 달인 종료
                {
                    break;
                }

                while (equipment != 0)
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
                    Console.WriteLine("                           |                                               |");
                    Console.WriteLine($"                           |           가진 금액 : {player.money}                    |");
                    Console.WriteLine("                           |                                               |");
                    Console.WriteLine("                           |           1. 강화 2.판매                      |");
                    
                    Console.WriteLine("                           |                                               |");
                    Console.WriteLine($"                           |           {count} 강 확률: {100 / count}                       |");
                    Console.WriteLine("                           |                                               |");
                    Console.WriteLine("                           |                                               |");
                    Console.WriteLine("                           |_______________________________________________|");
                    atmosphere.PlaySync();
                    int a = rand.Next(1, 101);
                    input = int.Parse(Console.ReadLine());

                    if (input == 1)
                    {
                        if (a < 100 / count)
                        {
                            Console.Clear();
                            success.PlaySync();
                            Console.WriteLine($" {count} 강 성공");
                        }
                        else
                        {
                            Console.Clear();
                            failure.PlaySync();
                            Console.WriteLine($" {count} 강 실패");
                            equipment = 0;
                            count = 1;
                            break;

                        }
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($" {count} 강 판매");
                        player.money += equipment * count;
                        count = 1;
                        break;
                    }
                    if (player.money <= 0 && equipment == 0)
                    {

                        break;
                    }

                }

            }//end of while

        }


        //경마의 달인
        public void horse_race(Player player)
        {
            SoundPlayer go = new SoundPlayer("C:\\Users\\ajtwj\\source\\repos\\console_code_01\\console_code_01\\Music\\go.wav");//선택
            int h_1 = 0;
            int h_2 = 0;
            int h_3 = 0;
            int h_4 = 0;
            int h_num = 0;
            int[] buff_num = new int[4];
            float[] buff = new float[6] {-0.02f, -0.01f, 0.01f, 0.01f,0.02f,-0.02f };
            string[] buff_s = new string[6] { "먹이를 많이 먹었습니다.", "잘 먹지 못했습니다.", "잘 먹었습니다.", "잠을 잘 잤습니다.",
            "잠을 많이 잣습니다.","잠을 자지 못했습니다."};
            char char_input = ' ';
            int R = 0;
            
            const int time_delay = 100;
            const string line = "------------------------------------------------------------";
            int line_len = line.Length;
            Game g = new Game();
            while (true)
            {
                for(int i=0; i<buff_num.Length; i++)
                {
                    buff_num[i] = rand.Next(0,6);
                }
                h_1 = rand.Next(1000,20000);
                h_2 = rand.Next(1000, 20000);
                h_3 = rand.Next(1000, 20000);
                h_4 = rand.Next(1000, 20000);
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                                         ※※※※ 말 뉴스 ※※※※             ");
                Console.WriteLine();
                Console.WriteLine($"                                   1번 말은 {buff_s[buff_num[0]]} 지금까지 배팅금액 : {h_1}");
                Console.WriteLine();
                Console.WriteLine($"                                   2번 말은 {buff_s[buff_num[1]]} 지금까지 배팅금액 : {h_2}");
                Console.WriteLine();
                Console.WriteLine($"                                   3번 말은 {buff_s[buff_num[2]]} 지금까지 배팅금액 : {h_3}");
                Console.WriteLine();
                Console.WriteLine($"                                   4번 말은 {buff_s[buff_num[3]]} 지금까지 배팅금액 : {h_4}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                                          종료하려면 아무키나 입력하세요");

                Console.ReadKey();
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                                       최소 배팅 금액은 5000원이야..        ");
                Console.WriteLine($"                                           가진 금액 : {player.money}원 ");
                Console.WriteLine("                               ____________________________________________ ");
                Console.WriteLine("                              |     어떤 말에 돈을 거시겠습니까?           |");
                Console.WriteLine("                              |     1. 1번 마                              |");
                Console.WriteLine("                              |     2. 2번 마                              |");
                Console.WriteLine("                              |     3. 3번 마                              |");
                Console.WriteLine("                              |     4. 4번 마                              |");
                Console.WriteLine("                              |     5. 메뉴로 갈래                         |");
                Console.WriteLine("                              |____________________________________________|");

                if (player.money<5000)
                {
                    Console.WriteLine("                                        미안 넌 돈이 없네");
                    Thread.Sleep(3000);
                    break;
                }
                int input = int.Parse(Console.ReadLine());
                if (input == 1 || input == 2 || input == 3 || input == 4)
                {
                    switch (input)
                    {
                        case 1:
                            while (true)
                            {
                                Console.Write($"얼마를 거시겠습니까? (가진돈 : {player.money})");
                                input = int.Parse(Console.ReadLine());
                                if (player.money > input|| input>5000)
                                {
                                    h_1 += input;
                                    h_num = 1; 
                                    player.money = player.money - input;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"가지돈 보다 많이 걸 수 없고 5000원보다는 많이 걸어야해 {player.money}");
                                }
                            }
                            break;
                        case 2:
                            while (true)
                            {
                                Console.Write($"얼마를 거시겠습니까? (가진돈 : {player.money})");
                                input = int.Parse(Console.ReadLine());
                                if (player.money > input || input > 5000)
                                {
                                    h_2 += input;
                                    h_num = 2;
                                    player.money = player.money - input;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"가지돈 보다 많이 걸 수 없고 5000원보다는 많이 걸어야해 {player.money}");
                                }
                            }
                            break;
                        case 3:
                            while (true)
                            {
                                Console.Write($"얼마를 거시겠습니까? (가진돈 : {player.money})");
                                input = int.Parse(Console.ReadLine());
                                if (player.money > input || input > 5000)
                                {
                                    h_3 += input;
                                    h_num = 3;
                                    player.money = player.money - input;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"가지돈 보다 많이 걸 수 없고 5000원보다는 많이 걸어야해 {player.money}");
                                }
                            }
                            break;
                        case 4:
                            while(true)
                            {
                                Console.Write($"얼마를 거시겠습니까? (가진돈 : {player.money})");
                                input = int.Parse(Console.ReadLine());
                                if (player.money > input || input > 5000)
                                {
                                    h_4 += input;
                                    h_num = 4;
                                    player.money = player.money - input;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"가지돈 보다 많이 걸 수 없고 5000원보다는 많이 걸어야해 {player.money}");
                                }
                            }                                                 
                            break;
                        case 5:
                            Console.WriteLine("메뉴로 돌아갑니다.");
                            break;
              
                    }


                }
                if(input==5)//메뉴로 돌아가기
                {
                    break;
                }

                int spead_a = 0;
                int spead_b = 0;
                int spead_c = 0;
                int spead_d = 0;
               
                while (true)
                {

                    Thread.Sleep(time_delay);
                    Console.Clear();

                    

                    double a = rand.NextDouble() * 2 + (0.5 + buff[buff_num[0]]);
                    double b = rand.NextDouble() * 2 + (0.5 + buff[buff_num[1]]);
                    double c = rand.NextDouble() * 2 + (0.5 + buff[buff_num[2]]);
                    double d = rand.NextDouble() * 2 + (0.1 + buff[buff_num[3]]);

                    spead_a = (int)(spead_a + a);
                    spead_b = (int)(spead_b + b);
                    spead_c = (int)(spead_c + c);
                    spead_d = (int)(spead_d + d);





                    Console.WriteLine($"                 1 번마 ㅁㅁㅁㅁ    {h_1} 원");
                    Console.WriteLine($"                 2 번마 ㅁㅁㅁㅁ    {h_2} 원");
                    Console.WriteLine($"                 3 번마 ㅁㅁㅁㅁ    {h_3} 원");
                    Console.WriteLine($"                 4 번마 ㅁㅁㅁㅁ    {h_4} 원");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("        ||●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●||");
                    Console.WriteLine("        ||●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●||");
                    Console.WriteLine("        ||●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●||");
                    Console.WriteLine("        ||●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●||");
                    Console.WriteLine("        ||●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●||");
                    Console.WriteLine("        ||●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●||");
                    Console.WriteLine(line);

                    for (int i = 0; i < spead_a; i++)
                        Console.Write(" ");
                    Console.WriteLine("ㅁ1ㅁ");

                    for (int i = 0; i < spead_b; i++)
                        Console.Write(" ");
                    Console.WriteLine("ㅁ2ㅁ");

                    for (int i = 0; i < spead_c; i++)
                        Console.Write(" ");
                    Console.WriteLine("ㅁ3ㅁ");

                    for (int i = 0; i < spead_d; i++)
                        Console.Write(" ");
                    Console.WriteLine("ㅁ4ㅁ");


                    Console.WriteLine(line);
                    Console.WriteLine("        ||●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●||");
                    Console.WriteLine("        ||●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●||");
                    Console.WriteLine("        ||●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●||");
                    Console.WriteLine("        ||●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●||");
                    Console.WriteLine("        ||●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●||");
                    Console.WriteLine("        ||●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●||");

                    if(R==0)
                    {
                        R = 1;
                        Thread.Sleep(3000);
                        go.PlaySync();
                    }

                    if (spead_a >= line_len || spead_b >= line_len || spead_c >= line_len || spead_d >= line_len)
                    {


                        var numb = "";

                        if (spead_a >= line_len)
                        {
                            numb = "1번마";
                        }
                        else if (spead_b >= line_len)
                        {
                            numb = "2번마";
                        }
                        else if (spead_c >= line_len)
                        {
                            numb = "3번마";
                        }
                        else if (spead_d >= line_len)
                        {
                            numb = "4번마";
                        }

                        Console.WriteLine("{0}가 당첨 되었습니다.", numb);


                        switch (numb)
                        {
                            case "1번마":
                                if(h_num ==1)
                                {
                                    player.money += h_1 * 3;
                                }
                                
                                Console.WriteLine("축하합니다.");
                                Console.WriteLine($"누군가는 상금 {(h_1 * 3)}원 획득!  남은 금액 {player.money}");
                                break;
                            case "2번마":
                                if (h_num == 2)
                                {
                                    player.money += h_2 * 3;
                                }
                                Console.WriteLine("축하합니다.");
                                Console.WriteLine($"누군가는 상금 {(h_2 * 3)}원 획득!  남은 금액 {player.money}");
                                break;
                            case "3번마":
                                if (h_num == 3)
                                {
                                    player.money += h_3 * 3;
                                }
                                Console.WriteLine("축하합니다.");
                                Console.WriteLine($"누군가는 상금 {(h_3 * 3)}원 획득!  남은 금액 {player.money}");
                                break;
                            case "4번마":
                                if (h_num == 4)
                                {
                                    player.money += h_4 * 3;
                                }
                                Console.WriteLine("축하합니다.");
                                Console.WriteLine($"누군가는 상금 {(h_4 * 3)}원 획득!  남은 금액 {player.money}");
                                break;
                        }
                        //배팅금들 모두 초기화
                        h_1 = 0;
                        h_2 = 0;
                        h_3 = 0;
                        h_4 = 0;
                        
                        Console.WriteLine("다시하려면 'r' 키를 누르시오.");
                        Console.WriteLine($"            남은돈 : {player.money}");
                        char_input = char.Parse(Console.ReadLine());
                        if (char_input == 'r')
                        {
                            char_input = ' ';
                            R = 0;
                            break;
                        }
                        else
                        {
                            input = 5;
                            break;
                        }

                    }
                    if (input == 5)//메뉴로 돌아가기
                    {
                        
                        break;
                    }


                }//end of while
                if (input == 5)//메뉴로 돌아가기
                {
                    input = 0;
                    break;
                }
            }//end of while
        }


        //홀짝의 달인
        public void sniffling(Player player)
        {
            int menyu = 0;
            int sniffling_rand = 0;
            int bat = 0; 
            int combat;
            SoundPlayer ok = new SoundPlayer("C:\\Users\\ajtwj\\source\\repos\\console_code_01\\console_code_01\\Music\\결과.wav");//선택

            while (menyu==0)
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
                Console.WriteLine("                           |                                               |");
                Console.WriteLine("                           |                                               |");
                Console.WriteLine("                           |                                               |");
                Console.WriteLine("                           |                   1. 판돈                     |");
                Console.WriteLine("                           |                                               |");
                Console.WriteLine("                           |                   2. 메뉴                     |");
                Console.WriteLine("                           |                                               |");
                Console.WriteLine("                           |                                               |");
                Console.WriteLine("                           |                                               |");
                Console.WriteLine("                           |                                               |");
                Console.WriteLine("                           |                                               |");
                Console.WriteLine("                           |_______________________________________________|");


                while(sniffling_rand==0)
                {
                    switch (Console.ReadLine())
                    {
                        case "1":

                            while (true)
                            {
                                Console.Write("판돈을 얼마로 하시겠습니까?");
                                sniffling_rand = int.Parse(Console.ReadLine());
                                if (player.money > sniffling_rand)
                                {
                                    if (sniffling_rand < 100)
                                    {
                                        Console.WriteLine("양심적으로 100원 이상은 걸자..");
                                    }
                                    else
                                    {
                                        break;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("그정도로 돈이 없어..");
                                }
                            }
                            break;
                        case "2":
                            menyu = 1;
                            sniffling_rand = 1;
                            break;
                        default:
                            Console.WriteLine("돈을 걸어주시죠.. 1번을 누르고 돈을 걸어주세요");
                            break;

                    }
                }
              

                if (menyu == 1)
                {
                    menyu = 0;
                    break;
                }



                while (menyu==0)
                {
                    if(player.money< sniffling_rand)
                    {
                        Console.WriteLine("돈이 없어 나가줘..");
                        Thread.Sleep(2000);
                        break;
                    }
                    Console.Clear();
                    wnajr_H();
                    Console.WriteLine($"               {player.money}원      메뉴로 나가서 판돈을 다시 설정 하실 수 있습니다.");
                    Console.WriteLine("                            _______________________________________________ ");
                    Console.WriteLine("                           |                                               |");
                    Console.WriteLine("                           |                   1.  홀                      |");
                    Console.WriteLine("                           |                                               |");
                    Console.WriteLine("                           |                   2.  짝                      | ");
                    Console.WriteLine("                           |                                               |");
                    Console.WriteLine("                           |                   3. 메뉴                     | ");
                    Console.WriteLine("                           |_______________________________________________|");
     


                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("홀!");
                            bat = 1;
                            player.money -= sniffling_rand;
                            break;
                        case "2":
                            Console.WriteLine("짝! ");
                            bat = 2;
                            player.money -= sniffling_rand;
                            break;
                        case "3":
                            menyu = 1;
                            break;
                        default:
                            break;
                    }

                    if (menyu == 1)
                    {
                        break;
                    }

                    Console.Clear();
                    wnajr_H();
                    Thread.Sleep(100);
                    Console.Clear();
                    wnajr_H1();
                    Thread.Sleep(100);
                    Console.Clear();
                    wnajr_H();
                    Thread.Sleep(100);
                    Console.Clear();
                    wnajr_H1();
                    Thread.Sleep(100);
                    Console.Clear();
                    wnajr_H();
                    combat = rand.Next(1, 5);
              
                    switch (combat)
                    {
                        case 1:
                            Console.Clear();
                            One_h();
                            break;
                        case 2:
                            Console.Clear();
                            Two_h();
                            break;
                        case 3:
                            Console.Clear();
                            T_h();
                            break;
                        case 4:
                            Console.Clear();
                            F_h();
                            break;
                    }
                    if(bat==1)
                    {
                        if(combat == 1 || combat == 3)
                        {
                            player.money += sniffling_rand*2;
                            Console.WriteLine($"홀에 걸었네 축하해");

                        }
                        else
                        {
                            Console.WriteLine("아쉽게 됬네");
                        }
                    }
                    else if(bat == 2 )
                    {
                        if(combat == 2 || combat == 4)
                        {
                            player.money += sniffling_rand*2;
                            Console.WriteLine($"짝에 걸었네 축하해");

                        }
                        else
                        {
                            Console.WriteLine("아쉽게 됬네");

                        }
                    }
                    else
                    {
                        Console.WriteLine("아쉽게 됬네");
                    }
                    Console.WriteLine("다시하려면 아무키나 눌러");
                    Console.ReadKey();

                }

                if (player.money < sniffling_rand)
                {
                    break;
                }

            }








        }
        //주먹
        public void wnajr_H()
        {

            Console.WriteLine("                                                                             ");
            Console.WriteLine("                           .        .   .   .!!!!!!!!!!!:..         .   .    ");
            Console.WriteLine("                               .   .     .   !.........-:. .   . . .   .    .");
            Console.WriteLine("                                             !         ,~                    ");
            Console.WriteLine("                                             !         ,~                    ");
            Console.WriteLine("                           .  .     .    .  :!         ,~  .   .    .   .    ");
            Console.WriteLine("                               .   .    .  :*          ,*,.   . .  .   . .  .");
            Console.WriteLine("                                         .~!.           -!,.   .        .    ");
            Console.WriteLine("                                         .:,             -*-                 ");
            Console.WriteLine("                                         -:               ,*-  . .           ");
            Console.WriteLine("                           .  .     .    !~                .:       .   .    ");
            Console.WriteLine("                               .   .     ;                  ;~ . . .        .");
            Console.WriteLine("                                        -;             :-   -:.              ");
            Console.WriteLine("                               .   .    !; -.       .~::    ,!,    .   . .  .");
            Console.WriteLine("                           .        .   *~!*!;    -!!*,      :..    .   .    ");
            Console.WriteLine("                               .   .    *-~  *!!**!,        ,!,    .   . .  .");
            Console.WriteLine("                                       -*!,  !; -!          ~:.              ");
            Console.WriteLine("                                       ;;;   *, ;:        -:;,               ");
            Console.WriteLine("                               .       ;!;   !  -!      -;*!-                ");
            Console.WriteLine("                           .  .     .  ;    ;!   !*;-!***, !. . .   .   .    ");
            Console.WriteLine("                               .       ;.   !~   !.;;;*:   !.  . . .         ");
            Console.WriteLine("                                       ::  ,!   .*    *,   !                 ");
            Console.WriteLine("                               .   .   .*::!*   ~*    !    !       .   . .  .");
            Console.WriteLine("                           .        .    :~:;   ;~   :*    !   .    .   .    ");
            Console.WriteLine("                               .   .    .  ,!..~*    !,   -!  .    .        .");
            Console.WriteLine("                                            ~:;:!-.,;*    !~                 ");
            Console.WriteLine("                                              . -;;;:!~~-::                  ");
            Console.WriteLine("                               .   .     .   .   .,...:*!~ .   . . .        .");

        }
        public void wnajr_H1()
        {

            Console.WriteLine("                                                                           ");
            Console.WriteLine("                         .        .   .   .!!!!!!!!!!!:..         .   .    ");
            Console.WriteLine("                             .   .     .   !.........-:. .   . . .   .    .");
            Console.WriteLine("                                           !         ,~                    ");
            Console.WriteLine("                                           !         ,~                    ");
            Console.WriteLine("                         .  .     .    .  :!         ,~  .   .    .   .    ");
            Console.WriteLine("                             .   .    .  :*          ,*,.   . .  .   . .  .");
            Console.WriteLine("                                       .~!.           -!,.   .        .    ");
            Console.WriteLine("                                       .:,             -*-                 ");
            Console.WriteLine("                                       -:               ,*-  . .           ");
            Console.WriteLine("                         .  .     .    !~                .:       .   .    ");
            Console.WriteLine("                             .   .     ;                  ;~ . . .        .");
            Console.WriteLine("                                      -;             :-   -:.              ");
            Console.WriteLine("                             .   .    !; -.       .~::    ,!,    .   . .  .");
            Console.WriteLine("                         .        .   *~!*!;    -!!*,      :..    .   .    ");
            Console.WriteLine("                             .   .    *-~  *!!**!,        ,!,    .   . .  .");
            Console.WriteLine("                                     -*!,  !; -!          ~:.              ");
            Console.WriteLine("                                     ;;;   *, ;:        -:;,               ");
            Console.WriteLine("                             .       ;!;   !  -!      -;*!-                ");
            Console.WriteLine("                         .  .     .  ;    ;!   !*;-!***, !. . .   .   .    ");
            Console.WriteLine("                             .       ;.   !~   !.;;;*:   !.  . . .         ");
            Console.WriteLine("                                     ::  ,!   .*    *,   !                 ");
            Console.WriteLine("                             .   .   .*::!*   ~*    !    !       .   . .  .");
            Console.WriteLine("                         .        .    :~:;   ;~   :*    !   .    .   .    ");
            Console.WriteLine("                             .   .    .  ,!..~*    !,   -!  .    .        .");
            Console.WriteLine("                                          ~:;:!-.,;*    !~                 ");
            Console.WriteLine("                                            . -;;;:!~~-::                  ");
            Console.WriteLine("                             .   .     .   .   .,...:*!~ .   . . .        .");

        }
        //홀하나
        public void One_h()
        {
            Console.WriteLine("                                   .  .   .,!;;;;;;;;;*~  .  . . .  .   .    ");
            Console.WriteLine("                                           --         *~                     ");
            Console.WriteLine("                                           ,-         !,                     ");
            Console.WriteLine("                           .  ..  .      . --         !, .    . .    . . .  .");
            Console.WriteLine("                                      .   -!,         ;:.    . . .           ");
            Console.WriteLine("                                         -*,           ::                    ");
            Console.WriteLine("                              .   .     ,!.             ;;           . . .   ");
            Console.WriteLine("                                   .  ..~-               !;  . . .  .   .    ");
            Console.WriteLine("                                       ,;.                !,                 ");
            Console.WriteLine("                                       ,~  ,!!            ~~                 ");
            Console.WriteLine("                                       ~~  #@@$           .!,                ");
            Console.WriteLine("                                   .  .;~  @@@@            --. . .  .   .    ");
            Console.WriteLine("                                       ;~  @@@@            ,!                ");
            Console.WriteLine("                                       ~~  -;:~    -,       ;:               ");
            Console.WriteLine("                                   .  .~~          -;        * . .  .   .    ");
            Console.WriteLine("                           .  .   .    ,~           ~:.      ;;      . . .  .");
            Console.WriteLine("                                       ,~            ~:;-.    !,             ");
            Console.WriteLine("                                       ,~              ,:;    :~             ");
            Console.WriteLine("                           .  ..  .    ,~                !:   ,:.    . . .  .");
            Console.WriteLine("                                       ,~                !!.  .!,            ");
            Console.WriteLine("                                       -~                !~:   ~:            ");
            Console.WriteLine("                                      .:~  ,,            !.:,  -!.           ");
            Console.WriteLine("                           .  ..  .    !~  !-            ! -!,.;~    . . .  .");
            Console.WriteLine("                                       *~  *-  :-  -*   .!  -:;~.            ");
            Console.WriteLine("                                       *-  *-  !-  -*   ,*                   ");
            Console.WriteLine("                           .  .   .    !-  !,  *-  -*   ~*           . . .  .");
            Console.WriteLine("                           .  ..  .    *~ ~;   :   -*   :~    . .    . . .  .");
            Console.WriteLine("                                      .:~ *;   :   -*   :,   . . .           ");
            Console.WriteLine("                                       ,:-!;  .:   -*   :,                   ");
            Console.WriteLine("                                       .--,;  -:   -*   :.                   ");
            Console.WriteLine("                                   .  .   .;  !:   ~*   : .  . . .  .   .    ");
            Console.WriteLine("                                      .   .!~:*:   !*  .;    . . .           ");
            Console.WriteLine("                           .  ..  .      . -!!.:   **. -:.    . .    . . .  .");
            Console.WriteLine("                                              .;   !:;!;,                    ");
            Console.WriteLine("                                              .;- ~;..-.                     ");
            Console.WriteLine("                                      .   .    -!;!.         . . .           ");

        }
        
        //짝둘
        public void Two_h()
        {
            Console.WriteLine("                                   .  .   .,!;;;;;;;;;*~  .  . . .  .   .    ");
            Console.WriteLine("                                           --         *~                     ");
            Console.WriteLine("                                           ,-         !,                     ");
            Console.WriteLine("                           .  ..  .      . --         !, .    . .    . . .  .");
            Console.WriteLine("                                      .   -!,         ;:.    . . .           ");
            Console.WriteLine("                                         -*,           ::                    ");
            Console.WriteLine("                              .   .     ,!.             ;;           . . .   ");
            Console.WriteLine("                                   .  ..~-               !;  . . .  .   .    ");
            Console.WriteLine("                                       ,;.                !,                 ");
            Console.WriteLine("                                       ,~  ,!!            ~~                 ");
            Console.WriteLine("                                       ~~  #@@$           .!,                ");
            Console.WriteLine("                                   .  .;~  @@@@            --. . .  .   .    ");
            Console.WriteLine("                                       ;~  @@@@            ,!                ");
            Console.WriteLine("                                       ~~  -;:~    -,       ;:               ");
            Console.WriteLine("                                   .  .~~          -;        * . .  .   .    ");
            Console.WriteLine("                           .  .   .    ,~       ,.  ~:.      ;;      . . .  .");
            Console.WriteLine("                                       ,~      *@=   ~:;-.    !,             ");
            Console.WriteLine("                                       ,~     =@@@*    ,:;    :~             ");
            Console.WriteLine("                           .  ..  .    ,~     -@@@#      !:   ,:.    . . .  .");
            Console.WriteLine("                                       ,~      ===       !!.  .!,            ");
            Console.WriteLine("                                       -~                !~:   ~:            ");
            Console.WriteLine("                                      .:~  ,,            !.:,  -!.           ");
            Console.WriteLine("                           .  ..  .    !~  !-            ! -!,.;~    . . .  .");
            Console.WriteLine("                                       *~  *-  :-  -*   .!  -:;~.            ");
            Console.WriteLine("                                       *-  *-  !-  -*   ,*                   ");
            Console.WriteLine("                                       *-  ;   !,  -*   :*                   ");
            Console.WriteLine("                                      .:~ *;   :   -*   :,   . . .           ");
            Console.WriteLine("                                       ,:-!;  .:   -*   :,                   ");
            Console.WriteLine("                                       .--,;  -:   -*   :.                   ");
            Console.WriteLine("                                   .  .   .;  !:   ~*   : .  . . .  .   .    ");
            Console.WriteLine("                                      .   .!~:*:   !*  .;    . . .           ");
            Console.WriteLine("                           .  ..  .      . -!!.:   **. -:.    . .    . . .  .");
            Console.WriteLine("                                              .;   !:;!;,                    ");
            Console.WriteLine("                                              .;- ~;..-.                     ");
            Console.WriteLine("                                      .   .    -!;!.         . . .           ");

        }

        //홀 셋
        public void T_h()
        {

            Console.WriteLine("                                   .  .   .,!;;;;;;;;;*~  .  . . .  .   .    ");
            Console.WriteLine("                                           --         *~                     ");
            Console.WriteLine("                                           ,-         !,                     ");
            Console.WriteLine("                           .  ..  .      . --         !, .    . .    . . .  .");
            Console.WriteLine("                                      .   -!,         ;:.    . . .           ");
            Console.WriteLine("                                         -*,           ::                    ");
            Console.WriteLine("                              .   .     ,!.             ;;           . . .   ");
            Console.WriteLine("                                   .  ..~-               !;  . . .  .   .    ");
            Console.WriteLine("                                       ,;.                !,                 ");
            Console.WriteLine("                                       ,~  ,!!            ~~                 ");
            Console.WriteLine("                                       ~~  #@@$   .*,     .!,                ");
            Console.WriteLine("                                   .  .;~  @@@@  $@@@,     --. . .  .   .    ");
            Console.WriteLine("                                       ;~  @@@@  #@@@$     ,!                ");
            Console.WriteLine("                                       ~~  -;:~  #@@@:      ;:               ");
            Console.WriteLine("                                   .  .~~        .@@@.       * . .  .   .    ");
            Console.WriteLine("                           .  .   .    ,~       ,.  ~:.      ;;      . . .  .");
            Console.WriteLine("                                       ,~      *@=   ~:;-.    !,             ");
            Console.WriteLine("                                       ,~     =@@@*    ,:;    :~             ");
            Console.WriteLine("                           .  ..  .    ,~     -@@@#      !:   ,:.    . . .  .");
            Console.WriteLine("                                       ,~      ===       !!.  .!,            ");
            Console.WriteLine("                                       -~                !~:   ~:            ");
            Console.WriteLine("                                      .:~  ,,            !.:,  -!.           ");
            Console.WriteLine("                           .  ..  .    !~  !-            ! -!,.;~    . . .  .");
            Console.WriteLine("                                       *~  *-  :-  -*   .!  -:;~.            ");
            Console.WriteLine("                                       *-  *-  !-  -*   ,*                   ");
            Console.WriteLine("                           .  ..  .    *~ ~;   :   -*   :~    . .    . . .  .");
            Console.WriteLine("                                      .:~ *;   :   -*   :,   . . .           ");
            Console.WriteLine("                                       ,:-!;  .:   -*   :,                   ");
            Console.WriteLine("                                       .--,;  -:   -*   :.                   ");
            Console.WriteLine("                                      .   .!~:*:   !*  .;    . . .           ");
            Console.WriteLine("                           .  ..  .      . -!!.:   **. -:.    . .    . . .  .");
            Console.WriteLine("                                              .;   !:;!;,                    ");
            Console.WriteLine("                                              .;- ~;..-.                     ");
            Console.WriteLine("                                      .   .    -!;!.         . . .           ");

        }
        //짝 넷
        public void F_h()
        {

            Console.WriteLine("                                   .  .   .,!;;;;;;;;;*~  .  . . .  .   .    ");
            Console.WriteLine("                                           --         *~                     ");
            Console.WriteLine("                                           ,-         !,                     ");
            Console.WriteLine("                           .  ..  .      . --         !, .    . .    . . .  .");
            Console.WriteLine("                                      .   -!,         ;:.    . . .           ");
            Console.WriteLine("                                         -*,           ::                    ");
            Console.WriteLine("                              .   .     ,!.             ;;           . . .   ");
            Console.WriteLine("                                   .  ..~-               !;  . . .  .   .    ");
            Console.WriteLine("                                       ,;.                !,                 ");
            Console.WriteLine("                                       ,~  ,!!            ~~                 ");
            Console.WriteLine("                                       ~~  #@@$   .*,     .!,                ");
            Console.WriteLine("                                   .  .;~  @@@@  $@@@,     --. . .  .   .    ");
            Console.WriteLine("                                       ;~  @@@@  #@@@$     ,!                ");
            Console.WriteLine("                                       ~~  -;:~  #@@@:      ;:               ");
            Console.WriteLine("                                   .  .~~        .@@@.       * . .  .   .    ");
            Console.WriteLine("                           .  .   .    ,~ ,@!.  ,.  ~:.      ;;      . . .  .");
            Console.WriteLine("                                       ,~-@@@= *@=   ~:;-.    !,             ");
            Console.WriteLine("                                       ,~~@@@@=@@@*    ,:;    :~             ");
            Console.WriteLine("                           .  ..  .    ,~ @@@,-@@@#      !:   ,:.    . . .  .");
            Console.WriteLine("                                       ,~  ;~  ===       !!.  .!,            ");
            Console.WriteLine("                                       -~                !~:   ~:            ");
            Console.WriteLine("                                      .:~  ,,            !.:,  -!.           ");
            Console.WriteLine("                           .  ..  .    !~  !-            ! -!,.;~    . . .  .");
            Console.WriteLine("                                       *~  *-  :-  -*   .!  -:;~.            ");
            Console.WriteLine("                                       *-  *-  !-  -*   ,*                   ");
            Console.WriteLine("                           .  .   .    !-  !,  *-  -*   ~*           . . .  .");
            Console.WriteLine("                           .  ..  .    *~ ~;   :   -*   :~    . .    . . .  .");
            Console.WriteLine("                                      .:~ *;   :   -*   :,   . . .           ");
            Console.WriteLine("                                       ,:-!;  .:   -*   :,                   ");
            Console.WriteLine("                                       .--,;  -:   -*   :.                   ");
            Console.WriteLine("                                      .   .!~:*:   !*  .;    . . .           ");
            Console.WriteLine("                           .  ..  .      . -!!.:   **. -:.    . .    . . .  .");
            Console.WriteLine("                                              .;   !:;!;,                    ");
            Console.WriteLine("                                              .;- ~;..-.                     ");
            Console.WriteLine("                                      .   .    -!;!.         . . .           ");

        }



    }
   
}

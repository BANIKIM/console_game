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
        //강화의 달인 타이틀 이미지
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
            Console.WriteLine("                         #$====================@                                                 ");
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
        //강화의 달인 메뉴 이미지
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
            Console.WriteLine("                        #$====================@       |                                               |");
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

        public void AC()
        {
            Console.WriteLine("                                                                       .                              ");
            Console.WriteLine("                                                                     ,$=                              ");
            Console.WriteLine("                                                                    -$$*                              ");
            Console.WriteLine("                                                                    !$$-                              ");
            Console.WriteLine("                                                                   ~$$$                               ");
            Console.WriteLine("                                                                  .!===-                    ....      ");
            Console.WriteLine("                                                                  -====!  ,---------------------      ");
            Console.WriteLine("                                                                  -====**!;;;;;;;;;;;;;;;;;:----,     ");
            Console.WriteLine("                                                                  -=======!:::::::::::::::::-----     ");
            Console.WriteLine("                                                                  -====!  -~~~~~~~~~~~~~~~~~,,,,      ");
            Console.WriteLine("                                                                  ,!===~                              ");
            Console.WriteLine("                                                                  -!***;,                             ");
            Console.WriteLine("                                                                  -!!!!!,                             ");
            Console.WriteLine("                                                                  -!!!!!,                             ");
            Console.WriteLine("                                                ,-----------------:!!!!!~-----                        ");
            Console.WriteLine("                                                -****************************~                        ");
            Console.WriteLine("                                     ***!!!!!!!!*============================                         ");
            Console.WriteLine("                                     $$$$$$$$$$$$===========================$                         ");
            Console.WriteLine("                                      :$$$$$$$$$$===========================.                         ");
            Console.WriteLine("                                       -*=$$$$$$$==========================!                          ");
            Console.WriteLine("                                         ~;=$$$$$$=========================,                          ");
            Console.WriteLine("                                           -~~~:;:========================;                           ");
            Console.WriteLine("                                                  ,-=====================;                            ");
            Console.WriteLine("                                                    .:=================*-                             ");
            Console.WriteLine("                                                      ;============***;                               ");
            Console.WriteLine("                                                      ~*=========*!-                                  ");
            Console.WriteLine("                                                       !=========!.                                   ");
            Console.WriteLine("                                                       !========*,                                    ");
            Console.WriteLine("                                                      ,!========*:                                    ");
            Console.WriteLine("                                                   ...;**********;....                                ");
            Console.WriteLine("                                                   !!!!!!!!!!!!!!!!!!!                                ");
            Console.WriteLine("                                                   ~~~~~~~~~~~~~~~~~~~                                ");
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

            //구매리스트
            Console.Clear();
            while (player.money > 0)
            {
                AB(player);
                if (player.money < 1000)//1000원 이하의 금액을 가지고 있다면 강화의 달인을 나간다.
                {
                    Console.WriteLine("너 칼 하나도 못사..");
                    Thread.Sleep(2000);
                    break;
                }
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        if (player.money >= 1000)
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

                while (equipment != 0) // 장비를 구매했다면 강화를 실패하거나 팔때까지 진행
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
                    int a = rand.Next(1, 101);//100의 난수를 받음
                    input = int.Parse(Console.ReadLine());

                    if (input == 1)
                    {

                        if (a < 100 / count) //1강은 99퍼센트 2강은 50퍼 3강은 33퍼식으로 확률이 내려감
                        {
                            Console.Clear();
                            AC();
                            success.PlaySync();
                            Console.WriteLine($" {count} 강 성공");
                        }
                        else
                        {
                            Console.Clear();
                            AC();
                            failure.PlaySync();
                            Console.WriteLine($" {count} 강 실패");
                            equipment = 0;
                            count = 1;
                            break;

                        }
                        count++;//강화가 성공하면 카운터 변수에 1이 더 해지고 판매금액과 강화 성공 확률이 떨어짐
                    }
                    else
                    {
                        Console.WriteLine($" {count} 강 판매"); //강화 수치만금 돈을 많이 받음
                        player.money += equipment * count;// 1강후 판매는 돈을 벌지 못함
                        count = 1;
                        break;
                    }
                    if (player.money <= 0 && equipment == 0)//돈이 0이고 강화할 장비가 없다면 게임을 종료함
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
            int h_1 = 0;// 1번말의 배팅금액을 저장할 변수
            int h_2 = 0;// 2번말의 배팅금액을 저장할 변수
            int h_3 = 0;// 3번말의 배팅금액을 저장할 변수
            int h_4 = 0;// 4번말의 배팅금액을 저장할 변수
            int h_num = 0; // 몇번말에 돈을 걸었는지 확인 할 변수
            int[] buff_num = new int[4]; // 말에게 속도 버프나 디버프를 줄 배열의 값
            float[] buff = new float[6] { -0.02f, -0.01f, 0.01f, 0.01f, 0.02f, -0.02f };//버프 디퍼브의 저장된 수치
            string[] buff_s = new string[6] { "먹이를 많이 먹었습니다.", "잘 먹지 못했습니다.", "잘 먹었습니다.", "잠을 잘 잤습니다.",
            "잠을 많이 잣습니다.","잠을 자지 못했습니다."};//버프 디버프의 내역
            char char_input = ' ';
            int R = 0;

            const int time_delay = 100;
            const string line = "------------------------------------------------------------";
            int line_len = line.Length;
            Game g = new Game();
            while (true)
            {
                for (int i = 0; i < buff_num.Length; i++)
                {
                    buff_num[i] = rand.Next(0, 6);
                }
                h_1 = rand.Next(1000, 20000);//초기 자금이 많이 드는 대신에 랜덤으로 말들에게 돈을 걸어서 추가로 돈을 더 벌 수 있음
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

                if (player.money < 5000) // 최소 배팅금액 5000원이 없다면 메인메뉴로 돌아간다..
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
                                if (player.money > input || input > 5000)//가진돈 보다 많이 거는것을 방지하기 위한 방어코드
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
                            while (true)
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
                            Console.WriteLine("메뉴로 돌아갑니다.");//메인 메뉴로 가기위한 선택문
                            break;

                    }


                }
                if (input == 5)//메뉴로 돌아가기
                {
                    break;
                }

                int spead_a = 0;
                int spead_b = 0;
                int spead_c = 0;
                int spead_d = 0;

                while (true)//말이 달리는걸 표현하기 위한 반복문
                {

                    Thread.Sleep(time_delay);
                    Console.Clear();



                    double a = rand.NextDouble() * 2 + (0.5 + buff[buff_num[0]]);//말들의 랜덤한 달리기 뒤에 배열로 버프가될 수도 디버프가 될수도 있음
                    double b = rand.NextDouble() * 2 + (0.5 + buff[buff_num[1]]);
                    double c = rand.NextDouble() * 2 + (0.5 + buff[buff_num[2]]);
                    double d = rand.NextDouble() * 2 + (0.5 + buff[buff_num[3]]);

                    spead_a = (int)(spead_a + a);
                    spead_b = (int)(spead_b + b);
                    spead_c = (int)(spead_c + c);
                    spead_d = (int)(spead_d + d);





                    Console.WriteLine($"                 1 번마 ㅁㅁㅁㅁ    {h_1} 원");//전광판
                    Console.WriteLine($"                 2 번마 ㅁㅁㅁㅁ    {h_2} 원");
                    Console.WriteLine($"                 3 번마 ㅁㅁㅁㅁ    {h_3} 원");
                    Console.WriteLine($"                 4 번마 ㅁㅁㅁㅁ    {h_4} 원");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("        ||●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●||");//관객
                    Console.WriteLine("        ||●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●||");
                    Console.WriteLine("        ||●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●||");
                    Console.WriteLine("        ||●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●||");
                    Console.WriteLine("        ||●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●||");
                    Console.WriteLine("        ||●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●||");
                    Console.WriteLine(line);

                    for (int i = 0; i < spead_a; i++)//1번마
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

                    if (R == 0)
                    {
                        R = 1;
                        Thread.Sleep(3000);//3초 후 
                        go.PlaySync();//총성과 함께 스타트
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


                        switch (numb)//당첨 말 확인 후 그 말에 돈을 걸었다면 상금을 지급
                        {
                            case "1번마":
                                if (h_num == 1)
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

                        Console.WriteLine("다시하려면 'r' 키를 누르시오.");//r을 입력하면 다시 배팅을 하고 경마에 참여
                        Console.WriteLine($"            남은돈 : {player.money}");
                        char_input = char.Parse(Console.ReadLine());
                        if (char_input == 'r')
                        {
                            char_input = ' ';
                            R = 0;
                            break;
                        }
                        else//다른 값이 입력되면 input에 5를 입력받고 게임을 나감
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
            int menyu = 0; // 메뉴 나가기 위한것
            int sniffling_rand = 0;
            int bat = 0;
            int combat;
            SoundPlayer ok = new SoundPlayer("C:\\Users\\ajtwj\\source\\repos\\console_code_01\\console_code_01\\Music\\결과.wav");//선택

            while (menyu == 0)// 메뉴 값이 0이면 계속 홀짝을 한다.
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


                while (sniffling_rand == 0)
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
                                    if (sniffling_rand < 100)//최소 배팅금 100원
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
                                    Console.WriteLine("그정도로 돈이 없어..");//가진돈 보다 배팅금을 많이 걸려고하면 방어하는 방어코드
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



                while (menyu == 0)
                {
                    if (player.money < sniffling_rand)//배팅금보다 가진돈이 적다면 메뉴로
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
                    //홀짝 흔드는거 표현
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
                    if (bat == 1)//금액 정산
                    {
                        if (combat == 1 || combat == 3)
                        {
                            player.money += sniffling_rand * 2;
                            Console.WriteLine($"홀에 걸었네 축하해");

                        }
                        else
                        {
                            Console.WriteLine("아쉽게 됬네");
                        }
                    }
                    else if (bat == 2)
                    {
                        if (combat == 2 || combat == 4)
                        {
                            player.money += sniffling_rand * 2;
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
                    Console.ReadKey();//계속진행

                }

                if (player.money < sniffling_rand)//게임오버 확인
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
        //주먹 흔들기
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

        // 숫자31게임

        public void number_G()
        {
            int[] arr = new int[32];
            int incount = 1;
            int a = 0;
            bool Brak = false;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                                                              사용자 차례    ");
                Console.WriteLine("                                                              Q 를 누르면 숫자를 외칠 수 있어!");
                Hu();
                for (int i = 0; i < 3; i++)//3번 말할 수 있다 유저차례
                {
                    
                    switch(Console.ReadKey().Key)
                    {
                        case ConsoleKey.Q:
                            Console.Clear();
                            Say_Hu(incount);
                            a = 1;
                            break;
                        default:
                            Brak = true;
                            break;
                    }
                    if(Brak==true)
                    {
                        Brak = false;
                        break;
                    }
                    if(i==2)
                    {
                        Thread.Sleep(1000);

                    }
                    if (incount == 31)
                    {
                        Brak = true;
                        Console.WriteLine("사용자 패배");
                        Thread.Sleep(3000);
                        break;
                    }
                    incount++;

                }
                if (Brak == true)
                {
                    Console.WriteLine("게임끝");
                    Brak = false;
                    break;
                }

                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                                                               컴퓨터 차례");
                Hu();
                
                
                if(Isu(a) ==true)//사용자가 외쳐야 컴퓨터 차례
                {
                    a = 0;
                    for (int i = 0; i < rand.Next(1, 3); i++)//3번 말할 수 있다 COM차례
                    {
                        Console.Clear();
                        Say_COM(incount);
                        Thread.Sleep(2000);
                        
                        if(incount==30)
                        {
                            incount++;
                            break;
                        }
                        if (incount == 31)
                        {
                            Brak = true;
                            Console.WriteLine("com 패배");
                            break;
                        }
                        incount++;
                    }
                    if(Brak==true)
                    {
                        Console.WriteLine("게임끝");
                        Thread.Sleep(3000);
                        Brak = false;
                        break;
                    }
                }
                
               


            }



        }
        public bool Isu(int a)
        {

            if(a==1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void Say()
        {

        }

        //대기 모션
        public void Hu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                                                                                                                 ");
            Console.WriteLine("                                                                                                                                 ");
            Console.WriteLine("                                                    -#@@$.             =@@@~             ~@@@=                                   ");
            Console.WriteLine("                                                   .@@@@@=            *@@@@@-           ,@@@@@*                                  ");
            Console.WriteLine("                                                   -@@@@@@            @@@@@@:           :@@@@@@                                  ");
            Console.WriteLine("                                                   -@@@@@@            @@@@@@:           ~@@@@@@                                  ");
            Console.WriteLine("                                                    @@@@@*            ;@@@@@,           .@@@@@:                                  ");
            Console.WriteLine("                                                    .#@@*              ;@@@,             ,@@@;                                   ");
            Console.WriteLine("                                                   ;     :~          -;  .  !           !     ;-                                 ");
            Console.WriteLine("                                                  $@@:.,;@@!        :@@!,.~#@#        .$@#~.-;@@;                                ");
            Console.WriteLine("                                                 =@@@@@@@@@@,       @@@@@@@@@@@       #@@@@@@@@@@.                               ");
            Console.WriteLine("                                                 #@@@@@@@@@@$      !@@@@@@@@@@@,     .@@@@@@@@@@@*                               ");
            Console.WriteLine("                                                 @@@@@@@@@@@#      #@@@@@@@@@@@,     .@@@@@@@@@@@#                               ");
            Console.WriteLine("                                                 @@@@@@@@@@@#      #@@@@@@@@@@@,     .@@@@@@@@@@@#                               ");
            Console.WriteLine("                                                 @@@@@@@@@@@#      #@@@@@@@@@@@,     .@@@@@@@@@@@#                               ");
            Console.WriteLine("                                                 @@@@@@@@@@@#      #@@@@@@@@@@@,     .@@@@@@@@@@@#                               ");
            Console.WriteLine("                                                                                                                                 ");
            Console.WriteLine("                                                                                                                                 ");
        }


        //말을 하면 나옴
        public void Say_COM(int a)
        {
            Console.WriteLine("                                                               COM                                   ");
            Console.WriteLine("                                                                              __________________     ");
            Console.WriteLine("                                                             $$$$$$$#        |                       ");
            Console.WriteLine($"                                                           $$$$$$$$$$$       |         {a}            ");
            Console.WriteLine("                                                         $$$$$$$$$$$$$$$     |    ______________     ");
            Console.WriteLine("                                                       #$$$$$$$$$$$$$$$$$$   |   /				    ");
            Console.WriteLine("                                                       $$$$$$$$$$$$$$$$$$$$  |  /				    ");
            Console.WriteLine("                                                      $$$$$$$$$$$$$$$$$$$$$  | /					    ");
            Console.WriteLine("                                                     $$$$$$$$$$$$$$$$$$$$$$$ |/					    ");
            Console.WriteLine("                                                     $$$$$$$$$$$$$$$$$$$$$$$ 					    ");
            Console.WriteLine("                                                    $$$$$$$$$$$$$$$$$$$$$$$$$					    ");
            Console.WriteLine("                                                    $$$$$$$$$$$$$$$$$$$$$$$$$					    ");
            Console.WriteLine("                                                    $$$$$$$$$$$$$$$$$$$$$$$$$					    ");
            Console.WriteLine("                                                    $$$$$               $$$$$					    ");
            Console.WriteLine("                                                     $$$$$              $$$$$					    ");
            Console.WriteLine("                                                     $$$$$$            $$$$$						    ");
            Console.WriteLine("                                                      $$$$$$#         $$$$$$						    ");
            Console.WriteLine("                                                       $$$$$$$      $$$$$$$$						    ");
            Console.WriteLine("                                                       #$$$$$$$$$$$$$$$$$$						    ");
            Console.WriteLine("                                                         $$$$$$$$$$$$$$$							    ");
            Console.WriteLine("                                                            $$$$$$$$$$$							    ");
            Console.WriteLine("                                                             $$$$$$$#							    ");
            Console.WriteLine("                                                    												    ");
            Console.WriteLine("                                                        ###@@@@@@@@@@@$##$						    ");
            Console.WriteLine("                                                      $$$$$$$#@@@@@$$$$$$$$$						    ");
            Console.WriteLine("                                                    $$$$$$$$$$$$$$$$$$$$$$$$						    ");
            Console.WriteLine("                                                    $$$$$$$$$$$$$$$$$$$$$$$$$$					    ");
        }


        public void Say_Hu(int a)
        {
            Console.WriteLine("                                                               ME                                   ");
            Console.WriteLine("                                                                              __________________     ");
            Console.WriteLine("                                                             $$$$$$$#        |                       ");
            Console.WriteLine($"                                                           $$$$$$$$$$$       |        {a}             ");
            Console.WriteLine("                                                         $$$$$$$$$$$$$$$     |    ______________     ");
            Console.WriteLine("                                                       #$$$$$$$$$$$$$$$$$$   |   /				    ");
            Console.WriteLine("                                                       $$$$$$$$$$$$$$$$$$$$  |  /				    ");
            Console.WriteLine("                                                      $$$$$$$$$$$$$$$$$$$$$  | /					    ");
            Console.WriteLine("                                                     $$$$$$$$$$$$$$$$$$$$$$$ |/					    ");
            Console.WriteLine("                                                     $$$$$$$$$$$$$$$$$$$$$$$ 					    ");
            Console.WriteLine("                                                    $$$$$$$$$$$$$$$$$$$$$$$$$					    ");
            Console.WriteLine("                                                    $$$$$$$$$$$$$$$$$$$$$$$$$					    ");
            Console.WriteLine("                                                    $$$$$$$$$$$$$$$$$$$$$$$$$					    ");
            Console.WriteLine("                                                    $$$$$               $$$$$					    ");
            Console.WriteLine("                                                     $$$$$              $$$$$					    ");
            Console.WriteLine("                                                     $$$$$$            $$$$$						    ");
            Console.WriteLine("                                                      $$$$$$#         $$$$$$						    ");
            Console.WriteLine("                                                       $$$$$$$      $$$$$$$$						    ");
            Console.WriteLine("                                                       #$$$$$$$$$$$$$$$$$$						    ");
            Console.WriteLine("                                                         $$$$$$$$$$$$$$$							    ");
            Console.WriteLine("                                                            $$$$$$$$$$$							    ");
            Console.WriteLine("                                                             $$$$$$$#							    ");
            Console.WriteLine("                                                    												    ");
            Console.WriteLine("                                                        ###@@@@@@@@@@@$##$						    ");
            Console.WriteLine("                                                      $$$$$$$#@@@@@$$$$$$$$$						    ");
            Console.WriteLine("                                                    $$$$$$$$$$$$$$$$$$$$$$$$						    ");
            Console.WriteLine("                                                    $$$$$$$$$$$$$$$$$$$$$$$$$$					    ");
        }

    }

}

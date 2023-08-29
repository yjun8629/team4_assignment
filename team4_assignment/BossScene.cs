﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

internal class BossScene
{
    Monster boss = new Monster(5);

    public void StartPhase()
    {
        Console.Clear();
        DrawTuna(0, 0);
        DrawHpBar(0, 20);
        DrawInfoUI(53, 0);
        DrawStatUI(53, 10);
        DrawSkillUI(81, 10);
        Console.SetCursorPosition(55, 2);
        Console.Write("자이언트 첨치가 출현했습니다!");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(55, 3);
        Console.Write("녀석은 무지하게 화가 나 있습니다.");
        Console.ResetColor();
        Choice1();
    }

    public void SkillPhase()
    {
        ClearInfo();
        Console.SetCursorPosition(55, 2);
        Console.Write("당신은 스킬 사용을 선택했습니다.");
        Console.SetCursorPosition(55, 3);
        Console.Write("사용할 스킬을 선택해주세요.");
        Choice2();
    }

    public void DamagePhase()
    {
        ClearInfo();
        ReduceHpBar(0, 20);
        Console.SetCursorPosition(55, 2);
        Console.Write("스킬 사용에 성공했습니다!");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(55, 3);
        Console.Write($"자이언트 참치의 체력은 {boss.Hp}남았습니다.");
        Console.ResetColor();
        Console.SetCursorPosition(55, 4);
        Console.Write("자이언트 참치는 몹시 화가 났습니다.");
        Console.SetCursorPosition(55, 5);
        Console.Write("다음 행동을 선택해주세요.");
        Choice3();
    }

    public void MonsterPhase()
    {
        ClearInfo();
        Console.SetCursorPosition(55, 2);
        Console.Write("자이언트 참치가 당신을 공격했습니다!");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(55, 3);
        Console.Write($"당신의 체력은 {Program.player.Hp}남았습니다.");
        Console.ResetColor();
        Console.SetCursorPosition(55, 4);
        Console.Write("다음 행동을 선택해주세요.");
        Choice4();
    }

    public void Choice1()
    {
        bool isSelect = false;
        Console.SetCursorPosition(53, 28);
        Console.Write("                                                        ");
        Console.SetCursorPosition(53, 28);
        Console.Write("[0]도망가기 [1]스킬사용 | 선택지를 입력해주세요.: ");

        while (isSelect == false)
        {
            while (isSelect == false)
            {
                string key = Console.ReadLine();

                if (key == "0")
                {
                    Program.entrance.EntranceUI();
                    isSelect = true;
                }
                else if (key == "1")
                {
                    SkillPhase();
                    isSelect = true;
                }
                else
                {
                    Console.SetCursorPosition(53, 28);
                    Console.Write("                                                        ");
                    Console.SetCursorPosition(53, 28);
                    Console.Write("[0]도망가기 [1]스킬사용 | 올바른 값을 입력해주세요.: ");
                }
            }
        }
    }

    public void Choice2()
    {
        bool isSelect = false;
        Console.SetCursorPosition(53, 28);
        Console.Write("                                                        ");
        Console.SetCursorPosition(53, 28);
        Console.Write("[1]사용 [2]사용 [3]사용 | 선택지를 입력해주세요.: ");

        while (isSelect == false)
        {
            while (isSelect == false)
            {
                string key = Console.ReadLine();

                if (key == "1")
                {
                    DamagePhase();
                    isSelect = true;
                }
                else if (key == "2")
                {
                    DamagePhase();
                    isSelect = true;
                }
                else if (key == "3")
                {
                    DamagePhase();
                    isSelect = true;
                }
                else
                {
                    Console.SetCursorPosition(53, 28);
                    Console.Write("                                                        ");
                    Console.SetCursorPosition(53, 28);
                    Console.Write("[1]사용 [2]사용 [3]사용 | 올바른 값을 입력해주세요.: ");
                }
            }
        }
    }

    public void Choice3()
    {
        bool isSelect = false;
        Console.SetCursorPosition(53, 28);
        Console.Write("                                                        ");
        Console.SetCursorPosition(53, 28);
        Console.Write("[0]도망가기 [1]계속하기 | 선택지를 입력해주세요.: ");

        while (isSelect ==  false)
        {
            while (isSelect == false)
            {
                string key = Console.ReadLine();

                if (key == "0")
                {
                    Program.entrance.EntranceUI();
                    isSelect = true;
                }
                else if (key == "1")
                {
                    MonsterPhase();
                    isSelect = true;
                }
                else
                {
                    Console.SetCursorPosition(53, 28);
                    Console.Write("                                                        ");
                    Console.SetCursorPosition(53, 28);
                    Console.Write("[0]도망가기 [1]계속하기 | 올바른 값을 입력해주세요.: ");
                }
            }
        }
    }

    public void Choice4()
    {
        bool isSelect = false;
        Console.SetCursorPosition(53, 28);
        Console.Write("                                                        ");
        Console.SetCursorPosition(53, 28);
        Console.Write("[0]도망가기 [1]스킬사용 | 선택지를 입력해주세요.: ");

        while (isSelect == false)
        {
            while (isSelect == false)
            {
                string key = Console.ReadLine();

                if (key == "0")
                {
                    Program.entrance.EntranceUI();
                    isSelect = true;
                }
                else if (key == "1")
                {
                    SkillPhase();
                    isSelect = true;
                }
                else
                {
                    Console.SetCursorPosition(53, 28);
                    Console.Write("                                                        ");
                    Console.SetCursorPosition(53, 28);
                    Console.Write("[0]도망가기 [1]스킬사용 | 올바른 값을 입력해주세요.: ");
                }
            }
        }
    }

    public void DrawInfoUI(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write("*---------------------- INFO ---------------------*");
        Console.SetCursorPosition(x, y + 8);
        Console.Write("*-------------------------------------------------*");
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x, y + i + 1);
            Console.Write("|");
            Console.SetCursorPosition(x + 50, y + i + 1);
            Console.Write("|");
        }
    }

    public void ClearInfo()
    {
        Console.SetCursorPosition(54, 1);
        Console.Write("                                                 ");
        Console.SetCursorPosition(54, 2);
        Console.Write("                                                 ");
        Console.SetCursorPosition(54, 3);
        Console.Write("                                                 ");
        Console.SetCursorPosition(54, 4);
        Console.Write("                                                 ");
        Console.SetCursorPosition(54, 5);
        Console.Write("                                                 ");
        Console.SetCursorPosition(54, 6);
        Console.Write("                                                 ");
        Console.SetCursorPosition(54, 7);
        Console.Write("                                                 ");
    }

    public void DrawStatUI(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write("*--------- STAT ---------*");
        Console.SetCursorPosition(x, y + 8);
        Console.Write("*------------------------*");
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x, y + i + 1);
            Console.Write("|");
            Console.SetCursorPosition(x + 25, y + i + 1);
            Console.Write("|");
        }
    }

    public void DrawSkillUI (int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write("*------- SKILL -------*");
        Console.SetCursorPosition(x, y + 8);
        Console.Write("*---------------------*");
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x, y + i + 1);
            Console.Write("|");
            Console.SetCursorPosition(x + 22, y + i + 1);
            Console.Write("|");
        }
    }

    public void DrawHpBar(int x, int y)
    {
        Console.SetCursorPosition(x + 1, y);
        Console.BackgroundColor = ConsoleColor.Red;
        for (int i = 0; i < 50; i++)
        {
            Console.Write(" ");
        }
        Console.ResetColor();
        Console.SetCursorPosition(x, y);
        Console.Write("|");
        Console.SetCursorPosition(x + 51, y);
        Console.Write("|");
    }

    public void ReduceHpBar(int x, int y)
    {
        for (int i = 50; i > 0; i--)
        {
            if (boss.Hp <= i * 10)
            {
                Console.SetCursorPosition(x + i, y);
                Console.Write(" ");
            }
        }
    }

    public void DrawTuna(int x, int y)
    {
        Console.SetCursorPosition(x, y + 0);
        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ @@@@@@@@@@@@@@@@@");
        Console.SetCursorPosition(x, y + 1);
        Console.Write("@@@@@@@@@@@@@@@@@@@**=@@@@@@@@@*~.:@@@@@@@@@@@@=@@@@");
        Console.SetCursorPosition(x, y + 2);
        Console.Write("@@@@@@@@@@@@@@@@@@!,,-;:@@@@@#;.:!@@@@@@@@@@@;;,@@@@");
        Console.SetCursorPosition(x, y + 3);
        Console.Write("@@@@@@@@@@@@@@@@@~,,,,,,-#@@#--,!@@@@@@@@@@@;..$@@@@");
        Console.SetCursorPosition(x, y + 4);
        Console.Write("@@@@@@@@@@@@@@@!.....-,, !:,~@@@@@@@@@@@@!  :@@@@@@@");
        Console.SetCursorPosition(x, y + 5);
        Console.Write("@@@@@@@@@@#$.                     =$@@@@@@!  $@@@@@@");
        Console.SetCursorPosition(x, y + 6);
        Console.Write("@@@@@@@@@*~*                         $#@@=   $@@@@@@");
        Console.SetCursorPosition(x, y + 7);
        Console.Write("@@@@@@@; ~~-:                        ,~:;,  ~#@@@@@@");
        Console.SetCursorPosition(x, y + 8);
        Console.Write("@@@@@@~.  :.,                               *@@@@@@@");
        Console.SetCursorPosition(x, y + 9);
        Console.Write("@@@@@@,          ~,,,,,,,,,,,,,,,*########* *@@@@@@@");
        Console.SetCursorPosition(x, y + 10);
        Console.Write("@@@@@@~=######;~~~~~~~~~~;##########$#=~@.   $@@@@@@");
        Console.SetCursorPosition(x, y + 11);
        Console.Write("@@@@@@@; !#######################=$!;!==@@!   $@@@@@");
        Console.SetCursorPosition(x, y + 12);
        Console.Write("@@@@@@@@!~*######$$$$$#######$:=;#**@@@@@@:  ~@@@@@@");
        Console.SetCursorPosition(x, y + 13);
        Console.Write("@@@@@@@@@$;=@####$$$$$#####@;~ ~#@@@@@@@@@@:  @@@@@@");
        Console.SetCursorPosition(x, y + 14);
        Console.Write("@@@@@@@@@@@@@ *##########= !:,~@@@@@@@@@@@@@~  @@@@@");
        Console.SetCursorPosition(x, y + 15);
        Console.Write("@@@@@@@@@@@@@@#$=*$;~~~=$#@@#-,,*@@@@@@@@@@@@#-,@@@@");
        Console.SetCursorPosition(x, y + 16);
        Console.Write("@@@@@@@@@@@@@@@@@!:!@@@@@@@@@@:::!@@@@@@@@@@@@@!@@@@");
        Console.SetCursorPosition(x, y + 17);
        Console.Write("@@@@@@@@@@@@@@@@@@*$@@@@@@@@@@@#*-:@@@@@@@@@@@@@@@@@");
        Console.SetCursorPosition(x, y + 18);
        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#,@@@@@@@@@@@@@@@@@");

        Console.SetCursorPosition(x, y + 22);
        Console.Write("  ::::::::::   :::    :::    ::::    :::        ::: ");
        Console.SetCursorPosition(x, y + 23);
        Console.Write("     :+:      :+:    :+:    :+:+:   :+:      :+: :+:");
        Console.SetCursorPosition(x, y + 24);
        Console.Write("    +:+      +:+    +:+    :+:+:+  +:+     +:+   +:+");
        Console.SetCursorPosition(x, y + 25);
        Console.Write("   +#+      +#+    +:+    +#+ +:+ +#+    +#++:++#++:");
        Console.SetCursorPosition(x, y + 26);
        Console.Write("  +#+      +#+    +#+    +#+  +#+#+#    +#+     +#+ ");
        Console.SetCursorPosition(x, y + 27);
        Console.Write(" #+#      #+#    #+#    #+#   #+#+#    #+#     #+#  ");
        Console.SetCursorPosition(x, y + 28);
        Console.Write("###       ########     ###    ####    ###     ###   ");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(x + 56, y + 20);
        Console.Write(":::::::::    ::::::::    ::::::::    ::::::::  ");
        Console.SetCursorPosition(x + 56, y + 21);
        Console.Write(":+:    :+:  :+:    :+:  :+:    :+:  :+:    :+: ");
        Console.SetCursorPosition(x + 56, y + 22);
        Console.Write("+:+   +:+   +:+    +:+  +:+         +:+        ");
        Console.SetCursorPosition(x + 56, y + 23);
        Console.Write("+#++:++#+   +#+    +:+  +#++:++#++  +#++:++#++ ");
        Console.SetCursorPosition(x + 56, y + 24);
        Console.Write("+#+    +#+  +#+    +#+         +#+         +#+ ");
        Console.SetCursorPosition(x + 56, y + 25);
        Console.Write("#+#    #+#  #+#    #+#  #+#    #+#  #+#    #+# ");
        Console.SetCursorPosition(x + 56, y + 26);
        Console.Write("#########    ########    ########    ########  ");
        Console.SetCursorPosition(x + 56, y + 27);
        Console.ResetColor();
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer Sound1 = new SoundPlayer(@"..\..\..\audio\FNaF World OST - Travel 1 [Fazbear Hills] Theme (Extended) (1) (online-audio-converter.com).wav");
            Sound1.PlayLooping();
            string priyom;
            string podacha;
            bool turn = true;
            string team_1 = "Команда 1";
            string team_2 = "Команда 2";
            Demonessa Demonessa1 = new Demonessa("Демонесса", 10, 50, 200, 0);
            Chupocabra Chupocabra1 = new Chupocabra("Чупокабра", 10, 50, 200, 0);
            Slut Slut1 = new Slut("Ночная бабочка", 10, 50, 200, 0);
            Maffioze Maffioze1 = new Maffioze("Мафиозе", 10, 50, 200, 0);
            Demonessa Mag = new Demonessa("Маг", 10, 50, 200, 0);
            Chupocabra Gem = new Chupocabra("Самоцвет", 10, 50, 200, 0);
            Slut Fet = new Slut("Фея", 10, 50, 200, 0);
            Maffioze Robot = new Maffioze("Робот", 10, 50, 200, 0);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(team_1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Demonessa1.name);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("xp : " + Demonessa1.xp);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Урон : " + Demonessa1.dmg);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Скиллы : " + Demonessa1.mp);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Броня : " + Demonessa1.armor);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Chupocabra1.name);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("xp : " + Chupocabra1.xp);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Урон : " + Chupocabra1.dmg);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Скиллы : " + Chupocabra1.mp);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Броня : " + Chupocabra1.armor);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Slut1.name);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("xp : " + Slut1.xp);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Урон : " + Slut1.dmg);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Скиллы : " + Slut1.mp);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Броня : " + Slut1.armor);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Maffioze1.name);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("xp : " + Maffioze1.xp);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Урон : " + Maffioze1.dmg);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Скиллы : " + Maffioze1.mp);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Броня : " + Maffioze1.armor);
            //hhh
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(team_2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Mag.name);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("xp : " + Mag.xp);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Урон : " + Mag.dmg);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Скиллы : " + Mag.mp);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Броня : " + Mag.armor);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Gem.name);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("xp : " + Gem.xp);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Урон : " + Gem.dmg);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Скиллы : " + Gem.mp);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Броня : " + Gem.armor);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Fet.name);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("xp : " + Fet.xp);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Урон : " + Fet.dmg);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Скиллы : " + Fet.mp);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Броня : " + Fet.armor);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Robot.name);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("xp : " + Robot.xp);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Урон : " + Robot.dmg);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Скиллы : " + Robot.mp);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Броня : " + Robot.armor);
            //hhh
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("правила: команды ходят по очереди, во время хода выбирай нападающего из своей команды и аттакованного другой");
            //hhh
            Console.WriteLine("напишите 'готов' когда захотите начать игру");
            string ready = Console.ReadLine();
            while (ready != "готов")
            {
                Console.WriteLine("упс, произошло недопонимание, убедитесь в том, что вы написали слово 'готов' из нижнего регистра клавиатуры");
                Console.WriteLine("напишите 'готов' когда захотите начать игру");
                ready = Console.ReadLine();
            }
            SoundPlayer Sound2 = new SoundPlayer(@"..\..\..\audio\FNAF World OST - Final Boss Music Extended (Perfect Loop) (1) (online-audio-converter.com).wav");
            Sound2.PlayLooping();
            while (0 == 0)
            {
                if (turn == true)
                {
                    Console.Clear();
                    Console.WriteLine(team_1 + "                                                                             " + team_2);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Demonessa1.name + "                                                                             " + Mag.name);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("xp : " + Demonessa1.xp + "                                                                               " + "xp : " + Mag.xp);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("урон : " + Demonessa1.dmg + "                                                                             " + "урон : " + Mag.dmg);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("скиллы : " + Demonessa1.mp + "                                                                          " + "скиллы : " + Mag.mp);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("броня : " + Demonessa1.armor + "                                                                             " + "броня : " + Mag.armor);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Mag.name + "                                                                                   " + Gem.name);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("xp : " + Chupocabra1.xp + "                                                                               " + "xp : " + Gem.xp);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("урон : " + Chupocabra1.dmg + "                                                                             " + "урон : " + Gem.dmg);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("скиллы : " + Chupocabra1.mp + "                                                                          " + "скиллы : " + Gem.mp);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("броня : " + Chupocabra1.armor + "                                                                             " + "броня : " + Gem.armor);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Slut1.name + "                                                                        " + Fet.name);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("xp : " + Slut1.xp + "                                                                               " + "xp : " + Fet.xp);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("урон : " + Slut1.dmg + "                                                                             " + "урон : " + Fet.dmg);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("скиллы : " + Slut1.mp + "                                                                          " + "скиллы : " + Fet.mp);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("броня : " + Slut1.armor + "                                                                             " + "броня : " + Fet.armor);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Maffioze1.name + "                                                                               " + Robot.name);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("xp : " + Maffioze1.xp + "                                                                               " + "xp : " + Robot.xp);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("урон : " + Maffioze1.dmg + "                                                                             " + "урон : " + Robot.dmg);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("скиллы : " + Maffioze1.mp + "                                                                          " + "скиллы : " + Robot.mp);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("броня : " + Maffioze1.armor + "                                                                             " + "броня : " + Robot.armor);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("ходит " + team_1);
                    Console.WriteLine("введите 1, если хотите нападать персонажем : " + Demonessa1.name);
                    Console.WriteLine("введите 2, если хотите нападать персонажем : " + Chupocabra1.name);
                    Console.WriteLine("введите 3, если хотите нападать персонажем : " + Slut1.name);
                    Console.WriteLine("введите 4, если хотите нападать персонажем : " + Maffioze1.name);
                    podacha = Console.ReadLine();
                    while (podacha != "1" && podacha != "2" && podacha != "3" && podacha != "4")
                    {
                        Console.WriteLine("упс, произошло недопонимание, убедитесь в том, что вы написали 1, 2, 3 или 4");
                        podacha = Console.ReadLine();
                    }
                    if (podacha == "1")
                    {
                        Console.WriteLine("аттакует персонаж " + Demonessa1.name);
                    }
                    if (podacha == "2")
                    {
                        Console.WriteLine("аттакует персонаж " + Chupocabra1.name);
                    }
                    if (podacha == "3")
                    {
                        Console.WriteLine("аттакует персонаж " + Slut1.name);
                    }
                    if (podacha == "4")
                    {
                        Console.WriteLine("аттакует персонаж " + Maffioze1.name);
                    }
                    Console.WriteLine("введите 1, если хотите аттаковать персонажа : " + Mag.name);
                    Console.WriteLine("введите 2, если хотите аттаковать персонажа : " + Gem.name);
                    Console.WriteLine("введите 3, если хотите аттаковать персонажа : " + Fet.name);
                    Console.WriteLine("введите 4, если хотите аттаковать персонажа : " + Robot.name);
                    priyom = Console.ReadLine();
                    while (priyom != "1" && priyom != "2" && priyom != "3" && priyom != "4")
                    {
                        Console.WriteLine("упс, произошло недопонимание, убедитесь в том, что вы написали 1, 2, 3 или 4");
                        priyom = Console.ReadLine();
                    }
                    if (priyom == "1")
                    {
                        Console.WriteLine("аттакован персонаж " + Mag.name);
                    }
                    if (priyom == "2")
                    {
                        Console.WriteLine("аттакован персонаж " + Gem.name);
                    }
                    if (priyom == "3")
                    {
                        Console.WriteLine("аттакован персонаж " + Fet.name);
                    }
                    if (priyom == "4")
                    {
                        Console.WriteLine("аттакован персонаж " + Robot.name);
                    }
                    Console.WriteLine("чтобы произвести аттаку, нажмите '1'");
                    string reshenie = Console.ReadLine();
                    while (reshenie != "1")
                    {
                        Console.WriteLine("упс, произошло недопонимание, убедитесь в том, что вы написали 1");
                        reshenie = Console.ReadLine();
                    }
                    if (reshenie == "1")
                    {
                        if (podacha == "1" && priyom == "1")
                        {
                            Mag.xp -= Demonessa1.dmg;
                        }
                        if (podacha == "1" && priyom == "2")
                        {
                            Mag.xp -= Chupocabra1.dmg;
                        }
                        if (podacha == "1" && priyom == "3")
                        {
                            Mag.xp -= Slut1.dmg;
                        }
                        if (podacha == "1" && priyom == "4")
                        {
                            Mag.xp -= Maffioze1.dmg;
                        }
                        if (podacha == "2" && priyom == "1")
                        {
                            Gem.xp -= Demonessa1.dmg;
                        }
                        if (podacha == "2" && priyom == "2")
                        {
                            Gem.xp -= Chupocabra1.dmg;
                        }
                        if (podacha == "2" && priyom == "3")
                        {
                            Gem.xp -= Slut1.dmg;
                        }
                        if (podacha == "2" && priyom == "4")
                        {
                            Gem.xp -= Maffioze1.dmg;
                        }
                        if (podacha == "3" && priyom == "1")
                        {
                            Fet.xp -= Demonessa1.dmg;
                        }
                        if (podacha == "3" && priyom == "2")
                        {
                            Fet.xp -= Chupocabra1.dmg;
                        }
                        if (podacha == "3" && priyom == "3")
                        {
                            Fet.xp -= Slut1.dmg;
                        }
                        if (podacha == "3" && priyom == "4")
                        {
                            Fet.xp -= Maffioze1.dmg;
                        }
                        if (podacha == "4" && priyom == "1")
                        {
                            Robot.xp -= Demonessa1.dmg;
                        }
                        if (podacha == "4" && priyom == "2")
                        {
                            Robot.xp -= Chupocabra1.dmg;
                        }
                        if (podacha == "4" && priyom == "3")
                        {
                            Robot.xp -= Slut1.dmg;
                        }
                        if (podacha == "4" && priyom == "4")
                        {
                            Robot.xp -= Maffioze1.dmg;
                        }
                    }
                    turn = false;
                }
                if (turn == false)
                {
                    Console.Clear();
                    Console.WriteLine(team_1 + "                                                                             " + team_2);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Demonessa1.name + "                                                                             " + Mag.name);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("xp : " + Demonessa1.xp + "                                                                               " + "xp : " + Mag.xp);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("урон : " + Demonessa1.dmg + "                                                                             " + "урон : " + Mag.dmg);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("скиллы : " + Demonessa1.mp + "                                                                          " + "скиллы : " + Mag.mp);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("броня : " + Demonessa1.armor + "                                                                             " + "броня : " + Mag.armor);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Mag.name + "                                                                                   " + Gem.name);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("xp : " + Chupocabra1.xp + "                                                                               " + "xp : " + Gem.xp);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("урон : " + Chupocabra1.dmg + "                                                                             " + "урон : " + Gem.dmg);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("скиллы : " + Chupocabra1.mp + "                                                                          " + "скиллы : " + Gem.mp);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("броня : " + Chupocabra1.armor + "                                                                             " + "броня : " + Gem.armor);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Slut1.name + "                                                                        " + Fet.name);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("xp : " + Slut1.xp + "                                                                               " + "xp : " + Fet.xp);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("урон : " + Slut1.dmg + "                                                                             " + "урон : " + Fet.dmg);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("скиллы : " + Slut1.mp + "                                                                          " + "скиллы : " + Fet.mp);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("броня : " + Slut1.armor + "                                                                             " + "броня : " + Fet.armor);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Maffioze1.name + "                                                                               " + Robot.name);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("xp : " + Maffioze1.xp + "                                                                               " + "xp : " + Robot.xp);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("урон : " + Maffioze1.dmg + "                                                                             " + "урон : " + Robot.dmg);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("скиллы : " + Maffioze1.mp + "                                                                          " + "скиллы : " + Robot.mp);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("броня : " + Maffioze1.armor + "                                                                             " + "броня : " + Robot.armor);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("ходит " + team_2);
                    Console.WriteLine("введите 1, если хотите нападать персонажем : " + Mag.name);
                    Console.WriteLine("введите 2, если хотите нападать персонажем : " + Gem.name);
                    Console.WriteLine("введите 3, если хотите нападать персонажем : " + Fet.name);
                    Console.WriteLine("введите 4, если хотите нападать персонажем : " + Robot.name);
                    podacha = Console.ReadLine();
                    while (podacha != "1" && podacha != "2" && podacha != "3" && podacha != "4")
                    {
                        Console.WriteLine("упс, произошло недопонимание, убедитесь в том, что вы написали 1, 2, 3 или 4");
                        podacha = Console.ReadLine();
                    }
                    if (podacha == "1")
                    {
                        Console.WriteLine("аттакует персонаж " + Mag.name);
                    }
                    if (podacha == "2")
                    {
                        Console.WriteLine("аттакует персонаж " + Gem.name);
                    }
                    if (podacha == "3")
                    {
                        Console.WriteLine("аттакует персонаж " + Fet.name);
                    }
                    if (podacha == "4")
                    {
                        Console.WriteLine("аттакует персонаж " + Robot.name);
                    }
                    Console.WriteLine("введите 1, если хотите аттаковать персонажа : " + Demonessa1.name);
                    Console.WriteLine("введите 2, если хотите аттаковать персонажа : " + Chupocabra1.name);
                    Console.WriteLine("введите 3, если хотите аттаковать персонажа : " + Slut1.name);
                    Console.WriteLine("введите 4, если хотите аттаковать персонажа : " + Maffioze1.name);
                    priyom = Console.ReadLine();
                    while (priyom != "1" && priyom != "2" && priyom != "3" && priyom != "4")
                    {
                        Console.WriteLine("упс, произошло недопонимание, убедитесь в том, что вы написали 1, 2, 3 или 4");
                        priyom = Console.ReadLine();
                    }
                    if (priyom == "1")
                    {
                        Console.WriteLine("аттакован персонаж " + Demonessa1.name);
                    }
                    if (priyom == "2")
                    {
                        Console.WriteLine("аттакован персонаж " + Chupocabra1.name);
                    }
                    if (priyom == "3")
                    {
                        Console.WriteLine("аттакован персонаж " + Slut1.name);
                    }
                    if (priyom == "4")
                    {
                        Console.WriteLine("аттакован персонаж " + Maffioze1.name);
                    }
                    Console.WriteLine("чтобы произвести аттаку, нажмите '1'");
                    string reshenie = Console.ReadLine();
                    while (reshenie != "1")
                    {
                        Console.WriteLine("упс, произошло недопонимание, убедитесь в том, что вы написали 1 или 2");
                        reshenie = Console.ReadLine();
                    }
                    if (reshenie == "1")
                    {
                        if (podacha == "1" && priyom == "1")
                        {
                            Demonessa1.xp -= Mag.dmg;
                        }
                        if (podacha == "1" && priyom == "2")
                        {
                            Demonessa1.xp -= Gem.dmg;
                        }
                        if (podacha == "1" && priyom == "3")
                        {
                            Demonessa1.xp -= Fet.dmg;
                        }
                        if (podacha == "1" && priyom == "4")
                        {
                            Demonessa1.xp -= Robot.dmg;
                        }
                        if (podacha == "2" && priyom == "1")
                        {
                            Chupocabra1.xp -= Mag.dmg;
                        }
                        if (podacha == "2" && priyom == "2")
                        {
                            Chupocabra1.xp -= Gem.dmg;
                        }
                        if (podacha == "2" && priyom == "3")
                        {
                            Chupocabra1.xp -= Fet.dmg;
                        }
                        if (podacha == "2" && priyom == "4")
                        {
                            Chupocabra1.xp -= Robot.dmg;
                        }
                        if (podacha == "3" && priyom == "1")
                        {
                            Slut1.xp -= Mag.dmg;
                        }
                        if (podacha == "3" && priyom == "2")
                        {
                            Slut1.xp -= Gem.dmg;
                        }
                        if (podacha == "3" && priyom == "3")
                        {
                            Slut1.xp -= Fet.dmg;
                        }
                        if (podacha == "3" && priyom == "4")
                        {
                            Slut1.xp -= Robot.dmg;
                        }
                        if (podacha == "4" && priyom == "1")
                        {
                            Maffioze1.xp -= Mag.dmg;
                        }
                        if (podacha == "4" && priyom == "2")
                        {
                            Maffioze1.xp -= Gem.dmg;
                        }
                        if (podacha == "4" && priyom == "3")
                        {
                            Maffioze1.xp -= Fet.dmg;
                        }
                        if (podacha == "4" && priyom == "4")
                        {
                            Maffioze1.xp -= Robot.dmg;
                        }
                    }
                    turn = true;
                }
            }
        }
    }
}


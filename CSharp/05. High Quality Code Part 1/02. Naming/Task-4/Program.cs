﻿namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class minite
    {
        static void Main(string[] аргументи)
        {
            const int Max = 35;
            
            string command = string.Empty;
            char[,] field = GetParameters.CreatePlayingField();
            char[,] bombs = GetParameters.SetBombs();
            int counter = 0;
            bool isDetonated = false;
            List<PointsHolder> topPlayers = new List<PointsHolder>(6);
            int row = 0;
            int col = 0;
            bool flag = true;
            bool flag2 = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    Drawer.DrawBoard(field);
                    flag = false;
                }

                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        RangList(topPlayers);
                        break;
                    case "restart":
                        field = GetParameters.CreatePlayingField();
                        bombs = GetParameters.SetBombs();
                        Drawer.DrawBoard(field);
                        isDetonated = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                tisinahod(field, bombs, row, col);
                                counter++;
                            }
                            if (Max == counter)
                            {
                                flag2 = true;
                            }
                            else
                            {
                                Drawer.DrawBoard(field);
                            }
                        }
                        else
                        {
                            isDetonated = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (isDetonated)
                {
                    Drawer.DrawBoard(bombs);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
                        "Daj si niknejm: ", counter);
                    string niknejm = Console.ReadLine();
                    PointsHolder t = new PointsHolder(niknejm, counter);

                    if (topPlayers.Count < 5)
                    {
                        topPlayers.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < topPlayers.Count; i++)
                        {
                            if (topPlayers[i].Points < t.Points)
                            {
                                topPlayers.Insert(i, t);
                                topPlayers.RemoveAt(topPlayers.Count - 1);
                                break;
                            }
                        }
                    }
                    topPlayers.Sort((PointsHolder firstRang, PointsHolder secondRang) => secondRang.Name.CompareTo(firstRang.Name));
                    topPlayers.Sort((PointsHolder firstRang, PointsHolder secondRang) => secondRang.Points.CompareTo(firstRang.Points));
                    RangList(topPlayers);

                    field = GetParameters.CreatePlayingField();
                    bombs = GetParameters.SetBombs();           
                    counter = 0;
                    isDetonated = false;
                    flag = true;
                }
                if (flag2)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    Drawer.DrawBoard(bombs);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string imeee = Console.ReadLine();
                    PointsHolder to4kii = new PointsHolder(imeee, counter);
                    topPlayers.Add(to4kii);
                    RangList(topPlayers);
                    field = GetParameters.CreatePlayingField();
                    bombs = GetParameters.SetBombs();          
                    counter = 0;
                    flag2 = false;
                    flag = true;
                }
            }

            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void RangList(List<PointsHolder> to4kii)
        {
            Console.WriteLine("\nTo4KI:");

            if (to4kii.Count > 0)
            {
                for (int i = 0; i < to4kii.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, to4kii[i].Name, to4kii[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void tisinahod(char[,] POLE,
            char[,] BOMBI, int RED, int KOLONA)
        {
            char kolkoBombi = kolko(BOMBI, RED, KOLONA);
            BOMBI[RED, KOLONA] = kolkoBombi;
            POLE[RED, KOLONA] = kolkoBombi;
        }
        
   


        private static void smetki(char[,] pole)
        {
            int kol = pole.GetLength(0);
            int red = pole.GetLength(1);

            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < red; j++)
                {
                    if (pole[i, j] != '*')
                    {
                        char kolkoo = kolko(pole, i, j);
                        pole[i, j] = kolkoo;
                    }
                }
            }
        }

        private static char kolko(char[,] r, int rr, int rrr)
        {
            int brojkata = 0;
            int reds = r.GetLength(0);
            int kols = r.GetLength(1);

            if (rr - 1 >= 0)
            {
                if (r[rr - 1, rrr] == '*')
                {
                    brojkata++;
                }
            }
            if (rr + 1 < reds)
            {
                if (r[rr + 1, rrr] == '*')
                {
                    brojkata++;
                }
            }
            if (rrr - 1 >= 0)
            {
                if (r[rr, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }
            if (rrr + 1 < kols)
            {
                if (r[rr, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr - 1 >= 0) && (rrr - 1 >= 0))
            {
                if (r[rr - 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr - 1 >= 0) && (rrr + 1 < kols))
            {
                if (r[rr - 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr + 1 < reds) && (rrr - 1 >= 0))
            {
                if (r[rr + 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr + 1 < reds) && (rrr + 1 < kols))
            {
                if (r[rr + 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }
            return char.Parse(brojkata.ToString());
        }
    }
}

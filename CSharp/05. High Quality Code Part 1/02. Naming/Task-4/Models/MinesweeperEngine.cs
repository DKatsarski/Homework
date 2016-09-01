using System;
using System.Collections.Generic;

namespace Minesweeper
{
    public static class MinesweeperEngine
    {
        public static void GameStart()
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
            bool newGameStarted = true;
            bool gameSolved = false;

            do
            {
                if (newGameStarted)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    Drawer.DrawBoard(field);
                    newGameStarted = false;
                }

                Console.Write("Daj red i kolona sys space mejdu tqh: ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row < field.GetLength(0) && col < field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        RangList.ShowRangList(topPlayers);
                        break;
                    case "restart":
                        field = GetParameters.CreatePlayingField();
                        bombs = GetParameters.SetBombs();
                        Drawer.DrawBoard(field);
                        isDetonated = false;
                        newGameStarted = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":

                        if (bombs[row, col] != '*')
                        {

                            if (bombs[row, col] == '-')
                            {
                                Drawer.UpdateSelectedPoint(field, bombs, row, col);
                                counter++;
                            }

                            if (Max == counter)
                            {
                                gameSolved = true;
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
                    RangList.ShowRangList(topPlayers);

                    field = GetParameters.CreatePlayingField();
                    bombs = GetParameters.SetBombs();
                    counter = 0;
                    isDetonated = false;
                    newGameStarted = true;
                }

                if (gameSolved)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    Drawer.DrawBoard(bombs);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string imeee = Console.ReadLine();
                    PointsHolder to4kii = new PointsHolder(imeee, counter);
                    topPlayers.Add(to4kii);
                    RangList.ShowRangList(topPlayers);
                    field = GetParameters.CreatePlayingField();
                    bombs = GetParameters.SetBombs();
                    counter = 0;
                    gameSolved = false;
                    newGameStarted = true;
                }
            }

            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }
    }
}

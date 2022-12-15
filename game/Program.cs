using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class Program
    {
        static char[][] Map;
        static int HP = 30;
        static int strenght = 5;
        static int box = 0;
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Нажмите Enter, чтобы начать новую игру");
                ConsoleKey answer = Console.ReadKey(true).Key;
                if (answer == ConsoleKey.Enter)
                {
                    Map = GenerateMap();
                    break;
                }

            }

            ConsoleKey action = ConsoleKey.T;
            while (action != ConsoleKey.Escape)
            {
                UpdateMap();
                if (HP <= 0) break;
                action = Console.ReadKey(true).Key;
                Move(Map, action);
            }
            Console.WriteLine($"Вы проиграли. Количество шагов:{box}");
        }
        public static char[][] GenerateMap()
        {

            char[][] map = new char[25][];
            for (int i = 0; i < map.GetLength(0); i++)
            {
                map[i] = new char[map.GetLength(0) * 2];
            }
            for (int i = 0; i < map.GetLength(0); i++)
            {
                if (i == 0 || i == map.GetLength(0) - 1)
                {
                    for (int j = 0; j < map[i].Length; j++)
                    {
                        map[i][j] = '|';
                    }

                }
                else
                {
                    for (int j = 1; j < map[i].Length - 1; j++)
                        map[i][j] = ' ';
                    map[i][0] = '|';
                    map[i][map[i].Length - 1] = '|';
                }

            }
            Random rnd = new Random();
            map[(map.GetLength(0) - 1) / 2][(map[0].Length - 1) / 2] = 'P';
            byte Enemy = 0;
            int[] coordinates;
            while (Enemy < 10)
            {
                coordinates = new int[2] { rnd.Next(1, map.GetLength(0) - 2), rnd.Next(1, map[0].Length - 2) };
                if ((map[coordinates[0]][coordinates[1]] != 'P' || map[coordinates[0]][coordinates[1]] != 'E') && Enemy <= 10)
                {
                    map[coordinates[0]][coordinates[1]] = 'E';
                    Enemy++;
                }

            }
            byte healingstuffcount = 0;
            while (healingstuffcount < 5)
            {
                coordinates = new int[2] { rnd.Next(1, map.GetLength(0) - 2), rnd.Next(1, map[0].Length - 2) };
                if ((map[coordinates[0]][coordinates[1]] != 'P' || map[coordinates[0]][coordinates[1]] != 'E' || map[coordinates[0]][coordinates[1]] != 'H') && healingstuffcount <= 5)
                {
                    map[coordinates[0]][coordinates[1]] = 'H';
                    healingstuffcount++;
                }
            }
            byte bufferscount = 0;
            while (bufferscount < 3)
            {
                coordinates = new int[2] { rnd.Next(1, map.GetLength(0) - 2), rnd.Next(1, map[0].Length - 2) };
                if ((map[coordinates[0]][coordinates[1]] != 'P' || map[coordinates[0]][coordinates[1]] != 'E' || map[coordinates[0]][coordinates[1]] != 'H' || map[coordinates[0]][coordinates[1]] != 'B') && bufferscount <= 3)
                {
                    map[coordinates[0]][coordinates[1]] = 'B';
                    bufferscount++;
                }

            }
            return map;
        }
        public static void UpdateMap()
        {
            Console.Clear();
            Console.WriteLine("Нажмите Esc для выхода из игры");
            for (int i = 0; i < Map.GetLength(0); i++)
            {
                for (int j = 0; j < Map[i].Length; j++)
                {
                    Console.Write(Map[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"HP - {HP}/30 | strenght - {strenght}");
        }


        public static char[][] Move(char[][] space, ConsoleKey direction)
        {
            ConsoleKey[] actions = new ConsoleKey[4] { ConsoleKey.W, ConsoleKey.A, ConsoleKey.S, ConsoleKey.D };
            for (int i = 0; i < space.GetLength(0); i++)
            {
                for (int j = 0; j < space[i].Length; j++)
                {
                    if (space[i][j] == 'P')
                    {

                        if ((direction == actions[0]) && space[i - 1][j] != '|')
                        {
                            if (space[i - 1][j] == 'H')
                            {
                                Healing();
                                space[i][j] = ' ';
                                space[i - 1][j] = 'P';
                            }
                            else if (space[i - 1][j] == 'E')
                            {
                                Fight();
                                space[i][j] = ' ';
                                space[i - 1][j] = 'P';
                            }
                            else if (space[i - 1][j] == 'B')
                            {
                                Buff();
                                space[i][j] = ' ';
                                space[i - 1][j] = 'P';
                            }
                            else if (space[i - 1][j] == ' ')
                            {
                                space[i][j] = ' ';
                                space[i - 1][j] = 'P';
                            }
                            box++;
                        }
                        else if ((direction == actions[1]) && space[i][j - 1] != '|')
                        {
                            if (space[i][j - 1] == 'H')
                            {
                                Healing();
                                space[i][j] = ' ';
                                space[i][j - 1] = 'P';
                            }
                            else if (space[i][j - 1] == 'E')
                            {
                                Fight();
                                space[i][j] = ' ';
                                space[i][j - 1] = 'P';
                            }
                            else if (space[i][j - 1] == 'B')
                            {
                                Buff();
                                space[i][j] = ' ';
                                space[i][j - 1] = 'P';
                            }
                            else if (space[i][j - 1] == ' ')
                            {
                                space[i][j] = ' ';
                                space[i][j - 1] = 'P';
                            }
                            box++;
                        }
                        else if ((direction == actions[2]) && space[i + 1][j] != '|')
                        {
                            if (space[i + 1][j] == 'H')
                            {
                                Healing();
                                space[i][j] = ' ';
                                space[i + 1][j] = 'P';
                            }
                            else if (space[i + 1][j] == 'E')
                            {
                                Fight();
                                space[i][j] = ' ';
                                space[i + 1][j] = 'P';
                            }
                            else if (space[i + 1][j] == 'B')
                            {
                                Buff();
                                space[i][j] = ' ';
                                space[i + 1][j] = 'P';
                            }
                            else if (space[i + 1][j] == ' ')
                            {
                                space[i][j] = ' ';
                                space[i + 1][j] = 'P';
                            }
                            box++;
                        }
                        else if ((direction == actions[3]) && space[i][j + 1] != '|')
                        {
                            if (space[i][j + 1] == 'H')
                            {
                                Healing();
                                space[i][j] = ' ';
                                space[i][j + 1] = 'P';
                            }
                            else if (space[i][j + 1] == 'E')
                            {
                                Fight();
                                space[i][j] = ' ';
                                space[i][j + 1] = 'P';
                            }
                            else if (space[i][j + 1] == 'B')
                            {
                                Buff();
                                space[i][j] = ' ';
                                space[i][j + 1] = 'P';
                            }
                            else if (space[i][j + 1] == ' ')
                            {
                                space[i][j] = ' ';
                                space[i][j + 1] = 'P';
                            }
                            box++;
                        }
                        break;

                    }
                }
            }
            return space;
        }
        public static void Fight()
        {
            int EnemyHP = 15;
            int EnemyPower = 5;
            while (EnemyHP > 0)
            {
                HP -= EnemyPower;
                EnemyHP -= strenght;
            }
        }
        public static void Healing()
        {
            if (HP <= 5)
            {
                HP += 25;
            }
            else if (HP < 30)
            {
                HP = 30;
            }
        }
        public static void Buff()
        {
            strenght += 10;
        }
        public static void Savestate()
        {

        }

    }
}

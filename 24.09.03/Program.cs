using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace _24._09._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2;
            int j = 0;
            string style = "";
            int v = 0;
            bool w = false;
            //Console.Clear();

            //█ ▓ ▒ ░

            do
            {

                //╔╗╚╝║═
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write('╔');
                for (int i = 1; i < Console.WindowWidth - 1; i++)
                {
                    Console.Write('═');
                }
                Console.Write('╗');
                for (int i = 1; i < Console.WindowHeight - 1; i++)
                {
                    Console.SetCursorPosition(Console.WindowWidth - 1, i);
                    Console.Write("║");
                }
                Console.SetCursorPosition(Console.WindowWidth - 1, Console.WindowHeight - 1);
                Console.Write('╝');
                for (int i = Console.WindowWidth - 2; i > 0; i--)
                {
                    Console.SetCursorPosition(i, Console.WindowHeight - 1);
                    Console.Write('═');
                }
                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                Console.Write('╚');
                for (int i = Console.WindowHeight - 2; i > 0; i--)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("║");
                }
                j++;
            } while (j < 1);
            Console.SetCursorPosition(0, 0);
            Console.SetCursorPosition(x, y - 2);
            // ▀ ▄ █ ─ │ ┌ ┐ └ ┘
            Console.ForegroundColor = ConsoleColor.White;

            if (v == 0)
            {
                //Új
                for (int i = x - 15; i < x + 16; i++)
                {
                    Console.SetCursorPosition(i, 5);
                    Console.Write("▄");
                }
                for (int i = x - 15; i < x + 16; i++)
                {
                    Console.SetCursorPosition(i, 6);
                    Console.Write("█");
                }
                for (int i = x - 15; i < x + 16; i++)
                {
                    Console.SetCursorPosition(i, 7);
                    Console.Write("█");
                }
                for (int i = x - 15; i < x + 16; i++)
                {
                    Console.SetCursorPosition(i, 8);
                    Console.Write("█");
                }
                for (int i = x - 15; i < x + 16; i++)
                {
                    Console.SetCursorPosition(i, 9);
                    Console.Write("▀");
                }
                Console.SetCursorPosition(x, 7);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Új");

                //Szerkesztés
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(x - 15, 10);
                Console.Write("┌");
                for (int i = x - 14; i < x + 15; i++)
                {
                    Console.SetCursorPosition(i, 10);
                    Console.Write("─");
                }
                Console.SetCursorPosition(x + 15, 10);
                Console.Write("┐");
                for (int i = 11; i < 14; i++)
                {
                    Console.SetCursorPosition(x + 15, i);
                    Console.Write("│");
                }
                Console.SetCursorPosition(x + 15, 14);
                Console.Write("┘");
                for (int i = x + 14; i > x - 15; i--)
                {
                    Console.SetCursorPosition(i, 14);
                    Console.Write("─");
                }
                Console.SetCursorPosition(x - 15, 14);
                Console.Write("└");
                for (int i = 13; i > 10; i--)
                {
                    Console.SetCursorPosition(x - 15, i);
                    Console.Write("│");
                }
                Console.SetCursorPosition(x - 5, 12);
                Console.Write("Szerkesztés");

                //Törlés
                Console.SetCursorPosition(x - 15, 15);
                Console.Write("┌");
                for (int i = x - 14; i < x + 15; i++)
                {
                    Console.SetCursorPosition(i, 15);
                    Console.Write("─");
                }
                Console.SetCursorPosition(x + 15, 15);
                Console.Write("┐");
                for (int i = 16; i < 19; i++)
                {
                    Console.SetCursorPosition(x + 15, i);
                    Console.Write("│");
                }
                Console.SetCursorPosition(x + 15, 19);
                Console.Write("┘");
                for (int i = x + 14; i > x - 15; i--)
                {
                    Console.SetCursorPosition(i, 19);
                    Console.Write("─");
                }
                Console.SetCursorPosition(x - 15, 19);
                Console.Write("└");
                for (int i = 18; i > 15; i--)
                {
                    Console.SetCursorPosition(x - 15, i);
                    Console.Write("│");
                }
                Console.SetCursorPosition(x - 2, 17);
                Console.Write("Törlés");

                //Kilépés
                Console.SetCursorPosition(x - 15, 20);
                Console.Write("┌");
                for (int i = x - 14; i < x + 15; i++)
                {
                    Console.SetCursorPosition(i, 20);
                    Console.Write("─");
                }
                Console.SetCursorPosition(x + 15, 20);
                Console.Write("┐");
                for (int i = 21; i < 24; i++)
                {
                    Console.SetCursorPosition(x + 15, i);
                    Console.Write("│");
                }
                Console.SetCursorPosition(x + 15, 24);
                Console.Write("┘");
                for (int i = x + 14; i > x - 15; i--)
                {
                    Console.SetCursorPosition(i, 24);
                    Console.Write("─");
                }
                Console.SetCursorPosition(x - 15, 24);
                Console.Write("└");
                for (int i = 23; i > 20; i--)
                {
                    Console.SetCursorPosition(x - 15, i);
                    Console.Write("│");
                }
                Console.SetCursorPosition(x - 2, 22);
                Console.Write("Kilépés");
            }
            else if (v == 1)
            {
                //Új
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(x - 15, 5);
                Console.Write("┌");
                for (int i = x - 14; i < x + 15; i++)
                {
                    Console.SetCursorPosition(i, 5);
                    Console.Write("─");
                }
                Console.SetCursorPosition(x + 15, 5);
                Console.Write("┐");
                for (int i = 6; i < 9; i++)
                {
                    Console.SetCursorPosition(x + 15, i);
                    Console.Write("│");
                }
                Console.SetCursorPosition(x + 15, 9);
                Console.Write("┘");
                for (int i = x + 14; i > x - 15; i--)
                {
                    Console.SetCursorPosition(i, 9);
                    Console.Write("─");
                }
                Console.SetCursorPosition(x - 15, 9);
                Console.Write("└");
                for (int i = 8; i > 5; i--)
                {
                    Console.SetCursorPosition(x - 15, i);
                    Console.Write("│");
                }
                Console.SetCursorPosition(x - 5, 7);
                Console.Write("Új");

                //Szerkesztés
                for (int i = x - 15; i < x + 16; i++)
                {
                    Console.SetCursorPosition(i, 10);
                    Console.Write("▄");
                }
                for (int i = x - 15; i < x + 16; i++)
                {
                    Console.SetCursorPosition(i, 11);
                    Console.Write("█");
                }
                for (int i = x - 15; i < x + 16; i++)
                {
                    Console.SetCursorPosition(i, 12);
                    Console.Write("█");
                }
                for (int i = x - 15; i < x + 16; i++)
                {
                    Console.SetCursorPosition(i, 13);
                    Console.Write("█");
                }
                for (int i = x - 15; i < x + 16; i++)
                {
                    Console.SetCursorPosition(i, 14);
                    Console.Write("▀");
                }
                Console.SetCursorPosition(x - 10, 12);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Szerkesztés");
            }
            Console.SetCursorPosition(x, 7);
            do
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            v = v > 0 ? v - 1 : 3; // Menü fel/le mozgatása
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            v = v < 3 ? v + 1 : 0;
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            w = true;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            w = true;
                            return;
                        }
                }
            } while (!w);
            

            /*switch (choice)
            {
                case "Piros":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "Zöld":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "Kék":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "Fehér":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "Cián":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "Sötét kék":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "Sötét cián":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "Sötét zöld":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "Magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
            }*/

            while (true)
            {
                //Console.SetCursorPosition(x, y);

                switch (Console.ReadKey(true).Key) 
                {
                    /*case ConsoleKey.LeftArrow:
                        if (x > 1) 
                        {
                            x--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (x < Console.WindowWidth - 2)
                        {
                            x++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (y > 1)
                        {
                            y--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (y < Console.WindowHeight - 2)
                        {
                            y++;
                        }
                        break;
                    case ConsoleKey.F5:
                        Console.ForegroundColor = ConsoleColor.Red; 
                        break;
                    case ConsoleKey.F6:
                        Console.ForegroundColor = ConsoleColor.Green; 
                        break;
                    case ConsoleKey.F7:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case ConsoleKey.F8:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case ConsoleKey.F9:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case ConsoleKey.NumPad6:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case ConsoleKey.F10:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    case ConsoleKey.F11:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case ConsoleKey.F12:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case ConsoleKey.Spacebar:
                        Console.Write(style);
                        break;
                    case ConsoleKey.Backspace:
                        Console.Clear();
                        break;
                    //█ ▓ ▒ ░
                    case ConsoleKey.F1:
                        style = "█";
                        break;
                    case ConsoleKey.F2:
                        style = "▓";
                        break;
                    case ConsoleKey.F3:
                        style = "▒";
                        break;
                    case ConsoleKey.F4:
                        style = "░";
                        break;*/
                    case ConsoleKey.Escape:
                        return;
                    default:
                        break;
                }
            }
        }
        /*static void DrawMenu(int x, ref int selectedIndex)
        {
            string[] options = { "Új", "Szerkesztés", "Törlés", "Kilépés" };

            for (int i = 0; i < options.Length; i++)
            {
                bool isSelected = (i == selectedIndex);
                DrawBlock(x, 5 + (i * 5), options[i], isSelected);
            }
        }

        static void DrawBlock(int x, int y, string text, bool selected)
        {
            if (selected)
            {

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }


            Console.SetCursorPosition(x - 15, y);
            Console.Write("┌");
            for (int i = x - 14; i < x + 15; i++)
            {
                Console.SetCursorPosition(i, y);
                Console.Write("─");
            }
            Console.SetCursorPosition(x + 15, y);
            Console.Write("┐");


            for (int i = y + 1; i < y + 4; i++)
            {
                Console.SetCursorPosition(x - 15, i);
                Console.Write("│");
                Console.SetCursorPosition(x + 15, i);
                Console.Write("│");
            }


            Console.SetCursorPosition(x - 15, y + 4);
            Console.Write("└");
            for (int i = x - 14; i < x + 15; i++)
            {
                Console.SetCursorPosition(i, y + 4);
                Console.Write("─");
            }
            Console.SetCursorPosition(x + 15, y + 4);
            Console.Write("┘");


            Console.SetCursorPosition(x - (text.Length / 2), y + 2);
            Console.Write(text);
            Console.ResetColor();
        }*/
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._09._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2;
            int v = 0;
            bool w = false;
            bool b = false;
            bool c = false;
            string style = "█";
            // █ ▓ ▒ ░
            Console.Clear();
            DrawBorder();

            do
            {

                DrawMenu(x, ref v);

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        v = v > 0 ? v - 1 : 3;
                        break;
                    case ConsoleKey.DownArrow:
                        v = v < 3 ? v + 1 : 0;
                        break;
                    case ConsoleKey.Enter:
                        w = true;
                        b = true;
                        break;
                    case ConsoleKey.Escape:
                        w = true;
                        break;
                }

            } while (!w);

            if (v == 0 && b)
            {
                c = true;
            }
            Console.Clear();
            DrawBorder();
            Console.ResetColor();
            Console.SetCursorPosition(x, y);
            while (c)
            {
                Console.SetCursorPosition(x, y);
                switch (Console.ReadKey(true).Key) 
                {
                    case ConsoleKey.UpArrow:
                        if (y > 1)
                        {
                            y--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (y < Console.WindowWidth - 1)
                        {
                            y++;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (x < Console.WindowWidth - 1)
                        {
                            x++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (x > 0)
                        {
                            x--;
                        }
                        break;
                    case ConsoleKey.F1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case ConsoleKey.F2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case ConsoleKey.F3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case ConsoleKey.F4:
                        style = "█";
                        break;
                    case ConsoleKey.F5:
                        style = "▓";
                        break;
                    case ConsoleKey.F6:
                        style = "▒";
                        break;
                    case ConsoleKey.F7:
                        style = "░";
                        break;
                    case ConsoleKey.Spacebar:
                        Console.Write(style);
                        break;
                    case ConsoleKey.Escape:
                        return;
                }
            }
        }

        static void DrawBorder()
        {
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
        }


        static void DrawMenu(int x, ref int selectedIndex)
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
            Console.SetCursorPosition(1, 1);
        }
        /*static void EditDrawing()
        {
            var files = Directory.GetFiles(saveDirectory);
            if (files.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("Nincs elérhető rajz a szerkesztéshez.");
                Console.ReadKey();
                return;
            }

            var selectedFile = SelectFile(files);
            LoadDrawing(selectedFile);
            inDrawingMode = true;
            Console.Clear();
        }

        static void DeleteDrawing()
        {
            var files = Directory.GetFiles(saveDirectory);
            if (files.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("Nincs elérhető rajz a törléshez.");
                Console.ReadKey();
                return;
            }

            var selectedFile = SelectFile(files);
            File.Delete(selectedFile);
            Console.Clear();
            Console.WriteLine("A fájl törölve lett.");
            Console.ReadKey();
        }

        static string SelectFile(string[] files)
        {
            int fileIndex = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Válassz egy rajzot:");
                for (int i = 0; i < files.Length; i++)
                {
                    if (i == fileIndex)
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    else
                        Console.ResetColor();

                    Console.WriteLine(Path.GetFileName(files[i]));
                }

                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.UpArrow && fileIndex > 0) fileIndex--;
                else if (key.Key == ConsoleKey.DownArrow && fileIndex < files.Length - 1) fileIndex++;
                else if (key.Key == ConsoleKey.Enter)
                    return files[fileIndex];
            }
        }

        static void LoadDrawing(string filePath)
        {
            rajz.Clear();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                int x = int.Parse(parts[0]);
                int y = int.Parse(parts[1]);
                char karakter = parts[2][0];
                ConsoleColor szin = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), parts[3]);
                rajz.Add((x, y, karakter, szin));
            }

            RedrawSavedDrawing();
        }

        static void SaveDrawing(string fileName)
        {
            List<string> lines = new List<string>();
            foreach (var item in rajz)
            {
                lines.Add($"{item.x},{item.y},{item.karakter},{item.szin}");
            }

            File.WriteAllLines(Path.Combine(saveDirectory, fileName), lines);
        }*/
    }
}

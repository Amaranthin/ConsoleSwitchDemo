using System;

namespace ConsoleSwitchDemo
{
    internal class Program
    {
        static void Main(string[] args) //Входната точка на всички конзолни програми
        {
            ShowMenu(); //извикваме метода показващ МЕНЮТО
            //проба Дилян

            int n = int.Parse(Console.ReadLine());

            int f = Factoriel(n);

            Console.WriteLine("Факториелът нa " + n + " е " + f);
            Console.WriteLine($"Факториелът на {n} e {f}");

            Console.ReadLine(); // demo edit ...
            //за да видим резултата преди да се затвори конзолата
        }

        static int Factoriel(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }

            return result;
        }

        static void ShowMenu()
        {
            Console.WriteLine("1) Поздрави ме");
            Console.WriteLine("2) Отпечатай квадрат");
            Console.WriteLine("3) Промени цвета на конзолата");
            Console.WriteLine("4) Правоъгълник");

            Console.Write("Вашият избор е: "); //без Line маркера остава на същия ред
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:  Greetings(); break;
                case 2:  int x = 5;  ShowSquare(x); break; 
                case 3:  ChangePenColor(); break;
                case 4:  ShowRectangle(5, 3); break;
                default: Console.WriteLine("Некоректен избор"); ShowMenu();  break;
            }

        }

        static void Greetings()
        {
            Console.Write("Въведете вашето име:");
            string name = Console.ReadLine();

            Console.Write("Вие сте мъж или жена:");
            string gender = Console.ReadLine();

            string myTitle;

            //if (gender == "мъж") myTitle = "господин"; //ако сме въвели мъж
            //else if (gender == "жена") myTitle = "госпожице"; //ако сме въвели жена
            //else myTitle = gender; //ако не е изпълнено нито едно от по-горните

            switch (gender)
            {
                case "мъж": myTitle = "господин"; break;
                case "жена": myTitle = "госпожице";  break;
                default: myTitle = gender; break;
            }

            Console.WriteLine("Здравейте " + myTitle + " " + name);
            //Console.WriteLine($"Здравейте {myTitle} {name}"); //- алтернативен начин за печатане

            ShowMenu();
        }

        static void ShowSquare(int n)
        {
            //Console.Write("Въведете големина на страната:"); //без Line ще запази на същия ред

            //int n = int.Parse(Console.ReadLine());

            string row = "";

            for (int x = 1; x <= n; x++) //за да образуваме редовете
            {
                row += "*";
            }

            for (int x = 1; x <= n; x++) //за да отпечатаме редовете
            {
                Console.WriteLine(row);
            }

            ShowMenu();
        }

        static void ChangePenColor()
        {
            Console.WriteLine("1) Син");
            Console.WriteLine("2) Червен");
            Console.WriteLine("3) Зелен");
            Console.WriteLine("4) Жълт");
            Console.WriteLine("5+) Бяло");

            Console.Write("Вашият избор е: "); 
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.ForegroundColor = ConsoleColor.Cyan; break;
                case 2: Console.ForegroundColor = ConsoleColor.Red; break;
                case 3: Console.ForegroundColor = ConsoleColor.Green; break;
                case 4: Console.ForegroundColor = ConsoleColor.Yellow; break;
                default: Console.ForegroundColor = ConsoleColor.White; break;
            }

            ShowMenu();
        }

        static void ShowRectangle(int width, int height)
        {
            Console.Write("Въведете символ:");
            string s = Console.ReadLine();

            string row = "";

            for (int x = 1; x <= width; x++) //за да образуваме редовете
            {
                row += s;
            }

            for (int x = 1; x <= height; x++) //за да отпечатаме редовете
            {
                Console.WriteLine(row);
            }

            ShowMenu();
        }

        public int Max(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }
    }
}

using System;

namespace WindowsFormsApp
{
    internal class Program
    {
        static int ReadNumber(string message)
        {
            //Console.Write(message);
            string input = Microsoft.VisualBasic.Interaction.InputBox(message, "Введите число: ");
            return Convert.ToInt32(input);
        }
        static bool IsWeekend(int dayOfWeek)
        {
            return dayOfWeek == 6 || dayOfWeek == 7; // 6 - суббота, 7 - воскресенье
        }
        static bool IsInteresting(int number)
        {
            int product = 1;
            int sum = 0;

            string numberString = number.ToString();
            for (int i = 0; i < numberString.Length; i++)
            {
                int digit = int.Parse(numberString[i].ToString());
                product *= digit;
                sum += digit;
            }

            return product % sum == 0;
        }
        static int GetQuadrant(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else
            {
                // Если точка лежит на одной из осей, возвращаем 0
                return 0;
            }
        }
        static int MakeArray(int a, int b)
        {
            int result = 0;
            if (b < 3)
            {
                MessageBox.Show("Третья цифра отсутствует");
            }
            else
            {
                int c = 1;
                for (int i = b; i > 3; i--)
                {
                    c = c * 10;
                }

                result = (a / c) % 10;
            }
            return result;
        }
        static string GetCoordinateRange(int quadrant)
        {
            string range = "";

            switch (quadrant)
            {
                case 1:
                    range = "x > 0, y > 0";
                    break;
                case 2:
                    range = "x < 0, y > 0";
                    break;
                case 3:
                    range = "x < 0, y < 0";
                    break;
                case 4:
                    range = "x > 0, y < 0";
                    break;
                default:
                    range = "Неверный номер четверти";
                    break;
            }

            return range;
        }

        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            double distance = Math.Round(Math.Sqrt(dx * dx + dy * dy), 2);
            return distance;
        }
        static double CalculateDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            double dz = z2 - z1;

            double distance = Math.Round(Math.Sqrt(dx * dx + dy * dy + dz * dz), 2);
            return distance;
        }

        static bool IsPalindrome(int number)
        {
            string numberString = number.ToString();

            // Проверяем симметричность цифр числа
            for (int i = 0; i < numberString.Length / 2; i++)
            {
                if (numberString[i] != numberString[numberString.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        static void Task1()
        {
            int x = ReadNumber("Введите первое число: ");
            int y = ReadNumber("Введите второе число: ");

            if (x > y)
            {
                MessageBox.Show("Число " + x + " больше числа " + y);
            }
            else
            {
                MessageBox.Show("Число " + y + " больше числа " + x);
            }
        }

        static void Task2()
        {
            int x = ReadNumber("Введите первое число: ");
            int y = ReadNumber("Введите второе число: ");
            int z = ReadNumber("Введите третье число: ");

            if (x > y && x > z)
            {
                MessageBox.Show("Число " + x + " больше числа " + y + " и больше числа " + z);
            }
            else if (y > x && y > z)
            {
                MessageBox.Show("Число " + y + " больше числа " + x + " и больше числа " + z);
            }
            else if (z > x && z > y)
            {
                MessageBox.Show("Число " + z + " больше числа " + x + " и больше числа " + y);
            }
            else
            {
                MessageBox.Show("У нас технические шоколадки...");
            }
        }

        static void Task3()
        {
            int x = ReadNumber("Введите число: ");

            if (x % 2 == 0)
            {
                MessageBox.Show("Число " + x + " четное");
            }
            else
            {
                MessageBox.Show("Число " + x + " нечетное");
            }
        }

        static void Task4()
        {
            int x = ReadNumber("Введите число: ");

            for (int i = 0; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    MessageBox.Show(Convert.ToString(i));
                }
            }
        }

        //HOMEWORK 26/06/23
        static void Task5()
        {
            // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
            int number = ReadNumber("Введите число: ");
            int count = number.ToString().Length;
            MessageBox.Show("Третья цифра числа: " + MakeArray(number, count));
        }
        static void Task_6() 
        {
            //  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            // Get user data and save in variable
            int num = ReadNumber("Введите 3-х значное число: ");
            int secondNum = (num/10) % 10;
            MessageBox.Show($"Вторая циферка числа: {num} равна: {secondNum}"); // using interpolations strings

        }
       
        static void Task_7() 
        {
            // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            int DayOfWeek = ReadNumber("Введите цифру, обозначающую день недели (1 - понедельник, 2 - вторник и т.д.):");
            bool isWeekend = IsWeekend(DayOfWeek);

            if (isWeekend)
            {
                MessageBox.Show("Этот день является выходным.");
            }
            else
            {
                 MessageBox.Show("Этот день не является выходным.");
            }


        }
      
        static void Task_8() 
        {
            /*  Назовём число «интересным» если его произведение цифр делится на их сумму БЕЗ остатка. Напишите программу, которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000(999 - последнее). (каждый эл-т массива – сгенерирован случайно)
                Пример для 1 элемента массива: 591, сумма: 5+9+1 = 15; произведение: 5*9*1 = 45; 45 / 15 - делится НАЦЕЛО, число "интересное"
                [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]
            */
            int[] interestingNumbers = new int[10];
            Random random = new Random();

            int count = 0;
            while (count < 10)
            {
                int number = random.Next(10, 1000);
                if (IsInteresting(number))
                {
                    interestingNumbers[count] = number;
                    count++;
                }
            }
            MessageBox.Show("Сгенерированный массив интересных чисел:\n"+ string.Join(", ", interestingNumbers));
            
        }
       
        static void task_9() 
        {
            /*
             * 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
            // причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
            // в которой находится эта точка.
             */
            int x = ReadNumber("Введите X: ");
            int y = ReadNumber("Введите Y: ");
            int quadrant = GetQuadrant(x, y);
            MessageBox.Show($"Точка находится в {quadrant} четверти плоскости.");
        }
       
        static void Task_10() 
        {
            int quadrant = ReadNumber("Введите номер четверти: ");
            string coordinateRange = GetCoordinateRange(quadrant);
            MessageBox.Show($"Диапазон координат точек в четверти {quadrant}: {coordinateRange}");
        }

        
        static void task_11() 
        {
            
            double x1 = ReadNumber("Введите X:");
            double y1 = ReadNumber("Введите Y:");

           
            double x2 = ReadNumber("Введите X2:");
            double y2 = ReadNumber("Введите Y2:");

            double distance = CalculateDistance(x1, y1, x2, y2);

            MessageBox.Show($"Расстояние между двумя точками: {distance}"  );
        }
        static void task_12() 
        {
            // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

            int N = ReadNumber("Ведите N:");

            MessageBox.Show("Таблица квадратов чисел от 1 до " + N + ":");

            for (int i = 1; i <= N; i++)
            {
                int square = i * i;
                MessageBox.Show(i + " * " + i + " = " + square);
            }
        }
        // HOMEWORK 29/06/2023 SEMINAR: 3
       
        static void home_task_1() 
        {
            /*  
             *  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
             */

            int number = ReadNumber("Введите пятизначное число: ");

            bool isPalindrome = IsPalindrome(number);

            if (isPalindrome)
            {
                MessageBox.Show("Число является палиндромом.");
            }
            else
            {
                MessageBox.Show("Число не является палиндромом.");
            }

            
        }
        static void home_task_2() 
        {
          /*
           * Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
           */
            double x1 = ReadNumber("Введите координаты первой точки X :");
            double y1 = ReadNumber("Введите координаты первой точки Y :");
            double z1 = ReadNumber("Введите координаты первой точки Z :");
            double x2 = ReadNumber("Введите координаты второй точки X :");
            double y2 = ReadNumber("Введите координаты второй точки Y :");
            double z2 = ReadNumber("Введите координаты второй точки Z :");
            double distance = CalculateDistance3D(x1, y1, z1, x2, y2, z2);
            MessageBox.Show($"Расстояние между точками: {distance}");
        }
        static void home_task_3() 
        {
            // Nапишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            int N = ReadNumber("Введите число N:");

            MessageBox.Show("Таблица кубов чисел от 1 до " + N + ":");

            for (int i = 1; i <= N; i++)
            {
                int cube = i * i * i;
                 MessageBox.Show($"{i}^3 = {cube}");
            }
        }
        static void Information() 
        {
            string msg = "xTSR ver 2.1\nПрограмма с домашними заданиями по курсу C#\nВ этом релизе всё дз с первого по 3 семинар\nАвтор: Крячко Виктор\nTelegram: https://t.me/WH3BABY\nGitHub: https://github.com/Wh3Baby";
            MessageBox.Show(msg);
        }
        [STAThread]
        private static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new MainForm());
        }

        public class MainForm : Form
        {
            public MainForm()
            {
                // CONSTRUCTOR
                InitializeComponents();
            }

            private void InitializeComponents()
            {
                // GUI STUFF
                this.Text = "xTSR 2.0";
                this.Size = new System.Drawing.Size(300, 200);

                Button task1Button = new Button();
                task1Button.Text = "Задание 1";
                task1Button.Click += (sender, e) => Task1();

                Button task2Button = new Button();
                task2Button.Text = "Задание 2";
                task2Button.Click += (sender, e) => Task2();

                Button task3Button = new Button();
                task3Button.Text = "Задание 3";
                task3Button.Click += (sender, e) => Task3();

                Button task4Button = new Button();
                task4Button.Text = "Задание 4";
                task4Button.Click += (sender, e) => Task4();

                Button task5Button = new Button();
                task5Button.Text = "Задание 5";
                task5Button.Click += (sender, e) => Task5();

                Button task6Button = new Button();
                task6Button.Text = "Задание 6";
                task6Button.Click += (sender,e) => Task_6();

                Button task7Button = new Button();
                task7Button.Text = "Задание 7";
                task7Button.Click += (sender, e) => Task_7();

                Button task8Button = new Button();
                task8Button.Text = "Задание 8";
                task8Button.Click += (sender, e) => Task_8();

                Button task9Button = new Button();
                task9Button.Text = "Задание 9";
                task9Button.Click += (sender, e) => task_9();

                Button task10Button = new Button();
                task10Button.Text = "Задание 10";
                task10Button.Click += (sender, e) => Task_10();

                Button task11Button = new Button();
                task11Button.Text = "Задание 11";
                task11Button.Click += (sender, e) => task_11();

                Button task12Button = new Button();
                task12Button.Text = "Задание 12";
                task12Button.Click += (sender, e) => task_12();

                Button homebtn_1 = new Button();
                homebtn_1.Text = "[ДЗ] # 1";
                homebtn_1.Click += (sender, e) => home_task_1();

                Button homebtn_2 = new Button();
                homebtn_2.Text = "[ДЗ] # 2";
                homebtn_2.Click += (sender, e) => home_task_2();

                Button homebtn_3 = new Button();
                homebtn_3.Text = "[ДЗ] # 3";
                homebtn_3.Click += (sender, e) => home_task_3();

                Button infoButton = new Button();
                infoButton.Text = "FAQ";
                infoButton.Click += (sender, e) => Information();


                FlowLayoutPanel panel = new();
                panel.Dock = DockStyle.Fill;
                panel.FlowDirection = FlowDirection.TopDown;

                panel.Controls.Add(task1Button);

                panel.Controls.Add(task2Button);

                panel.Controls.Add(task3Button);

                panel.Controls.Add(task4Button);

                panel.Controls.Add(task5Button);

                panel.Controls.Add(task6Button);

                panel.Controls.Add(task7Button);

                panel.Controls.Add(task8Button);

                panel.Controls.Add(task9Button);

                panel.Controls.Add(task10Button);

                panel.Controls.Add(task11Button);

                panel.Controls.Add(task12Button);

                panel.Controls.Add(homebtn_1);

                panel.Controls.Add(homebtn_2);

                panel.Controls.Add(homebtn_3);

                panel.Controls.Add(infoButton);

                this.Controls.Add(panel);
            }

            
        }
    }
}
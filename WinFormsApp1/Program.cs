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

        //ACTIAL HOMEWORK 26/06/23
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
        static bool IsWeekend(int dayOfWeek)
        {
            return dayOfWeek == 6 || dayOfWeek == 7; // 6 - суббота, 7 - воскресенье
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
        static void Information() 
        {
            string msg = "Это вторая версия проекта xTSR\nПрограмма с домашними заданиями по курсу C#\nВ этом релизе всё дз с первого по второй семинар\nЧто нового?\n[+]GUI\n[+]Универсальная функция чтения строк и перевода в int\nАвтор: Крячко Виктор\nTelegram: https://t.me/WH3BABY\nGitHub: https://github.com/Wh3Baby";
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
                InitializeComponents();
            }

            private void InitializeComponents()
            {
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
                panel.Controls.Add(infoButton);

                this.Controls.Add(panel);
            }

            
        }
    }
}
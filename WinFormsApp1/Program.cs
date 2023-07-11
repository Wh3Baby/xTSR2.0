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
                MessageBox.Show($"Число: {number} - является палиндромом.");
            }
            else
            {
                MessageBox.Show($"Число: {number} -  не является палиндромом.");
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
        // HOME WORK SEMINAR #3 entry
        static void newHome() 
        {
            /*
             * Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
                3, 5 -> 243 (3⁵)
                2, 4 -> 16
             */
            int A = ReadNumber("Введите А: ");
            int B = ReadNumber("Введите B: ");
            int result = 1;
            for (int i = 1; i <= B; i++)
            {
                result *= A;
            }

            MessageBox.Show($"Результат: {result}");

        }
        static void newHome2() 
        {
            // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            int number = ReadNumber("Введите число: ");
            int sum = 0;

            int tempNumber = Math.Abs(number); // Используем Math.Abs для получения абсолютного значения числа

            while (tempNumber > 0)
            {
                int digit = tempNumber % 10; // Получаем последнюю цифру числа
                sum += digit; // Добавляем цифру к сумме
                tempNumber /= 10; // Удаляем последнюю цифру из числа
            }

            MessageBox.Show($"Сумма цифр числа: {sum}");

        }
        static void newHome3() 
        {
            /*
             * Напишите программу, которая задаёт массив из 8 элементов в диапазоне от 10 до 1000 и выводит их на экран.
                Или массив из 8 элементов вводится с консоли (каждый элемент вводит человек)
            */
            int[] numbers = new int[8];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReadNumber($"Введите элемент {i + 1}: ");
            }

            MessageBox.Show("Элементы массива:");
            foreach (int number in numbers)
            {
                MessageBox.Show($"Элементы массива: {number}");
            }

        }
        // HOME WORK SEMINAR by 06/07/2023
        static void newHome4 ()
        {
            /*                  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
                                [345, 897, 568, 234] -> 2
            */

            int[] numbers = new int[4];
            Random random = new Random();
            int countEven = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100, 1000);
                if (numbers[i] % 2 == 0)
                {
                    countEven++;
                }
            }

            MessageBox.Show($"Массив: {string.Join(", ", numbers)}\nКоличество четных чисел: {countEven}");

        }

        static void newHome5() 
        {
            /*              Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
                            [3, 7, 23, 12] -> 19
                            [-4, -6, 89, 6] -> 0
            */
            int[] array = new int[4];
            Random random = new Random();
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 11);
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }
            MessageBox.Show($"Массив: {string.Join(", ", array)}\nСумма элементов на нечетных позициях: {sum}");

        }

        static void newHome6() 
        {
            /*          Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
                        [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
            */
            double[] array = { 3.22, 4.2, 1.15, 77.15, 65.2 };
            double min = array[0];
            double max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            double difference = max - min;

            MessageBox.Show($"Массив: {string.Join(", ", array)}\nРазница между максимальным и минимальным элементами: {difference}");

        }
        //  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
        static void hoome1() 
        {
            // 10.07.2023
            int count = 0; // init counter
            int range = ReadNumber("Введите кол-во чисел:");
            for (int i = 0; i<range; i++) 
            {
                int m = ReadNumber("Введите значение:");
                if (m > 0)
                    count++;
            }
            MessageBox.Show($"В вашем вводе\nЧисел которые больше 0\n{count}");
        }
        /*Напишите программу, которая найдёт точку пересечения двух прямых, 
         * заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/
        static void hoome2() 
        {
            // 10/07/2023
            var b1 = ReadNumber("Введите b1");
            var k1 = ReadNumber("Введите k1");
            var b2 = ReadNumber("Введите b2");
            var k2 = ReadNumber("Введите k2");
            var delta_k = k1 - k2;
            if (delta_k == 0) 
            {
                MessageBox.Show("Прямые параллельны.");
            }
            else 
            {
               var delta_b = b1 - b2; 
               var x  = delta_b / delta_k;
               var y = k1 * x +b1;
                MessageBox.Show($"Точка пересечения прямых: ({x} , {y} ");

            }


        }
        static void Information() 
        {
            string msg = "xTSR ver 2.2\nПрограмма с домашними заданиями по курсу C#\nВ этом релизе всё дз с первого по 5 семинар\nАвтор: Крячко Виктор\nTelegram: https://t.me/WH3BABY\nGitHub: https://github.com/Wh3Baby";
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
                this.Text = "xTSR 2.2";
                this.Size = new System.Drawing.Size(300, 300);


                Button nhb = new Button();
                nhb.Text = "[10.07.2023] #1";
                nhb.Click += (sender, e) => hoome1();

                Button nhb2 = new Button();
                nhb2.Text = "[10.07.2023] #2";
                nhb2.Click += (sender, e) => hoome2();

                Button infoButton = new Button();
                infoButton.Text = "FAQ";
                infoButton.Click += (sender, e) => Information();


                FlowLayoutPanel panel = new();
                panel.Dock = DockStyle.Fill;
                panel.FlowDirection = FlowDirection.TopDown;
                panel.Controls.Add(nhb);
                panel.Controls.Add(nhb2);
                panel.Controls.Add(infoButton);

                this.Controls.Add(panel);
            }

            
        }
    }
}
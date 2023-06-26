using System;

namespace WindowsFormsApp
{
    internal class Program
    {
        static int ReadNumber(string message)
        {
            //Console.Write(message);
            string input = Microsoft.VisualBasic.Interaction.InputBox(message, "������� �����: ");
            return Convert.ToInt32(input);
        }

        static int MakeArray(int a, int b)
        {
            int result = 0;
            if (b < 3)
            {
                MessageBox.Show("������ ����� �����������");
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
            int x = ReadNumber("������� ������ �����: ");
            int y = ReadNumber("������� ������ �����: ");

            if (x > y)
            {
                MessageBox.Show("����� " + x + " ������ ����� " + y);
            }
            else
            {
                MessageBox.Show("����� " + y + " ������ ����� " + x);
            }
        }

        static void Task2()
        {
            int x = ReadNumber("������� ������ �����: ");
            int y = ReadNumber("������� ������ �����: ");
            int z = ReadNumber("������� ������ �����: ");

            if (x > y && x > z)
            {
                MessageBox.Show("����� " + x + " ������ ����� " + y + " � ������ ����� " + z);
            }
            else if (y > x && y > z)
            {
                MessageBox.Show("����� " + y + " ������ ����� " + x + " � ������ ����� " + z);
            }
            else if (z > x && z > y)
            {
                MessageBox.Show("����� " + z + " ������ ����� " + x + " � ������ ����� " + y);
            }
            else
            {
                MessageBox.Show("� ��� ����������� ���������...");
            }
        }

        static void Task3()
        {
            int x = ReadNumber("������� �����: ");

            if (x % 2 == 0)
            {
                MessageBox.Show("����� " + x + " ������");
            }
            else
            {
                MessageBox.Show("����� " + x + " ��������");
            }
        }

        static void Task4()
        {
            int x = ReadNumber("������� �����: ");

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
            // �������� ���������, ������� ������� ������ ����� ��������� ����� ��� ��������, ��� ������� ����� ���. �� 10 ��������
            int number = ReadNumber("������� �����: ");
            int count = number.ToString().Length;
            MessageBox.Show("������ ����� �����: " + MakeArray(number, count));
        }
        static void Task_6() 
        {
            //  �������� ���������, ������� ��������� �� ���� ���������� ����� � �� ������ ���������� ������ ����� ����� �����.
            // Get user data and save in variable
            int num = ReadNumber("������� 3-� ������� �����: ");
            int secondNum = (num/10) % 10;
            MessageBox.Show($"������ ������� �����: {num} �����: {secondNum}"); // using interpolations strings

        }
        static bool IsWeekend(int dayOfWeek)
        {
            return dayOfWeek == 6 || dayOfWeek == 7; // 6 - �������, 7 - �����������
        }
        static void Task_7() 
        {
            // �������� ���������, ������� ��������� �� ���� �����, ������������ ���� ������, � ���������, �������� �� ���� ���� ��������.
            int DayOfWeek = ReadNumber("������� �����, ������������ ���� ������ (1 - �����������, 2 - ������� � �.�.):");
            bool isWeekend = IsWeekend(DayOfWeek);

            if (isWeekend)
            {
                MessageBox.Show("���� ���� �������� ��������.");
            }
            else
            {
                 MessageBox.Show("���� ���� �� �������� ��������.");
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
            /*  ������ ����� ����������� ���� ��� ������������ ���� ������� �� �� ����� ��� �������. �������� ���������, ������� ��������� ������ �� 10 ������������ ��������� ����� ����� �� 10 �� 1000(999 - ���������). (������ ��-� ������� � ������������ ��������)
                ������ ��� 1 �������� �������: 591, �����: 5+9+1 = 15; ������������: 5*9*1 = 45; 45 / 15 - ������� ������, ����� "����������"
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
            MessageBox.Show("��������������� ������ ���������� �����:\n"+ string.Join(", ", interestingNumbers));
            
        }
        static void Information() 
        {
            string msg = "��� ������ ������ ������� xTSR\n��������� � ��������� ��������� �� ����� C#\n� ���� ������ �� �� � ������� �� ������ �������\n��� ������?\n[+]GUI\n[+]������������� ������� ������ ����� � �������� � int\n�����: ������ ������\nTelegram: https://t.me/WH3BABY\nGitHub: https://github.com/Wh3Baby";
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
                task1Button.Text = "������� 1";
                task1Button.Click += (sender, e) => Task1();

                Button task2Button = new Button();
                task2Button.Text = "������� 2";
                task2Button.Click += (sender, e) => Task2();

                Button task3Button = new Button();
                task3Button.Text = "������� 3";
                task3Button.Click += (sender, e) => Task3();

                Button task4Button = new Button();
                task4Button.Text = "������� 4";
                task4Button.Click += (sender, e) => Task4();

                Button task5Button = new Button();
                task5Button.Text = "������� 5";
                task5Button.Click += (sender, e) => Task5();

                Button task6Button = new Button();
                task6Button.Text = "������� 6";
                task6Button.Click += (sender,e) => Task_6();

                Button task7Button = new Button();
                task7Button.Text = "������� 7";
                task7Button.Click += (sender, e) => Task_7();

                Button task8Button = new Button();
                task8Button.Text = "������� 8";
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
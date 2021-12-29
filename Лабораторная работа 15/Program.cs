using System;
using System.Threading;
using System.Diagnostics;
using System.Reflection;
using System.IO;
namespace Лабораторная_работа_15
{
    class Program
    {
        static object locker = new object();
        static void Main(string[] args)
        {
            //1.
            TimerCallback timer = new TimerCallback(Smile);
            Timer timer2 = new Timer(timer, null, 0, 10001);
            foreach (Process proc in Process.GetProcesses())
            {
                try
                {
                    Console.WriteLine($"Id: {proc.Id}");
                    Console.WriteLine($"Name: {proc.ProcessName}");
                    Console.WriteLine($"Priority: {proc.PriorityClass}");
                    Console.WriteLine($"Start: {proc.StartTime}");
                    Console.WriteLine($"Responding: {proc.Responding}");

                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Name: {proc.ProcessName} {ex.Message}");
                }

                Console.WriteLine("-------------------------------------------------");
            }
            //2.
            AppDomain domain = AppDomain.CurrentDomain;
            Console.WriteLine($"Name: {domain.FriendlyName}");
            Console.WriteLine($"ApplicationBase: {domain.SetupInformation.ApplicationBase}");
            Console.WriteLine($"TargetFrameworkName: {domain.SetupInformation.TargetFrameworkName}");
            foreach (Assembly x in domain.GetAssemblies())
            {
                Console.WriteLine(x.GetName().FullName);
            }
            //3
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Введите число до которого будет идти счёт:");
            int number1 = int.Parse(Console.ReadLine());
            Thread thread1 = new Thread(new ParameterizedThreadStart(YourNumbers));
            thread1.Name = "NumberThread";
            thread1.Start(number1);
            //4
            int number2 = int.Parse(Console.ReadLine());


            Thread thread2 = new Thread(new ParameterizedThreadStart(EvenAndOdd));
            thread2.Name = "EvenNumberThread";
            thread2.Priority = ThreadPriority.Normal;
            Console.WriteLine($"Поток:{thread2.Name} Приоритет:{thread2.Priority}");
            thread2.Start(number2);

            Thread thread3 = new Thread(new ParameterizedThreadStart(EvenAndOdd));
            thread3.Name = "OddNumberThread";
            thread3.Priority = ThreadPriority.Highest;
            Console.WriteLine($"Поток:{thread3.Name} Приоритет:{thread3.Priority}");
            thread3.Start(number2);
        }
        public static void Smile(object NoParametr)
        {
            Console.WriteLine("(-_-)");

        }
        public static void YourNumbers(object n)
        {
            string writePath = "numbers.txt";
            Thread t = Thread.CurrentThread;
            for (int i = 1; i <= (int)n; i++)
            {

                Console.WriteLine(i);
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(i);
                }

                if (i == (int)n)
                {
                    Console.WriteLine($"Имя потока: {t.Name}");

                    Console.WriteLine($"Запущен ли поток: {t.IsAlive}");
                    Console.WriteLine($"Приоритет потока: {t.Priority}");
                    Console.WriteLine($"Статус потока: {t.ThreadState}");
                }

                Thread.Sleep(150);

            }
        }
        public static void EvenAndOdd(object n)
        {
            string writePath = "Allnumbers.txt";
            Thread t = Thread.CurrentThread;
            lock (locker)
            {
                for (int i = 1; i <= (int)n; i++)
                {
                    if (t.Name == "EvenNumberThread")
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                            {
                                sw.WriteLine(i);
                            }
                        }

                        Thread.Sleep(50);
                    }

                    if (t.Name == "OddNumberThread")
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(i);
                            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                            {
                                sw.WriteLine(i);
                            }
                        }
                        Thread.Sleep(100);
                    }

                }
            }
        }
    }
}


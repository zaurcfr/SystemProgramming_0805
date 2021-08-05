using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace SystemProgramming_0805
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Mutex

            //int i = 0;

            //Mutex mutex = new Mutex();

            //Thread th1 = new Thread(() =>
            //{
            //    for (; i < 1000; i++)
            //    {
            //        mutex.WaitOne();
            //        Console.WriteLine($"\t{i}");
            //        mutex.ReleaseMutex();
            //    }
            //});

            //Thread th2 = new Thread(() =>
            //{
            //    for (; i < 1000; i++)
            //    {
            //        mutex.WaitOne();
            //        Console.WriteLine($"\t\t{i}");
            //        mutex.ReleaseMutex();
            //    }
            //});

            //Thread th3 = new Thread(() =>
            //{
            //    for (int j = 2000; j < 3000; j++)
            //    {
            //        Console.WriteLine($"{j}");
            //    }
            //});

            //th1.Start();
            //th2.Start();
            //th3.Start();

            #endregion

            #region Lock

            //int i = 0;

            //var obj = new object();

            //Thread th1 = new Thread(() =>
            //{
            //    for (; i < 1000;)
            //    {
            //        lock (obj)
            //        {
            //            Console.WriteLine($"\t{i++}");
            //        }
            //    }
            //});

            //Thread th2 = new Thread(() =>
            //{
            //    for (; i < 1000;)
            //    {
            //        lock (obj)
            //        {
            //            Console.WriteLine($"\t\t{i++}");
            //        }
            //    }
            //});

            //Thread th3 = new Thread(() =>
            //{
            //    for (int j = 2000; j < 3000; j++)
            //    {
            //        Console.WriteLine($"{j}");
            //    }
            //});

            //th1.Start();
            //th2.Start();
            ////th3.Start();

            #endregion

            #region Task

            //var t = Task.Run(() =>
            //{
            //    return "aa";
            //});

            //Console.WriteLine(t.Result);

            //Task.Run(() =>
            //{
            //    for (int i = 0; i < 1000; i++)
            //    {
            //        Console.WriteLine($"\t{i}");
            //    }
            //});

            //Task.Run(() =>
            //{
            //    for (int i = 1000; i < 2000; i++)
            //    {
            //        Console.WriteLine($"\t\t{i}");
            //    }
            //});

            //for (int i = 0; i < 3000; i++)
            //{
            //    Console.WriteLine("");
            //}

            Task<string> task = File.ReadAllTextAsync("C:\\Users\\cefe_a8xp\\source\\repos\\SystemProgramming_0805\\SystemProgramming_0805\\test.txt");

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }

            Task.Run(() =>
            {
                for (int i = 1000; i < 2000; i++)
                {
                    Console.WriteLine($"\t\t{i}");
                }
            });

            Console.WriteLine(task.Result);

            //Console.WriteLine(File.ReadAllText("C:\\Users\\cefe_a8xp\\source\\repos\\SystemProgramming_0805\\SystemProgramming_0805\\test.txt"));


            #endregion

        }
    }
}

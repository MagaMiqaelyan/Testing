using System;
using System.Collections.Concurrent;
using System.Threading;

namespace Testing
{
    public static class Myclass
    {
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }       

    internal class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        [ThreadStatic]
        public static int _field;

        private static void function1()
        {
            Myclass.Message("In Function 1.");
            function2();
        }

        private static void function2()
        {
            Myclass.Message("In Function 2.");
        }
              
        private static void Main(string[] args)
        {
            //Myclass.Message("In Main function.");
            //function1();
            //Console.ReadKey();

            //int[][] matrix = new int[3][];
            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    matrix[i] = new int[3]; // Create inner array
            //    for (int j = 0; j < matrix[i].Length; j++)
            //        matrix[i][j] = i * 3 + j;
            //}
            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    for (int j = 0; j < matrix[i].Length; j++)
            //    {
            //        Console.Write(matrix[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            //int n = 0;
            //var up = Task.Run(() =>
            //{
            //    for (int i = 0; i < 1000000; i++)
            //        n++;
            //});
            //for (int i = 0; i < 1000000; i++)
            //    n--;
            //up.Wait();
            //Console.WriteLine(n);

            //int isInUse = 15;
            //if (Interlocked.Exchange(ref isInUse, 1) == 0)
            //{
            //    Console.WriteLine(isInUse);
            //}
            //int a=11, b=15;
            //Interlocked.CompareExchange(ref isInUse, a, b);
            //Console.WriteLine(isInUse);

            //ConcurrentBag<int> bag = new ConcurrentBag<int>();
            //bag.Add(42);
            //bag.Add(21);
            //int result;
            //if (bag.TryTake(out result))
            //    Console.WriteLine(result);
            //if (bag.TryPeek(out result))
            //    Console.WriteLine("There is a next item: {0}", result);

            //BlockingCollection<string> col = new BlockingCollection<string>();
            //Task read = Task.Run(() =>
            //{
            //    while (true)
            //    {
            //        Console.WriteLine(col.Take());
            //    }
            //});

            //Task write = Task.Run(() =>
            //{
            //    while (true)
            //    {
            //        string s = Console.ReadLine();
            //        if (string.IsNullOrWhiteSpace(s))
            //        {
            //            break;
            //        }

            //        col.Add(s);
            //    }
            //});
            //write.Wait();

            //Task<int[]> parent = Task.Run(() =>
            //{
            //    var results = new int[3];
            //    new Task(() => results[0] = 0, TaskCreationOptions.AttachedToParent).Start();
            //    new Task(() => results[1] = 1, TaskCreationOptions.AttachedToParent).Start();
            //    new Task(() => results[2] = 2, TaskCreationOptions.AttachedToParent).Start();
            //    return results;
            //});
            //var finalTask = parent.ContinueWith(
            //parentTask =>
            //{
            //    foreach (int i in parentTask.Result)
            //    {
            //        Console.WriteLine(i);
            //    }
            //});
            //finalTask.Wait();


            //new Thread(() =>
            //{
            //    for (int x = 0; x < 10; x++)
            //    {
            //        _field++;
            //        Console.WriteLine("Thread A: {0}", _field);
            //    }
            //}).Start();
            //new Thread(() =>
            //{
            //    for (int x = 0; x < 10; x++)
            //    {
            //        _field++;
            //        Console.WriteLine("Thread B: {0}", _field);
            //    }
            //}).Start();
            //Console.ReadKey();

            //Thread t = new Thread(new ThreadStart(ThreadMethod));
            //t.IsBackground = true;
            //t.Start();

            //Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            //t.Start(5);
            //t.Join();

            //bool stopped = false;
            //Thread t = new Thread(new ThreadStart(() =>
            //{
            //    while (!stopped)
            //    {
            //        Console.WriteLine("Running...");
            //        Thread.Sleep(1000);
            //    }
            //}));
            //t.Start();
            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();
            //stopped = true;
            //t.Join();

        }
    }
}


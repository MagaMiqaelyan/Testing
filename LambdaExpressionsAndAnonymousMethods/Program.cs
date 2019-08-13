using System.Collections.Generic;

namespace LambdaExpressionsAndAnonymousMethods
{
    internal class Program
    {
        private static IEnumerable<int> Fibs(int fibCount)
        {
            for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++)
            {
                yield return prevFib;
                int newFib = prevFib + curFib;
                prevFib = curFib;
                curFib = newFib;
            }
        }
        private static void Main(string[] args)
        {
            //foreach (int fib in Fibs(6))
            //    Console.Write(fib + " ");

            ///333
            //Action[] actions1 = new Action[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    actions1[i] = () => Console.Write(i);
            //}
            //foreach (Action a in actions1)
            //{
            //    a();
            //}

            ///012
            //Action[] actions2 = new Action[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    int loopScopedi = i;
            //    actions2[i] = () => Console.Write(loopScopedi);
            //}
            //foreach (Action a in actions2)
            //{
            //    a();
            //}

            ///Func with Anonymous Method
            //Func<int> getRandomNumber = delegate ()
            //{
            //    Random rnd = new Random();
            //    return rnd.Next(1, 100);
            //};
            //Console.WriteLine(getRandomNumber());

            ///Func with lambda expression
            //Func<int> getRandomNumber = () => new Random().Next(1, 100);

        }
    }
}

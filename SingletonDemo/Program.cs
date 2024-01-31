using System.Net.Http.Headers;

namespace SingletonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(() =>
            {
                var instance = SingletonService.Instance(1);
            });

            Thread t2 = new Thread(() =>
            {
                var instance = SingletonService.Instance(2);
            });

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }


    }
}

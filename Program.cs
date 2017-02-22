using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedThreadPool
{
    class Program
    {
        static int mainCount;
        static int threadCount;
        
        static void Main(string[] args)
        {
            if (args == null || args.Length < 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Недостаточно входных данных");
            }

            mainCount = Convert.ToInt32(args[0]);
            threadCount = Convert.ToInt32(args[1]);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("run.exe {0} {1}", mainCount, threadCount);

            Console.ReadKey();
        }
    }
}

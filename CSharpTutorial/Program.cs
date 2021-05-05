using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharpTutorial
{

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i ++)
            {
                var StopWatch = new StopWatch();

                StopWatch.Start();
                System.Threading.Thread.Sleep(1000);
                StopWatch.Stop();
                Console.WriteLine(StopWatch.DisplayDuration());
            }
        }
    }
    
}

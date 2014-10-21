using System;
using log4net;

namespace Logging
{
    class MainClass
    {
        static readonly ILog log = LogManager.GetLogger(typeof(MainClass));

        public static void Main(string[] args)
        {
            Console.WriteLine("sdf");
            log.Info("Hello World!");
            Console.ReadLine();
        }
    }
}

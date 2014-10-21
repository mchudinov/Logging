using System;
using log4net;

namespace Logging
{
    class MainClass
    {
        static readonly ILog log = LogManager.GetLogger(typeof(MainClass));

        public static void Main(string[] args)
        {
            log.Info("Hello World!");
            log.InfoFormat("Hello {0}", "World!");
            log.Debug("Hello Debugging World!");
            log.Error("Hello Error World!");
            Console.ReadLine();
        }
    }
}

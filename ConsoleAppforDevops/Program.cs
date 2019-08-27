using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppforDevops
{
    class Program
    {
        private static Logger logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {



        }
    }


    public class BusinessRepo1
    {
        private static Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public BusinessRepo1()
        {
            logger.Info("deleteCmTest success");
        }
        

    }

    public class BusinessRepo2
    {
        private static Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public BusinessRepo2()
        {
            logger.Info("deleteCmTest success");
        }


    }
}

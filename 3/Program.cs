using System;
using Logger;

namespace ProgLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Log log = new Log();
            log.info("Information Test");
            log.emergency("Emergency Test");
            log.alert("Alert Test");
            log.critical("Critical Test");
            log.error("Error test");
            log.warning("Warning Test");
            log.notice("Notice Test");
            log.debug("Debug Test");

            log.generate("D:/");
        }
    }
}
using System;
namespace Mosh_Part2.oop
{
    public class DBMigrator
    {
        private LoggerComposition Logger;

        public DBMigrator(LoggerComposition logger)
        {
            this.Logger = logger;
        }

        public void StartMigrate()
        {
            //do something and log reports
            Logger.Log();
        }


    }
}

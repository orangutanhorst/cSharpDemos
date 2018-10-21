using System;

namespace Extensibility
{
    public class DBMigrator
    {

        // this concept is called dependency injection !
        private readonly ILogger _logger;

        public DBMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);

            // Details to be implemented

            _logger.LogInfo("Migration finished at " + DateTime.Now);
        }

    }
}
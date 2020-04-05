using System;

namespace Backoffice.Adapters.Database.Configurations
{
    public class QueriesDatabaseConfiguration
    {
        private string connectionString;

        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Connection string cannot be null or empty.");

                connectionString = value;
            }
        }
    }
}

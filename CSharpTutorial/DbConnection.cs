using System;

namespace CSharpTutorial
{
    public abstract class DbConnection
    {
        private string ConnectionString { get; set; }
        private TimeSpan Timeout { get; set; }

        public DbConnection(string connection)
        {
            if (string.IsNullOrEmpty(connection))
                throw new NullReferenceException();

            this.ConnectionString = connection;
        }

        public abstract void Open();
        public abstract void Close();

    }

}

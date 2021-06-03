using System;

namespace CSharpTutorial
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

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

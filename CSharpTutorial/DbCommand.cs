using System;

namespace CSharpTutorial
{
    class DbCommand
    {
        public DbConnection Connection { get; set; }
        public string Instructions { get; set; }

        public DbCommand(DbConnection connection)
        {
            if (connection == null)
                throw new NullReferenceException();

            this.Connection = connection;

            if (String.IsNullOrEmpty(connection.ConnectionString))
            {
                throw new NullReferenceException();
            }
            else if (connection.ConnectionString == new SqlConnection("Sql").ConnectionString)
            {
                this.Instructions = "T-SQL Instructions to the database";
            }
            else
            {
                this.Instructions = "Other instructions";
            }
        }

        public void OpenConnection()
        {
            Connection.Open();
        }

        public void RunInstructions()
        {
            Console.WriteLine(this.Instructions);
        }

        public void CloseConnection()
        {
            Connection.Close();
        }
    }

}

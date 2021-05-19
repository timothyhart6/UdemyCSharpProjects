namespace CSharpTutorial
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connection) : base(connection)
        {
        }

        public override void Open()
        {
            System.Console.WriteLine("Open");
        }

        public override void Close()
        {
            System.Console.WriteLine("Close");
        }
    }

}

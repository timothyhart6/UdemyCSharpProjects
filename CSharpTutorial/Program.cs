using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharpTutorial
{

    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("test SQL Connection");
            var dbCommand = new DbCommand(sqlConnection);

            dbCommand.OpenConnection();
            dbCommand.CloseConnection();
            dbCommand.RunInstructions();
        }

    }
    
}

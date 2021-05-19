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
            var sqlDbConnection = new SqlConnection("Test");
            sqlDbConnection.Open();
            sqlDbConnection.Close();

            var oracle = new OracleConnection("Test");

            oracle.Open();
            oracle.Close();
        }

    }
    
}

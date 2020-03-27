using DesafioFramework.Dal.Abstract;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Dal.Concrete
{
    public class ConnectionDb : IConnectionDb
    {
        public MySqlConnection GetDbConnection() => new MySqlConnection(ConnStringGetter.Connstring);
    }
}

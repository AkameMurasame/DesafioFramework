using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Dal.Abstract
{
    public interface IConnectionDb
    {
        MySqlConnection GetDbConnection();
    }
}

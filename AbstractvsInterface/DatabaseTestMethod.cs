using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractvsInterface
{
    //Abstractionda ilk yaklaşım bir metodun tekrarlandığı görülüyorsa base e çekilmesi burdaki durum baseDb classı oluşturuldu.
    public class BaseDb
    {
        public DataTable ExecuteSql(string sql)
        {
            //generate sql
            return new DataTable();
        }
    }
    public class SqlServerDb:BaseDb
    {
        public string GetDbVersion() => "SqlServer 2024";
        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WITH(NOLOCK) WHERE ID={id}";
        }
        
    }

    public class OracleDb: BaseDb
    {
        public string GetDbVersion() => "Oracle Server 2024";
        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WITH(NOLOCK) WHERE ID={id}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractvsInterface
{
    //Abstractionda ilk yaklaşım bir metodun tekrarlandığı görülüyorsa base e çekilmesi burdaki durum baseDb classı oluşturuldu.
    //Abstractlarda interfacelere nazaran içerisinde kod yazılabilmesi

    public  abstract class BaseDb
    {
        public abstract string GetDbVersion();

        public DataTable ExecuteSql(string sql)
        {
            //generate sql
            return new DataTable();
        }
    }

    public class  MySqlDb:BaseDb
    {
        public  override string GetDbVersion() => "MySql Db";
        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS  WHERE ID={id}";
        }

    }
    public class SqlServerDb:BaseDb
    {
        public override string  GetDbVersion() => "SqlServer 2024";
        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WITH(NOLOCK) WHERE ID={id}";
        }
        
    }
    public class OracleDb: BaseDb
    {
        public override string GetDbVersion() => "Oracle Server 2024";
        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS  WHERE  USER_ID={id}";
        }
    }
}

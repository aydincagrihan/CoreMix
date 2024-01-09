

//Interface->Aggrement(sözleşme)-CanAbleTo-Birşey yapabilme yeteneği

using AbstractvsInterface;

var sqlDb = new SqlServerDb();
sqlDb.ExecuteSql("");

var oracleDb=new OracleDb();
oracleDb.ExecuteSql("");
var ver = oracleDb.GetDbVersion();

var car=new Car();
car.Go();
car.Stop();

var plane=new Plane();
plane.Go();
plane.Stop();
plane.Soar();


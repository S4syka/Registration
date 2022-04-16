using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DatabaseHelper;

namespace DBToWebConnection {
  public  class DBConnection {
    private Database _database;
    public DBConnection(string ConnectionString) {
      _database = new Database(ConnectionString);
    }

    public  bool IsRegistered(string UserName, string Password) {
      SqlParameter userNameParameter = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
      userNameParameter.Value = UserName;
      SqlParameter passwordParameter = new SqlParameter("@PasswordHash", SqlDbType.BigInt);
      passwordParameter.Value = Password.GetHashCode();

      using(var reader = _database.ExecuteReader("GetUser_SP", CommandType.StoredProcedure, userNameParameter, passwordParameter)) {
        if (reader.Read()) return true;
        return false;
      }
    }

    public void Register(string UserName, string Password) {
      
      SqlParameter userNameParameter = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
      userNameParameter.Value = UserName;
      SqlParameter passwordParameter = new SqlParameter("@PasswordHash", SqlDbType.BigInt);
      passwordParameter.Value = Password.GetHashCode();

      object obj = _database.ExecuteReader("InsertUser_SP", CommandType.StoredProcedure, userNameParameter, passwordParameter);
    }
  }
}

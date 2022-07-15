using System.Collections.Generic;
using System.Transactions;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace CommonUitility;

public class DapperUitility
{
    public static int ExecuteNonQuery<T>(string cmdText, T lsModel)
    {   
        int result = 0;
        string connectionString = "Server=localhost;Port=5432;Database=test;UserId=admin;Password=admin";
        //解密
        using (var tranScope = new TransactionScope(TransactionScopeOption.Required,
                               new System.TimeSpan(0, 15, 0)))
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                result = conn.Execute(cmdText, lsModel);
                conn.Close();
            }

            tranScope.Complete();
        }

        return result;
    }
}
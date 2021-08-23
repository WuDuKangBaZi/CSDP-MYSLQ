using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 客成部机器人数据管理端
{
    class MySqlHelper
    {
        #region 链接MYSQL
        /// <summary>
        /// 返回MySqlConnection对象
        /// </summary>
        /// <returns></returns>
        public MySqlConnection getMysqlConn()
        {
            string connStr = "server=rm-bp1qwcy0nz49q02u89o.mysql.rds.aliyuncs.com;port=3306;user=operate;password=nXg8NATBJhBDL43hkUEdLcpgF6Czsg2H; database=csdp;SslMode=none;";
            MySqlConnection connection = new MySqlConnection(connStr);
            return connection;
        }
        #endregion

        #region 执行SQL
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sqlStr"></param>
        public void getmysqlcom(string sqlStr)
        {
            MySqlConnection connection = this.getMysqlConn();
            connection.Open();
            MySqlCommand command = new MySqlCommand(sqlStr, connection);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            connection.Dispose();
        }
        #endregion
        #region 有返回结果的执行
        /// <summary>
        /// 有返回的MYSQL
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>
        public MySqlDataReader getMySqlReader(string sqlStr)
        {
            MySqlConnection connection = this.getMysqlConn();
            connection.Open();
            MySqlCommand command = new MySqlCommand(sqlStr, connection);
            MySqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return dataReader;
        }
        #endregion
    }
}

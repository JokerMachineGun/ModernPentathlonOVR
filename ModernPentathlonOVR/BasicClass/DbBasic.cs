using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ModernPentathlonOVR.BasicClass
{
    class DbBasic
    {
        #region 全局变量
        public static SqlConnection connection;
        public static string connectionStr = @"Data Source=.\SQL;Initial Catalog=Db_ModernPentathlon;Integrated Security=True";
        #endregion

        #region 建立数据库连接
        ///<summary>
        ///建立数据库连接
        ///</summary>
        ///<returns>返回SqlConnection对象</returns>
        public static SqlConnection getConnection()
        {
            connection = new SqlConnection(connectionStr); //将SQLConnection对象与指定的数据库连接
            connection.Open();//打开数据库连接
            return connection;

        }
        #endregion

        #region 关闭数据库连接
        ///<summary>
        ///关闭与数据库的连接
        ///</summary>
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open) //判断与数据库的连接是否打开
            {
                connection.Close(); //关闭数据库的连接
                connection.Dispose(); //释放connection变量的所有空间
            }
        }
        #endregion

        #region 读取指定表中的信息
        ///<summary>
        ///读取指定表中的信息
        ///</summary>
        ///<param name="SqlStr">Sql语句</param>
        ///<returns>返回bool型</returns>
        public SqlDataReader getInformations(string SqlStr)
        {
            getConnection();    //打开与数据库的连接
            SqlCommand command = connection.CreateCommand();    //创建一个SqlCommand对象，用于执行SQL语句
            command.CommandText = SqlStr;   //获取指定的SQL语句
            SqlDataReader reader = command.ExecuteReader(); //执行SQL语名句，生成一个SqlDataReader对象
            return reader;
        }
        #endregion

        #region 执行增，删，改的操作方法
        ///<summary>
        ///执行增，删，改的操作方法
        ///</summary>
        ///<param name="SqlStr">Sql语句</param>
        public int modifyInformations(string SqlStr)
        {
            getConnection();    //打开与数据库的连接
            SqlCommand command = new SqlCommand(SqlStr, connection);    //创建一个SQLCommand对象，用于执行SQL语句
            int count = Convert.ToInt32(command.ExecuteNonQuery()); //执行SQL语句，返回受影响的行数
            command.Dispose();  //释放所有空间
            closeConnection();  //调用closeConnection方法，关闭与数据库的连接
            return count;

        }
        #endregion

        #region
        ///<summary>
        ///创建一个DataSet对象
        ///</summary>
        ///<param name="SqlStr">SQL语句</param>
        ///<param name="TableName">表名</param>
        ///<returns>返回DataSet对象</returns>
        public DataSet getDataSet(string SqlStr, string TableName)
        {
            getConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(SqlStr, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, TableName);    //通过SQLDataAdapter对象的Fill()方法，将数据表信息添加到DataSet对象中
            closeConnection();
            return ds;
        }
        #endregion
    }
}

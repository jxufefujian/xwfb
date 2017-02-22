/* 创建人：付建
 * 时间： 2016-12-10
 * 功能： 新闻类别表操作类
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Model;

namespace DAL
{
      public  class CategoryDAO
    {
        private SQLHelper sqlhelper = null;
            public CategoryDAO() {
            sqlhelper = new SQLHelper();
        }
        //查询所有的新闻类别
        public DataTable SelectAll() {
            DataTable dt = new DataTable();
            String sql = "select * from category ";
            dt = sqlhelper.ExecuteQuery(sql , CommandType.Text);
            return dt;
        }

        //添加新闻类别
        public bool Insert(string caName) {
            bool flag = false;
            String sql = "insert into category(name) value (@caName)";
            MySqlParameter[] paras = new MySqlParameter[] {
                new MySqlParameter("@caName", caName)
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }

        /// <summary>
        ///  修改类别
        /// </summary>
        /// <param name="id">类别ID</param>
        /// <param name="caName">类别名称</param>
        /// <returns></returns>
        public bool Update(Category ca)
        {
            bool flag = false;
            string sql = "update category set  name= @caName  where id= @id";
            MySqlParameter[] paras = new MySqlParameter[] {
                new MySqlParameter("@id", ca.Id),
                new MySqlParameter("@caName",ca.Name)
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }

        /// <summary>
        ///  删除类别（连同其下的新闻及新闻评论一起删除）
        /// </summary>
        /// <param name="id">类别ID</param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            bool flag = false;
            string sql = "delete from category where id=@id";
            MySqlParameter[] paras = new MySqlParameter[] {
                new MySqlParameter("@id", id)
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }


        //查询新闻查入是否存在
        public bool IsExists(string caName) {
            bool flag = false;
            string sql = "select * from category where name = '"+caName+"'";
            DataTable dt = sqlhelper.ExecuteQuery(sql, CommandType.Text);
            if (dt.Rows.Count>0)
            {
                flag = true;
            }
            return flag;

        }

    }
}

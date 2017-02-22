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
    public class CommentDAO
    {
        private SQLHelper sqlhelper = null;
        public CommentDAO()
        {
            sqlhelper = new SQLHelper();

        }

        /// <summary>
        ///  根据新闻ID取出该新闻的所有评论
        /// </summary>
        /// <param name="newsId">新闻ID</param>
        /// <returns></returns>
        public DataTable SelectByNewsId(string newsId)
        {
            DataTable dt = new DataTable();
            string sql = "select * from comment where newsId= @newsId order by createTime desc";
            MySqlParameter[] paras = new MySqlParameter[] {
            new MySqlParameter("@newsId", newsId)
           };
            dt = sqlhelper.ExecuteQuery(sql, paras, CommandType.Text);
            return dt;
        }


        /// <summary>
        ///  添加评论
        /// </summary>
        /// <param name="c">评论实体类</param>
        /// <returns></returns>
        public bool Insert(Comment c)
        {
            bool flag = false;
            string sql = "insert into comment(content,userIp, newsId) values(@content,@userIp,@newsId)";
            MySqlParameter[] paras = new MySqlParameter[] {
            new MySqlParameter("@content", c.Content),
            new MySqlParameter("@userIp", c.UserIp),
            new MySqlParameter("@newsId", c.NewsId)
           };
            int res = sqlhelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }

        /// <summary>
        ///  删除评论
        /// </summary>
        /// <param name="id">评论ID</param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            bool flag = false;
            string sql = "delete from comment where id=@id";
            MySqlParameter[] paras = new MySqlParameter[] {
            new MySqlParameter("@id",id)
           };
            int res = sqlhelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }


    }
}

/*
 * 创建人：付建
 * 创建时间：2016-12-13
 * 说明：新闻表操作类
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using Model;


namespace DAL
{
    public class NewsDAO
    {
        private SQLHelper sqlhelper;
        public NewsDAO()
        {
            sqlhelper = new SQLHelper();
        }

        #region 选择全部新闻
        /// <summary>
        /// 选择全部新闻
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            string sql = "select * from news order by createTime desc";
            dt = new SQLHelper().ExecuteQuery(sql, CommandType.Text);
            return dt;
        }
        #endregion

        #region 选择5新闻
        /// <summary>
        /// 选择全部新闻
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNewNews()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM news,category WHERE news.caid=category.id";
            dt = new SQLHelper().ExecuteQuery(sql, CommandType.Text);
            return dt;
        }
        #endregion




        #region 通过类别ID选择新闻
        /// <summary>
        ///  根据类别ID取出该类别下的所有新闻
        /// </summary>
        /// <param name="caid">类别ID</param>
        /// <returns></returns>
        public DataTable SelectByCaId(string caId)
        {
            // TODO:根据类别ID取出该类别下的所有新闻
            DataTable dt = new DataTable();
            string sql = "select * from news,category where news.caid=category.id AND caid= @caId  ";
            MySqlParameter[] paras = new MySqlParameter[] {
                new MySqlParameter("@caId", caId)
            };
            dt = sqlhelper.ExecuteQuery(sql, paras, CommandType.Text);
            return dt;
        }
        #endregion

        #region 通过新闻ID查看新闻
                /// <summary>
        ///  根据新闻ID取出该条新闻主体内容
        /// </summary>
        /// <param name="id">新闻ID</param>
        /// <returns></returns>
        public DataTable SelectById(string id)
        {
            // TODO:根据新闻ID取出该条新闻主体内容            
 
             DataTable dt = new DataTable();
  
            string sql = "select * from news where id = @id ";
            MySqlParameter[] paras = new MySqlParameter[] {
                new  MySqlParameter("@id", id)
            };
             dt  = sqlhelper.ExecuteQuery(sql, paras, CommandType.Text);

            return dt;
        }
        #endregion

        #region 通过标题查找新闻
                /// <summary>
        ///  根据标题搜索新闻
        /// </summary>
        /// <param name="title">新闻标题关键字</param>
        /// <returns></returns>
        public DataTable SelectByTitle(string title)
        {
            // TODO:根据标题搜索新闻
            DataTable dt = new DataTable();

           string sql = "select * from news,category where category.id = news.caId AND title =  @title ";
            MySqlParameter[] paras = new MySqlParameter[] {
                new  MySqlParameter("@title", title)
            };
            dt = sqlhelper.ExecuteQuery(sql, paras, CommandType.Text);
            return dt;
        }
        #endregion

        #region 通过内容查找新闻
                /// <summary>
        ///  根据内容搜索新闻
        /// </summary>
        /// <param name="content">新闻内容关键字</param>
        /// <returns></returns>
        public DataTable SelectByContent(string content)
        {
            // TODO:根据内容搜索新闻
            DataTable dt = new DataTable();

            string sql = "select * from news,category where category.id = news.caId AND news.content like '%" + content + "%'";
            MySqlParameter[] paras = new MySqlParameter[] {
                new  MySqlParameter("@content", content)
            };
            dt = sqlhelper.ExecuteQuery(sql, paras, CommandType.Text);
            return dt;
        }
        #endregion


         /// <summary>
        ///  增加新闻
        /// </summary>
        /// <param name="n">新闻实体现</param>
        /// <returns></returns>
        public bool Insert(News n)
        {
            // TODO:增加新闻
            bool flag = false;
            string sql = "insert into news(title,content, caId) values(@title,@content,@caId)";
            MySqlParameter[] paras = new MySqlParameter[] {
            new MySqlParameter("@title",n.Title),
            new MySqlParameter("@content", n.Content),
            new MySqlParameter("@caId", n.CaId)
           };
            int res = sqlhelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
   

        #region 修改新闻
         /// <summary>
        ///  修改新闻
        /// </summary>
        /// <param name="n">新闻实体类</param>
        /// <returns></returns>
        public bool Update(News  n)
        {
            // TODO:修改新闻
            bool flag = false;
            string sql = "UPDATE news set title = @title , content = @content , caid = @caId where id = @newsid ";
            MySqlParameter[] paras = new MySqlParameter[] {
                new  MySqlParameter("@title", n.Title),
                new  MySqlParameter("@content", n.Content),
                new  MySqlParameter("@caid", n.CaId),
                new  MySqlParameter("@newsid", n.Id)
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 删除新闻
                /// <summary>
        ///  删除新闻（连同其下新闻评论一起删除）
        /// </summary>
        /// <param name="id">新闻ID</param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            // TODO:删除新闻
            bool flag = false;
            string sql = "DELETE from news where id = @id";
            MySqlParameter[] paras = new MySqlParameter[] {
                new  MySqlParameter("@id", id)
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

    }
}

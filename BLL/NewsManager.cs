/*
 * 创建人：付建
 * 创建时间：2016-12-17
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;
using System.Data;
using MySql.Data.MySqlClient;

namespace BLL
{
    public class NewsManager
    {
        private NewsDAO ndao = null;
        public NewsManager()
        {
            ndao = new NewsDAO();
        }


        #region 选择全部新闻
        /// <summary>
        /// 选择全部新闻
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAll()
        {
            return ndao.SelectAll();
        }
        #endregion

        #region 选择最新5条新闻
        /// <summary>
        ///  取出最新10条新闻（所属分类、新闻标题、发布时间）
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNewNews()
        {
            return ndao.SelectNewNews();
        }
        #endregion

        #region 选择5条热点新闻
        /// <summary>
        ///  取出10条热点新闻
        /// </summary>
        /// <returns></returns>
        //public DataTable SelectHotNews()
        //{
         //  return ndao.SelectHotNews();
       // }
        #endregion

        #region 通过类别ID选择新闻
        /// <summary>
        ///  根据类别ID取出该类别下的所有新闻
        /// </summary>
        /// <param name="caid">类别ID</param>
        /// <returns></returns>
        public DataTable SelectByCaId(string caid)
        {
            return ndao.SelectByCaId(caid);
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
            return ndao.SelectById(id);
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
            return ndao.SelectByTitle(title);
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
            return ndao.SelectByContent(content);
        }
        #endregion

        #region 增加新闻
        /// <summary>
        ///  增加新闻
        /// </summary>
        /// <param name="n">新闻实体现</param>
        /// <returns></returns>
        public bool Insert(News n)
        {
            return ndao.Insert(n);
        }
        #endregion

        #region 修改新闻
        /// <summary>
        ///  修改新闻
        /// </summary>
        /// <param name="n">新闻实体类</param>
        /// <returns></returns>
        public bool Update(News n)
        {
            return ndao.Update(n);
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
            return ndao.Delete(id);
        }
        #endregion

    }
}

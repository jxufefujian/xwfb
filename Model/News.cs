/* 
 *  作者：付建
 *  创建时间：2016-12-13
 *  类说明：新闻实体类
 */
namespace Model
{
    /// <summary>
    /// 新闻实体类
    /// </summary>
    public class News
    {
        private string id;
        /// <summary>
        /// 主键，自增
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string title;
        /// <summary>
        /// 新闻标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string content;
        /// <summary>
        /// 新闻内容
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private string createTime;
        /// <summary>
        /// 新闻发表时间
        /// </summary>
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

        private string caId;
        /// <summary>
        /// 新闻所属类别ID
        /// </summary>
        public string CaId
        {
            get { return caId; }
            set { caId = value; }
        }

        public News() { }

        public News(string title, string content, string caid)
        {
            this.title = title;
            this.content = content;
            this.caId = caid;
        }

        public News(string id, string title, string content, string caid)
        {
            this.id = id;
            this.title = title;
            this.content = content;
            this.caId = caid;
        }
    }
}

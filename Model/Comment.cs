/* 
 *  ���ߣ�����
 *  ����ʱ�䣺2016-12-13
 *  ��˵������������ʵ����
 */ 
namespace Model
{
    /// <summary>
    /// ��������ʵ����
    /// </summary>
    public class Comment
    {
        private string id;
        /// <summary>
        /// ����������
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string content;
        /// <summary>
        /// ��������
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private string userIp;
        /// <summary>
        /// ������IP
        /// </summary>
        public string UserIp
        {
            get { return userIp; }
            set { userIp = value; }
        }

        private string createTime;
        /// <summary>
        /// ���۷���ʱ��
        /// </summary>
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

        private string newsId;
        /// <summary>
        /// ��������ID
        /// </summary>
        public string NewsId
        {
            get { return newsId; }
            set { newsId = value; }
        }

        public Comment()
        { }

        public Comment(string content,string userIp, string newsId)
        {
            this.content = content;
            this.userIp = userIp;
            this.newsId = newsId;
        }
    }
}

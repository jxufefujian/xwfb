/* 
 *  ���ߣ�����
 *  ����ʱ�䣺2016-12-13
 *  ��˵��������ʵ����
 */
namespace Model
{
    /// <summary>
    /// ����ʵ����
    /// </summary>
    public class News
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

        private string title;
        /// <summary>
        /// ���ű���
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
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

        private string createTime;
        /// <summary>
        /// ���ŷ���ʱ��
        /// </summary>
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

        private string caId;
        /// <summary>
        /// �����������ID
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

/* 
 *  ���ߣ�����
 *  ����ʱ�䣺2016-12-12
 *  ��˵�����������ʵ����
 */ 
namespace Model
{
    /// <summary>
    /// �������ʵ����
    /// </summary>
    public class Category
    {
        private string id;
        /// <summary>
        /// ����,����
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        /// <summary>
        /// �������
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Category(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

    }
}

/* 
 *  作者：付建
 *  创建时间：2016-12-12
 *  类说明：新闻类别实体类
 */ 
namespace Model
{
    /// <summary>
    /// 新闻类别实体类
    /// </summary>
    public class Category
    {
        private string id;
        /// <summary>
        /// 主键,自增
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        /// <summary>
        /// 类别名称
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

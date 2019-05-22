using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement.Entity
{
    /// <summary>
    /// 图书信息
    /// </summary>
    public class Book
    {
        /// <summary>
        /// 图书ID
        /// </summary>
        public string ID
        {
            get;
            set;
        }

        /// <summary>
        /// 图书名称
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// 图书价格
        /// </summary>
        public decimal Price
        {
            get;
            set;
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            get;
            set;
        }
    }
}

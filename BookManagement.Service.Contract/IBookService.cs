using BookManagement.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Service.Contract
{
    /// <summary>
    /// 图书管理服务
    /// </summary>
    public interface IBookService : IService
    {
        /// <summary>
        /// 获取图书集合
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Book>> GetBooks();

        /// <summary>
        /// 新增图书
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        Book AddBook(Book book);

        /// <summary>
        /// 修改图书
        /// </summary>
        /// <param name="book"></param>
        void UpdateBook(Book book);

        /// <summary>
        /// 删除图书
        /// </summary>
        /// <param name="ID"></param>
        void DeleteBook(string ID);
    }
}

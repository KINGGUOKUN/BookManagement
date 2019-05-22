using BookManagement.Entity;
using BookManagement.Repository.Contract;
using BookManagement.Service.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace BookManagement.Service
{
    /// <summary>
    /// 图书管理服务
    /// </summary>
    public class BookService : IBookService
    {
        #region Private Fields

        private readonly IBookRepository _bookRepository;

        #endregion

        #region Constructors

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// 获取图书集合
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _bookRepository.Get();
        }

        /// <summary>
        /// 新增图书
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public Book AddBook(Book book)
        {
            _bookRepository.Insert(book);
            _bookRepository.Save();

            return book;
        }

        /// <summary>
        /// 修改图书
        /// </summary>
        /// <param name="book"></param>
        public void UpdateBook(Book book)
        {
            _bookRepository.Update(book);
        }

        /// <summary>
        /// 删除图书
        /// </summary>
        /// <param name="ID"></param>
        public void DeleteBook(string ID)
        {
            _bookRepository.Delete(ID);
        }

        #endregion
    }
}

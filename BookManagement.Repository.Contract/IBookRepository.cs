using BookManagement.Entity;
using BookManagement.Infrusture.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement.Repository.Contract
{
    /// <summary>
    /// 图书仓储
    /// </summary>
    public interface IBookRepository : IRepository<Book>
    {
    }
}

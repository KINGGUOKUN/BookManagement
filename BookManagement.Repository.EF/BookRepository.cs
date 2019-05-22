using BookManagement.Entity;
using BookManagement.Infrusture.EF;
using BookManagement.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BookManagement.Repository.EF
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(BookContext context)
            : base(context)
        {
        }
    }
}

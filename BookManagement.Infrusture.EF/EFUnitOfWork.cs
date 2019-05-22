using BookManagement.Infrusture.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace BookManagement.Infrusture.EF
{
    /// <summary>
    /// 工作单元的EF实现
    /// </summary>
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public EFUnitOfWork(DbContext context)
        {
            _context = context;
        }

        public DbTransaction BeginTransaction()
        {
            _context.Database.BeginTransaction();

            return _context.Database.CurrentTransaction.GetDbTransaction();
        }

        public void CommitTransaction()
        {
            _context.SaveChanges();
            _context.Database.CommitTransaction();
        }

        public void RollbackTransaction()
        {
            _context.Database.RollbackTransaction();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace BookManagement.Infrusture.Contract
{
    /// <summary>
    /// 工作单元接口
    /// </summary>
    public interface IUnitOfWork
    {
        DbTransaction BeginTransaction();

        void CommitTransaction();

        void RollbackTransaction();
    }
}

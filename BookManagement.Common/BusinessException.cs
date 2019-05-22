using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement.Common
{
    /// <summary>
    /// 自定义业务异常
    /// </summary>
    public class BusinessException : Exception
    {
        public BusinessException(int hResult, string message)
            : base(message)
        {
            base.HResult = hResult;
        }
    }
}

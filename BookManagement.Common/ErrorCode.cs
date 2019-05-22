using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement.Common
{
    /// <summary>
    /// 系统异常枚举
    /// </summary>
    public enum ErrorCode
    {
        Forbidden = 403,
        NotFound = 404,
        InternalServerError = 500,
        NotImplemented = 501,
    }
}

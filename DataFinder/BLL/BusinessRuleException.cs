using System;
using System.Collections.Generic;
using System.Text;

namespace DataFinder.BLL
{
    /// <summary>
    /// пользовательское исключение
    /// </summary>
    class BusinessRuleException : Exception
    {
        public BusinessRuleException(string message) : base(message)
        {

        }
    }
}

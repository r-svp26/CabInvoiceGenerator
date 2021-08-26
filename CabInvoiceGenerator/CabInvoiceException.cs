using System;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// Exception class
    /// </summary>
    public class CabInvoiceException : Exception
    {
        /// <summary>
        /// exception type
        /// </summary>
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE,
            INVALID_DISTANCE,
            INVALID_TIME,
            NULL_RIDES,
            INVALID_USER_ID
        }
        public ExceptionType type;
        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="exceptionType"></param>
        /// <param name="message"></param>
        public CabInvoiceException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

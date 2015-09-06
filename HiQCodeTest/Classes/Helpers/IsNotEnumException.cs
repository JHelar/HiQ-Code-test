using System;
using System.Runtime.Serialization;

namespace HiQCodeTest.Classes
{
    [Serializable]
    internal class IsNotEnumException : Exception
    {
        public IsNotEnumException()
        {
        }

        public IsNotEnumException(string message) : base(message)
        {
        }

        public IsNotEnumException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IsNotEnumException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
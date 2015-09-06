using System;
using System.Runtime.Serialization;

namespace HiQCodeTest.Classes
{
    [Serializable]
    internal class IsNotCarException : Exception
    {
        public IsNotCarException()
        {
        }

        public IsNotCarException(string message) : base(message)
        {
        }

        public IsNotCarException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IsNotCarException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
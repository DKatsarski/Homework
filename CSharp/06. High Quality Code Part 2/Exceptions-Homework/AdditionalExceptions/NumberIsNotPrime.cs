namespace Exceptions_Homework
{
    using System;
    using System.Runtime.Serialization;

    public class NumberIsNotPrime : Exception
    {
        public NumberIsNotPrime()
        {
        }

        public NumberIsNotPrime(string message) : base(message)
        {
        }

        public NumberIsNotPrime(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NumberIsNotPrime(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

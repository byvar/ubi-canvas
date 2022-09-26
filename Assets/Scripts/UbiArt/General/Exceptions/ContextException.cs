using System;
using System.Runtime.Serialization;

namespace UbiArt
{
    [Serializable]
    public class ContextException : Exception
    {
        public ContextException() { }

        public ContextException(string message) : base(message) { }

        public ContextException(string message, Exception inner) : base(message, inner) { }

        protected ContextException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
using System.Runtime.Serialization;

namespace quiz
{
    [Serializable]
    public class ControlNotFoundException : Exception
    {
        public ControlNotFoundException()
        {}

        public ControlNotFoundException(string? message) : base(message)
        {}

        public ControlNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {}

        protected ControlNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {}
    }

    [Serializable]
    public class IncorrectTagException : Exception
    {
        public IncorrectTagException()
        { }

        public IncorrectTagException(string? message) : base(message)
        { }

        public IncorrectTagException(string? message, Exception? innerException) : base(message, innerException)
        { }

        protected IncorrectTagException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }

    [Serializable]
    public class NoRadioButtonChecked : Exception
    {
        public NoRadioButtonChecked()
        { }

        public NoRadioButtonChecked(string? message) : base(message)
        { }

        public NoRadioButtonChecked(string? message, Exception? innerException) : base(message, innerException)
        { }

        protected NoRadioButtonChecked(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}

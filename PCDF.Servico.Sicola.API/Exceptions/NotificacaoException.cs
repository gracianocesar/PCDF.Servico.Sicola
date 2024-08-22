using System;
using System.Runtime.Serialization;

namespace PCDF.Servico.Sicola.API.Exceptions
{
    [Serializable]
    public class NotificacaoException : Exception
    {
        public NotificacaoException()
        {
        }

        public NotificacaoException(string message)
            : base(message)
        { }

        public NotificacaoException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected NotificacaoException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}

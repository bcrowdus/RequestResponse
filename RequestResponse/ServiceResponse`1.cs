using System;
using System.Collections.Generic;

namespace RequestResponse
{
    public class ServiceResponse<TMessage> : IServiceResponse<TMessage>
        where TMessage : IServiceMessage
    {
        public ServiceResponse(TMessage message)
        {
            this.Message = message;
            this.Exceptions = new List<Exception>();
        }

        public ServiceResponse(TMessage message, Exception ex) : this(message)
        {
            this.Exceptions.Add(ex);
        }

        public ServiceResponse(TMessage message, List<Exception> exceptions) : this(message)
        {
            this.Exceptions.AddRange(exceptions);
        }

        public TMessage Message { get; set; }

        public bool HasErrors {
            get { return this.Exceptions.Count > 0; }
        }
        public List<Exception> Exceptions { get; set; }

    }
}
using System;
using System.Collections.Generic;

namespace RequestResponse
{
    public class ServiceResponse : IServiceResponse
    {
        public ServiceResponse()
        {
            this.Exceptions = new List<Exception>();
        }
        public bool HasErrors {
            get { return this.Exceptions.Count > 0; }
        }
        public List<Exception> Exceptions { get; set; }
    }
}
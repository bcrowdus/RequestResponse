using System;
using System.Collections.Generic;

namespace RequestResponse
{
    public interface IServiceResponse
    {
        bool HasErrors { get; }
        List<Exception> Exceptions { get; set; }
    }
}

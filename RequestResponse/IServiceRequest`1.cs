using System.Security.Principal;

namespace RequestResponse
{    public interface IPrincipalRequest
    {
        IPrincipal User { get; }
    }

    public interface IServiceRequest : IPrincipalRequest
    {

    }

    public interface IServiceRequest<TMessage> : IServiceRequest
        where TMessage : IServiceMessage
    {
        TMessage Message { get; }        
    }

    
}

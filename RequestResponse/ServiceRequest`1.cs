using System.Security.Principal;

namespace RequestResponse
{
    public class ServiceRequest<TMessage> : IServiceRequest<TMessage>, IPrincipalRequest
        where TMessage : IServiceMessage
    {
        public TMessage Message { get; }

        public IPrincipal User { get; }

        public ServiceRequest(TMessage message)
        {
            this.Message = message;
        }

        public ServiceRequest(TMessage message, IPrincipal user) : this(message)
        {
            this.User = user;
        }
    }
}
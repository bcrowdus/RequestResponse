
namespace RequestResponse
{
    public interface IServiceResponse<TMessage> : IServiceResponse
        where TMessage : IServiceMessage
    {
        TMessage Message { get; set; }
    }
}

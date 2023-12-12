using MediatR;

namespace ShoppingCartApi.UseCases.Behaviors
{
    public class LogingPiplineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where TResponse : IRequest<TResponse>
    {

        private readonly ILogger<LogingPiplineBehavior<TRequest, TResponse>> _logger;
        public LogingPiplineBehavior(ILogger<LogingPiplineBehavior<TRequest, TResponse>> logger)
        {
            _logger = logger;
        }
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {


            _logger.LogInformation("Start Request {@RequestName} {@DateTimeUtc} {@Request}",typeof(TRequest),DateTime.UtcNow,request);
            var result = await next();

            _logger.LogInformation("Start Request {@RequestName} {@DateTimeUtc} {@Response}", typeof(TRequest), DateTime.UtcNow, result);
            return result;


        }
    }
}

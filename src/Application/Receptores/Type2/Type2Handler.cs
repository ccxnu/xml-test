using MediatR;

public class Type2Handler : IRequestHandler<Type2Command, BaseResponse>
{
    public Task<BaseResponse> Handle(Type2Command request, CancellationToken cancellationToken)
    {
        return Task.FromResult<BaseResponse>(new Type2Response
        {
            FullMessage = $"Saludos distinguidos {request.Title} {request.Name}",
            Detail = "Este es un mensaje tipo 2",
            IsPremium = true
        });
    }
}

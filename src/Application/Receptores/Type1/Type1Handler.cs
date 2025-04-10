using MediatR;

public class Type1Handler : IRequestHandler<Type1Command, BaseResponse>
{
    public Task<BaseResponse> Handle(Type1Command request, CancellationToken cancellationToken)
    {
        return Task.FromResult<BaseResponse>(new Type1Response
        {
            Message = $"Hola {request.Name}",
            StatusCode = 200
        });
    }
}

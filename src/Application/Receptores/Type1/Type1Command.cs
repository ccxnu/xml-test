using MediatR;

public class Type1Command : IRequest<BaseResponse>
{
    public string Name { get; }

    public Type1Command(string name)
    {
        Name = name;
    }
}

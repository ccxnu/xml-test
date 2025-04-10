using MediatR;

public class Type2Command : IRequest<BaseResponse>
{
    public string Name { get; }
    public string Title { get; }

    public Type2Command(string name, string title)
    {
        Name = name;
        Title = title;
    }
}

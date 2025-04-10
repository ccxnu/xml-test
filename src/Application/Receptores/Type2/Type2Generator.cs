using MediatR;
using System.Xml.Serialization;

public class Type2CommandGenerator : ICommandGenerator
{
    public bool CanHandle(string content) => content.Contains("<Type2Request>");

    public IRequest<BaseResponse> GenerateCommand(string content)
    {
        var serializer = new XmlSerializer(typeof(Type2Request));
        using var reader = new StringReader(content);
        var request = (Type2Request)serializer.Deserialize(reader)!;
        return new Type2Command(request.Name, request.Title);
    }
}

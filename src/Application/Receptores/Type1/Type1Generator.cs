using System.Xml.Serialization;
using MediatR;

public class Type1CommandGenerator : ICommandGenerator
{
    public bool CanHandle(string content) => content.Contains("<Type1Request>");

    public IRequest<BaseResponse> GenerateCommand(string content)
    {
        var serializer = new XmlSerializer(typeof(Type1Request));
        using (var reader = new StringReader(content))
        {
            var request = (Type1Request)serializer.Deserialize(reader)!;
            return new Type1Command(request.Name);
        }
    }
}

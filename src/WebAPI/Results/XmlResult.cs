using System.Xml.Serialization;
using Microsoft.AspNetCore.WebUtilities;

namespace Microsoft.AspNetCore.Http;

static class XmlResultExtensions
{
    public static IResult Xml<T>(this IResultExtensions _resultExtensions, T data)
    {
        ArgumentNullException.ThrowIfNull(_resultExtensions, nameof(_resultExtensions));

        return new XmlResult<T>(data);
    }
}

class XmlResult<T> : IResult
{
    private static readonly XmlSerializer _serializer = new(typeof(T));
    private readonly T _data;

    public XmlResult(T data)
    {
        _data = data;
    }

    public async Task ExecuteAsync(HttpContext httpContext)
    {
        httpContext.Response.ContentType = "application/xml";

        using var stream = new FileBufferingWriteStream();
        _serializer.Serialize(stream, _data);

        await stream.DrainBufferAsync(httpContext.Response.Body);
    }
}

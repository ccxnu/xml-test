using System.Xml.Serialization;

[XmlInclude(typeof(Type1Response))]
[XmlInclude(typeof(Type2Response))]
public abstract class BaseResponse
{
    [XmlIgnore]
    public abstract string ResponseType { get; }
}

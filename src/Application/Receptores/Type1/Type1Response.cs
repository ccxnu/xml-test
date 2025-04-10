using System.Xml.Serialization;

[XmlRoot("Type1Response")]
public class Type1Response : BaseResponse
{
    public override string ResponseType => "Type1";

    [XmlElement("Saludo")]
    public string Message { get; set; } = string.Empty;

    [XmlElement("Codigo")]
    public int StatusCode { get; set; }
}

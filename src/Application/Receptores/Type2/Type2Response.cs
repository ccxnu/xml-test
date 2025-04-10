using System.Xml.Serialization;

[XmlRoot("Type2Response")]
public class Type2Response : BaseResponse
{
    public override string ResponseType => "Type2";

    [XmlElement("MensajeCompleto")]
    public string FullMessage { get; set; } = string.Empty;

    [XmlElement("Detalle")]
    public string Detail { get; set; } = string.Empty;

    [XmlElement("EsPremium")]
    public bool IsPremium { get; set; }
}

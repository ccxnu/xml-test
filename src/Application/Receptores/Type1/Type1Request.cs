using System.Xml.Serialization;

[XmlRoot("Type1Request")]
public class Type1Request
{
    [XmlElement("Name")]
    public string Name { get; set; } = string.Empty;
}

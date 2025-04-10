using System.Xml.Serialization;

[XmlRoot("Type2Request")]
public class Type2Request
{
    [XmlElement("Name")]
    public string Name { get; set; } = string.Empty;

    [XmlElement("Title")]
    public string Title { get; set; } = string.Empty;
}

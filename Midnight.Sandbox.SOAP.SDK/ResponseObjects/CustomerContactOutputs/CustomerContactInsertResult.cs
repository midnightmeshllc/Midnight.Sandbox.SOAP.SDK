using Midnight.Sandbox.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.Sandbox.SOAP.SDK.ResponseObjects.CustomerContactOutputs;

/// <summary>
/// Represents the result of inserting a customer contact in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class CustomerContactInsertResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the inserted contact.
    /// </summary>
    [XmlElement("ContactID")]
    public int ContactID { get; set; }
}

using Midnight.Sandbox.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.Sandbox.SOAP.SDK.ResponseObjects.VendorOutputs;

/// <summary>
/// Represents the result of a vendor update operation in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class VendorUpdateResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the updated vendor.
    /// </summary>
    [XmlElement("VendorId")]
    public int VendorID { get; set; }
}

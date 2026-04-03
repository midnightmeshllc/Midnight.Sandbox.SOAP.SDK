using Midnight.Sandbox.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.Sandbox.SOAP.SDK.ResponseObjects.OrderVersionDetailOutputs;

/// <summary>
/// Represents the result of inserting an order version detail in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionDetailInsertResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the inserted order version detail.
    /// </summary>
    [XmlElement("OrderVersionDetailID")]
    public int OrderVersionDetailID { get; set; }
}

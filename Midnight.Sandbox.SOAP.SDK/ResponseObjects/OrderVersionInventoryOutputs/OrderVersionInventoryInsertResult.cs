using Midnight.Sandbox.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.Sandbox.SOAP.SDK.ResponseObjects.OrderVersionInventoryOutputs;

/// <summary>
/// Represents the result of inserting an order version inventory in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionInventoryInsertResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the inserted order inventory.
    /// </summary>
    [XmlElement("OrderInventoryID")]
    public int OrderInventoryID { get; set; }
}

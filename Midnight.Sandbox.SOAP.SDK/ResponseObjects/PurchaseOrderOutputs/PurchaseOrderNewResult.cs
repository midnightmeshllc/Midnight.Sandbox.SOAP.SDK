using Midnight.Sandbox.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.Sandbox.SOAP.SDK.ResponseObjects.PurchaseOrderOutputs;

/// <summary>
/// Represents the result of a new purchase order operation in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class PurchaseOrderNewResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the newly created purchase order.
    /// </summary>
    [XmlElement("PurchaseOrderID")]
    public int PurchaseOrderID { get; set; }
}

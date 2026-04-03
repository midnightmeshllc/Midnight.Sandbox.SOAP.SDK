using Midnight.Sandbox.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.Sandbox.SOAP.SDK.ResponseObjects.InventoryOutputs;

/// <summary>
/// Represents the result of updating an inventory item in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class InventoryUpdateResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the updated inventory item.
    /// </summary>
    public int? ItemID { get; set; }
}

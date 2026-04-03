using Midnight.Sandbox.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.Sandbox.SOAP.SDK.ResponseObjects.CustomerOutputs;

/// <summary>
/// Represents the result of updating a customer in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class CustomerUpdateResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the updated customer.
    /// </summary>
    public int? CustomerID { get; set; }
}

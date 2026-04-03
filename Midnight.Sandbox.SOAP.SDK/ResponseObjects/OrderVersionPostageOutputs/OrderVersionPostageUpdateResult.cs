using Midnight.Sandbox.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.Sandbox.SOAP.SDK.ResponseObjects.OrderVersionPostageOutputs;

/// <summary>
/// Represents the result of updating an order version postage in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionPostageUpdateResult : CommonResult
{
}

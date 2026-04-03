using Midnight.Sandbox.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.Sandbox.SOAP.SDK.ResponseObjects.OrderVersionDropOutputs;

/// <summary>
/// Represents the result of deleting an order version drop in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionDropDeleteResult : CommonResult
{ 
}

using Midnight.Sandbox.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.Sandbox.SOAP.SDK.ResponseObjects.OrderOutputs;

/// <summary>
/// Represents the result of adding an attachment to an order in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderAddAttachmentResult : CommonResult
{
}

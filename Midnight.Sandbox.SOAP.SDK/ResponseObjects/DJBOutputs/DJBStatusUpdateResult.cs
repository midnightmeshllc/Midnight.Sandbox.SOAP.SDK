using Midnight.Sandbox.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.Sandbox.SOAP.SDK.ResponseObjects.DJBOutputs;

/// <summary>
/// Represents the result of updating a DJB status in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class DJBStatusUpdateResult : CommonResult
{
}

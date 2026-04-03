using Midnight.Sandbox.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.Sandbox.SOAP.SDK.ResponseObjects.JobCostOutputs;

/// <summary>
/// Represents the result of a job out operation in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class JobOutResult : CommonResult
{
}

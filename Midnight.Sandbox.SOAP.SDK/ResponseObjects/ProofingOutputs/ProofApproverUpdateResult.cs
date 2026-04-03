using Midnight.Sandbox.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.Sandbox.SOAP.SDK.ResponseObjects.ProofingOutputs;

/// <summary>
/// Represents the result of updating an approver for a proof request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class ProofApproverUpdateResult : CommonResult
{
}

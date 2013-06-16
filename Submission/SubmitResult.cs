using System.Collections.Generic;
using System.Xml.Serialization;
using GalaxyToolApi.Enums;

namespace GalaxyToolApi.Submission
{
    [XmlRoot("galaxytool")]
    public class SubmitResult : GalaxyToolResult
    {
        [XmlElement("returncode")]
        public int ReturnCode { get; set; }

        [XmlElement("message")]
        public List<ResultMessage> Messages { get; set; }

        public SubmissionResultCode ResultCode
        {
            get { return (SubmissionResultCode)ReturnCode; }
            set { ReturnCode = (int)value; }
        }

        public bool WasSuccessful
        {
            get
            {
                return ResultCode == SubmissionResultCode.GalaxyViewInserted || ResultCode == SubmissionResultCode.ReportInserted ||
                        ResultCode == SubmissionResultCode.StatsUpdated || ResultCode == SubmissionResultCode.AllyHistoryUpdated ||
                        ResultCode == SubmissionResultCode.FleetMovementUpdated || ResultCode == SubmissionResultCode.EspionageUpdated ||
                        ResultCode == SubmissionResultCode.MessageUpdated || ResultCode == SubmissionResultCode.CombatReportUpdated;
            }
        }
    }
}
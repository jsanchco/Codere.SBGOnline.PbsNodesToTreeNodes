using System.Runtime.Serialization;

namespace Codere.SBGOnline.PbsNodesToTreeNodes.Models
{
    [DataContract]
    public class CategoryInfo
    {
        [DataMember]
        public string CategoryId { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
        [DataMember]
        public bool IsRelevant { get; set; }
    }
}

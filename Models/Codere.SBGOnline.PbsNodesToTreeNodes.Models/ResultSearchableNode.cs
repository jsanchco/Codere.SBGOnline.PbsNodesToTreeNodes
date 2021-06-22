using System.Runtime.Serialization;

namespace Codere.SBGOnline.PbsNodesToTreeNodes.Models
{
    [DataContract]
    public class ResultSearchableNode : SearcheableNode
    {
        [DataMember]
        public decimal Odd { get; set; }
        [DataMember]
        public int SortOrder { get; set; }
        [DataMember]
        public string Tax { get; set; }
        public bool IsCombinable { get; set; }
        [DataMember]
        public int GameTypeResultsNr { get; set; }
    }
}

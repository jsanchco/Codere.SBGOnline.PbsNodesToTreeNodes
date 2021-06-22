using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Codere.SBGOnline.PbsNodesToTreeNodes.Models
{
    [DataContract]
    public class GameSearchableNode : SearcheableNode
    {
        [DataMember]
        public string SpecialOddsValue { get; set; }
        [DataMember]
        public CategoryInfo CategoryInfo { get; set; }
        [DataMember]
        public CategoryInfo[] CategoryInfos { get; set; }
        [DataMember]
        public Dictionary<string, CategoryInfo[]> LocalizedCategoryInfos { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public int GameTypeId { get; set; }
        [DataMember]
        public bool SmartMarketAvailable { get; set; }
    }
}

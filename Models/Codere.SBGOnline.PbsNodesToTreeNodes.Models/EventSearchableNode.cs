using Codere.SBGOnline.PbsNodesToTreeNodes.Model;
using Codere.ThirdParty.BGT.ServiceReferences.SportsBookService.BGT_SportsBookService.Objects.TransferObjects;
using System;
using System.Runtime.Serialization;

namespace Codere.SBGOnline.PbsNodesToTreeNodes.Models
{
    [DataContract]
    public class EventSearchableNode : SearcheableNode
    {
        [DataMember]
        public LiveHistoryTO LiveHistory { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public ParticipantTO[] Participants { get; set; }
        public bool IsCombinable { get; set; }
        public string StatisticsId { get; set; }
        public string StreamingEnabled { get; set; }
        public string StreamingId { get; set; }
        public bool LTMEnabled { get; set; }
        [DataMember]
        public string SmartMarketReferenceGameTypeIds { get; set; }
    }

}

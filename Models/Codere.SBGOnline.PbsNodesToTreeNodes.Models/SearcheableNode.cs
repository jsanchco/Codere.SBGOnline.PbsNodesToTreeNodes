using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Codere.SBGOnline.PbsNodesToTreeNodes.Models
{
    [KnownType(typeof(SearcheableNode))]
    [KnownType(typeof(EventSearchableNode))]
    [KnownType(typeof(GameSearchableNode))]
    [KnownType(typeof(ResultSearchableNode))]
    //[KnownType(typeof(ResultGreyhoundHorseSearchableNode))]
    //[KnownType(typeof(GameGreyhoundHorseSearchableNode))]
    //[KnownType(typeof(EventGreyhoundHorseSearchableNode))]
    [DataContract]
    public class SearcheableNode
    {
        public SearcheableNode()
        {
            LastUpdated = DateTime.Now;
            LocalizedName = new Dictionary<string, string>(3);
            LiveDeactivationDelayS = 80;
        }

        public bool Locked => !IsActive && LastUpdated > DateTime.Now.AddSeconds(LiveDeactivationDelayS * -1);
        public int LiveDeactivationDelayS { get; set; }
        public int ChildrenCount { get; set; }
        /// <summary>
        /// used to join leagues in navigation
        /// </summary>
        public int MergePriority { get; set; }
        /// <summary>
        /// used to join leagues in navigation by this id
        /// </summary>
        public string UniqueId { get; set; }
        /// <summary>
        /// used to join leagues in navigation by this id
        /// </summary>
        [DataMember]
        public string ParentUniqueId { get; set; }
        [DataMember]
        public string Parent2UniqueId { get; set; }
        [DataMember]
        public string Parent3UniqueId { get; set; }
        [DataMember]
        public bool IsLive { get; set; }
        [DataMember]
        public DateTime LastUpdated { get; set; }
        //public BaseNodeTO Node { get; set; }
        [DataMember]
        public string NodeName { get; set; }
        [DataMember]
        public string NodeId { get; set; }
        [DataMember]
        public NodeType Type { get; set; }
        public int Status { get; set; }
        //InplayType Possible values: NotRunningLive = 17000, RunningLive = 17001, Both = 17002 
        public int InplayType { get; set; }
        [DataMember]
        public virtual bool IsActive { get; set; }
        public bool IsDeletable { get; set; }
        [DataMember]
        public string SportHandle { get; set; }
        public int BookMakerId { get; set; }
        [DataMember]
        public int Priority { get; set; }
        [DataMember]
        public string CountryCode { get; set; }
        //public bool HasResults { get; set; }
        [DataMember]
        public string ParentNodeId { get; set; }
        [DataMember]
        public string ParentNodeName { get; set; }
        [DataMember]
        public int ParentNodePriority { get; set; }
        [DataMember]
        public string DisplayTypeName { get; set; }
        /// <summary>
        /// GrandParent
        /// </summary>
        [DataMember]
        public string Parent2NodeId { get; set; }
        [DataMember]
        public string Parent2NodeName { get; set; }
        [DataMember]
        public int Parent2NodePriority { get; set; }
        /// <summary>
        /// GrandGrandParent
        /// </summary>
        [DataMember]
        public string Parent3NodeId { get; set; }
        [DataMember]
        public string Parent3NodeName { get; set; }
        [DataMember]
        public int Parent3NodePriority { get; set; }
        /// <summary>
        /// GrandGrandGrandparent
        /// </summary>
        [DataMember]
        public string Parent4NodeId { get; set; }
        [DataMember]
        public string Parent4NodeName { get; set; }
        [DataMember]
        public int Parent4NodePriority { get; set; }
        [DataMember]
        public string Parent5NodeId { get; set; }
        [DataMember]
        public string Parent5NodeName { get; set; }
        [DataMember]
        public int Parent5NodePriority { get; set; }
        [DataMember]
        public string Parent6NodeId { get; set; }
        [DataMember]
        public string Parent6NodeName { get; set; }
        [DataMember]
        public int Parent6NodePriority { get; set; }
        [DataMember]
        public int EventNodeTypeId { get; set; }
        [DataMember]
        public string TypeFilterList { get; set; }
        public Dictionary<string, string> LocalizedName { get; set; }
        public Dictionary<string, string> ParentLocalizedName { get; set; }
        public Dictionary<string, string> Parent2LocalizedName { get; set; }
        public Dictionary<string, string> Parent3LocalizedName { get; set; }
        public Dictionary<string, string> Parent4LocalizedName { get; set; }
        public Dictionary<string, string> Parent5LocalizedName { get; set; }
        public Dictionary<string, string> Parent6LocalizedName { get; set; }
    }
}

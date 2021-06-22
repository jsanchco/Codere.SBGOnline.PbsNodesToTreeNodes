using System.Collections.Generic;

namespace Codere.SBGOnline.PbsNodesToTreeNodes.Models.Extensions
{
    public static class SearcheableNodeUtil
    {
        public static string GetLocalizedName(this SearcheableNode searcheableNode)
        {
            return searcheableNode.GetLocalizedName(searcheableNode.LocalizedName, searcheableNode.NodeName);
        }

        public static string GetLocalizedName(this SearcheableNode searcheableNode, IDictionary<string, string> dic, string defaultName)
        {
            //string language = Codere.SBGOnline.Common.Properties.Resources.LanguageCode;
            string language = "es";
            return searcheableNode.GetLocalizedName(dic, language, defaultName);
        }

        public static string GetLocalizedName(this SearcheableNode searcheableNode, IDictionary<string, string> dic, string language, string defaultName)
        {
            string locName = defaultName;
            if (language == "en" && !dic.ContainsKey("en"))
            {
                language = "-1";
            }

            if (!string.IsNullOrEmpty(language) && searcheableNode.LocalizedName != null)
            {
                string sName;

                var ex = dic.TryGetValue(language, out sName);
                if (ex)
                {
                    locName = sName;
                }
            }
            return null;
            //return NodeManagementHelper.CleanUpEventName(locName);
        }
    }
}

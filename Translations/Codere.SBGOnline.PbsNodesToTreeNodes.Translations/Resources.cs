using Codere.SBGOnline.PbsNodesToTreeNodes.Language;
using System.Globalization;

namespace Codere.SBGOnline.PbsNodesToTreeNodes.Translations
{
    public class Resources
    {
        private readonly CultureInfo _culture;
        public Resources(CultureInfo culture)
        {
            _culture = culture;
        }

        public string ST_BS_BET_CANCELLED => LocalizationUtils<Resources>.GetValue("ST_BS_BET_CANCELLED", _culture);
        public string ST_BS_BET_DECLINED => LocalizationUtils<Resources>.GetValue("ST_BS_BET_DECLINED", _culture);
        public string ST_BS_BET_LOST => LocalizationUtils<Resources>.GetValue("ST_BS_BET_LOST", _culture);
        public string ST_BS_BET_MANUAL => LocalizationUtils<Resources>.GetValue("ST_BS_BET_MANUAL", _culture);
        public string ST_BS_BET_OPEN => LocalizationUtils<Resources>.GetValue("ST_BS_BET_OPEN", _culture);
        public string ST_BS_BET_WON => LocalizationUtils<Resources>.GetValue("ST_BS_BET_WON", _culture);
        public string ST_GEN_DATABSE_ERROR => LocalizationUtils<Resources>.GetValue("ST_GEN_DATABSE_ERROR", _culture);
        public string _CaneBeParsed => LocalizationUtils<Resources>.GetValue("_CaneBeParsed", _culture);
        public string _not_started => LocalizationUtils<Resources>.GetValue("_not_started", _culture);
        public string _started => LocalizationUtils<Resources>.GetValue("_started", _culture);
        public string _1p => LocalizationUtils<Resources>.GetValue("_1p", _culture);
        public string _2p => LocalizationUtils<Resources>.GetValue("_2p", _culture);
        public string __1p_ot => LocalizationUtils<Resources>.GetValue("__1p_ot", _culture);

    }
}

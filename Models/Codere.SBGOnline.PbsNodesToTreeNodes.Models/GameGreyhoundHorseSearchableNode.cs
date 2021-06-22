namespace Codere.SBGOnline.PbsNodesToTreeNodes.Models
{
    public class GameGreyhoundHorseSearchableNode : GameSearchableNode
    {
        public int OddsAvailability { get; set; }
        // Corresponding enums: APIConstants.BetTypeAvailability
        /// <summary>
        /// Defines the bet types that are available for this game. Only set for horse/greyhound racing games.
        /// Possible values:  Undefined = -1, NoBet = 13000, Winner = 13001, Place = 13002, WinnerAndPlace = 13003, Forecast = 13004, ForecastAndWinner = 13005,
        ///ForecastAndPlace = 13006, ForecastAndWinnerAndPlace = 13007, Triccast = 13008,  TricastAndWinner = 13009,  TricastAndPlace = 13010,
        ///TricastAndWinenrAndPlace = 13011,TricastAndForecast = 13012, TricastAndForecastAndWinner = 13013, TricastAndForecastAndPlace = 13014,
        ///TricastAndForecastAndWinnerAndPlace = 13015, PlaceOnly = 13016,PlaceAndPlaceOnly = 13018, WinnerAndPlaceAndPlaceOnly = 13019, ForecastAndPlaceAndPlaceOnly = 13022,
        ///ForecastAndWinnerAndPlaceAndPlaceOnly = 13023, TricastAndPlaceAndPlaceOnly = 13026, TricastAndWinnerAndPlaceAndPlaceOnly= 13027, TricastAndForecastAndPlaceAndPlaceOnly = 13030,
        /// TricastAndForecastAndWinnerAndPlaceAndPlaceOnly = 13031,               
        /// </summary>
        public int BetTypeAvailability { get; set; }
        bool _isActive;
        public override bool IsActive
        {
            get
            {
                return _isActive &&
                    (IsBetTypeAvailable(GreyhoundHorseBetType.Tricast) ||
                    IsBetTypeAvailable(GreyhoundHorseBetType.Forecast) ||
                    IsBetTypeAvailable(GreyhoundHorseBetType.Place) ||
                    IsBetTypeAvailable(GreyhoundHorseBetType.Win)
                    );
            }

            set { _isActive = value; }
        }

        public bool IsBetTypeAvailable(GreyhoundHorseBetType betType)
        {
            if (BetTypeAvailability < 13001) return false;
            switch (betType)
            {
                case GreyhoundHorseBetType.Tricast:
                    return ((BetTypeAvailability - 13000) & 8) > 0;
                case GreyhoundHorseBetType.Win:
                    return ((BetTypeAvailability - 13000) & 1) > 0;
                case GreyhoundHorseBetType.Forecast:
                    return ((BetTypeAvailability - 13000) & 4) > 0;
                case GreyhoundHorseBetType.Place:
                    return ((BetTypeAvailability - 13000) & 2) > 0;
            }
            
            return false;
        }
    }
}

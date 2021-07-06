using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders.UI
{
    public class Place
    {
        #region Properties
        public int PlaceNumber { get; set; }
        public PlaceType PlaceType { get; set; }

        public Place(int placeNumber, PlaceType placeType = PlaceType.Normal)
        {
            PlaceNumber = placeNumber;
            PlaceType = placeType;
        }

        #endregion Properties
    }
}

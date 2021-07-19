using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders.UI
{
    public class GameInfo
    {
        public GameStyle GameStyle { get; set; }
        public string PlayerName1 { get; set; }
        public string PlayerName2 { get; set; }
        public string PlayerName3 { get; set; }
        public string PlayerName4 { get; set; }

        public GameInfo()
        {
            
        }

        public GameInfo(GameStyle gameStyle, string playerName1, string playerName2, string playerName3, string playerName4)
        {
            GameStyle = gameStyle;
            PlayerName1 = playerName1;
            PlayerName2 = playerName2;
            PlayerName3 = playerName3;
            PlayerName4 = playerName4;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders.UI
{
    public interface IPlayerInfo
    {
        PlayerInfo GetInfo();
    }

    public class PlayerInfo: IPlayerInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CurrentPosition { get; set; } = 0;
        public Point CurrentPoint { get; set; }
        public int CurrentDiceNumber { get; set; }
        public string CurrentStatus { get; set; }
        public bool IsStarted { get; set; } = false;

        public PlayerInfo(int id, string name, int currentPosition)
        {
            Id = id;
            Name = name;
            CurrentPosition = currentPosition;
        }

        public PlayerInfo GetInfo()
        {
            return this;
        }
    }
}

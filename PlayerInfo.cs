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
        bool IsWon();
    }

    public class PlayerInfo: IPlayerInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; } = 0;
        public int CurrentPosition { get; set; } = 0;
        public Point CurrentPoint { get; set; }
        public int CurrentDiceNumber { get; set; }
        public string CurrentStatus { get; set; }
        public bool IsStarted { get; set; } = false;
        public bool IsFinished { get; set; } = false;
        public bool SelfTurn { get; set; } = false;
        public bool IsSix { get; set; } = false;
        public PlayerInfo()
        {
            
        }

        public PlayerInfo(int id, string name, int currentPosition)
        {
            Id = id;
            Name = name;
            CurrentPosition = currentPosition;
        }

        public bool IsWon()
        {
            return this.IsFinished;
        }        

        public interface IPlayerInfoFactory
        {
            IPlayerInfo CreatePlayerInfo();
        }

        public class PlayerInfoFactory : IPlayerInfoFactory
        {
            public IPlayerInfo CreatePlayerInfo()
            {
                return new PlayerInfo();
            }
        }
    }
}

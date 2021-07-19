using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders.UI
{
    public class Game
    {
        private readonly IDiceFactory _diceFactory;
        private readonly PlayerInfo.IPlayerInfoFactory _playerInfoFactory;

        private IDice _dice;
        private IPlayerInfo _playerInfo;
        public Game(IGameFactory gameFactory)
        {
            _diceFactory = gameFactory.CreateDiceFactory();
            _playerInfoFactory = gameFactory.CreatePlayerInfoFactory();

        }

        public void Play()
        {

        }
        public void Reset()
        {
            this._dice = _diceFactory.CreateDice();
            this._playerInfo = _playerInfoFactory.CreatePlayerInfo();

        }
    }

    public interface IGameFactory
    {
        IDiceFactory CreateDiceFactory();
        PlayerInfo.IPlayerInfoFactory CreatePlayerInfoFactory();
    }

    public class GameFactory: IGameFactory
    {
        public IDiceFactory CreateDiceFactory()
        {
            return new DiceFactory();
        }

        public PlayerInfo.IPlayerInfoFactory CreatePlayerInfoFactory()
        {
            return new PlayerInfo.PlayerInfoFactory();
        }
    }
}

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

        private IDice _dice;
        public Game(IGameFactory gameFactory)
        {
            _diceFactory = gameFactory.CreateDiceFactory();

        }

        public void Reset()
        {
            this._dice = _diceFactory.CreateDice();

        }
    }

    public interface IGameFactory
    {
        IDiceFactory CreateDiceFactory();
    }

    public class GameFactory: IGameFactory
    {
        public IDiceFactory CreateDiceFactory()
        {
            return new DiceFactory();
        }
    }
}

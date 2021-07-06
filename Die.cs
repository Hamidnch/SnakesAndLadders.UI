using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders.UI
{
    public interface IDice
    {
        int Roll();
    }

    public class Dice: IDice
    {
        public int Roll()
        {
            var random = new Random();
            var diceNumber = random.Next(1, 7);
            return diceNumber;
        }
    }

    public interface IDiceFactory
    {
        IDice CreateDice();
    }

    public class DiceFactory:IDiceFactory
    {
        public IDice CreateDice()
        {
            return new Dice();
        }
    }
}

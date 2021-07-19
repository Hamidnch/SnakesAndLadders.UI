using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakesAndLadders.UI
{
    public interface IDice
    {
        int Min { get; set; }
        int Max { get; set; }
        int Value { get; set; }

        Task<int> Roll();
    }

    public class Dice: IDice
    {
        //Store number of rolls of each number
        private long[] _rolls = { 0, 0, 0, 0, 0, 0 };


        public int Min { get; set; }
        public int Max { get; set; }
        public int Value { get; set; }

        public Dice()
        {
            this.Min = 1;
            this.Max = 6;
        }

        public Dice(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public async Task<int> Roll()
        {
            await Task.Delay(500);
            var random = new Random();
            Value = random.Next(Min, Max + 1);
            return Value;
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

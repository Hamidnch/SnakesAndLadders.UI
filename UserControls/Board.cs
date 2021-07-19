using SnakesAndLadders.UI.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakesAndLadders.UI.UserControls
{
    public partial class Board : UserControl, IBoard
    {
        #region Fields

        private readonly IDice _dice;

        private int _playerCount = 5;
        private readonly PlayerInfo[] _playerInfo;
        private readonly Place[,] _places = new Place[10, 10];

        private readonly int _cellWidth;
        private readonly int _cellHeight;

        private readonly Dictionary<int, int> _ladders = new Dictionary<int, int>();
        private readonly Dictionary<int, int> _snakes = new Dictionary<int, int>();
        #endregion Fields

        #region Ctor

        #region Properties

        public int PlayerCount
        {
            get => _playerCount;
            set
            {
                _playerCount = value switch
                {
                    < 1 => 1,
                    > 4 => 4,
                    _ => _playerCount
                };

                _playerCount = value;
            }
        }

        public int Turn { get; private set; }

        //public PlayerInfo[] Players { get; set; }

        #endregion Properties
        public Board()
        {
            InitializeComponent();
            InitializeBoard();
            
            IDiceFactory diceFactory = new DiceFactory();
            _dice = diceFactory.CreateDice();

            _playerInfo = new PlayerInfo[_playerCount];
            InitializePlayer();

            this._cellWidth = (this.Width / 10) + 4;
            this._cellHeight = (this.Height / 10);
        }

        #endregion Ctor

        #region Indexers
        public Place this[int i, int j] => _places[i, j];

        #endregion Indexers
       
        #region Private Methods

        private void InitializeBoard()
        {
            var row = _places.GetUpperBound(0);
            var col = _places.GetUpperBound(1);

            for (var i = 0; i <= row; i++)
            {
                for (var j = 0; j <= col; j++)
                {
                    var currentNumber = (i * 10) + (j + 1);
                    _places[i, j] = new Place(currentNumber, PlaceType.Normal);
                }
            }
            
            //Has Ladder
            _places[0, 1] = new Place(2, PlaceType.Ladder);
            _places[0, 7] = new Place(8, PlaceType.Ladder);
            _places[1, 9] = new Place(20, PlaceType.Ladder);
            _places[3, 1] = new Place(32, PlaceType.Ladder);
            _places[4, 0] = new Place(41, PlaceType.Ladder);
            _places[7, 3] = new Place(74, PlaceType.Ladder);
            _places[8, 1] = new Place(82, PlaceType.Ladder);
            _places[8, 4] = new Place(85, PlaceType.Ladder);
            
            //Has Snake
            _places[2, 8] = new Place(29, PlaceType.Snake);
            _places[3, 7] = new Place(38, PlaceType.Snake);
            _places[4, 6] = new Place(47, PlaceType.Snake);
            _places[5, 2] = new Place(53, PlaceType.Snake);
            _places[6, 1] = new Place(62, PlaceType.Snake);
            _places[8, 5] = new Place(86, PlaceType.Snake);
            _places[9, 1] = new Place(92, PlaceType.Snake);
            _places[9, 6] = new Place(97, PlaceType.Snake);


            //Ladder Dictionary
            _ladders.Add(2, 23);
            _ladders.Add(8, 34);
            _ladders.Add(20, 77);
            _ladders.Add(32, 68);
            _ladders.Add(41, 79);
            _ladders.Add(74, 88);
            _ladders.Add(82, 100);
            _ladders.Add(85, 95);

            //Snake Dictionary
            _snakes.Add(29, 9);
            _snakes.Add(38, 15);
            _snakes.Add(47, 5);
            _snakes.Add(53, 33);
            _snakes.Add(62, 37);
            _snakes.Add(86, 54);
            _snakes.Add(92, 70);
            _snakes.Add(97, 25);
        }

        private bool HasSnake(int currentPosition)
        {
            return _places.Cast<Place>().Any(place => place.PlaceType == PlaceType.Snake && place.PlaceNumber == currentPosition);
        }
        private bool HasLadder(int currentPosition)
        {
            foreach (var place in _places)
            {
                if (place.PlaceType == PlaceType.Ladder && place.PlaceNumber == currentPosition)
                    return true;
            }

            return false;
        }

        private int GetDestinationBySnakeOrLatter(int currentPosition)
        {
            if (HasLadder(currentPosition))
            {
                return _ladders[currentPosition];
            }

            return HasSnake(currentPosition) ? _snakes[currentPosition] : 0;
        }
        private void InitializePlayer()
        {
            for (var i = 0; i < _playerCount; i++)
            {
                _playerInfo[i] = new PlayerInfo(i + 1, $"Player{i}", 0);
            }
        }
        #endregion Private Methods

        #region Public Methods

        public async Task<PlayerInfo> ThrowUpDice(int playerId)
        {
            this.Turn = playerId;
            //var random = new Random();
            var diceNumber = await _dice.Roll(); //random.Next(1, 7);
            var playerInfo = _playerInfo[playerId];
            playerInfo.Id = playerId;
            playerInfo.CurrentDiceNumber = diceNumber;
            var currentPosition = playerInfo.CurrentPosition + diceNumber;
            
            if (diceNumber == 6)
            {
                playerInfo.IsSix = true;
            }
            
            if (playerInfo.IsStarted)
            {
                playerInfo.CurrentPosition = currentPosition;
            }
            else if (playerInfo.IsSix && !playerInfo.IsStarted && !playerInfo.IsFinished)
            {
                playerInfo.IsStarted = true;
                playerInfo.CurrentPosition = 1;
                //playerInfo.CurrentPlace = 
                var agent = new Agent(playerId);

                agent.SetImage(playerId switch
                {
                    0 => Resources.Yellow,
                    1 => Resources.Red,
                    2 => Resources.Blue,
                    3 => Resources.Brown,
                    4 => Resources.Purple,
                    _ => Resources.Green
                });

                var offset = _cellWidth / 7;
                agent.Location = new Point(this.Left + offset, this.Height - _cellHeight);
                this.Controls.Add(agent);
                agent.BringToFront();
                agent.Show();
            }

            //else if (playerInfo.IsStarted && playerInfo.IsSix && !playerInfo.IsFinished)
            //{
            //    playerInfo.SelfTurn = true;
            //}

            return playerInfo;
        }

        public PlayerInfo MovePiece(PlayerInfo playerInfo)
        {
            var cell = playerInfo.CurrentPosition;
            //var row = cell / 10;
            var col = cell % 10;

            if (cell % 10 == 0) col = 10;

            var offsetX = ((this.Width) / 10) / 7;
            var offsetY = ((this.Height) / 10);

            var pos = new Point();
            var str = string.Empty;
            var startPositionX = this.Left + offsetX;  //24
            var startPositionY = this.Height;
            var g = 0;
            switch (cell)
            {
                case > 90:
                    g = cell - 90;
                    pos.X = startPositionX + (Math.Abs(10 - col) * this._cellWidth);
                    pos.Y = startPositionY - ((10 * _cellHeight) + 38);
                    str +=
                        $"Case 90 => dice: {playerInfo.CurrentDiceNumber}, position: {playerInfo.CurrentPosition}, cell: {cell}, col: {col}, posX = {pos.X} and posY = {pos.Y}, cell width: {_cellWidth}, cell height: {_cellHeight}";
                    break;
                case > 80:
                    g = cell - 80;
                    pos.X = startPositionX + ((col - 1) * this._cellWidth);
                    pos.Y = startPositionY - ((9 * _cellHeight) + 30);
                    str +=
                        $"Case 80 => dice: {playerInfo.CurrentDiceNumber}, position: {playerInfo.CurrentPosition}, cell: {cell}, col: {col}, posX = {pos.X} and posY = {pos.Y}, cell width: {_cellWidth}, cell height: {_cellHeight}";
                    break;
                case > 70:
                    g = cell - 70;
                    pos.X = startPositionX + (Math.Abs(10 - col) * this._cellWidth);
                    pos.Y = startPositionY - ((8 * _cellHeight) + 28);
                    str +=
                        $"Case 70 => dice: {playerInfo.CurrentDiceNumber}, position: {playerInfo.CurrentPosition}, cell: {cell}, col: {col}, posX = {pos.X} and posY = {pos.Y}, cell width: {_cellWidth}, cell height: {_cellHeight}";
                    break;
                case > 60:
                    g = cell - 60;
                    pos.X = startPositionX + ((col - 1) * this._cellWidth);
                    pos.Y = startPositionY - ((7 * _cellHeight) + 25);
                    str +=
                        $"Case 60 => dice: {playerInfo.CurrentDiceNumber}, position: {playerInfo.CurrentPosition}, cell: {cell}, col: {col}, posX = {pos.X} and posY = {pos.Y}, cell width: {_cellWidth}, cell height: {_cellHeight}";
                    break;
                case > 50:
                    g = cell - 50;
                    pos.X = startPositionX + (Math.Abs(10 - col) * _cellWidth);
                    pos.Y = startPositionY - ((6 * _cellHeight) + 18);
                    str +=
                        $"Case 50 => dice: {playerInfo.CurrentDiceNumber}, position: {playerInfo.CurrentPosition}, cell: {cell}, col: {col}, posX = {pos.X} and posY = {pos.Y}, cell width: {_cellWidth}, cell height: {_cellHeight}";
                    break;
                case > 40:
                    pos.X = startPositionX + ((col - 1) * _cellWidth);
                    pos.Y = startPositionY - ((5 * _cellHeight) + 15);
                    str +=
                        $"Case 40 => dice: {playerInfo.CurrentDiceNumber}, position: {playerInfo.CurrentPosition}, cell: {cell}, col: {col}, posX = {pos.X} and posY = {pos.Y}, cell width: {_cellWidth}, cell height: {_cellHeight}";
                    break;
                case > 30:
                    pos.X = startPositionX + (Math.Abs(10 - col) * _cellWidth);
                    pos.Y = startPositionY - ((4 * _cellHeight) + 10);
                    str +=
                        $"Case 30 => dice: {playerInfo.CurrentDiceNumber}, position: {playerInfo.CurrentPosition}, cell: {cell}, col: {col}, posX = {pos.X} and posY = {pos.Y}, cell width: {_cellWidth}, cell height: {_cellHeight}";
                    break;
                case > 20:
                    pos.X = startPositionX + ((col - 1) * _cellWidth);
                    pos.Y = startPositionY - ((3 * _cellHeight) + 7);
                    str +=
                        $"Case 20 => dice: {playerInfo.CurrentDiceNumber}, position: {playerInfo.CurrentPosition}, cell: {cell}, col: {col}, posX = {pos.X} and posY = {pos.Y}, cell width: {_cellWidth}, cell height: {_cellHeight}";
                    break;
                case > 10:
                    pos.X = startPositionX + (Math.Abs(10 - col) * _cellWidth);
                    pos.Y = startPositionY - ((2 * _cellHeight));
                    str +=
                        $"Case 10 => dice: {playerInfo.CurrentDiceNumber}, position: {playerInfo.CurrentPosition}, cell: {cell}, col: {col}, posX = {pos.X} and posY = {pos.Y}, cell width: {_cellWidth}, cell height: {_cellHeight}";
                    break;
                default:
                    pos.X = startPositionX + ((col - 1) * _cellWidth);
                    pos.Y = startPositionY - ((1 * _cellHeight) - 5);
                    str +=
                        $"Default => dice: {playerInfo.CurrentDiceNumber}, position: {playerInfo.CurrentPosition}, cell: {cell}, col: {col}, posX = {pos.X} and posY = {pos.Y}, cell width: {_cellWidth}, cell height: {_cellHeight}";
                    break;
            }

            playerInfo.CurrentPoint = pos;

            if (playerInfo.IsStarted && playerInfo.CurrentPosition != 1)
            {
                foreach (var control in this.Controls)
                {
                    if (control is Agent agent)
                    {
                        if (agent.PlayerId == playerInfo.Id)
                        {
                            agent.Location = playerInfo.CurrentPoint;
                            var currentPosition = GetDestinationBySnakeOrLatter(playerInfo.CurrentPosition);

                            if (playerInfo.CurrentPosition >= 100)
                            {
                                playerInfo.IsFinished = true;
                                agent.Dispose();
                            }

                            if (currentPosition > 0)
                            {
                                playerInfo.Id = agent.PlayerId;
                                playerInfo.CurrentPosition = currentPosition;
                                Thread.Sleep(100);
                                MovePiece(playerInfo);
                            }
                            //if (HasSnake(playerInfo.CurrentPosition))
                            //{
                            //    MessageBox.Show("Bite by snake ....");
                            //}

                        }
                    }
                }
            }
            playerInfo.CurrentStatus = str;

            return playerInfo;
        }

        #endregion Public Methods
    }
}

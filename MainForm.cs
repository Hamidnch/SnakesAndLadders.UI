using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnakesAndLadders.UI.Helpers;
using SnakesAndLadders.UI.Properties;

namespace SnakesAndLadders.UI
{
    public partial class MainForm : Form
    {
        private readonly Bitmap[] _faces = new Bitmap[7];
        private readonly SoundPlayer _musicPlayer = new();
        
        public MainForm()
        {
            InitializeComponent();
            _faces[1] = new Bitmap(Resources.dice1);
            _faces[2] = new Bitmap(Resources.dice2);
            _faces[3] = new Bitmap(Resources.dice3);
            _faces[4] = new Bitmap(Resources.dice4);
            _faces[5] = new Bitmap(Resources.dice5);
            _faces[6] = new Bitmap(Resources.dice6);
            _musicPlayer.Stream = Resources.diceVoice;
        }

        private void EnableDisableDice(int diceNumber)
        {
            btn_Dice4.Enabled = true;
            btn_Dice3.Enabled = true;
            btn_Dice2.Enabled = true;
            btn_Dice1.Enabled = true;
            var turn = board1.Turn;
            label1.Text = turn.ToString();

            if (turn == 0 && diceNumber == 6)
            {
                btn_Dice4.Enabled = false;
                btn_Dice3.Enabled = false;
                btn_Dice2.Enabled = false;
                btn_Dice1.Enabled = false;
                lbl_DiceComputer.Enabled = true;
            }
            else if (turn == 1 && diceNumber == 6)
            {
                btn_Dice4.Enabled = false;
                btn_Dice3.Enabled = false;
                btn_Dice2.Enabled = false;
                btn_Dice1.Enabled = true;
                lbl_DiceComputer.Enabled = false;
            }

            //switch (UtilityHelper.GameInfo.GameStyle)
            //{
            //    case GameStyle.OnePlayer:
            //        btn_Dice1.Enabled = true;
            //        break;
            //    case GameStyle.TwoPlayer:
            //        btn_Dice2.Enabled = true;
            //        btn_Dice1.Enabled = false;
            //        break;
            //    case GameStyle.ThreePlayer:
            //        btn_Dice3.Enabled = false;
            //        btn_Dice2.Enabled = false;
            //        btn_Dice1.Enabled = true;
            //        break;
            //    case GameStyle.FourPlayer:
            //        btn_Dice4.Enabled = false;
            //        btn_Dice3.Enabled = false;
            //        btn_Dice2.Enabled = false;
            //        btn_Dice1.Enabled = true;
            //        break;
            //    default:
            //        throw new ArgumentOutOfRangeException();
            //}
        }

        private async Task<int> RollDiceAndMoveAgent(int playerId)
        {
            var info = await board1.ThrowUpDice(playerId);
            var status = board1.MovePiece(info).CurrentStatus;
            listBox1.Items.Add($"Player Id: {playerId}," + status);
            if (info.IsWon())
            {
                MessageBox.Show($"The Player won with number {info.Id} !");
            }
            return info.CurrentDiceNumber;

            //lbl_Dice.Text = info.CurrentDiceNumber.ToString();
            //pb_Dice.Image = new Bitmap(_faces[info.CurrentDiceNumber]);
            //listBox1.Items.Add(board1.MovePiece(info).CurrentStatus);
            //btn_Dice1.Enabled = false;
        }

        private async void btn_Player1_Click(object sender, EventArgs e)
        {
            btn_Dice1.Enabled = false;
            btn_Dice1.BackColor = Color.Silver;
            var diceNumber = await RollDiceAndMoveAgent(1);
            EnableDisableDice(diceNumber);
            lbl_Dice1.Text = diceNumber.ToString();
            pb_Dice1.Image = _faces[diceNumber];
            _musicPlayer.Play();
            while (diceNumber == 6)
            {
                btn_Dice1.Enabled = false;
                btn_Dice1.BackColor = Color.Silver;
                diceNumber = await RollDiceAndMoveAgent(1);
                EnableDisableDice(diceNumber);
                lbl_Dice1.Text = diceNumber.ToString();
                pb_Dice1.Image = _faces[diceNumber];
                _musicPlayer.Play();
            }
            //var info = board1.ThrowUpDice(1);
            //lbl_Dice1.Text = info.CurrentDiceNumber.ToString();
            //listBox1.Items.Add(board1.MovePiece(info).CurrentStatus);


            if (UtilityHelper.GameInfo.GameStyle == GameStyle.OnePlayer)
            {
                diceNumber = await RollDiceAndMoveAgent(0);
                lbl_DiceComputer.Text = diceNumber.ToString();
                pb_DiceComputer.Image = _faces[diceNumber];
                _musicPlayer.Play();
                while (diceNumber == 6)
                {
                    diceNumber = await RollDiceAndMoveAgent(0);
                    lbl_DiceComputer.Text = diceNumber.ToString();
                    pb_DiceComputer.Image = _faces[diceNumber];
                    _musicPlayer.Play();
                }
                //Thread.Sleep(1000);
                btn_Dice1.Enabled = true;
                btn_Dice1.BackColor = Color.GreenYellow;
                //info = board1.ThrowUpDice(0);
                //lbl_DiceComputer.Text = info.CurrentDiceNumber.ToString();
                //board1.MovePiece(info);
                //btn_Dice1.Enabled = true;
            }
        }

        private async void btn_Player2_Click(object sender, EventArgs e)
        {
            btn_Dice2.Enabled = false;
            btn_Dice2.BackColor = Color.Silver;
            var diceNumber = await RollDiceAndMoveAgent(2);
            EnableDisableDice(diceNumber);
            lbl_Dice2.Text = diceNumber.ToString();
            pb_Dice2.Image = _faces[diceNumber];
            _musicPlayer.Play();
            while (diceNumber == 6)
            {
                diceNumber = await RollDiceAndMoveAgent(2);
                EnableDisableDice(diceNumber);
                lbl_Dice2.Text = diceNumber.ToString();
                pb_Dice2.Image = _faces[diceNumber];
                _musicPlayer.Play();
            }
            //var info = board1.ThrowUpDice(1);
            //lbl_Dice2.Text = info.CurrentDiceNumber.ToString();
            //board1.MovePiece(info);
            //listBox2.Items.Add(board1.MovePiece(info).CurrentStatus);
        }
       
        private void MainForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SetDiceVisibleStatus(UtilityHelper.GameInfo);
        }

        private void SetDiceVisibleStatus(GameInfo gameInfo)
        {
            if (gameInfo.GameStyle == GameStyle.OnePlayer)
            {
                gb_Player1.Visible = true;
                gb_Player2.Visible = false;
                gb_Player3.Visible = false;
                gb_Player4.Visible = false;
                gb_Player1.Text = gameInfo.PlayerName1;
                gb_Computer.Visible = true;
            }
            else if(gameInfo.GameStyle == GameStyle.TwoPlayer)
            {
                gb_Player1.Visible = true;
                gb_Player2.Visible = true;
                gb_Player3.Visible = false;
                gb_Player4.Visible = false;
                gb_Player1.Text = gameInfo.PlayerName1;
                gb_Player2.Text = gameInfo.PlayerName2;
            }
            else if (gameInfo.GameStyle == GameStyle.ThreePlayer)
            {
                gb_Player1.Visible = true;
                gb_Player2.Visible = true;
                gb_Player3.Visible = true;
                gb_Player4.Visible = false;
                gb_Player1.Text = gameInfo.PlayerName1;
                gb_Player2.Text = gameInfo.PlayerName2;
                gb_Player3.Text = gameInfo.PlayerName3;
            }
            else if (gameInfo.GameStyle == GameStyle.FourPlayer)
            {
                gb_Player1.Visible = true;
                gb_Player2.Visible = true;
                gb_Player3.Visible = true;
                gb_Player4.Visible = true;
                gb_Player1.Text = gameInfo.PlayerName1;
                gb_Player2.Text = gameInfo.PlayerName2;
                gb_Player3.Text = gameInfo.PlayerName3;
                gb_Player4.Text = gameInfo.PlayerName4;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void btn_Dice3_Click(object sender, EventArgs e)
        {
            btn_Dice3.Enabled = false;
            btn_Dice3.BackColor = Color.Silver;
            var diceNumber = await RollDiceAndMoveAgent(3);
            EnableDisableDice(diceNumber);
            lbl_Dice3.Text = diceNumber.ToString();
            pb_Dice3.Image = _faces[diceNumber];
            _musicPlayer.Play();
            while (diceNumber == 6)
            {
                diceNumber = await RollDiceAndMoveAgent(3);
                EnableDisableDice(diceNumber);
                lbl_Dice3.Text = diceNumber.ToString();
                pb_Dice3.Image = _faces[diceNumber];
                _musicPlayer.Play();
            }
        }

        private async void btn_Dice4_Click(object sender, EventArgs e)
        {
            btn_Dice4.Enabled = false;
            btn_Dice4.BackColor = Color.Silver;
            var diceNumber = await RollDiceAndMoveAgent(4);
            EnableDisableDice(diceNumber);
            lbl_Dice4.Text = diceNumber.ToString();
            pb_Dice4.Image = _faces[diceNumber];
            _musicPlayer.Play();
            while (diceNumber == 6)
            {
                diceNumber = await RollDiceAndMoveAgent(4);
                EnableDisableDice(diceNumber);
                lbl_Dice4.Text = diceNumber.ToString();
                pb_Dice4.Image = _faces[diceNumber];
                _musicPlayer.Play();
            }
        }
    }
}

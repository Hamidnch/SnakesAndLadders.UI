using System;
using System.Windows.Forms;

namespace SnakesAndLadders.UI
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Player1_Click(object sender, EventArgs e)
        {
            var info = board1.ThrowUpDice(0);
            lbl_Player1_DiceNumber.Text = info.CurrentDiceNumber.ToString();
            listBox1.Items.Add(board1.MovePiece(info).CurrentStatus);
        }

        private void btn_Player2_Click(object sender, EventArgs e)
        {
            var info = board1.ThrowUpDice(1);
            lbl_Player2_DiceNumber.Text = info.CurrentDiceNumber.ToString();
            board1.MovePiece(info);
            listBox2.Items.Add(board1.MovePiece(info).CurrentStatus);
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            lbl_Pos.Text = e.Location.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}

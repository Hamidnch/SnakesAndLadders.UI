using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnakesAndLadders.UI.Helpers;

namespace SnakesAndLadders.UI
{
    public partial class SelectPlayerForm : Form
    {
        private GameStyle _gameStyle = GameStyle.OnePlayer;
        public SelectPlayerForm()
        {
            InitializeComponent();
        }

        private void SetTextBoxAndLabelVisibleStatus(GameStyle gameStyle)
        {
            _gameStyle = gameStyle;
            switch (gameStyle)
            {
                case GameStyle.OnePlayer:
                    lbl_PlayerName1.Visible = true;
                    txt_PlayerName1.Visible = true;
                    txt_PlayerName1.Focus();

                    lbl_PlayerName2.Visible = false;
                    txt_PlayerName2.Visible = false;

                    lbl_PlayerName3.Visible = false;
                    txt_PlayerName3.Visible = false;

                    lbl_PlayerName4.Visible = false;
                    txt_PlayerName4.Visible = false;
                    break;
                case GameStyle.TwoPlayer:
                    lbl_PlayerName1.Visible = true;
                    txt_PlayerName1.Visible = true;
                    txt_PlayerName1.Focus();

                    lbl_PlayerName2.Visible = true;
                    txt_PlayerName2.Visible = true;

                    lbl_PlayerName3.Visible = false;
                    txt_PlayerName3.Visible = false;

                    lbl_PlayerName4.Visible = false;
                    txt_PlayerName4.Visible = false;
                    break;
                case GameStyle.ThreePlayer:
                    lbl_PlayerName1.Visible = true;
                    txt_PlayerName1.Visible = true;
                    txt_PlayerName1.Focus();

                    lbl_PlayerName2.Visible = true;
                    txt_PlayerName2.Visible = true;

                    lbl_PlayerName3.Visible = true;
                    txt_PlayerName3.Visible = true;

                    lbl_PlayerName4.Visible = false;
                    txt_PlayerName4.Visible = false;
                    break;
                case GameStyle.FourPlayer:
                    lbl_PlayerName1.Visible = true;
                    txt_PlayerName1.Visible = true;
                    txt_PlayerName1.Focus();

                    lbl_PlayerName2.Visible = true;
                    txt_PlayerName2.Visible = true;

                    lbl_PlayerName3.Visible = true;
                    txt_PlayerName3.Visible = true;

                    lbl_PlayerName4.Visible = true;
                    txt_PlayerName4.Visible = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(gameStyle), gameStyle, null);
            }
        }

        private void rb_OnPlayer_CheckedChanged(object sender, EventArgs e)
        {
            SetTextBoxAndLabelVisibleStatus(GameStyle.OnePlayer);
        }

        private void rb_TwoPlayer_CheckedChanged(object sender, EventArgs e)
        {
            SetTextBoxAndLabelVisibleStatus(GameStyle.TwoPlayer);
        }

        private void rb_ThreePlayer_CheckedChanged(object sender, EventArgs e)
        {
            SetTextBoxAndLabelVisibleStatus(GameStyle.ThreePlayer);
        }

        private void rb_FourPlayer_CheckedChanged(object sender, EventArgs e)
        {
            SetTextBoxAndLabelVisibleStatus(GameStyle.FourPlayer);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            UtilityHelper.GameInfo = new GameInfo(_gameStyle, 
                txt_PlayerName1.Text,
                txt_PlayerName2.Text,
                txt_PlayerName3.Text,
                txt_PlayerName4.Text);

            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}

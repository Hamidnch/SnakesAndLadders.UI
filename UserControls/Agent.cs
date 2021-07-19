using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakesAndLadders.UI.UserControls
{
    public partial class Agent : UserControl
    {
        public int PlayerId { get; set; }

        public Agent()
        {
            InitializeComponent();
        }

        public Agent(int playerId)
        {
            InitializeComponent();
            PlayerId = playerId;
            lbl_Location.Text = playerId.ToString();
        }

        public Agent(int playerId, Image image)
        {
            InitializeComponent();
            PlayerId = playerId;
            this.picture.Image = image;
            lbl_Location.Text = playerId.ToString();
        }

        public void SetImage(Image image)
        {
            this.picture.Image = null;
            this.picture.Image = image;
        }

        private void Agent_LocationChanged(object sender, EventArgs e)
        {
            //lbl_Location.Text = this.Location.X + "," + this.Location.Y;
        }
    }
}

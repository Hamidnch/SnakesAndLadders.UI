
namespace SnakesAndLadders.UI.UserControls
{
    partial class Agent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picture = new System.Windows.Forms.PictureBox();
            this.lbl_Location = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Image = global::SnakesAndLadders.UI.Properties.Resources.Purple;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(38, 30);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // lbl_Location
            // 
            this.lbl_Location.BackColor = System.Drawing.Color.Red;
            this.lbl_Location.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Location.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Location.ForeColor = System.Drawing.Color.LightYellow;
            this.lbl_Location.Location = new System.Drawing.Point(0, 30);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(38, 13);
            this.lbl_Location.TabIndex = 1;
            this.lbl_Location.Text = "0 , 0";
            this.lbl_Location.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Agent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picture);
            this.Controls.Add(this.lbl_Location);
            this.DoubleBuffered = true;
            this.Name = "Agent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(38, 43);
            this.LocationChanged += new System.EventHandler(this.Agent_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label lbl_Location;
    }
}

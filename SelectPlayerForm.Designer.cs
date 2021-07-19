
namespace SnakesAndLadders.UI
{
    partial class SelectPlayerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rb_OnPlayer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_FourPlayer = new System.Windows.Forms.RadioButton();
            this.rb_ThreePlayer = new System.Windows.Forms.RadioButton();
            this.rb_TwoPlayer = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_PlayerName1 = new System.Windows.Forms.Label();
            this.txt_PlayerName1 = new System.Windows.Forms.TextBox();
            this.lbl_PlayerName2 = new System.Windows.Forms.Label();
            this.txt_PlayerName2 = new System.Windows.Forms.TextBox();
            this.lbl_PlayerName3 = new System.Windows.Forms.Label();
            this.txt_PlayerName3 = new System.Windows.Forms.TextBox();
            this.lbl_PlayerName4 = new System.Windows.Forms.Label();
            this.txt_PlayerName4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_OnPlayer
            // 
            this.rb_OnPlayer.AutoSize = true;
            this.rb_OnPlayer.Checked = true;
            this.rb_OnPlayer.Location = new System.Drawing.Point(15, 22);
            this.rb_OnPlayer.Name = "rb_OnPlayer";
            this.rb_OnPlayer.Size = new System.Drawing.Size(97, 19);
            this.rb_OnPlayer.TabIndex = 0;
            this.rb_OnPlayer.TabStop = true;
            this.rb_OnPlayer.Text = "بازی با کامپیوتر";
            this.rb_OnPlayer.UseVisualStyleBackColor = true;
            this.rb_OnPlayer.CheckedChanged += new System.EventHandler(this.rb_OnPlayer_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_FourPlayer);
            this.groupBox1.Controls.Add(this.rb_ThreePlayer);
            this.groupBox1.Controls.Add(this.rb_TwoPlayer);
            this.groupBox1.Controls.Add(this.rb_OnPlayer);
            this.groupBox1.Location = new System.Drawing.Point(382, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "سبک بازی";
            // 
            // rb_FourPlayer
            // 
            this.rb_FourPlayer.AutoSize = true;
            this.rb_FourPlayer.Location = new System.Drawing.Point(43, 112);
            this.rb_FourPlayer.Name = "rb_FourPlayer";
            this.rb_FourPlayer.Size = new System.Drawing.Size(69, 19);
            this.rb_FourPlayer.TabIndex = 0;
            this.rb_FourPlayer.Text = "چهار نفره";
            this.rb_FourPlayer.UseVisualStyleBackColor = true;
            this.rb_FourPlayer.CheckedChanged += new System.EventHandler(this.rb_FourPlayer_CheckedChanged);
            // 
            // rb_ThreePlayer
            // 
            this.rb_ThreePlayer.AutoSize = true;
            this.rb_ThreePlayer.Location = new System.Drawing.Point(48, 82);
            this.rb_ThreePlayer.Name = "rb_ThreePlayer";
            this.rb_ThreePlayer.Size = new System.Drawing.Size(64, 19);
            this.rb_ThreePlayer.TabIndex = 0;
            this.rb_ThreePlayer.Text = "سه نفره";
            this.rb_ThreePlayer.UseVisualStyleBackColor = true;
            this.rb_ThreePlayer.CheckedChanged += new System.EventHandler(this.rb_ThreePlayer_CheckedChanged);
            // 
            // rb_TwoPlayer
            // 
            this.rb_TwoPlayer.AutoSize = true;
            this.rb_TwoPlayer.Location = new System.Drawing.Point(52, 52);
            this.rb_TwoPlayer.Name = "rb_TwoPlayer";
            this.rb_TwoPlayer.Size = new System.Drawing.Size(60, 19);
            this.rb_TwoPlayer.TabIndex = 0;
            this.rb_TwoPlayer.Text = "دو نفره";
            this.rb_TwoPlayer.UseVisualStyleBackColor = true;
            this.rb_TwoPlayer.CheckedChanged += new System.EventHandler(this.rb_TwoPlayer_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(345, 171);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(426, 171);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(78, 31);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "شروع";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SnakesAndLadders.UI.Properties.Resources.Board;
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_PlayerName1
            // 
            this.lbl_PlayerName1.AutoSize = true;
            this.lbl_PlayerName1.Location = new System.Drawing.Point(311, 33);
            this.lbl_PlayerName1.Name = "lbl_PlayerName1";
            this.lbl_PlayerName1.Size = new System.Drawing.Size(52, 15);
            this.lbl_PlayerName1.TabIndex = 4;
            this.lbl_PlayerName1.Text = "نام بازیگر";
            // 
            // txt_PlayerName1
            // 
            this.txt_PlayerName1.Location = new System.Drawing.Point(142, 29);
            this.txt_PlayerName1.Name = "txt_PlayerName1";
            this.txt_PlayerName1.Size = new System.Drawing.Size(163, 23);
            this.txt_PlayerName1.TabIndex = 5;
            // 
            // lbl_PlayerName2
            // 
            this.lbl_PlayerName2.AutoSize = true;
            this.lbl_PlayerName2.Location = new System.Drawing.Point(311, 63);
            this.lbl_PlayerName2.Name = "lbl_PlayerName2";
            this.lbl_PlayerName2.Size = new System.Drawing.Size(52, 15);
            this.lbl_PlayerName2.TabIndex = 4;
            this.lbl_PlayerName2.Text = "نام بازیگر";
            this.lbl_PlayerName2.Visible = false;
            // 
            // txt_PlayerName2
            // 
            this.txt_PlayerName2.Location = new System.Drawing.Point(142, 59);
            this.txt_PlayerName2.Name = "txt_PlayerName2";
            this.txt_PlayerName2.Size = new System.Drawing.Size(163, 23);
            this.txt_PlayerName2.TabIndex = 5;
            this.txt_PlayerName2.Visible = false;
            // 
            // lbl_PlayerName3
            // 
            this.lbl_PlayerName3.AutoSize = true;
            this.lbl_PlayerName3.Location = new System.Drawing.Point(311, 92);
            this.lbl_PlayerName3.Name = "lbl_PlayerName3";
            this.lbl_PlayerName3.Size = new System.Drawing.Size(52, 15);
            this.lbl_PlayerName3.TabIndex = 4;
            this.lbl_PlayerName3.Text = "نام بازیگر";
            this.lbl_PlayerName3.Visible = false;
            // 
            // txt_PlayerName3
            // 
            this.txt_PlayerName3.Location = new System.Drawing.Point(142, 88);
            this.txt_PlayerName3.Name = "txt_PlayerName3";
            this.txt_PlayerName3.Size = new System.Drawing.Size(163, 23);
            this.txt_PlayerName3.TabIndex = 5;
            this.txt_PlayerName3.Visible = false;
            // 
            // lbl_PlayerName4
            // 
            this.lbl_PlayerName4.AutoSize = true;
            this.lbl_PlayerName4.Location = new System.Drawing.Point(311, 122);
            this.lbl_PlayerName4.Name = "lbl_PlayerName4";
            this.lbl_PlayerName4.Size = new System.Drawing.Size(52, 15);
            this.lbl_PlayerName4.TabIndex = 4;
            this.lbl_PlayerName4.Text = "نام بازیگر";
            this.lbl_PlayerName4.Visible = false;
            // 
            // txt_PlayerName4
            // 
            this.txt_PlayerName4.Location = new System.Drawing.Point(142, 118);
            this.txt_PlayerName4.Name = "txt_PlayerName4";
            this.txt_PlayerName4.Size = new System.Drawing.Size(163, 23);
            this.txt_PlayerName4.TabIndex = 5;
            this.txt_PlayerName4.Visible = false;
            // 
            // SelectPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 215);
            this.Controls.Add(this.txt_PlayerName4);
            this.Controls.Add(this.lbl_PlayerName4);
            this.Controls.Add(this.txt_PlayerName3);
            this.Controls.Add(this.lbl_PlayerName3);
            this.Controls.Add(this.txt_PlayerName2);
            this.Controls.Add(this.lbl_PlayerName2);
            this.Controls.Add(this.txt_PlayerName1);
            this.Controls.Add(this.lbl_PlayerName1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Name = "SelectPlayerForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بازی مار و پله";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_OnPlayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_ThreePlayer;
        private System.Windows.Forms.RadioButton rb_TwoPlayer;
        private System.Windows.Forms.RadioButton rb_FourPlayer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_PlayerName1;
        private System.Windows.Forms.TextBox txt_PlayerName1;
        private System.Windows.Forms.Label lbl_PlayerName2;
        private System.Windows.Forms.TextBox txt_PlayerName2;
        private System.Windows.Forms.Label lbl_PlayerName3;
        private System.Windows.Forms.TextBox txt_PlayerName3;
        private System.Windows.Forms.Label lbl_PlayerName4;
        private System.Windows.Forms.TextBox txt_PlayerName4;
    }
}
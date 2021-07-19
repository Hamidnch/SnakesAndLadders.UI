
namespace SnakesAndLadders.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Dice1 = new System.Windows.Forms.Button();
            this.board1 = new SnakesAndLadders.UI.UserControls.Board();
            this.lbl_Dice1 = new System.Windows.Forms.Label();
            this.btn_Dice2 = new System.Windows.Forms.Button();
            this.lbl_Dice2 = new System.Windows.Forms.Label();
            this.gb_Player1 = new System.Windows.Forms.GroupBox();
            this.pb_Dice1 = new System.Windows.Forms.PictureBox();
            this.gb_Player2 = new System.Windows.Forms.GroupBox();
            this.pb_Dice2 = new System.Windows.Forms.PictureBox();
            this.gb_Player3 = new System.Windows.Forms.GroupBox();
            this.pb_Dice3 = new System.Windows.Forms.PictureBox();
            this.btn_Dice3 = new System.Windows.Forms.Button();
            this.lbl_Dice3 = new System.Windows.Forms.Label();
            this.gb_Player4 = new System.Windows.Forms.GroupBox();
            this.pb_Dice4 = new System.Windows.Forms.PictureBox();
            this.btn_Dice4 = new System.Windows.Forms.Button();
            this.lbl_Dice4 = new System.Windows.Forms.Label();
            this.gb_Computer = new System.Windows.Forms.GroupBox();
            this.pb_DiceComputer = new System.Windows.Forms.PictureBox();
            this.lbl_DiceComputer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gb_Player1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dice1)).BeginInit();
            this.gb_Player2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dice2)).BeginInit();
            this.gb_Player3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dice3)).BeginInit();
            this.gb_Player4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dice4)).BeginInit();
            this.gb_Computer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DiceComputer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Dice1
            // 
            this.btn_Dice1.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_Dice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dice1.Location = new System.Drawing.Point(47, 22);
            this.btn_Dice1.Name = "btn_Dice1";
            this.btn_Dice1.Size = new System.Drawing.Size(62, 36);
            this.btn_Dice1.TabIndex = 2;
            this.btn_Dice1.Text = "تاس";
            this.btn_Dice1.UseVisualStyleBackColor = false;
            this.btn_Dice1.Click += new System.EventHandler(this.btn_Player1_Click);
            // 
            // board1
            // 
            this.board1.AutoSize = true;
            this.board1.Location = new System.Drawing.Point(12, 12);
            this.board1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.board1.Name = "board1";
            this.board1.PlayerCount = 2;
            this.board1.Size = new System.Drawing.Size(800, 709);
            this.board1.TabIndex = 3;
            // 
            // lbl_Dice1
            // 
            this.lbl_Dice1.AutoSize = true;
            this.lbl_Dice1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dice1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Dice1.Location = new System.Drawing.Point(6, 26);
            this.lbl_Dice1.Name = "lbl_Dice1";
            this.lbl_Dice1.Size = new System.Drawing.Size(36, 28);
            this.lbl_Dice1.TabIndex = 4;
            this.lbl_Dice1.Text = "---";
            // 
            // btn_Dice2
            // 
            this.btn_Dice2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Dice2.Enabled = false;
            this.btn_Dice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dice2.Location = new System.Drawing.Point(47, 22);
            this.btn_Dice2.Name = "btn_Dice2";
            this.btn_Dice2.Size = new System.Drawing.Size(62, 36);
            this.btn_Dice2.TabIndex = 2;
            this.btn_Dice2.Text = "تاس";
            this.btn_Dice2.UseVisualStyleBackColor = false;
            this.btn_Dice2.Click += new System.EventHandler(this.btn_Player2_Click);
            // 
            // lbl_Dice2
            // 
            this.lbl_Dice2.AutoSize = true;
            this.lbl_Dice2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dice2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Dice2.Location = new System.Drawing.Point(6, 26);
            this.lbl_Dice2.Name = "lbl_Dice2";
            this.lbl_Dice2.Size = new System.Drawing.Size(36, 28);
            this.lbl_Dice2.TabIndex = 4;
            this.lbl_Dice2.Text = "---";
            // 
            // gb_Player1
            // 
            this.gb_Player1.Controls.Add(this.pb_Dice1);
            this.gb_Player1.Controls.Add(this.btn_Dice1);
            this.gb_Player1.Controls.Add(this.lbl_Dice1);
            this.gb_Player1.Location = new System.Drawing.Point(838, 12);
            this.gb_Player1.Name = "gb_Player1";
            this.gb_Player1.Size = new System.Drawing.Size(125, 141);
            this.gb_Player1.TabIndex = 7;
            this.gb_Player1.TabStop = false;
            this.gb_Player1.Text = "بازیگر اول";
            this.gb_Player1.Visible = false;
            // 
            // pb_Dice1
            // 
            this.pb_Dice1.Location = new System.Drawing.Point(26, 62);
            this.pb_Dice1.Name = "pb_Dice1";
            this.pb_Dice1.Size = new System.Drawing.Size(79, 70);
            this.pb_Dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Dice1.TabIndex = 8;
            this.pb_Dice1.TabStop = false;
            // 
            // gb_Player2
            // 
            this.gb_Player2.Controls.Add(this.pb_Dice2);
            this.gb_Player2.Controls.Add(this.btn_Dice2);
            this.gb_Player2.Controls.Add(this.lbl_Dice2);
            this.gb_Player2.Location = new System.Drawing.Point(838, 155);
            this.gb_Player2.Name = "gb_Player2";
            this.gb_Player2.Size = new System.Drawing.Size(125, 141);
            this.gb_Player2.TabIndex = 7;
            this.gb_Player2.TabStop = false;
            this.gb_Player2.Text = "بازیگر دوم";
            this.gb_Player2.Visible = false;
            // 
            // pb_Dice2
            // 
            this.pb_Dice2.Location = new System.Drawing.Point(26, 62);
            this.pb_Dice2.Name = "pb_Dice2";
            this.pb_Dice2.Size = new System.Drawing.Size(79, 70);
            this.pb_Dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Dice2.TabIndex = 9;
            this.pb_Dice2.TabStop = false;
            // 
            // gb_Player3
            // 
            this.gb_Player3.Controls.Add(this.pb_Dice3);
            this.gb_Player3.Controls.Add(this.btn_Dice3);
            this.gb_Player3.Controls.Add(this.lbl_Dice3);
            this.gb_Player3.Location = new System.Drawing.Point(838, 299);
            this.gb_Player3.Name = "gb_Player3";
            this.gb_Player3.Size = new System.Drawing.Size(125, 141);
            this.gb_Player3.TabIndex = 7;
            this.gb_Player3.TabStop = false;
            this.gb_Player3.Text = "بازیگر سوم";
            this.gb_Player3.Visible = false;
            // 
            // pb_Dice3
            // 
            this.pb_Dice3.Location = new System.Drawing.Point(26, 63);
            this.pb_Dice3.Name = "pb_Dice3";
            this.pb_Dice3.Size = new System.Drawing.Size(79, 70);
            this.pb_Dice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Dice3.TabIndex = 9;
            this.pb_Dice3.TabStop = false;
            // 
            // btn_Dice3
            // 
            this.btn_Dice3.BackColor = System.Drawing.Color.Salmon;
            this.btn_Dice3.Enabled = false;
            this.btn_Dice3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dice3.Location = new System.Drawing.Point(47, 23);
            this.btn_Dice3.Name = "btn_Dice3";
            this.btn_Dice3.Size = new System.Drawing.Size(62, 36);
            this.btn_Dice3.TabIndex = 2;
            this.btn_Dice3.Text = "تاس";
            this.btn_Dice3.UseVisualStyleBackColor = false;
            this.btn_Dice3.Click += new System.EventHandler(this.btn_Dice3_Click);
            // 
            // lbl_Dice3
            // 
            this.lbl_Dice3.AutoSize = true;
            this.lbl_Dice3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dice3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Dice3.Location = new System.Drawing.Point(6, 28);
            this.lbl_Dice3.Name = "lbl_Dice3";
            this.lbl_Dice3.Size = new System.Drawing.Size(36, 28);
            this.lbl_Dice3.TabIndex = 4;
            this.lbl_Dice3.Text = "---";
            // 
            // gb_Player4
            // 
            this.gb_Player4.Controls.Add(this.pb_Dice4);
            this.gb_Player4.Controls.Add(this.btn_Dice4);
            this.gb_Player4.Controls.Add(this.lbl_Dice4);
            this.gb_Player4.Location = new System.Drawing.Point(838, 442);
            this.gb_Player4.Name = "gb_Player4";
            this.gb_Player4.Size = new System.Drawing.Size(125, 141);
            this.gb_Player4.TabIndex = 7;
            this.gb_Player4.TabStop = false;
            this.gb_Player4.Text = "بازیگر سوم";
            this.gb_Player4.Visible = false;
            // 
            // pb_Dice4
            // 
            this.pb_Dice4.Location = new System.Drawing.Point(26, 62);
            this.pb_Dice4.Name = "pb_Dice4";
            this.pb_Dice4.Size = new System.Drawing.Size(79, 70);
            this.pb_Dice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Dice4.TabIndex = 9;
            this.pb_Dice4.TabStop = false;
            // 
            // btn_Dice4
            // 
            this.btn_Dice4.BackColor = System.Drawing.Color.Gold;
            this.btn_Dice4.Enabled = false;
            this.btn_Dice4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dice4.Location = new System.Drawing.Point(47, 22);
            this.btn_Dice4.Name = "btn_Dice4";
            this.btn_Dice4.Size = new System.Drawing.Size(62, 36);
            this.btn_Dice4.TabIndex = 2;
            this.btn_Dice4.Text = "تاس";
            this.btn_Dice4.UseVisualStyleBackColor = false;
            this.btn_Dice4.Click += new System.EventHandler(this.btn_Dice4_Click);
            // 
            // lbl_Dice4
            // 
            this.lbl_Dice4.AutoSize = true;
            this.lbl_Dice4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dice4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Dice4.Location = new System.Drawing.Point(6, 26);
            this.lbl_Dice4.Name = "lbl_Dice4";
            this.lbl_Dice4.Size = new System.Drawing.Size(36, 28);
            this.lbl_Dice4.TabIndex = 4;
            this.lbl_Dice4.Text = "---";
            // 
            // gb_Computer
            // 
            this.gb_Computer.Controls.Add(this.pb_DiceComputer);
            this.gb_Computer.Controls.Add(this.lbl_DiceComputer);
            this.gb_Computer.Location = new System.Drawing.Point(969, 22);
            this.gb_Computer.Name = "gb_Computer";
            this.gb_Computer.Size = new System.Drawing.Size(110, 131);
            this.gb_Computer.TabIndex = 7;
            this.gb_Computer.TabStop = false;
            this.gb_Computer.Text = "کامپیوتر";
            this.gb_Computer.Visible = false;
            // 
            // pb_DiceComputer
            // 
            this.pb_DiceComputer.Location = new System.Drawing.Point(15, 55);
            this.pb_DiceComputer.Name = "pb_DiceComputer";
            this.pb_DiceComputer.Size = new System.Drawing.Size(79, 70);
            this.pb_DiceComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_DiceComputer.TabIndex = 9;
            this.pb_DiceComputer.TabStop = false;
            // 
            // lbl_DiceComputer
            // 
            this.lbl_DiceComputer.AutoSize = true;
            this.lbl_DiceComputer.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DiceComputer.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_DiceComputer.Location = new System.Drawing.Point(37, 21);
            this.lbl_DiceComputer.Name = "lbl_DiceComputer";
            this.lbl_DiceComputer.Size = new System.Drawing.Size(36, 28);
            this.lbl_DiceComputer.TabIndex = 4;
            this.lbl_DiceComputer.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1116, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(969, 159);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(276, 484);
            this.listBox1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 661);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_Player4);
            this.Controls.Add(this.gb_Player3);
            this.Controls.Add(this.gb_Player2);
            this.Controls.Add(this.gb_Computer);
            this.Controls.Add(this.gb_Player1);
            this.Controls.Add(this.board1);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gb_Player1.ResumeLayout(false);
            this.gb_Player1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dice1)).EndInit();
            this.gb_Player2.ResumeLayout(false);
            this.gb_Player2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dice2)).EndInit();
            this.gb_Player3.ResumeLayout(false);
            this.gb_Player3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dice3)).EndInit();
            this.gb_Player4.ResumeLayout(false);
            this.gb_Player4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dice4)).EndInit();
            this.gb_Computer.ResumeLayout(false);
            this.gb_Computer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DiceComputer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Dice1;
        private UserControls.Board board1;
        private System.Windows.Forms.Label lbl_Dice1;
        private System.Windows.Forms.Button btn_Dice2;
        private System.Windows.Forms.Label lbl_Dice2;
        private System.Windows.Forms.GroupBox gb_Player1;
        private System.Windows.Forms.GroupBox gb_Player2;
        private System.Windows.Forms.GroupBox gb_Player3;
        private System.Windows.Forms.Button btn_Dice3;
        private System.Windows.Forms.Label lbl_Dice3;
        private System.Windows.Forms.GroupBox gb_Player4;
        private System.Windows.Forms.Button btn_Dice4;
        private System.Windows.Forms.Label lbl_Dice4;
        private System.Windows.Forms.GroupBox gb_Computer;
        private System.Windows.Forms.Label lbl_DiceComputer;
        private System.Windows.Forms.PictureBox pb_Dice1;
        private System.Windows.Forms.PictureBox pb_Dice2;
        private System.Windows.Forms.PictureBox pb_Dice3;
        private System.Windows.Forms.PictureBox pb_Dice4;
        private System.Windows.Forms.PictureBox pb_DiceComputer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}


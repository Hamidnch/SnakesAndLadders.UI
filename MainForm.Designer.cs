
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
            this.btn_Player1 = new System.Windows.Forms.Button();
            this.board1 = new SnakesAndLadders.UI.UserControls.Board();
            this.lbl_Player1_DiceNumber = new System.Windows.Forms.Label();
            this.btn_Player2 = new System.Windows.Forms.Button();
            this.lbl_Player2_DiceNumber = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Pos = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Player1
            // 
            this.btn_Player1.Location = new System.Drawing.Point(957, 28);
            this.btn_Player1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Player1.Name = "btn_Player1";
            this.btn_Player1.Size = new System.Drawing.Size(71, 48);
            this.btn_Player1.TabIndex = 2;
            this.btn_Player1.Text = "Player1";
            this.btn_Player1.UseVisualStyleBackColor = true;
            this.btn_Player1.Click += new System.EventHandler(this.btn_Player1_Click);
            // 
            // board1
            // 
            this.board1.AutoSize = true;
            this.board1.Location = new System.Drawing.Point(14, 16);
            this.board1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.board1.Name = "board1";
            this.board1.PlayerCount = 2;
            this.board1.Size = new System.Drawing.Size(914, 945);
            this.board1.TabIndex = 3;
            // 
            // lbl_Player1_DiceNumber
            // 
            this.lbl_Player1_DiceNumber.AutoSize = true;
            this.lbl_Player1_DiceNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Player1_DiceNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Player1_DiceNumber.Location = new System.Drawing.Point(970, 80);
            this.lbl_Player1_DiceNumber.Name = "lbl_Player1_DiceNumber";
            this.lbl_Player1_DiceNumber.Size = new System.Drawing.Size(45, 35);
            this.lbl_Player1_DiceNumber.TabIndex = 4;
            this.lbl_Player1_DiceNumber.Text = "---";
            // 
            // btn_Player2
            // 
            this.btn_Player2.Location = new System.Drawing.Point(1251, 28);
            this.btn_Player2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Player2.Name = "btn_Player2";
            this.btn_Player2.Size = new System.Drawing.Size(71, 48);
            this.btn_Player2.TabIndex = 2;
            this.btn_Player2.Text = "Player2";
            this.btn_Player2.UseVisualStyleBackColor = true;
            this.btn_Player2.Click += new System.EventHandler(this.btn_Player2_Click);
            // 
            // lbl_Player2_DiceNumber
            // 
            this.lbl_Player2_DiceNumber.AutoSize = true;
            this.lbl_Player2_DiceNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Player2_DiceNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Player2_DiceNumber.Location = new System.Drawing.Point(1267, 80);
            this.lbl_Player2_DiceNumber.Name = "lbl_Player2_DiceNumber";
            this.lbl_Player2_DiceNumber.Size = new System.Drawing.Size(45, 35);
            this.lbl_Player2_DiceNumber.TabIndex = 4;
            this.lbl_Player2_DiceNumber.Text = "---";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(935, 124);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(487, 304);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(935, 500);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(487, 284);
            this.listBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1129, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Pos
            // 
            this.lbl_Pos.AutoSize = true;
            this.lbl_Pos.Location = new System.Drawing.Point(1105, 80);
            this.lbl_Pos.Name = "lbl_Pos";
            this.lbl_Pos.Size = new System.Drawing.Size(50, 20);
            this.lbl_Pos.TabIndex = 7;
            this.lbl_Pos.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1129, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 881);
            this.Controls.Add(this.lbl_Pos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_Player2_DiceNumber);
            this.Controls.Add(this.lbl_Player1_DiceNumber);
            this.Controls.Add(this.btn_Player2);
            this.Controls.Add(this.btn_Player1);
            this.Controls.Add(this.board1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Player1;
        private UserControls.Board board1;
        private System.Windows.Forms.Label lbl_Player1_DiceNumber;
        private System.Windows.Forms.Button btn_Player2;
        private System.Windows.Forms.Label lbl_Player2_DiceNumber;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Pos;
        private System.Windows.Forms.Button button2;
    }
}


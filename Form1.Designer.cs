namespace Pokemonbattle
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.PBPlayer = new System.Windows.Forms.PictureBox();
            this.PBEnemy = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.PlayerName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbName2 = new System.Windows.Forms.TextBox();
            this.BtAtk = new System.Windows.Forms.Button();
            this.BtAtk1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.TimeEnAtk = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEnemy)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBPlayer
            // 
            this.PBPlayer.BackColor = System.Drawing.Color.Transparent;
            this.PBPlayer.Image = global::Pokemonbattle.Properties.Resources._006;
            this.PBPlayer.Location = new System.Drawing.Point(34, 217);
            this.PBPlayer.Name = "PBPlayer";
            this.PBPlayer.Size = new System.Drawing.Size(261, 238);
            this.PBPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPlayer.TabIndex = 0;
            this.PBPlayer.TabStop = false;
            // 
            // PBEnemy
            // 
            this.PBEnemy.BackColor = System.Drawing.Color.Transparent;
            this.PBEnemy.Image = global::Pokemonbattle.Properties.Resources._009;
            this.PBEnemy.Location = new System.Drawing.Point(764, 184);
            this.PBEnemy.Name = "PBEnemy";
            this.PBEnemy.Size = new System.Drawing.Size(247, 204);
            this.PBEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBEnemy.TabIndex = 1;
            this.PBEnemy.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.PlayerName);
            this.panel1.Location = new System.Drawing.Point(12, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 87);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "HP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(13, 5);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(122, 46);
            this.tbName.TabIndex = 4;
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayerName.Location = new System.Drawing.Point(13, 10);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(0, 18);
            this.PlayerName.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.tbName2);
            this.panel2.Location = new System.Drawing.Point(747, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 81);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "HP";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 7;
            // 
            // tbName2
            // 
            this.tbName2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbName2.Location = new System.Drawing.Point(3, 3);
            this.tbName2.Multiline = true;
            this.tbName2.Name = "tbName2";
            this.tbName2.Size = new System.Drawing.Size(121, 42);
            this.tbName2.TabIndex = 5;
            // 
            // BtAtk
            // 
            this.BtAtk.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtAtk.Location = new System.Drawing.Point(747, 410);
            this.BtAtk.Name = "BtAtk";
            this.BtAtk.Size = new System.Drawing.Size(106, 57);
            this.BtAtk.TabIndex = 6;
            this.BtAtk.Text = "Attack";
            this.BtAtk.UseVisualStyleBackColor = true;
            this.BtAtk.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtAtk1
            // 
            this.BtAtk1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtAtk1.Location = new System.Drawing.Point(892, 410);
            this.BtAtk1.Name = "BtAtk1";
            this.BtAtk1.Size = new System.Drawing.Size(106, 57);
            this.BtAtk1.TabIndex = 7;
            this.BtAtk1.Text = "Attack2";
            this.BtAtk1.UseVisualStyleBackColor = true;
            this.BtAtk1.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(312, 398);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 57);
            this.button5.TabIndex = 10;
            this.button5.Text = "Charizard";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(443, 398);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 57);
            this.button6.TabIndex = 11;
            this.button6.Text = " Pikachu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(312, 461);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 57);
            this.button7.TabIndex = 13;
            this.button7.Text = "Pidgeot";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(443, 461);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 57);
            this.button8.TabIndex = 12;
            this.button8.Text = "Raichu";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // TimeEnAtk
            // 
            this.TimeEnAtk.Interval = 2000;
            this.TimeEnAtk.Tick += new System.EventHandler(this.TimeEnAtk_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Pokemonbattle.Properties.Resources.f25f7aee4d558219fb64b9e2f223d64b;
            this.ClientSize = new System.Drawing.Size(1023, 569);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtAtk1);
            this.Controls.Add(this.BtAtk);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PBEnemy);
            this.Controls.Add(this.PBPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEnemy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox PBPlayer;
        private PictureBox PBEnemy;
        private Panel panel1;
        private Label PlayerName;
        private Panel panel2;
        private Button BtAtk;
        private Button BtAtk1;
        private TextBox tbName;
        private TextBox tbName2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private System.Windows.Forms.Timer TimeEnAtk;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
    }
}
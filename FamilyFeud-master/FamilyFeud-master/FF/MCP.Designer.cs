namespace FF
{
    partial class MCP
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
            this.GMSwitcher = new System.Windows.Forms.TabControl();
            this.MainGame = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LoadNextRound = new System.Windows.Forms.Button();
            this.GMTriple = new System.Windows.Forms.RadioButton();
            this.GMDouble = new System.Windows.Forms.RadioButton();
            this.GMSingle = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Answer12 = new System.Windows.Forms.Button();
            this.Answer11 = new System.Windows.Forms.Button();
            this.Answer10 = new System.Windows.Forms.Button();
            this.Answer9 = new System.Windows.Forms.Button();
            this.Answer8 = new System.Windows.Forms.Button();
            this.Value12 = new System.Windows.Forms.TextBox();
            this.Value11 = new System.Windows.Forms.TextBox();
            this.Value10 = new System.Windows.Forms.TextBox();
            this.Value9 = new System.Windows.Forms.TextBox();
            this.Value8 = new System.Windows.Forms.TextBox();
            this.Value7 = new System.Windows.Forms.TextBox();
            this.Answer7 = new System.Windows.Forms.Button();
            this.Value6 = new System.Windows.Forms.TextBox();
            this.Value5 = new System.Windows.Forms.TextBox();
            this.Value4 = new System.Windows.Forms.TextBox();
            this.Value3 = new System.Windows.Forms.TextBox();
            this.Value2 = new System.Windows.Forms.TextBox();
            this.Value1 = new System.Windows.Forms.TextBox();
            this.Answer6 = new System.Windows.Forms.Button();
            this.Answer5 = new System.Windows.Forms.Button();
            this.Answer4 = new System.Windows.Forms.Button();
            this.Answer3 = new System.Windows.Forms.Button();
            this.Answer2 = new System.Windows.Forms.Button();
            this.Answer1 = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.FastMoney = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.StrikeSound = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.P1Play = new System.Windows.Forms.Button();
            this.P1Pass = new System.Windows.Forms.Button();
            this.P1Score = new System.Windows.Forms.Label();
            this.P1Strikes = new System.Windows.Forms.Label();
            this.P2Pass = new System.Windows.Forms.Button();
            this.P2Play = new System.Windows.Forms.Button();
            this.P2Strikes = new System.Windows.Forms.Label();
            this.P2Score = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GlobalScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentPlayingTeam = new System.Windows.Forms.Label();
            this.GameMode = new System.Windows.Forms.Label();
            this.GMSwitcher.SuspendLayout();
            this.MainGame.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // GMSwitcher
            // 
            this.GMSwitcher.Controls.Add(this.MainGame);
            this.GMSwitcher.Controls.Add(this.FastMoney);
            this.GMSwitcher.Location = new System.Drawing.Point(12, 12);
            this.GMSwitcher.Name = "GMSwitcher";
            this.GMSwitcher.SelectedIndex = 0;
            this.GMSwitcher.Size = new System.Drawing.Size(725, 463);
            this.GMSwitcher.TabIndex = 0;
            // 
            // MainGame
            // 
            this.MainGame.Controls.Add(this.groupBox6);
            this.MainGame.Controls.Add(this.groupBox5);
            this.MainGame.Controls.Add(this.groupBox4);
            this.MainGame.Controls.Add(this.groupBox3);
            this.MainGame.Controls.Add(this.groupBox2);
            this.MainGame.Controls.Add(this.groupBox1);
            this.MainGame.Location = new System.Drawing.Point(4, 22);
            this.MainGame.Name = "MainGame";
            this.MainGame.Padding = new System.Windows.Forms.Padding(3);
            this.MainGame.Size = new System.Drawing.Size(717, 437);
            this.MainGame.TabIndex = 0;
            this.MainGame.Text = "Main Game";
            this.MainGame.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GameMode);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.LoadNextRound);
            this.groupBox2.Controls.Add(this.GMTriple);
            this.groupBox2.Controls.Add(this.GMDouble);
            this.groupBox2.Controls.Add(this.GMSingle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(511, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Round Control";
            // 
            // LoadNextRound
            // 
            this.LoadNextRound.Location = new System.Drawing.Point(10, 164);
            this.LoadNextRound.Name = "LoadNextRound";
            this.LoadNextRound.Size = new System.Drawing.Size(75, 23);
            this.LoadNextRound.TabIndex = 4;
            this.LoadNextRound.Text = "Load Round";
            this.LoadNextRound.UseVisualStyleBackColor = true;
            // 
            // GMTriple
            // 
            this.GMTriple.AutoSize = true;
            this.GMTriple.Location = new System.Drawing.Point(6, 109);
            this.GMTriple.Name = "GMTriple";
            this.GMTriple.Size = new System.Drawing.Size(51, 17);
            this.GMTriple.TabIndex = 3;
            this.GMTriple.Text = "Triple";
            this.GMTriple.UseVisualStyleBackColor = true;
            // 
            // GMDouble
            // 
            this.GMDouble.AutoSize = true;
            this.GMDouble.Location = new System.Drawing.Point(6, 84);
            this.GMDouble.Name = "GMDouble";
            this.GMDouble.Size = new System.Drawing.Size(59, 17);
            this.GMDouble.TabIndex = 2;
            this.GMDouble.Text = "Double";
            this.GMDouble.UseVisualStyleBackColor = true;
            // 
            // GMSingle
            // 
            this.GMSingle.AutoSize = true;
            this.GMSingle.Checked = true;
            this.GMSingle.Location = new System.Drawing.Point(6, 61);
            this.GMSingle.Name = "GMSingle";
            this.GMSingle.Size = new System.Drawing.Size(54, 17);
            this.GMSingle.TabIndex = 1;
            this.GMSingle.TabStop = true;
            this.GMSingle.Text = "Single";
            this.GMSingle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Next game played will be...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Answer12);
            this.groupBox1.Controls.Add(this.Answer11);
            this.groupBox1.Controls.Add(this.Answer10);
            this.groupBox1.Controls.Add(this.Answer9);
            this.groupBox1.Controls.Add(this.Answer8);
            this.groupBox1.Controls.Add(this.Value12);
            this.groupBox1.Controls.Add(this.Value11);
            this.groupBox1.Controls.Add(this.Value10);
            this.groupBox1.Controls.Add(this.Value9);
            this.groupBox1.Controls.Add(this.Value8);
            this.groupBox1.Controls.Add(this.Value7);
            this.groupBox1.Controls.Add(this.Answer7);
            this.groupBox1.Controls.Add(this.Value6);
            this.groupBox1.Controls.Add(this.Value5);
            this.groupBox1.Controls.Add(this.Value4);
            this.groupBox1.Controls.Add(this.Value3);
            this.groupBox1.Controls.Add(this.Value2);
            this.groupBox1.Controls.Add(this.Value1);
            this.groupBox1.Controls.Add(this.Answer6);
            this.groupBox1.Controls.Add(this.Answer5);
            this.groupBox1.Controls.Add(this.Answer4);
            this.groupBox1.Controls.Add(this.Answer3);
            this.groupBox1.Controls.Add(this.Answer2);
            this.groupBox1.Controls.Add(this.Answer1);
            this.groupBox1.Controls.Add(this.shapeContainer1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Survey";
            // 
            // Answer12
            // 
            this.Answer12.Enabled = false;
            this.Answer12.Location = new System.Drawing.Point(254, 164);
            this.Answer12.Name = "Answer12";
            this.Answer12.Size = new System.Drawing.Size(169, 23);
            this.Answer12.TabIndex = 22;
            this.Answer12.UseVisualStyleBackColor = true;
            this.Answer12.Click += new System.EventHandler(this.Answer12_Click);
            // 
            // Answer11
            // 
            this.Answer11.Enabled = false;
            this.Answer11.Location = new System.Drawing.Point(254, 135);
            this.Answer11.Name = "Answer11";
            this.Answer11.Size = new System.Drawing.Size(169, 23);
            this.Answer11.TabIndex = 21;
            this.Answer11.UseVisualStyleBackColor = true;
            this.Answer11.Click += new System.EventHandler(this.Answer11_Click);
            // 
            // Answer10
            // 
            this.Answer10.Enabled = false;
            this.Answer10.Location = new System.Drawing.Point(254, 106);
            this.Answer10.Name = "Answer10";
            this.Answer10.Size = new System.Drawing.Size(169, 23);
            this.Answer10.TabIndex = 20;
            this.Answer10.UseVisualStyleBackColor = true;
            this.Answer10.Click += new System.EventHandler(this.Answer10_Click);
            // 
            // Answer9
            // 
            this.Answer9.Enabled = false;
            this.Answer9.Location = new System.Drawing.Point(254, 77);
            this.Answer9.Name = "Answer9";
            this.Answer9.Size = new System.Drawing.Size(169, 23);
            this.Answer9.TabIndex = 19;
            this.Answer9.UseVisualStyleBackColor = true;
            this.Answer9.Click += new System.EventHandler(this.Answer9_Click);
            // 
            // Answer8
            // 
            this.Answer8.Enabled = false;
            this.Answer8.Location = new System.Drawing.Point(254, 48);
            this.Answer8.Name = "Answer8";
            this.Answer8.Size = new System.Drawing.Size(169, 23);
            this.Answer8.TabIndex = 18;
            this.Answer8.UseVisualStyleBackColor = true;
            this.Answer8.Click += new System.EventHandler(this.Answer8_Click);
            // 
            // Value12
            // 
            this.Value12.Enabled = false;
            this.Value12.Location = new System.Drawing.Point(223, 167);
            this.Value12.Name = "Value12";
            this.Value12.Size = new System.Drawing.Size(25, 20);
            this.Value12.TabIndex = 17;
            // 
            // Value11
            // 
            this.Value11.Enabled = false;
            this.Value11.Location = new System.Drawing.Point(223, 138);
            this.Value11.Name = "Value11";
            this.Value11.Size = new System.Drawing.Size(25, 20);
            this.Value11.TabIndex = 16;
            // 
            // Value10
            // 
            this.Value10.Enabled = false;
            this.Value10.Location = new System.Drawing.Point(223, 109);
            this.Value10.Name = "Value10";
            this.Value10.Size = new System.Drawing.Size(25, 20);
            this.Value10.TabIndex = 15;
            // 
            // Value9
            // 
            this.Value9.Enabled = false;
            this.Value9.Location = new System.Drawing.Point(223, 80);
            this.Value9.Name = "Value9";
            this.Value9.Size = new System.Drawing.Size(25, 20);
            this.Value9.TabIndex = 14;
            // 
            // Value8
            // 
            this.Value8.Enabled = false;
            this.Value8.Location = new System.Drawing.Point(223, 52);
            this.Value8.Name = "Value8";
            this.Value8.Size = new System.Drawing.Size(25, 20);
            this.Value8.TabIndex = 13;
            // 
            // Value7
            // 
            this.Value7.Enabled = false;
            this.Value7.Location = new System.Drawing.Point(223, 22);
            this.Value7.Name = "Value7";
            this.Value7.Size = new System.Drawing.Size(25, 20);
            this.Value7.TabIndex = 12;
            // 
            // Answer7
            // 
            this.Answer7.Enabled = false;
            this.Answer7.Location = new System.Drawing.Point(254, 19);
            this.Answer7.Name = "Answer7";
            this.Answer7.Size = new System.Drawing.Size(169, 23);
            this.Answer7.TabIndex = 11;
            this.Answer7.UseVisualStyleBackColor = true;
            this.Answer7.Click += new System.EventHandler(this.Answer7_Click);
            // 
            // Value6
            // 
            this.Value6.Enabled = false;
            this.Value6.Location = new System.Drawing.Point(182, 167);
            this.Value6.Name = "Value6";
            this.Value6.Size = new System.Drawing.Size(25, 20);
            this.Value6.TabIndex = 7;
            // 
            // Value5
            // 
            this.Value5.Enabled = false;
            this.Value5.Location = new System.Drawing.Point(182, 138);
            this.Value5.Name = "Value5";
            this.Value5.Size = new System.Drawing.Size(25, 20);
            this.Value5.TabIndex = 10;
            // 
            // Value4
            // 
            this.Value4.Enabled = false;
            this.Value4.Location = new System.Drawing.Point(182, 109);
            this.Value4.Name = "Value4";
            this.Value4.Size = new System.Drawing.Size(25, 20);
            this.Value4.TabIndex = 9;
            // 
            // Value3
            // 
            this.Value3.Enabled = false;
            this.Value3.Location = new System.Drawing.Point(182, 80);
            this.Value3.Name = "Value3";
            this.Value3.Size = new System.Drawing.Size(25, 20);
            this.Value3.TabIndex = 7;
            // 
            // Value2
            // 
            this.Value2.Enabled = false;
            this.Value2.Location = new System.Drawing.Point(182, 52);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(25, 20);
            this.Value2.TabIndex = 8;
            // 
            // Value1
            // 
            this.Value1.Enabled = false;
            this.Value1.Location = new System.Drawing.Point(182, 22);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(25, 20);
            this.Value1.TabIndex = 6;
            // 
            // Answer6
            // 
            this.Answer6.Enabled = false;
            this.Answer6.Location = new System.Drawing.Point(6, 165);
            this.Answer6.Name = "Answer6";
            this.Answer6.Size = new System.Drawing.Size(169, 23);
            this.Answer6.TabIndex = 5;
            this.Answer6.UseVisualStyleBackColor = true;
            this.Answer6.Click += new System.EventHandler(this.Answer6_Click);
            // 
            // Answer5
            // 
            this.Answer5.Enabled = false;
            this.Answer5.Location = new System.Drawing.Point(6, 136);
            this.Answer5.Name = "Answer5";
            this.Answer5.Size = new System.Drawing.Size(169, 23);
            this.Answer5.TabIndex = 4;
            this.Answer5.UseVisualStyleBackColor = true;
            this.Answer5.Click += new System.EventHandler(this.Answer5_Click);
            // 
            // Answer4
            // 
            this.Answer4.Enabled = false;
            this.Answer4.Location = new System.Drawing.Point(6, 107);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(169, 23);
            this.Answer4.TabIndex = 3;
            this.Answer4.UseVisualStyleBackColor = true;
            this.Answer4.Click += new System.EventHandler(this.Answer4_Click);
            // 
            // Answer3
            // 
            this.Answer3.Enabled = false;
            this.Answer3.Location = new System.Drawing.Point(6, 78);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(169, 23);
            this.Answer3.TabIndex = 2;
            this.Answer3.UseVisualStyleBackColor = true;
            this.Answer3.Click += new System.EventHandler(this.Answer3_Click);
            // 
            // Answer2
            // 
            this.Answer2.Enabled = false;
            this.Answer2.Location = new System.Drawing.Point(6, 49);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(169, 23);
            this.Answer2.TabIndex = 1;
            this.Answer2.UseVisualStyleBackColor = true;
            this.Answer2.Click += new System.EventHandler(this.Answer2_Click);
            // 
            // Answer1
            // 
            this.Answer1.Enabled = false;
            this.Answer1.Location = new System.Drawing.Point(6, 20);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(169, 23);
            this.Answer1.TabIndex = 0;
            this.Answer1.UseVisualStyleBackColor = true;
            this.Answer1.Click += new System.EventHandler(this.Answer1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(493, 180);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 210;
            this.lineShape1.X2 = 210;
            this.lineShape1.Y1 = -16;
            this.lineShape1.Y2 = 212;
            // 
            // FastMoney
            // 
            this.FastMoney.Location = new System.Drawing.Point(4, 22);
            this.FastMoney.Name = "FastMoney";
            this.FastMoney.Padding = new System.Windows.Forms.Padding(3);
            this.FastMoney.Size = new System.Drawing.Size(717, 437);
            this.FastMoney.TabIndex = 1;
            this.FastMoney.Text = "Fast Money";
            this.FastMoney.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StrikeSound);
            this.groupBox3.Location = new System.Drawing.Point(6, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(705, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game Control";
            // 
            // StrikeSound
            // 
            this.StrikeSound.Location = new System.Drawing.Point(6, 19);
            this.StrikeSound.Name = "StrikeSound";
            this.StrikeSound.Size = new System.Drawing.Size(75, 23);
            this.StrikeSound.TabIndex = 0;
            this.StrikeSound.Text = "Strike";
            this.StrikeSound.UseVisualStyleBackColor = true;
            this.StrikeSound.Click += new System.EventHandler(this.StrikeSound_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.P1Strikes);
            this.groupBox4.Controls.Add(this.P1Score);
            this.groupBox4.Controls.Add(this.P1Pass);
            this.groupBox4.Controls.Add(this.P1Play);
            this.groupBox4.Location = new System.Drawing.Point(6, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 164);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Team 1 Control";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.P2Strikes);
            this.groupBox5.Controls.Add(this.P2Score);
            this.groupBox5.Controls.Add(this.P2Pass);
            this.groupBox5.Controls.Add(this.P2Play);
            this.groupBox5.Location = new System.Drawing.Point(466, 267);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(245, 164);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Team 2 Control";
            // 
            // P1Play
            // 
            this.P1Play.Location = new System.Drawing.Point(7, 20);
            this.P1Play.Name = "P1Play";
            this.P1Play.Size = new System.Drawing.Size(75, 23);
            this.P1Play.TabIndex = 0;
            this.P1Play.Text = "Play";
            this.P1Play.UseVisualStyleBackColor = true;
            // 
            // P1Pass
            // 
            this.P1Pass.Location = new System.Drawing.Point(167, 20);
            this.P1Pass.Name = "P1Pass";
            this.P1Pass.Size = new System.Drawing.Size(75, 23);
            this.P1Pass.TabIndex = 1;
            this.P1Pass.Text = "Pass";
            this.P1Pass.UseVisualStyleBackColor = true;
            // 
            // P1Score
            // 
            this.P1Score.AutoSize = true;
            this.P1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Score.Location = new System.Drawing.Point(6, 46);
            this.P1Score.Name = "P1Score";
            this.P1Score.Size = new System.Drawing.Size(40, 42);
            this.P1Score.TabIndex = 2;
            this.P1Score.Text = "0";
            // 
            // P1Strikes
            // 
            this.P1Strikes.AutoSize = true;
            this.P1Strikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Strikes.ForeColor = System.Drawing.Color.Red;
            this.P1Strikes.Location = new System.Drawing.Point(6, 88);
            this.P1Strikes.Name = "P1Strikes";
            this.P1Strikes.Size = new System.Drawing.Size(40, 42);
            this.P1Strikes.TabIndex = 3;
            this.P1Strikes.Text = "0";
            // 
            // P2Pass
            // 
            this.P2Pass.Location = new System.Drawing.Point(166, 20);
            this.P2Pass.Name = "P2Pass";
            this.P2Pass.Size = new System.Drawing.Size(75, 23);
            this.P2Pass.TabIndex = 3;
            this.P2Pass.Text = "Pass";
            this.P2Pass.UseVisualStyleBackColor = true;
            // 
            // P2Play
            // 
            this.P2Play.Location = new System.Drawing.Point(6, 20);
            this.P2Play.Name = "P2Play";
            this.P2Play.Size = new System.Drawing.Size(75, 23);
            this.P2Play.TabIndex = 2;
            this.P2Play.Text = "Play";
            this.P2Play.UseVisualStyleBackColor = true;
            // 
            // P2Strikes
            // 
            this.P2Strikes.AutoSize = true;
            this.P2Strikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Strikes.ForeColor = System.Drawing.Color.Red;
            this.P2Strikes.Location = new System.Drawing.Point(6, 88);
            this.P2Strikes.Name = "P2Strikes";
            this.P2Strikes.Size = new System.Drawing.Size(40, 42);
            this.P2Strikes.TabIndex = 5;
            this.P2Strikes.Text = "0";
            // 
            // P2Score
            // 
            this.P2Score.AutoSize = true;
            this.P2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Score.Location = new System.Drawing.Point(6, 46);
            this.P2Score.Name = "P2Score";
            this.P2Score.Size = new System.Drawing.Size(40, 42);
            this.P2Score.TabIndex = 4;
            this.P2Score.Text = "0";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CurrentPlayingTeam);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.GlobalScore);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(260, 267);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 164);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Game Overview";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current pot score:";
            // 
            // GlobalScore
            // 
            this.GlobalScore.AutoSize = true;
            this.GlobalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GlobalScore.Location = new System.Drawing.Point(7, 37);
            this.GlobalScore.Name = "GlobalScore";
            this.GlobalScore.Size = new System.Drawing.Size(25, 25);
            this.GlobalScore.TabIndex = 1;
            this.GlobalScore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Team Playing:";
            // 
            // CurrentPlayingTeam
            // 
            this.CurrentPlayingTeam.AutoSize = true;
            this.CurrentPlayingTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPlayingTeam.Location = new System.Drawing.Point(7, 90);
            this.CurrentPlayingTeam.Name = "CurrentPlayingTeam";
            this.CurrentPlayingTeam.Size = new System.Drawing.Size(67, 25);
            this.CurrentPlayingTeam.TabIndex = 3;
            this.CurrentPlayingTeam.Text = "None";
            // 
            // GameMode
            // 
            this.GameMode.AutoSize = true;
            this.GameMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameMode.Location = new System.Drawing.Point(6, 16);
            this.GameMode.Name = "GameMode";
            this.GameMode.Size = new System.Drawing.Size(157, 24);
            this.GameMode.TabIndex = 5;
            this.GameMode.Text = "Single (face-off)";
            // 
            // MCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 487);
            this.Controls.Add(this.GMSwitcher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MCP";
            this.ShowIcon = false;
            this.Text = "Master Control Program";
            this.Load += new System.EventHandler(this.MCP_Load);
            this.GMSwitcher.ResumeLayout(false);
            this.MainGame.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl GMSwitcher;
        private System.Windows.Forms.TabPage MainGame;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton GMTriple;
        private System.Windows.Forms.RadioButton GMDouble;
        private System.Windows.Forms.RadioButton GMSingle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage FastMoney;
        private System.Windows.Forms.Button Answer2;
        private System.Windows.Forms.Button Answer1;
        private System.Windows.Forms.TextBox Value1;
        private System.Windows.Forms.Button Answer6;
        private System.Windows.Forms.Button Answer5;
        private System.Windows.Forms.Button Answer4;
        private System.Windows.Forms.Button Answer3;
        private System.Windows.Forms.TextBox Value6;
        private System.Windows.Forms.TextBox Value5;
        private System.Windows.Forms.TextBox Value4;
        private System.Windows.Forms.TextBox Value3;
        private System.Windows.Forms.TextBox Value2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button Answer12;
        private System.Windows.Forms.Button Answer11;
        private System.Windows.Forms.Button Answer10;
        private System.Windows.Forms.Button Answer9;
        private System.Windows.Forms.Button Answer8;
        private System.Windows.Forms.TextBox Value12;
        private System.Windows.Forms.TextBox Value11;
        private System.Windows.Forms.TextBox Value10;
        private System.Windows.Forms.TextBox Value9;
        private System.Windows.Forms.TextBox Value8;
        private System.Windows.Forms.TextBox Value7;
        private System.Windows.Forms.Button Answer7;
        private System.Windows.Forms.Button LoadNextRound;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button StrikeSound;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label CurrentPlayingTeam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GlobalScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label P2Strikes;
        private System.Windows.Forms.Label P2Score;
        private System.Windows.Forms.Button P2Pass;
        private System.Windows.Forms.Button P2Play;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label P1Strikes;
        private System.Windows.Forms.Label P1Score;
        private System.Windows.Forms.Button P1Pass;
        private System.Windows.Forms.Button P1Play;
        private System.Windows.Forms.Label GameMode;
    }
}


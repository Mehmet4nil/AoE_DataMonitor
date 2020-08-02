namespace AoE_DataMonitor
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userListBox = new System.Windows.Forms.ListBox();
            this.chrtWood = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.selectPlayerButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chrtFood = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblWood = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.radio1x = new System.Windows.Forms.RadioButton();
            this.radio2x = new System.Windows.Forms.RadioButton();
            this.radio4x = new System.Windows.Forms.RadioButton();
            this.radio16x = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStone = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.chrtStone = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtGold = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblMils = new System.Windows.Forms.Label();
            this.lblVils = new System.Windows.Forms.Label();
            this.chrtMils = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtVils = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblScore = new System.Windows.Forms.Label();
            this.chrtScore = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblPlyr = new System.Windows.Forms.Label();
            this.grbBxStatus = new System.Windows.Forms.GroupBox();
            this.lblFirstPlayer = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrtWood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtStone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtMils)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtVils)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.grbBxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // userListBox
            // 
            this.userListBox.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 14;
            this.userListBox.Location = new System.Drawing.Point(12, 25);
            this.userListBox.Name = "userListBox";
            this.userListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.userListBox.Size = new System.Drawing.Size(170, 116);
            this.userListBox.TabIndex = 0;
            // 
            // chrtWood
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtWood.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtWood.Legends.Add(legend1);
            this.chrtWood.Location = new System.Drawing.Point(-16, 278);
            this.chrtWood.Name = "chrtWood";
            this.chrtWood.Size = new System.Drawing.Size(540, 260);
            this.chrtWood.TabIndex = 1;
            this.chrtWood.Text = "chrtWood";
            // 
            // selectPlayerButton
            // 
            this.selectPlayerButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectPlayerButton.Location = new System.Drawing.Point(12, 171);
            this.selectPlayerButton.Name = "selectPlayerButton";
            this.selectPlayerButton.Size = new System.Drawing.Size(170, 23);
            this.selectPlayerButton.TabIndex = 2;
            this.selectPlayerButton.Text = "Select Players and Speed";
            this.selectPlayerButton.UseVisualStyleBackColor = true;
            this.selectPlayerButton.Click += new System.EventHandler(this.selectPlayerButton_click);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.playButton.Location = new System.Drawing.Point(12, 200);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(81, 22);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 94;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chrtFood
            // 
            chartArea2.Name = "ChartArea1";
            this.chrtFood.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtFood.Legends.Add(legend2);
            this.chrtFood.Location = new System.Drawing.Point(525, 278);
            this.chrtFood.Name = "chrtFood";
            this.chrtFood.Size = new System.Drawing.Size(540, 260);
            this.chrtFood.TabIndex = 5;
            this.chrtFood.Text = "chrtFood";
            // 
            // lblWood
            // 
            this.lblWood.AutoSize = true;
            this.lblWood.Location = new System.Drawing.Point(434, 412);
            this.lblWood.Name = "lblWood";
            this.lblWood.Size = new System.Drawing.Size(36, 13);
            this.lblWood.TabIndex = 6;
            this.lblWood.Text = "Wood";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(975, 406);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(31, 13);
            this.lblFood.TabIndex = 7;
            this.lblFood.Text = "Food";
            // 
            // pauseButton
            // 
            this.pauseButton.Enabled = false;
            this.pauseButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pauseButton.Location = new System.Drawing.Point(101, 200);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(81, 22);
            this.pauseButton.TabIndex = 8;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // radio1x
            // 
            this.radio1x.AutoSize = true;
            this.radio1x.Checked = true;
            this.radio1x.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio1x.Location = new System.Drawing.Point(12, 147);
            this.radio1x.Name = "radio1x";
            this.radio1x.Size = new System.Drawing.Size(35, 18);
            this.radio1x.TabIndex = 9;
            this.radio1x.TabStop = true;
            this.radio1x.Text = "1x";
            this.radio1x.UseVisualStyleBackColor = true;
            // 
            // radio2x
            // 
            this.radio2x.AutoSize = true;
            this.radio2x.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio2x.Location = new System.Drawing.Point(54, 147);
            this.radio2x.Name = "radio2x";
            this.radio2x.Size = new System.Drawing.Size(37, 18);
            this.radio2x.TabIndex = 10;
            this.radio2x.TabStop = true;
            this.radio2x.Text = "2x";
            this.radio2x.UseVisualStyleBackColor = true;
            // 
            // radio4x
            // 
            this.radio4x.AutoSize = true;
            this.radio4x.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio4x.Location = new System.Drawing.Point(97, 147);
            this.radio4x.Name = "radio4x";
            this.radio4x.Size = new System.Drawing.Size(37, 18);
            this.radio4x.TabIndex = 11;
            this.radio4x.TabStop = true;
            this.radio4x.Text = "4x";
            this.radio4x.UseVisualStyleBackColor = true;
            // 
            // radio16x
            // 
            this.radio16x.AutoSize = true;
            this.radio16x.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio16x.Location = new System.Drawing.Point(140, 147);
            this.radio16x.Name = "radio16x";
            this.radio16x.Size = new System.Drawing.Size(42, 18);
            this.radio16x.TabIndex = 12;
            this.radio16x.TabStop = true;
            this.radio16x.Text = "16x";
            this.radio16x.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(6, 19);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            // 
            // lblStone
            // 
            this.lblStone.AutoSize = true;
            this.lblStone.Location = new System.Drawing.Point(431, 669);
            this.lblStone.Name = "lblStone";
            this.lblStone.Size = new System.Drawing.Size(35, 13);
            this.lblStone.TabIndex = 17;
            this.lblStone.Text = "Stone";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(1515, 405);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(29, 13);
            this.lblGold.TabIndex = 16;
            this.lblGold.Text = "Gold";
            // 
            // chrtStone
            // 
            chartArea3.Name = "ChartArea1";
            this.chrtStone.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chrtStone.Legends.Add(legend3);
            this.chrtStone.Location = new System.Drawing.Point(-16, 544);
            this.chrtStone.Name = "chrtStone";
            this.chrtStone.Size = new System.Drawing.Size(540, 260);
            this.chrtStone.TabIndex = 15;
            this.chrtStone.Text = "chrtStone";
            // 
            // chrtGold
            // 
            chartArea4.Name = "ChartArea1";
            this.chrtGold.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chrtGold.Legends.Add(legend4);
            this.chrtGold.Location = new System.Drawing.Point(1066, 278);
            this.chrtGold.Name = "chrtGold";
            this.chrtGold.Size = new System.Drawing.Size(540, 260);
            this.chrtGold.TabIndex = 14;
            this.chrtGold.Text = "chrtGold";
            // 
            // lblMils
            // 
            this.lblMils.AutoSize = true;
            this.lblMils.Location = new System.Drawing.Point(1501, 668);
            this.lblMils.Name = "lblMils";
            this.lblMils.Size = new System.Drawing.Size(66, 13);
            this.lblMils.TabIndex = 21;
            this.lblMils.Text = "Military Units";
            // 
            // lblVils
            // 
            this.lblVils.AutoSize = true;
            this.lblVils.Location = new System.Drawing.Point(964, 669);
            this.lblVils.Name = "lblVils";
            this.lblVils.Size = new System.Drawing.Size(46, 13);
            this.lblVils.TabIndex = 20;
            this.lblVils.Text = "Villagers";
            // 
            // chrtMils
            // 
            chartArea5.Name = "ChartArea1";
            this.chrtMils.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chrtMils.Legends.Add(legend5);
            this.chrtMils.Location = new System.Drawing.Point(1066, 544);
            this.chrtMils.Name = "chrtMils";
            this.chrtMils.Size = new System.Drawing.Size(540, 260);
            this.chrtMils.TabIndex = 19;
            this.chrtMils.Text = "chrtMils";
            // 
            // chrtVils
            // 
            chartArea6.Name = "ChartArea1";
            this.chrtVils.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chrtVils.Legends.Add(legend6);
            this.chrtVils.Location = new System.Drawing.Point(525, 544);
            this.chrtVils.Name = "chrtVils";
            this.chrtVils.Size = new System.Drawing.Size(540, 260);
            this.chrtVils.TabIndex = 18;
            this.chrtVils.Text = "chrtVils";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(972, 143);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 23;
            this.lblScore.Text = "Score";
            // 
            // chrtScore
            // 
            chartArea7.Name = "ChartArea1";
            this.chrtScore.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chrtScore.Legends.Add(legend7);
            this.chrtScore.Location = new System.Drawing.Point(525, 12);
            this.chrtScore.Name = "chrtScore";
            this.chrtScore.Size = new System.Drawing.Size(540, 260);
            this.chrtScore.TabIndex = 22;
            this.chrtScore.Text = "chrtScore";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(966, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(410, 428);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(957, 422);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1497, 421);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1507, 684);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(959, 685);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(57, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(424, 685);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(51, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 30;
            this.pictureBox7.TabStop = false;
            // 
            // lblPlyr
            // 
            this.lblPlyr.AutoSize = true;
            this.lblPlyr.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlyr.Location = new System.Drawing.Point(73, 4);
            this.lblPlyr.Name = "lblPlyr";
            this.lblPlyr.Size = new System.Drawing.Size(52, 18);
            this.lblPlyr.TabIndex = 31;
            this.lblPlyr.Text = "Players";
            // 
            // grbBxStatus
            // 
            this.grbBxStatus.Controls.Add(this.lblStatus);
            this.grbBxStatus.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbBxStatus.Location = new System.Drawing.Point(12, 228);
            this.grbBxStatus.Name = "grbBxStatus";
            this.grbBxStatus.Size = new System.Drawing.Size(169, 46);
            this.grbBxStatus.TabIndex = 32;
            this.grbBxStatus.TabStop = false;
            this.grbBxStatus.Text = "File Status";
            // 
            // lblFirstPlayer
            // 
            this.lblFirstPlayer.AutoSize = true;
            this.lblFirstPlayer.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstPlayer.Location = new System.Drawing.Point(959, 229);
            this.lblFirstPlayer.Name = "lblFirstPlayer";
            this.lblFirstPlayer.Size = new System.Drawing.Size(65, 15);
            this.lblFirstPlayer.TabIndex = 33;
            this.lblFirstPlayer.Text = "FirstPlayer";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecond.Location = new System.Drawing.Point(915, 213);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(61, 14);
            this.lblSecond.TabIndex = 34;
            this.lblSecond.Text = "First Player";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirstPlayer);
            this.Controls.Add(this.grbBxStatus);
            this.Controls.Add(this.lblPlyr);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMils);
            this.Controls.Add(this.lblVils);
            this.Controls.Add(this.chrtMils);
            this.Controls.Add(this.chrtVils);
            this.Controls.Add(this.lblStone);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.chrtStone);
            this.Controls.Add(this.chrtGold);
            this.Controls.Add(this.radio16x);
            this.Controls.Add(this.radio4x);
            this.Controls.Add(this.radio2x);
            this.Controls.Add(this.radio1x);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.lblWood);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.selectPlayerButton);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.chrtFood);
            this.Controls.Add(this.chrtWood);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.chrtScore);
            this.Name = "Form1";
            this.Text = "AoE Data Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtWood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtStone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtMils)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtVils)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.grbBxStatus.ResumeLayout(false);
            this.grbBxStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtWood;
        private System.Windows.Forms.Button selectPlayerButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtFood;
        private System.Windows.Forms.Label lblWood;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.RadioButton radio1x;
        private System.Windows.Forms.RadioButton radio2x;
        private System.Windows.Forms.RadioButton radio4x;
        private System.Windows.Forms.RadioButton radio16x;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStone;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtStone;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtGold;
        private System.Windows.Forms.Label lblMils;
        private System.Windows.Forms.Label lblVils;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtMils;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtVils;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblPlyr;
        private System.Windows.Forms.GroupBox grbBxStatus;
        private System.Windows.Forms.Label lblFirstPlayer;
        private System.Windows.Forms.Label lblSecond;
    }
}


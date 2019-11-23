namespace WojciechWojtowiczLab1Zadanie
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.labelGoldMine = new System.Windows.Forms.Label();
            this.labelSawmill = new System.Windows.Forms.Label();
            this.labelBarrack = new System.Windows.Forms.Label();
            this.buttonGoldMineUpgrade = new System.Windows.Forms.Button();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.labelGlobalTime = new System.Windows.Forms.Label();
            this.labelMyArmy = new System.Windows.Forms.Label();
            this.labelWood = new System.Windows.Forms.Label();
            this.labelGold = new System.Windows.Forms.Label();
            this.labelWallLevel = new System.Windows.Forms.Label();
            this.progressBarGoldMineUpgrade = new System.Windows.Forms.ProgressBar();
            this.buttonSawmillUpgrade = new System.Windows.Forms.Button();
            this.buttonWallUpgrade = new System.Windows.Forms.Button();
            this.progressBarSawmillUpgrade = new System.Windows.Forms.ProgressBar();
            this.timerGoldMineUpgrade = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerSawmillUpgrade = new System.Windows.Forms.Timer(this.components);
            this.timerBarrackUpgrade = new System.Windows.Forms.Timer(this.components);
            this.timerWallUpgrade = new System.Windows.Forms.Timer(this.components);
            this.buttonBarrackUpgrade = new System.Windows.Forms.Button();
            this.progressBarBarrackUpgrade = new System.Windows.Forms.ProgressBar();
            this.progressBarWallUpgrade = new System.Windows.Forms.ProgressBar();
            this.buttonGoldMineInfo = new System.Windows.Forms.Button();
            this.buttonSawmillInfo = new System.Windows.Forms.Button();
            this.buttonWallInfo = new System.Windows.Forms.Button();
            this.buttonBarrackMore = new System.Windows.Forms.Button();
            this.labelSawmillMaterials = new System.Windows.Forms.Label();
            this.labelWallMaterials = new System.Windows.Forms.Label();
            this.labelBarrackMaterials = new System.Windows.Forms.Label();
            this.labelGoldMineMaterials = new System.Windows.Forms.Label();
            this.pictureBoxVillage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVillage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGoldMine
            // 
            this.labelGoldMine.AutoSize = true;
            this.labelGoldMine.BackColor = System.Drawing.Color.Transparent;
            this.labelGoldMine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGoldMine.Location = new System.Drawing.Point(29, 175);
            this.labelGoldMine.Name = "labelGoldMine";
            this.labelGoldMine.Size = new System.Drawing.Size(89, 25);
            this.labelGoldMine.TabIndex = 1;
            this.labelGoldMine.Text = "Kopalnia";
            // 
            // labelSawmill
            // 
            this.labelSawmill.AutoSize = true;
            this.labelSawmill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSawmill.Location = new System.Drawing.Point(17, 692);
            this.labelSawmill.Name = "labelSawmill";
            this.labelSawmill.Size = new System.Drawing.Size(68, 25);
            this.labelSawmill.TabIndex = 2;
            this.labelSawmill.Text = "Tartak";
            // 
            // labelBarrack
            // 
            this.labelBarrack.AutoSize = true;
            this.labelBarrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBarrack.Location = new System.Drawing.Point(388, 338);
            this.labelBarrack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBarrack.Name = "labelBarrack";
            this.labelBarrack.Size = new System.Drawing.Size(84, 25);
            this.labelBarrack.TabIndex = 3;
            this.labelBarrack.Text = "Koszary";
            // 
            // buttonGoldMineUpgrade
            // 
            this.buttonGoldMineUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGoldMineUpgrade.Location = new System.Drawing.Point(23, 206);
            this.buttonGoldMineUpgrade.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGoldMineUpgrade.Name = "buttonGoldMineUpgrade";
            this.buttonGoldMineUpgrade.Size = new System.Drawing.Size(100, 28);
            this.buttonGoldMineUpgrade.TabIndex = 4;
            this.buttonGoldMineUpgrade.Text = "Ulepsz";
            this.buttonGoldMineUpgrade.UseVisualStyleBackColor = true;
            this.buttonGoldMineUpgrade.Click += new System.EventHandler(this.buttonGoldMineUpgrade_Click);
            // 
            // timerCount
            // 
            this.timerCount.Tick += new System.EventHandler(this.timerCount_Tick);
            // 
            // labelGlobalTime
            // 
            this.labelGlobalTime.AutoSize = true;
            this.labelGlobalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGlobalTime.Location = new System.Drawing.Point(747, 11);
            this.labelGlobalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGlobalTime.Name = "labelGlobalTime";
            this.labelGlobalTime.Size = new System.Drawing.Size(207, 29);
            this.labelGlobalTime.TabIndex = 5;
            this.labelGlobalTime.Text = "Dzien 0 Godzina 0";
            // 
            // labelMyArmy
            // 
            this.labelMyArmy.AutoSize = true;
            this.labelMyArmy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMyArmy.Location = new System.Drawing.Point(747, 52);
            this.labelMyArmy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMyArmy.Name = "labelMyArmy";
            this.labelMyArmy.Size = new System.Drawing.Size(161, 29);
            this.labelMyArmy.TabIndex = 6;
            this.labelMyArmy.Text = "Wojownicy 10";
            // 
            // labelWood
            // 
            this.labelWood.AutoSize = true;
            this.labelWood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWood.Location = new System.Drawing.Point(747, 92);
            this.labelWood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWood.Name = "labelWood";
            this.labelWood.Size = new System.Drawing.Size(129, 29);
            this.labelWood.TabIndex = 7;
            this.labelWood.Text = "Drewno 10";
            // 
            // labelGold
            // 
            this.labelGold.AutoSize = true;
            this.labelGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGold.Location = new System.Drawing.Point(747, 133);
            this.labelGold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(112, 29);
            this.labelGold.TabIndex = 8;
            this.labelGold.Text = "Zloto 100";
            // 
            // labelWallLevel
            // 
            this.labelWallLevel.AutoSize = true;
            this.labelWallLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWallLevel.Location = new System.Drawing.Point(659, 470);
            this.labelWallLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWallLevel.Name = "labelWallLevel";
            this.labelWallLevel.Size = new System.Drawing.Size(130, 25);
            this.labelWallLevel.TabIndex = 9;
            this.labelWallLevel.Text = "Mur poziom 1";
            // 
            // progressBarGoldMineUpgrade
            // 
            this.progressBarGoldMineUpgrade.Location = new System.Drawing.Point(23, 241);
            this.progressBarGoldMineUpgrade.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarGoldMineUpgrade.Maximum = 5;
            this.progressBarGoldMineUpgrade.Name = "progressBarGoldMineUpgrade";
            this.progressBarGoldMineUpgrade.Size = new System.Drawing.Size(207, 28);
            this.progressBarGoldMineUpgrade.TabIndex = 10;
            this.progressBarGoldMineUpgrade.Visible = false;
            // 
            // buttonSawmillUpgrade
            // 
            this.buttonSawmillUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSawmillUpgrade.Location = new System.Drawing.Point(183, 689);
            this.buttonSawmillUpgrade.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSawmillUpgrade.Name = "buttonSawmillUpgrade";
            this.buttonSawmillUpgrade.Size = new System.Drawing.Size(100, 28);
            this.buttonSawmillUpgrade.TabIndex = 11;
            this.buttonSawmillUpgrade.Text = "Ulepsz";
            this.buttonSawmillUpgrade.UseVisualStyleBackColor = true;
            this.buttonSawmillUpgrade.Click += new System.EventHandler(this.buttonSawmillUpgrade_Click);
            // 
            // buttonWallUpgrade
            // 
            this.buttonWallUpgrade.Location = new System.Drawing.Point(664, 498);
            this.buttonWallUpgrade.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWallUpgrade.Name = "buttonWallUpgrade";
            this.buttonWallUpgrade.Size = new System.Drawing.Size(100, 28);
            this.buttonWallUpgrade.TabIndex = 12;
            this.buttonWallUpgrade.Text = "Ulepsz";
            this.buttonWallUpgrade.UseVisualStyleBackColor = true;
            this.buttonWallUpgrade.Click += new System.EventHandler(this.buttonWallUpgrade_Click);
            // 
            // progressBarSawmillUpgrade
            // 
            this.progressBarSawmillUpgrade.Location = new System.Drawing.Point(291, 689);
            this.progressBarSawmillUpgrade.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarSawmillUpgrade.Maximum = 5;
            this.progressBarSawmillUpgrade.Name = "progressBarSawmillUpgrade";
            this.progressBarSawmillUpgrade.Size = new System.Drawing.Size(133, 28);
            this.progressBarSawmillUpgrade.TabIndex = 13;
            this.progressBarSawmillUpgrade.Visible = false;
            // 
            // timerGoldMineUpgrade
            // 
            this.timerGoldMineUpgrade.Interval = 1000;
            this.timerGoldMineUpgrade.Tick += new System.EventHandler(this.timerGoldMineUpgrade_Tick);
            // 
            // timerSawmillUpgrade
            // 
            this.timerSawmillUpgrade.Interval = 1000;
            this.timerSawmillUpgrade.Tick += new System.EventHandler(this.timerSawmillUpgrade_Tick);
            // 
            // timerBarrackUpgrade
            // 
            this.timerBarrackUpgrade.Interval = 1000;
            this.timerBarrackUpgrade.Tick += new System.EventHandler(this.timerBarrackUpgrade_Tick);
            // 
            // timerWallUpgrade
            // 
            this.timerWallUpgrade.Interval = 1000;
            this.timerWallUpgrade.Tick += new System.EventHandler(this.timerWallUpgrade_Tick);
            // 
            // buttonBarrackUpgrade
            // 
            this.buttonBarrackUpgrade.Location = new System.Drawing.Point(381, 367);
            this.buttonBarrackUpgrade.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBarrackUpgrade.Name = "buttonBarrackUpgrade";
            this.buttonBarrackUpgrade.Size = new System.Drawing.Size(100, 28);
            this.buttonBarrackUpgrade.TabIndex = 15;
            this.buttonBarrackUpgrade.Text = "Ulepsz";
            this.buttonBarrackUpgrade.UseVisualStyleBackColor = true;
            this.buttonBarrackUpgrade.Click += new System.EventHandler(this.buttonBarrackUpgrade_Click);
            // 
            // progressBarBarrackUpgrade
            // 
            this.progressBarBarrackUpgrade.Location = new System.Drawing.Point(381, 402);
            this.progressBarBarrackUpgrade.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarBarrackUpgrade.Maximum = 5;
            this.progressBarBarrackUpgrade.Name = "progressBarBarrackUpgrade";
            this.progressBarBarrackUpgrade.Size = new System.Drawing.Size(207, 28);
            this.progressBarBarrackUpgrade.TabIndex = 16;
            this.progressBarBarrackUpgrade.Visible = false;
            // 
            // progressBarWallUpgrade
            // 
            this.progressBarWallUpgrade.Location = new System.Drawing.Point(664, 534);
            this.progressBarWallUpgrade.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarWallUpgrade.Maximum = 5;
            this.progressBarWallUpgrade.Name = "progressBarWallUpgrade";
            this.progressBarWallUpgrade.Size = new System.Drawing.Size(207, 28);
            this.progressBarWallUpgrade.TabIndex = 17;
            this.progressBarWallUpgrade.Visible = false;
            // 
            // buttonGoldMineInfo
            // 
            this.buttonGoldMineInfo.Location = new System.Drawing.Point(131, 206);
            this.buttonGoldMineInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGoldMineInfo.Name = "buttonGoldMineInfo";
            this.buttonGoldMineInfo.Size = new System.Drawing.Size(100, 28);
            this.buttonGoldMineInfo.TabIndex = 18;
            this.buttonGoldMineInfo.Text = "Info";
            this.buttonGoldMineInfo.UseVisualStyleBackColor = true;
            this.buttonGoldMineInfo.Click += new System.EventHandler(this.buttonGoldMineInfo_Click);
            // 
            // buttonSawmillInfo
            // 
            this.buttonSawmillInfo.Location = new System.Drawing.Point(183, 654);
            this.buttonSawmillInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSawmillInfo.Name = "buttonSawmillInfo";
            this.buttonSawmillInfo.Size = new System.Drawing.Size(100, 28);
            this.buttonSawmillInfo.TabIndex = 19;
            this.buttonSawmillInfo.Text = "Info";
            this.buttonSawmillInfo.UseVisualStyleBackColor = true;
            this.buttonSawmillInfo.Click += new System.EventHandler(this.buttonSawmillInfo_Click);
            // 
            // buttonWallInfo
            // 
            this.buttonWallInfo.Location = new System.Drawing.Point(771, 498);
            this.buttonWallInfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWallInfo.Name = "buttonWallInfo";
            this.buttonWallInfo.Size = new System.Drawing.Size(100, 28);
            this.buttonWallInfo.TabIndex = 20;
            this.buttonWallInfo.Text = "Info";
            this.buttonWallInfo.UseVisualStyleBackColor = true;
            this.buttonWallInfo.Click += new System.EventHandler(this.buttonWallInfo_Click);
            // 
            // buttonBarrackMore
            // 
            this.buttonBarrackMore.Location = new System.Drawing.Point(489, 367);
            this.buttonBarrackMore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBarrackMore.Name = "buttonBarrackMore";
            this.buttonBarrackMore.Size = new System.Drawing.Size(100, 28);
            this.buttonBarrackMore.TabIndex = 21;
            this.buttonBarrackMore.Text = "Więcej";
            this.buttonBarrackMore.UseVisualStyleBackColor = true;
            this.buttonBarrackMore.Click += new System.EventHandler(this.buttonBarrackMore_Click);
            // 
            // labelSawmillMaterials
            // 
            this.labelSawmillMaterials.AutoSize = true;
            this.labelSawmillMaterials.Location = new System.Drawing.Point(291, 695);
            this.labelSawmillMaterials.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSawmillMaterials.Name = "labelSawmillMaterials";
            this.labelSawmillMaterials.Size = new System.Drawing.Size(52, 17);
            this.labelSawmillMaterials.TabIndex = 22;
            this.labelSawmillMaterials.Text = "sawmill";
            // 
            // labelWallMaterials
            // 
            this.labelWallMaterials.AutoSize = true;
            this.labelWallMaterials.Location = new System.Drawing.Point(672, 534);
            this.labelWallMaterials.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWallMaterials.Name = "labelWallMaterials";
            this.labelWallMaterials.Size = new System.Drawing.Size(31, 17);
            this.labelWallMaterials.TabIndex = 23;
            this.labelWallMaterials.Text = "wall";
            // 
            // labelBarrackMaterials
            // 
            this.labelBarrackMaterials.AutoSize = true;
            this.labelBarrackMaterials.Location = new System.Drawing.Point(389, 402);
            this.labelBarrackMaterials.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBarrackMaterials.Name = "labelBarrackMaterials";
            this.labelBarrackMaterials.Size = new System.Drawing.Size(56, 17);
            this.labelBarrackMaterials.TabIndex = 24;
            this.labelBarrackMaterials.Text = "barrack";
            // 
            // labelGoldMineMaterials
            // 
            this.labelGoldMineMaterials.AutoSize = true;
            this.labelGoldMineMaterials.Location = new System.Drawing.Point(31, 241);
            this.labelGoldMineMaterials.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGoldMineMaterials.Name = "labelGoldMineMaterials";
            this.labelGoldMineMaterials.Size = new System.Drawing.Size(65, 17);
            this.labelGoldMineMaterials.TabIndex = 25;
            this.labelGoldMineMaterials.Text = "goldmine";
            // 
            // pictureBoxVillage
            // 
            this.pictureBoxVillage.Image = global::WojciechWojtowiczLab1Zadanie.Properties.Resources.wioskav2;
            this.pictureBoxVillage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxVillage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxVillage.Name = "pictureBoxVillage";
            this.pictureBoxVillage.Size = new System.Drawing.Size(1013, 729);
            this.pictureBoxVillage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVillage.TabIndex = 0;
            this.pictureBoxVillage.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.labelGoldMineMaterials);
            this.Controls.Add(this.labelBarrackMaterials);
            this.Controls.Add(this.labelWallMaterials);
            this.Controls.Add(this.labelSawmillMaterials);
            this.Controls.Add(this.buttonBarrackMore);
            this.Controls.Add(this.buttonWallInfo);
            this.Controls.Add(this.buttonSawmillInfo);
            this.Controls.Add(this.buttonGoldMineInfo);
            this.Controls.Add(this.progressBarWallUpgrade);
            this.Controls.Add(this.progressBarBarrackUpgrade);
            this.Controls.Add(this.buttonBarrackUpgrade);
            this.Controls.Add(this.progressBarSawmillUpgrade);
            this.Controls.Add(this.buttonWallUpgrade);
            this.Controls.Add(this.buttonSawmillUpgrade);
            this.Controls.Add(this.progressBarGoldMineUpgrade);
            this.Controls.Add(this.labelWallLevel);
            this.Controls.Add(this.labelGold);
            this.Controls.Add(this.labelWood);
            this.Controls.Add(this.labelMyArmy);
            this.Controls.Add(this.labelGlobalTime);
            this.Controls.Add(this.buttonGoldMineUpgrade);
            this.Controls.Add(this.labelBarrack);
            this.Controls.Add(this.labelSawmill);
            this.Controls.Add(this.labelGoldMine);
            this.Controls.Add(this.pictureBoxVillage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Symulator Wioski";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVillage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxVillage;
        private System.Windows.Forms.Label labelGoldMine;
        private System.Windows.Forms.Label labelSawmill;
        private System.Windows.Forms.Label labelBarrack;
        private System.Windows.Forms.Button buttonGoldMineUpgrade;
        private System.Windows.Forms.Timer timerCount;
        private System.Windows.Forms.Label labelGlobalTime;
        private System.Windows.Forms.Label labelMyArmy;
        private System.Windows.Forms.Label labelWood;
        private System.Windows.Forms.Label labelGold;
        private System.Windows.Forms.Label labelWallLevel;
        private System.Windows.Forms.ProgressBar progressBarGoldMineUpgrade;
        private System.Windows.Forms.Button buttonSawmillUpgrade;
        private System.Windows.Forms.Button buttonWallUpgrade;
        private System.Windows.Forms.ProgressBar progressBarSawmillUpgrade;
        private System.Windows.Forms.Timer timerGoldMineUpgrade;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timerSawmillUpgrade;
        private System.Windows.Forms.Timer timerBarrackUpgrade;
        private System.Windows.Forms.Timer timerWallUpgrade;
        private System.Windows.Forms.Button buttonBarrackUpgrade;
        private System.Windows.Forms.ProgressBar progressBarBarrackUpgrade;
        private System.Windows.Forms.ProgressBar progressBarWallUpgrade;
        private System.Windows.Forms.Button buttonGoldMineInfo;
        private System.Windows.Forms.Button buttonSawmillInfo;
        private System.Windows.Forms.Button buttonWallInfo;
        private System.Windows.Forms.Button buttonBarrackMore;
        private System.Windows.Forms.Label labelSawmillMaterials;
        private System.Windows.Forms.Label labelWallMaterials;
        private System.Windows.Forms.Label labelBarrackMaterials;
        private System.Windows.Forms.Label labelGoldMineMaterials;
    }
}


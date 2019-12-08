namespace WojciechWojtowiczLab3Zadanie
{
    partial class FormGame
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
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.labelMyMoney = new System.Windows.Forms.Label();
            this.labelMyHonor = new System.Windows.Forms.Label();
            this.labelMyFishingCard = new System.Windows.Forms.Label();
            this.timerGlobalTime = new System.Windows.Forms.Timer(this.components);
            this.labelHour = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelWeek = new System.Windows.Forms.Label();
            this.buttonLakeBeginer = new System.Windows.Forms.Button();
            this.buttonLakeIntermediate = new System.Windows.Forms.Button();
            this.buttonLakeAdvenced = new System.Windows.Forms.Button();
            this.buttonLakeBeginerInfo = new System.Windows.Forms.Button();
            this.buttonLakeIntermediateInfo = new System.Windows.Forms.Button();
            this.buttonLakeAdvencedInfo = new System.Windows.Forms.Button();
            this.buttonShop = new System.Windows.Forms.Button();
            this.pictureBoxGame = new System.Windows.Forms.PictureBox();
            this.buttonFishingCentre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.AutoSize = true;
            this.buttonBackToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(113, 30);
            this.buttonBackToMainMenu.TabIndex = 0;
            this.buttonBackToMainMenu.Text = "Menu glowne";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // labelMyMoney
            // 
            this.labelMyMoney.AutoSize = true;
            this.labelMyMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMyMoney.Location = new System.Drawing.Point(682, 60);
            this.labelMyMoney.Name = "labelMyMoney";
            this.labelMyMoney.Size = new System.Drawing.Size(149, 24);
            this.labelMyMoney.TabIndex = 2;
            this.labelMyMoney.Text = "Pieniądze: 0PLN";
            // 
            // labelMyHonor
            // 
            this.labelMyHonor.AutoSize = true;
            this.labelMyHonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMyHonor.Location = new System.Drawing.Point(682, 101);
            this.labelMyHonor.Name = "labelMyHonor";
            this.labelMyHonor.Size = new System.Drawing.Size(83, 24);
            this.labelMyHonor.TabIndex = 3;
            this.labelMyHonor.Text = "Honor: 0";
            // 
            // labelMyFishingCard
            // 
            this.labelMyFishingCard.AutoSize = true;
            this.labelMyFishingCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMyFishingCard.Location = new System.Drawing.Point(682, 145);
            this.labelMyFishingCard.Name = "labelMyFishingCard";
            this.labelMyFishingCard.Size = new System.Drawing.Size(193, 24);
            this.labelMyFishingCard.TabIndex = 4;
            this.labelMyFishingCard.Text = "Karta wędkarska: Brak";
            // 
            // timerGlobalTime
            // 
            this.timerGlobalTime.Interval = 1000;
            this.timerGlobalTime.Tick += new System.EventHandler(this.timerGlobalTime_Tick);
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHour.Location = new System.Drawing.Point(846, 9);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(100, 24);
            this.labelHour.TabIndex = 5;
            this.labelHour.Text = "Godzina: 0";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDay.Location = new System.Drawing.Point(753, 9);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(78, 24);
            this.labelDay.TabIndex = 6;
            this.labelDay.Text = "Dzień: 0";
            // 
            // labelWeek
            // 
            this.labelWeek.AutoSize = true;
            this.labelWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWeek.Location = new System.Drawing.Point(641, 9);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(97, 24);
            this.labelWeek.TabIndex = 7;
            this.labelWeek.Text = "Tydzień: 0";
            // 
            // buttonLakeBeginer
            // 
            this.buttonLakeBeginer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLakeBeginer.Location = new System.Drawing.Point(179, 235);
            this.buttonLakeBeginer.Name = "buttonLakeBeginer";
            this.buttonLakeBeginer.Size = new System.Drawing.Size(104, 30);
            this.buttonLakeBeginer.TabIndex = 8;
            this.buttonLakeBeginer.Text = "Idź na ryby";
            this.buttonLakeBeginer.UseVisualStyleBackColor = true;
            this.buttonLakeBeginer.Click += new System.EventHandler(this.buttonLakeBeginer_Click);
            // 
            // buttonLakeIntermediate
            // 
            this.buttonLakeIntermediate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLakeIntermediate.Location = new System.Drawing.Point(552, 475);
            this.buttonLakeIntermediate.Name = "buttonLakeIntermediate";
            this.buttonLakeIntermediate.Size = new System.Drawing.Size(104, 30);
            this.buttonLakeIntermediate.TabIndex = 9;
            this.buttonLakeIntermediate.Text = "Idź na ryby";
            this.buttonLakeIntermediate.UseVisualStyleBackColor = true;
            this.buttonLakeIntermediate.Click += new System.EventHandler(this.buttonLakeIntermediate_Click);
            // 
            // buttonLakeAdvenced
            // 
            this.buttonLakeAdvenced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLakeAdvenced.Location = new System.Drawing.Point(52, 685);
            this.buttonLakeAdvenced.Name = "buttonLakeAdvenced";
            this.buttonLakeAdvenced.Size = new System.Drawing.Size(104, 30);
            this.buttonLakeAdvenced.TabIndex = 10;
            this.buttonLakeAdvenced.Text = "Idź na ryby";
            this.buttonLakeAdvenced.UseVisualStyleBackColor = true;
            this.buttonLakeAdvenced.Click += new System.EventHandler(this.buttonLakeAdvenced_Click);
            // 
            // buttonLakeBeginerInfo
            // 
            this.buttonLakeBeginerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLakeBeginerInfo.Location = new System.Drawing.Point(204, 271);
            this.buttonLakeBeginerInfo.Name = "buttonLakeBeginerInfo";
            this.buttonLakeBeginerInfo.Size = new System.Drawing.Size(55, 30);
            this.buttonLakeBeginerInfo.TabIndex = 11;
            this.buttonLakeBeginerInfo.Text = "Info";
            this.buttonLakeBeginerInfo.UseVisualStyleBackColor = true;
            this.buttonLakeBeginerInfo.Click += new System.EventHandler(this.buttonLakeBeginerInfo_Click);
            // 
            // buttonLakeIntermediateInfo
            // 
            this.buttonLakeIntermediateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLakeIntermediateInfo.Location = new System.Drawing.Point(577, 511);
            this.buttonLakeIntermediateInfo.Name = "buttonLakeIntermediateInfo";
            this.buttonLakeIntermediateInfo.Size = new System.Drawing.Size(55, 30);
            this.buttonLakeIntermediateInfo.TabIndex = 12;
            this.buttonLakeIntermediateInfo.Text = "Info";
            this.buttonLakeIntermediateInfo.UseVisualStyleBackColor = true;
            this.buttonLakeIntermediateInfo.Click += new System.EventHandler(this.buttonLakeIntermediateInfo_Click);
            // 
            // buttonLakeAdvencedInfo
            // 
            this.buttonLakeAdvencedInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLakeAdvencedInfo.Location = new System.Drawing.Point(77, 721);
            this.buttonLakeAdvencedInfo.Name = "buttonLakeAdvencedInfo";
            this.buttonLakeAdvencedInfo.Size = new System.Drawing.Size(55, 30);
            this.buttonLakeAdvencedInfo.TabIndex = 13;
            this.buttonLakeAdvencedInfo.Text = "Info";
            this.buttonLakeAdvencedInfo.UseVisualStyleBackColor = true;
            this.buttonLakeAdvencedInfo.Click += new System.EventHandler(this.buttonLakeAdvencedInfo_Click);
            // 
            // buttonShop
            // 
            this.buttonShop.AutoSize = true;
            this.buttonShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShop.Location = new System.Drawing.Point(577, 685);
            this.buttonShop.Name = "buttonShop";
            this.buttonShop.Size = new System.Drawing.Size(75, 30);
            this.buttonShop.TabIndex = 14;
            this.buttonShop.Text = "Sklep";
            this.buttonShop.UseVisualStyleBackColor = true;
            this.buttonShop.Click += new System.EventHandler(this.buttonShop_Click);
            // 
            // pictureBoxGame
            // 
            this.pictureBoxGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGame.Image = global::WojciechWojtowiczLab3Zadanie.Properties.Resources.mapa_gry;
            this.pictureBoxGame.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxGame.Name = "pictureBoxGame";
            this.pictureBoxGame.Size = new System.Drawing.Size(958, 831);
            this.pictureBoxGame.TabIndex = 1;
            this.pictureBoxGame.TabStop = false;
            // 
            // buttonFishingCentre
            // 
            this.buttonFishingCentre.Location = new System.Drawing.Point(12, 48);
            this.buttonFishingCentre.Name = "buttonFishingCentre";
            this.buttonFishingCentre.Size = new System.Drawing.Size(113, 35);
            this.buttonFishingCentre.TabIndex = 15;
            this.buttonFishingCentre.Text = "Złowione ryby";
            this.buttonFishingCentre.UseVisualStyleBackColor = true;
            this.buttonFishingCentre.Click += new System.EventHandler(this.buttonFishingCentre_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(958, 831);
            this.Controls.Add(this.buttonFishingCentre);
            this.Controls.Add(this.buttonShop);
            this.Controls.Add(this.buttonLakeAdvencedInfo);
            this.Controls.Add(this.buttonLakeIntermediateInfo);
            this.Controls.Add(this.buttonLakeBeginerInfo);
            this.Controls.Add(this.buttonLakeAdvenced);
            this.Controls.Add(this.buttonLakeIntermediate);
            this.Controls.Add(this.buttonLakeBeginer);
            this.Controls.Add(this.labelWeek);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.labelMyFishingCard);
            this.Controls.Add(this.labelMyHonor);
            this.Controls.Add(this.labelMyMoney);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.pictureBoxGame);
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.Text = "Mapa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.PictureBox pictureBoxGame;
        private System.Windows.Forms.Label labelMyMoney;
        private System.Windows.Forms.Label labelMyHonor;
        private System.Windows.Forms.Label labelMyFishingCard;
        private System.Windows.Forms.Timer timerGlobalTime;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelWeek;
        private System.Windows.Forms.Button buttonLakeBeginer;
        private System.Windows.Forms.Button buttonLakeIntermediate;
        private System.Windows.Forms.Button buttonLakeAdvenced;
        private System.Windows.Forms.Button buttonLakeBeginerInfo;
        private System.Windows.Forms.Button buttonLakeIntermediateInfo;
        private System.Windows.Forms.Button buttonLakeAdvencedInfo;
        private System.Windows.Forms.Button buttonShop;
        private System.Windows.Forms.Button buttonFishingCentre;
    }
}
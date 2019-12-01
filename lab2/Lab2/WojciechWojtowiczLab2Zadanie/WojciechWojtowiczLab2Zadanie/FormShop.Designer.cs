namespace WojciechWojtowiczLab2Zadanie
{
    partial class FormShop
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
            this.labelHour = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelWeek = new System.Windows.Forms.Label();
            this.labelMyMoney = new System.Windows.Forms.Label();
            this.labelMyHonor = new System.Windows.Forms.Label();
            this.labelMyFishingCard = new System.Windows.Forms.Label();
            this.timerGlobalTime = new System.Windows.Forms.Timer(this.components);
            this.buttonFishingCard = new System.Windows.Forms.Button();
            this.pictureBoxShop = new System.Windows.Forms.PictureBox();
            this.buttonGetFishingCard = new System.Windows.Forms.Button();
            this.labelCardExamCost = new System.Windows.Forms.Label();
            this.labelCardCost = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShop)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHour.Location = new System.Drawing.Point(12, 9);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(85, 24);
            this.labelHour.TabIndex = 1;
            this.labelHour.Text = "Godzina:";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDay.Location = new System.Drawing.Point(12, 41);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(63, 24);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Dzień:";
            // 
            // labelWeek
            // 
            this.labelWeek.AutoSize = true;
            this.labelWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWeek.Location = new System.Drawing.Point(12, 73);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(82, 24);
            this.labelWeek.TabIndex = 3;
            this.labelWeek.Text = "Tydzień:";
            // 
            // labelMyMoney
            // 
            this.labelMyMoney.AutoSize = true;
            this.labelMyMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMyMoney.Location = new System.Drawing.Point(12, 105);
            this.labelMyMoney.Name = "labelMyMoney";
            this.labelMyMoney.Size = new System.Drawing.Size(98, 24);
            this.labelMyMoney.TabIndex = 4;
            this.labelMyMoney.Text = "Pieniądze:";
            // 
            // labelMyHonor
            // 
            this.labelMyHonor.AutoSize = true;
            this.labelMyHonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMyHonor.Location = new System.Drawing.Point(12, 137);
            this.labelMyHonor.Name = "labelMyHonor";
            this.labelMyHonor.Size = new System.Drawing.Size(68, 24);
            this.labelMyHonor.TabIndex = 5;
            this.labelMyHonor.Text = "Honor:";
            // 
            // labelMyFishingCard
            // 
            this.labelMyFishingCard.AutoSize = true;
            this.labelMyFishingCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMyFishingCard.Location = new System.Drawing.Point(12, 169);
            this.labelMyFishingCard.Name = "labelMyFishingCard";
            this.labelMyFishingCard.Size = new System.Drawing.Size(151, 24);
            this.labelMyFishingCard.TabIndex = 6;
            this.labelMyFishingCard.Text = "Karta wędkarska:";
            // 
            // timerGlobalTime
            // 
            this.timerGlobalTime.Interval = 1000;
            this.timerGlobalTime.Tick += new System.EventHandler(this.timerGlobalTime_Tick);
            // 
            // buttonFishingCard
            // 
            this.buttonFishingCard.AutoSize = true;
            this.buttonFishingCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFishingCard.Location = new System.Drawing.Point(490, 403);
            this.buttonFishingCard.Name = "buttonFishingCard";
            this.buttonFishingCard.Size = new System.Drawing.Size(298, 35);
            this.buttonFishingCard.TabIndex = 7;
            this.buttonFishingCard.Text = "Egzamin na kartę wędkarską";
            this.buttonFishingCard.UseVisualStyleBackColor = true;
            this.buttonFishingCard.Click += new System.EventHandler(this.buttonFishingCard_Click);
            // 
            // pictureBoxShop
            // 
            this.pictureBoxShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxShop.Image = global::WojciechWojtowiczLab2Zadanie.Properties.Resources.sklep;
            this.pictureBoxShop.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxShop.Name = "pictureBoxShop";
            this.pictureBoxShop.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShop.TabIndex = 0;
            this.pictureBoxShop.TabStop = false;
            // 
            // buttonGetFishingCard
            // 
            this.buttonGetFishingCard.AutoSize = true;
            this.buttonGetFishingCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGetFishingCard.Location = new System.Drawing.Point(12, 403);
            this.buttonGetFishingCard.Name = "buttonGetFishingCard";
            this.buttonGetFishingCard.Size = new System.Drawing.Size(269, 35);
            this.buttonGetFishingCard.TabIndex = 8;
            this.buttonGetFishingCard.Text = "Wykup kartę wędkarską";
            this.buttonGetFishingCard.UseVisualStyleBackColor = true;
            this.buttonGetFishingCard.Visible = false;
            this.buttonGetFishingCard.Click += new System.EventHandler(this.buttonGetFishingCard_Click);
            // 
            // labelCardExamCost
            // 
            this.labelCardExamCost.AutoSize = true;
            this.labelCardExamCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCardExamCost.Location = new System.Drawing.Point(550, 371);
            this.labelCardExamCost.Name = "labelCardExamCost";
            this.labelCardExamCost.Size = new System.Drawing.Size(178, 20);
            this.labelCardExamCost.TabIndex = 9;
            this.labelCardExamCost.Text = "Koszt egzaminu: 50PLN";
            // 
            // labelCardCost
            // 
            this.labelCardCost.AutoSize = true;
            this.labelCardCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCardCost.Location = new System.Drawing.Point(27, 371);
            this.labelCardCost.Name = "labelCardCost";
            this.labelCardCost.Size = new System.Drawing.Size(238, 20);
            this.labelCardCost.TabIndex = 10;
            this.labelCardCost.Text = "Koszt karty wędkarskiej: 100PLN";
            this.labelCardCost.Visible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.Location = new System.Drawing.Point(713, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 30);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Wyjście";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelCardCost);
            this.Controls.Add(this.labelCardExamCost);
            this.Controls.Add(this.buttonGetFishingCard);
            this.Controls.Add(this.buttonFishingCard);
            this.Controls.Add(this.labelMyFishingCard);
            this.Controls.Add(this.labelMyHonor);
            this.Controls.Add(this.labelMyMoney);
            this.Controls.Add(this.labelWeek);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.pictureBoxShop);
            this.MaximizeBox = false;
            this.Name = "FormShop";
            this.Text = "Sklep wędkarski";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxShop;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelWeek;
        private System.Windows.Forms.Label labelMyMoney;
        private System.Windows.Forms.Label labelMyHonor;
        private System.Windows.Forms.Label labelMyFishingCard;
        private System.Windows.Forms.Timer timerGlobalTime;
        private System.Windows.Forms.Button buttonFishingCard;
        private System.Windows.Forms.Button buttonGetFishingCard;
        private System.Windows.Forms.Label labelCardExamCost;
        private System.Windows.Forms.Label labelCardCost;
        private System.Windows.Forms.Button buttonClose;
    }
}
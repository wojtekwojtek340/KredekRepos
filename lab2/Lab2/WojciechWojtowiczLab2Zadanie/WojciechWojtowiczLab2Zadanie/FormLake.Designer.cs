namespace WojciechWojtowiczLab2Zadanie
{
    partial class FormLake
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
            this.timerGlobalTime = new System.Windows.Forms.Timer(this.components);
            this.buttonStartFishing = new System.Windows.Forms.Button();
            this.buttonLookAtNet = new System.Windows.Forms.Button();
            this.buttonStopFishing = new System.Windows.Forms.Button();
            this.buttonLeaveLake = new System.Windows.Forms.Button();
            this.timerFishingMechanism = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxBream = new System.Windows.Forms.PictureBox();
            this.pictureBoxPike = new System.Windows.Forms.PictureBox();
            this.pictureBoxCarp = new System.Windows.Forms.PictureBox();
            this.pictureBoxFishingRod = new System.Windows.Forms.PictureBox();
            this.pictureBoxLakePicture = new System.Windows.Forms.PictureBox();
            this.labelMyMoney = new System.Windows.Forms.Label();
            this.labelMyHonor = new System.Windows.Forms.Label();
            this.labelMyFishingCard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFishingRod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLakePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHour.Location = new System.Drawing.Point(12, 9);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(130, 31);
            this.labelHour.TabIndex = 1;
            this.labelHour.Text = "Godzina: ";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDay.Location = new System.Drawing.Point(12, 53);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(99, 31);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Dzień: ";
            // 
            // labelWeek
            // 
            this.labelWeek.AutoSize = true;
            this.labelWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWeek.Location = new System.Drawing.Point(12, 97);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(125, 31);
            this.labelWeek.TabIndex = 3;
            this.labelWeek.Text = "Tydzień: ";
            // 
            // timerGlobalTime
            // 
            this.timerGlobalTime.Interval = 1000;
            this.timerGlobalTime.Tick += new System.EventHandler(this.timerGlobalTime_Tick_1);
            // 
            // buttonStartFishing
            // 
            this.buttonStartFishing.AutoSize = true;
            this.buttonStartFishing.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStartFishing.Location = new System.Drawing.Point(329, 755);
            this.buttonStartFishing.Name = "buttonStartFishing";
            this.buttonStartFishing.Size = new System.Drawing.Size(262, 52);
            this.buttonStartFishing.TabIndex = 5;
            this.buttonStartFishing.Text = "Zarzuć wędkę";
            this.buttonStartFishing.UseVisualStyleBackColor = true;
            this.buttonStartFishing.Click += new System.EventHandler(this.buttonStartFishing_Click);
            // 
            // buttonLookAtNet
            // 
            this.buttonLookAtNet.AutoSize = true;
            this.buttonLookAtNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLookAtNet.Location = new System.Drawing.Point(18, 755);
            this.buttonLookAtNet.Name = "buttonLookAtNet";
            this.buttonLookAtNet.Size = new System.Drawing.Size(282, 52);
            this.buttonLookAtNet.TabIndex = 6;
            this.buttonLookAtNet.Text = "Przeglądaj sieć";
            this.buttonLookAtNet.UseVisualStyleBackColor = true;
            this.buttonLookAtNet.Click += new System.EventHandler(this.buttonLookAtNet_Click);
            // 
            // buttonStopFishing
            // 
            this.buttonStopFishing.AutoSize = true;
            this.buttonStopFishing.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStopFishing.Location = new System.Drawing.Point(623, 755);
            this.buttonStopFishing.Name = "buttonStopFishing";
            this.buttonStopFishing.Size = new System.Drawing.Size(289, 52);
            this.buttonStopFishing.TabIndex = 11;
            this.buttonStopFishing.Text = "Schowaj wędkę";
            this.buttonStopFishing.UseVisualStyleBackColor = true;
            this.buttonStopFishing.Click += new System.EventHandler(this.buttonStopFishing_Click);
            // 
            // buttonLeaveLake
            // 
            this.buttonLeaveLake.AutoSize = true;
            this.buttonLeaveLake.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLeaveLake.Location = new System.Drawing.Point(936, 12);
            this.buttonLeaveLake.Name = "buttonLeaveLake";
            this.buttonLeaveLake.Size = new System.Drawing.Size(270, 52);
            this.buttonLeaveLake.TabIndex = 12;
            this.buttonLeaveLake.Text = "Opuść łowisko";
            this.buttonLeaveLake.UseVisualStyleBackColor = true;
            this.buttonLeaveLake.Click += new System.EventHandler(this.buttonLeaveLake_Click);
            // 
            // timerFishingMechanism
            // 
            this.timerFishingMechanism.Tick += new System.EventHandler(this.timerFishingMechanism_Tick);
            // 
            // pictureBoxBream
            // 
            this.pictureBoxBream.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBream.Image = global::WojciechWojtowiczLab2Zadanie.Properties.Resources.leszcz2;
            this.pictureBoxBream.Location = new System.Drawing.Point(443, 588);
            this.pictureBoxBream.Name = "pictureBoxBream";
            this.pictureBoxBream.Size = new System.Drawing.Size(188, 120);
            this.pictureBoxBream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBream.TabIndex = 10;
            this.pictureBoxBream.TabStop = false;
            this.pictureBoxBream.Visible = false;
            this.pictureBoxBream.Click += new System.EventHandler(this.pictureBoxBream_Click);
            // 
            // pictureBoxPike
            // 
            this.pictureBoxPike.Image = global::WojciechWojtowiczLab2Zadanie.Properties.Resources.szczupak2;
            this.pictureBoxPike.Location = new System.Drawing.Point(654, 448);
            this.pictureBoxPike.Name = "pictureBoxPike";
            this.pictureBoxPike.Size = new System.Drawing.Size(186, 135);
            this.pictureBoxPike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPike.TabIndex = 9;
            this.pictureBoxPike.TabStop = false;
            this.pictureBoxPike.Visible = false;
            this.pictureBoxPike.Click += new System.EventHandler(this.pictureBoxPike_Click);
            // 
            // pictureBoxCarp
            // 
            this.pictureBoxCarp.Image = global::WojciechWojtowiczLab2Zadanie.Properties.Resources.Karp;
            this.pictureBoxCarp.Location = new System.Drawing.Point(208, 448);
            this.pictureBoxCarp.Name = "pictureBoxCarp";
            this.pictureBoxCarp.Size = new System.Drawing.Size(188, 135);
            this.pictureBoxCarp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCarp.TabIndex = 8;
            this.pictureBoxCarp.TabStop = false;
            this.pictureBoxCarp.Visible = false;
            this.pictureBoxCarp.Click += new System.EventHandler(this.pictureBoxCarp_Click);
            // 
            // pictureBoxFishingRod
            // 
            this.pictureBoxFishingRod.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFishingRod.Image = global::WojciechWojtowiczLab2Zadanie.Properties.Resources.wędka1;
            this.pictureBoxFishingRod.Location = new System.Drawing.Point(995, 433);
            this.pictureBoxFishingRod.Name = "pictureBoxFishingRod";
            this.pictureBoxFishingRod.Size = new System.Drawing.Size(211, 374);
            this.pictureBoxFishingRod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFishingRod.TabIndex = 7;
            this.pictureBoxFishingRod.TabStop = false;
            this.pictureBoxFishingRod.Visible = false;
            // 
            // pictureBoxLakePicture
            // 
            this.pictureBoxLakePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLakePicture.Image = global::WojciechWojtowiczLab2Zadanie.Properties.Resources.jezioro2;
            this.pictureBoxLakePicture.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLakePicture.Name = "pictureBoxLakePicture";
            this.pictureBoxLakePicture.Size = new System.Drawing.Size(1218, 819);
            this.pictureBoxLakePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLakePicture.TabIndex = 4;
            this.pictureBoxLakePicture.TabStop = false;
            // 
            // labelMyMoney
            // 
            this.labelMyMoney.AutoSize = true;
            this.labelMyMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMyMoney.Location = new System.Drawing.Point(12, 141);
            this.labelMyMoney.Name = "labelMyMoney";
            this.labelMyMoney.Size = new System.Drawing.Size(148, 31);
            this.labelMyMoney.TabIndex = 13;
            this.labelMyMoney.Text = "Pieniądze: ";
            // 
            // labelMyHonor
            // 
            this.labelMyHonor.AutoSize = true;
            this.labelMyHonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMyHonor.Location = new System.Drawing.Point(12, 185);
            this.labelMyHonor.Name = "labelMyHonor";
            this.labelMyHonor.Size = new System.Drawing.Size(103, 31);
            this.labelMyHonor.TabIndex = 14;
            this.labelMyHonor.Text = "Honor: ";
            // 
            // labelMyFishingCard
            // 
            this.labelMyFishingCard.AutoSize = true;
            this.labelMyFishingCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMyFishingCard.Location = new System.Drawing.Point(12, 229);
            this.labelMyFishingCard.Name = "labelMyFishingCard";
            this.labelMyFishingCard.Size = new System.Drawing.Size(232, 31);
            this.labelMyFishingCard.TabIndex = 15;
            this.labelMyFishingCard.Text = "Karta wędkarska: ";
            // 
            // FormLake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1218, 819);
            this.Controls.Add(this.labelMyFishingCard);
            this.Controls.Add(this.labelMyHonor);
            this.Controls.Add(this.labelMyMoney);
            this.Controls.Add(this.buttonLeaveLake);
            this.Controls.Add(this.buttonStopFishing);
            this.Controls.Add(this.pictureBoxBream);
            this.Controls.Add(this.pictureBoxPike);
            this.Controls.Add(this.pictureBoxCarp);
            this.Controls.Add(this.pictureBoxFishingRod);
            this.Controls.Add(this.buttonLookAtNet);
            this.Controls.Add(this.buttonStartFishing);
            this.Controls.Add(this.labelWeek);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.pictureBoxLakePicture);
            this.MaximizeBox = false;
            this.Name = "FormLake";
            this.Text = "Jezioro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFishingRod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLakePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelWeek;
        private System.Windows.Forms.Timer timerGlobalTime;
        private System.Windows.Forms.PictureBox pictureBoxLakePicture;
        private System.Windows.Forms.Button buttonStartFishing;
        private System.Windows.Forms.Button buttonLookAtNet;
        private System.Windows.Forms.PictureBox pictureBoxFishingRod;
        private System.Windows.Forms.PictureBox pictureBoxCarp;
        private System.Windows.Forms.PictureBox pictureBoxPike;
        private System.Windows.Forms.PictureBox pictureBoxBream;
        private System.Windows.Forms.Button buttonStopFishing;
        private System.Windows.Forms.Button buttonLeaveLake;
        private System.Windows.Forms.Timer timerFishingMechanism;
        private System.Windows.Forms.Label labelMyMoney;
        private System.Windows.Forms.Label labelMyHonor;
        private System.Windows.Forms.Label labelMyFishingCard;
    }
}
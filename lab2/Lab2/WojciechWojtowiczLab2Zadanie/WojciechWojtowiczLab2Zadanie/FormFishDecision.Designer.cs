namespace WojciechWojtowiczLab2Zadanie
{
    partial class FormFishDecision
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
            this.labelCatchedFishName = new System.Windows.Forms.Label();
            this.labelCatchedFishLenght = new System.Windows.Forms.Label();
            this.labelCatchedFishProtectionLenght = new System.Windows.Forms.Label();
            this.buttonTakeFish = new System.Windows.Forms.Button();
            this.buttonThrowFish = new System.Windows.Forms.Button();
            this.labelCatchedFish = new System.Windows.Forms.Label();
            this.labelCatchedFishWeighht = new System.Windows.Forms.Label();
            this.pictureBoxDecision = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecision)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCatchedFishName
            // 
            this.labelCatchedFishName.AutoSize = true;
            this.labelCatchedFishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCatchedFishName.Location = new System.Drawing.Point(12, 61);
            this.labelCatchedFishName.Name = "labelCatchedFishName";
            this.labelCatchedFishName.Size = new System.Drawing.Size(99, 25);
            this.labelCatchedFishName.TabIndex = 1;
            this.labelCatchedFishName.Text = "Gatunek:";
            // 
            // labelCatchedFishLenght
            // 
            this.labelCatchedFishLenght.AutoSize = true;
            this.labelCatchedFishLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCatchedFishLenght.Location = new System.Drawing.Point(12, 145);
            this.labelCatchedFishLenght.Name = "labelCatchedFishLenght";
            this.labelCatchedFishLenght.Size = new System.Drawing.Size(97, 25);
            this.labelCatchedFishLenght.TabIndex = 3;
            this.labelCatchedFishLenght.Text = "Rozmiar:";
            // 
            // labelCatchedFishProtectionLenght
            // 
            this.labelCatchedFishProtectionLenght.AutoSize = true;
            this.labelCatchedFishProtectionLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCatchedFishProtectionLenght.Location = new System.Drawing.Point(12, 187);
            this.labelCatchedFishProtectionLenght.Name = "labelCatchedFishProtectionLenght";
            this.labelCatchedFishProtectionLenght.Size = new System.Drawing.Size(198, 25);
            this.labelCatchedFishProtectionLenght.TabIndex = 4;
            this.labelCatchedFishProtectionLenght.Text = "Rozmiar ochronny: ";
            // 
            // buttonTakeFish
            // 
            this.buttonTakeFish.AutoSize = true;
            this.buttonTakeFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTakeFish.Location = new System.Drawing.Point(43, 258);
            this.buttonTakeFish.Name = "buttonTakeFish";
            this.buttonTakeFish.Size = new System.Drawing.Size(105, 35);
            this.buttonTakeFish.TabIndex = 5;
            this.buttonTakeFish.Text = "Do sieci!";
            this.buttonTakeFish.UseVisualStyleBackColor = true;
            this.buttonTakeFish.Click += new System.EventHandler(this.buttonTakeFish_Click);
            // 
            // buttonThrowFish
            // 
            this.buttonThrowFish.AutoSize = true;
            this.buttonThrowFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonThrowFish.Location = new System.Drawing.Point(238, 258);
            this.buttonThrowFish.Name = "buttonThrowFish";
            this.buttonThrowFish.Size = new System.Drawing.Size(105, 35);
            this.buttonThrowFish.TabIndex = 6;
            this.buttonThrowFish.Text = "Wypuść!";
            this.buttonThrowFish.UseVisualStyleBackColor = true;
            this.buttonThrowFish.Click += new System.EventHandler(this.buttonThrowFish_Click);
            // 
            // labelCatchedFish
            // 
            this.labelCatchedFish.AutoSize = true;
            this.labelCatchedFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCatchedFish.Location = new System.Drawing.Point(12, 9);
            this.labelCatchedFish.Name = "labelCatchedFish";
            this.labelCatchedFish.Size = new System.Drawing.Size(247, 25);
            this.labelCatchedFish.TabIndex = 0;
            this.labelCatchedFish.Text = "Udało Ci się złowić rybę!";
            // 
            // labelCatchedFishWeighht
            // 
            this.labelCatchedFishWeighht.AutoSize = true;
            this.labelCatchedFishWeighht.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCatchedFishWeighht.Location = new System.Drawing.Point(12, 103);
            this.labelCatchedFishWeighht.Name = "labelCatchedFishWeighht";
            this.labelCatchedFishWeighht.Size = new System.Drawing.Size(74, 25);
            this.labelCatchedFishWeighht.TabIndex = 7;
            this.labelCatchedFishWeighht.Text = "Waga:";
            // 
            // pictureBoxDecision
            // 
            this.pictureBoxDecision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDecision.Image = global::WojciechWojtowiczLab2Zadanie.Properties.Resources.sukces_w_połowie;
            this.pictureBoxDecision.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDecision.Name = "pictureBoxDecision";
            this.pictureBoxDecision.Size = new System.Drawing.Size(398, 336);
            this.pictureBoxDecision.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDecision.TabIndex = 8;
            this.pictureBoxDecision.TabStop = false;
            // 
            // FormFishDecision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(398, 336);
            this.Controls.Add(this.labelCatchedFishWeighht);
            this.Controls.Add(this.buttonThrowFish);
            this.Controls.Add(this.buttonTakeFish);
            this.Controls.Add(this.labelCatchedFishProtectionLenght);
            this.Controls.Add(this.labelCatchedFishLenght);
            this.Controls.Add(this.labelCatchedFishName);
            this.Controls.Add(this.labelCatchedFish);
            this.Controls.Add(this.pictureBoxDecision);
            this.MaximizeBox = false;
            this.Name = "FormFishDecision";
            this.Text = "Przegląd złowionej ryby";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCatchedFishName;
        private System.Windows.Forms.Label labelCatchedFishLenght;
        private System.Windows.Forms.Label labelCatchedFishProtectionLenght;
        private System.Windows.Forms.Button buttonTakeFish;
        private System.Windows.Forms.Button buttonThrowFish;
        private System.Windows.Forms.Label labelCatchedFish;
        private System.Windows.Forms.Label labelCatchedFishWeighht;
        private System.Windows.Forms.PictureBox pictureBoxDecision;
    }
}
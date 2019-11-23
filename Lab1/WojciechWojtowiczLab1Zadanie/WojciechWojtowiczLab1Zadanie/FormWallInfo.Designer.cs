namespace WojciechWojtowiczLab1Zadanie
{
    partial class FormWallInfo
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
            this.labelWallLevel = new System.Windows.Forms.Label();
            this.labelWallDefense = new System.Windows.Forms.Label();
            this.labelWallDefenseNext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWallLevel
            // 
            this.labelWallLevel.AutoSize = true;
            this.labelWallLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWallLevel.Location = new System.Drawing.Point(80, 33);
            this.labelWallLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWallLevel.Name = "labelWallLevel";
            this.labelWallLevel.Size = new System.Drawing.Size(172, 31);
            this.labelWallLevel.TabIndex = 0;
            this.labelWallLevel.Text = "Poziom muru";
            // 
            // labelWallDefense
            // 
            this.labelWallDefense.AutoSize = true;
            this.labelWallDefense.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWallDefense.Location = new System.Drawing.Point(16, 89);
            this.labelWallDefense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWallDefense.Name = "labelWallDefense";
            this.labelWallDefense.Size = new System.Drawing.Size(271, 31);
            this.labelWallDefense.TabIndex = 1;
            this.labelWallDefense.Text = "Współczynnik obrony";
            // 
            // labelWallDefenseNext
            // 
            this.labelWallDefenseNext.AutoSize = true;
            this.labelWallDefenseNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWallDefenseNext.Location = new System.Drawing.Point(16, 151);
            this.labelWallDefenseNext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWallDefenseNext.Name = "labelWallDefenseNext";
            this.labelWallDefenseNext.Size = new System.Drawing.Size(299, 31);
            this.labelWallDefenseNext.TabIndex = 2;
            this.labelWallDefenseNext.Text = "Następny współczynnik";
            // 
            // FormWallInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WojciechWojtowiczLab1Zadanie.Properties.Resources.mur;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.labelWallDefenseNext);
            this.Controls.Add(this.labelWallDefense);
            this.Controls.Add(this.labelWallLevel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormWallInfo";
            this.Text = "FormWallInfo";
            this.Load += new System.EventHandler(this.FormWallInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWallLevel;
        private System.Windows.Forms.Label labelWallDefense;
        private System.Windows.Forms.Label labelWallDefenseNext;
    }
}
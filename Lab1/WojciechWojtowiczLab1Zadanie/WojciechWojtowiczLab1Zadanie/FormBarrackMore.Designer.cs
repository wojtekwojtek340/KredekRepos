namespace WojciechWojtowiczLab1Zadanie
{
    partial class FormBarrackMore
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
            this.labelMyGold = new System.Windows.Forms.Label();
            this.labelMyArmy = new System.Windows.Forms.Label();
            this.textBoxChoose = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelExpense = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelNumberOfArmy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMyGold
            // 
            this.labelMyGold.AutoSize = true;
            this.labelMyGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMyGold.Location = new System.Drawing.Point(11, 11);
            this.labelMyGold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMyGold.Name = "labelMyGold";
            this.labelMyGold.Size = new System.Drawing.Size(188, 29);
            this.labelMyGold.TabIndex = 0;
            this.labelMyGold.Text = "Posiadane złoto";
            // 
            // labelMyArmy
            // 
            this.labelMyArmy.AutoSize = true;
            this.labelMyArmy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMyArmy.Location = new System.Drawing.Point(11, 60);
            this.labelMyArmy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMyArmy.Name = "labelMyArmy";
            this.labelMyArmy.Size = new System.Drawing.Size(238, 29);
            this.labelMyArmy.TabIndex = 1;
            this.labelMyArmy.Text = "Posiadani wojownicy";
            // 
            // textBoxChoose
            // 
            this.textBoxChoose.Location = new System.Drawing.Point(73, 178);
            this.textBoxChoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxChoose.Name = "textBoxChoose";
            this.textBoxChoose.Size = new System.Drawing.Size(132, 22);
            this.textBoxChoose.TabIndex = 2;
            this.textBoxChoose.TextChanged += new System.EventHandler(this.textBoxChoose_TextChanged);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo.Location = new System.Drawing.Point(60, 126);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(241, 29);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "Rekrutuj wojowników";
            // 
            // labelExpense
            // 
            this.labelExpense.AutoSize = true;
            this.labelExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExpense.Location = new System.Drawing.Point(236, 174);
            this.labelExpense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExpense.Name = "labelExpense";
            this.labelExpense.Size = new System.Drawing.Size(72, 29);
            this.labelExpense.TabIndex = 4;
            this.labelExpense.Text = "Koszt";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonConfirm.Location = new System.Drawing.Point(124, 257);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(133, 49);
            this.buttonConfirm.TabIndex = 5;
            this.buttonConfirm.Text = "Potwierdź";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelNumberOfArmy
            // 
            this.labelNumberOfArmy.AutoSize = true;
            this.labelNumberOfArmy.Location = new System.Drawing.Point(120, 207);
            this.labelNumberOfArmy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumberOfArmy.Name = "labelNumberOfArmy";
            this.labelNumberOfArmy.Size = new System.Drawing.Size(36, 17);
            this.labelNumberOfArmy.TabIndex = 6;
            this.labelNumberOfArmy.Text = "Ilość";
            // 
            // FormBarrackMore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WojciechWojtowiczLab1Zadanie.Properties.Resources.koszary;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.labelNumberOfArmy);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelExpense);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxChoose);
            this.Controls.Add(this.labelMyArmy);
            this.Controls.Add(this.labelMyGold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBarrackMore";
            this.Text = "FormBarrackMore";
            this.Load += new System.EventHandler(this.FormBarrackMore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMyGold;
        private System.Windows.Forms.Label labelMyArmy;
        private System.Windows.Forms.TextBox textBoxChoose;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelExpense;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelNumberOfArmy;
    }
}
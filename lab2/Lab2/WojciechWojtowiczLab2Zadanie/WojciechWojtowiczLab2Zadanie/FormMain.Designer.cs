namespace WojciechWojtowiczLab2Zadanie
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonLoadGame = new System.Windows.Forms.Button();
            this.buttonSaveGame = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.pictureBoxMainMenu = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.AutoSize = true;
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNewGame.Location = new System.Drawing.Point(335, 244);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(95, 31);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "Nowa gra";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonLoadGame
            // 
            this.buttonLoadGame.AutoSize = true;
            this.buttonLoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLoadGame.Location = new System.Drawing.Point(332, 294);
            this.buttonLoadGame.Name = "buttonLoadGame";
            this.buttonLoadGame.Size = new System.Drawing.Size(101, 31);
            this.buttonLoadGame.TabIndex = 1;
            this.buttonLoadGame.Text = "Wczytaj gre";
            this.buttonLoadGame.UseVisualStyleBackColor = true;
            this.buttonLoadGame.Click += new System.EventHandler(this.buttonLoadGame_Click);
            // 
            // buttonSaveGame
            // 
            this.buttonSaveGame.AutoSize = true;
            this.buttonSaveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveGame.Location = new System.Drawing.Point(335, 194);
            this.buttonSaveGame.Name = "buttonSaveGame";
            this.buttonSaveGame.Size = new System.Drawing.Size(95, 31);
            this.buttonSaveGame.TabIndex = 2;
            this.buttonSaveGame.Text = "Zapisz gre";
            this.buttonSaveGame.UseVisualStyleBackColor = true;
            this.buttonSaveGame.Visible = false;
            this.buttonSaveGame.Click += new System.EventHandler(this.buttonSaveGame_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.AutoSize = true;
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonContinue.Location = new System.Drawing.Point(335, 144);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(95, 31);
            this.buttonContinue.TabIndex = 3;
            this.buttonContinue.Text = "Kontynuuj";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.AutoSize = true;
            this.labelMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMainMenu.Location = new System.Drawing.Point(238, 97);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(288, 31);
            this.labelMainMenu.TabIndex = 4;
            this.labelMainMenu.Text = "Symulator wędkarstwa";
            // 
            // pictureBoxMainMenu
            // 
            this.pictureBoxMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMainMenu.Image = global::WojciechWojtowiczLab2Zadanie.Properties.Resources.Zdjęcie_startowe;
            this.pictureBoxMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMainMenu.Name = "pictureBoxMainMenu";
            this.pictureBoxMainMenu.Size = new System.Drawing.Size(725, 398);
            this.pictureBoxMainMenu.TabIndex = 5;
            this.pictureBoxMainMenu.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.Location = new System.Drawing.Point(335, 344);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(95, 31);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Wyjdź";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(725, 398);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelMainMenu);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonLoadGame);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonSaveGame);
            this.Controls.Add(this.pictureBoxMainMenu);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Symulator wędkarstwa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonLoadGame;
        private System.Windows.Forms.Button buttonSaveGame;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label labelMainMenu;
        private System.Windows.Forms.PictureBox pictureBoxMainMenu;
        private System.Windows.Forms.Button buttonClose;
    }
}


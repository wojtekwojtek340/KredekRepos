namespace WojciechWojtowiczLab3Zadanie
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.buttonSingIn = new System.Windows.Forms.Button();
            this.buttonSingUp = new System.Windows.Forms.Button();
            this.pictureBoxMainMenu = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelLoggedName = new System.Windows.Forms.Label();
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
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(12, 17);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(36, 13);
            this.labelUserName.TabIndex = 7;
            this.labelUserName.Text = "Login:";
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Location = new System.Drawing.Point(9, 46);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(39, 13);
            this.labelUserPassword.TabIndex = 8;
            this.labelUserPassword.Text = "Hasło:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(57, 14);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserName.TabIndex = 10;
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(57, 43);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserPassword.TabIndex = 11;
            // 
            // buttonSingIn
            // 
            this.buttonSingIn.Location = new System.Drawing.Point(163, 12);
            this.buttonSingIn.Name = "buttonSingIn";
            this.buttonSingIn.Size = new System.Drawing.Size(75, 23);
            this.buttonSingIn.TabIndex = 12;
            this.buttonSingIn.Text = "Zaloguj";
            this.buttonSingIn.UseVisualStyleBackColor = true;
            this.buttonSingIn.Click += new System.EventHandler(this.buttonSingIn_Click);
            // 
            // buttonSingUp
            // 
            this.buttonSingUp.Location = new System.Drawing.Point(163, 41);
            this.buttonSingUp.Name = "buttonSingUp";
            this.buttonSingUp.Size = new System.Drawing.Size(75, 23);
            this.buttonSingUp.TabIndex = 13;
            this.buttonSingUp.Text = "Zarejestruj";
            this.buttonSingUp.UseVisualStyleBackColor = true;
            this.buttonSingUp.Click += new System.EventHandler(this.buttonSingUp_Click);
            // 
            // pictureBoxMainMenu
            // 
            this.pictureBoxMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMainMenu.Image = global::WojciechWojtowiczLab3Zadanie.Properties.Resources.Zdjęcie_startowe;
            this.pictureBoxMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMainMenu.Name = "pictureBoxMainMenu";
            this.pictureBoxMainMenu.Size = new System.Drawing.Size(725, 398);
            this.pictureBoxMainMenu.TabIndex = 5;
            this.pictureBoxMainMenu.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(130, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 14;
            this.buttonLogout.Text = "Wyloguj";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelLoggedName
            // 
            this.labelLoggedName.AutoSize = true;
            this.labelLoggedName.Location = new System.Drawing.Point(12, 17);
            this.labelLoggedName.Name = "labelLoggedName";
            this.labelLoggedName.Size = new System.Drawing.Size(71, 13);
            this.labelLoggedName.TabIndex = 15;
            this.labelLoggedName.Text = "Zalogowany: ";
            this.labelLoggedName.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(725, 398);
            this.Controls.Add(this.labelLoggedName);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonSingUp);
            this.Controls.Add(this.buttonSingIn);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.labelUserName);
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
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Button buttonSingIn;
        private System.Windows.Forms.Button buttonSingUp;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelLoggedName;
    }
}


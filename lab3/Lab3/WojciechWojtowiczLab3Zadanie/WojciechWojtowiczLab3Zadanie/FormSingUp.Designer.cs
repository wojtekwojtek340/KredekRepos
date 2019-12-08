namespace WojciechWojtowiczLab3Zadanie
{
    partial class FormSingUp
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.labelSingUp = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.buttonSingUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(102, 120);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserName.TabIndex = 0;
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(102, 173);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserPassword.TabIndex = 1;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(298, 12);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(338, 460);
            this.dataGridViewUsers.TabIndex = 2;
            // 
            // labelSingUp
            // 
            this.labelSingUp.AutoSize = true;
            this.labelSingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSingUp.Location = new System.Drawing.Point(47, 12);
            this.labelSingUp.Name = "labelSingUp";
            this.labelSingUp.Size = new System.Drawing.Size(182, 39);
            this.labelSingUp.TabIndex = 3;
            this.labelSingUp.Text = "Zarejestruj";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserName.Location = new System.Drawing.Point(13, 115);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(83, 25);
            this.labelUserName.TabIndex = 4;
            this.labelUserName.Text = "Nazwa:";
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserPassword.Location = new System.Drawing.Point(23, 168);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(73, 25);
            this.labelUserPassword.TabIndex = 5;
            this.labelUserPassword.Text = "Hasło:";
            // 
            // buttonSingUp
            // 
            this.buttonSingUp.AutoSize = true;
            this.buttonSingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSingUp.Location = new System.Drawing.Point(102, 232);
            this.buttonSingUp.Name = "buttonSingUp";
            this.buttonSingUp.Size = new System.Drawing.Size(94, 30);
            this.buttonSingUp.TabIndex = 6;
            this.buttonSingUp.Text = "Zarejestruj";
            this.buttonSingUp.UseVisualStyleBackColor = true;
            this.buttonSingUp.Click += new System.EventHandler(this.buttonSingUp_Click);
            // 
            // FormSingUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 484);
            this.Controls.Add(this.buttonSingUp);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelSingUp);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Name = "FormSingUp";
            this.Text = "FormSingUp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label labelSingUp;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Button buttonSingUp;
    }
}
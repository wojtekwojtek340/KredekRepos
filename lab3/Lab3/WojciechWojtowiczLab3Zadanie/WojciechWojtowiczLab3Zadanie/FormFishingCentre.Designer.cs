namespace WojciechWojtowiczLab3Zadanie
{
    partial class FormFishingCentre
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
            this.dataGridViewFishes = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxLenght = new System.Windows.Forms.TextBox();
            this.textBoxProtectionLenght = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelEdit = new System.Windows.Forms.Label();
            this.labelFishName = new System.Windows.Forms.Label();
            this.labelFishWeight = new System.Windows.Forms.Label();
            this.labelFishLenght = new System.Windows.Forms.Label();
            this.labelFishProtectionLenght = new System.Windows.Forms.Label();
            this.checkBoxMyFishes = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFishes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFishes
            // 
            this.dataGridViewFishes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFishes.Location = new System.Drawing.Point(274, 12);
            this.dataGridViewFishes.Name = "dataGridViewFishes";
            this.dataGridViewFishes.Size = new System.Drawing.Size(735, 654);
            this.dataGridViewFishes.TabIndex = 0;
            this.dataGridViewFishes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFishes_CellMouseClick);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(18, 106);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 35);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWeight.Location = new System.Drawing.Point(18, 188);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 35);
            this.textBoxWeight.TabIndex = 2;
            // 
            // textBoxLenght
            // 
            this.textBoxLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLenght.Location = new System.Drawing.Point(18, 270);
            this.textBoxLenght.Name = "textBoxLenght";
            this.textBoxLenght.Size = new System.Drawing.Size(100, 35);
            this.textBoxLenght.TabIndex = 3;
            // 
            // textBoxProtectionLenght
            // 
            this.textBoxProtectionLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxProtectionLenght.Location = new System.Drawing.Point(21, 352);
            this.textBoxProtectionLenght.Name = "textBoxProtectionLenght";
            this.textBoxProtectionLenght.Size = new System.Drawing.Size(100, 35);
            this.textBoxProtectionLenght.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(21, 473);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 35);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoSize = true;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdit.Location = new System.Drawing.Point(105, 473);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(82, 35);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.AutoSize = true;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRemove.Location = new System.Drawing.Point(193, 473);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 35);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "Usuń";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClear.Location = new System.Drawing.Point(92, 514);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(108, 35);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Wyczyść";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEdit.Location = new System.Drawing.Point(105, 12);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(114, 39);
            this.labelEdit.TabIndex = 10;
            this.labelEdit.Text = "Edytuj";
            // 
            // labelFishName
            // 
            this.labelFishName.AutoSize = true;
            this.labelFishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFishName.Location = new System.Drawing.Point(12, 68);
            this.labelFishName.Name = "labelFishName";
            this.labelFishName.Size = new System.Drawing.Size(142, 29);
            this.labelFishName.TabIndex = 11;
            this.labelFishName.Text = "Nazwa ryby:";
            // 
            // labelFishWeight
            // 
            this.labelFishWeight.AutoSize = true;
            this.labelFishWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFishWeight.Location = new System.Drawing.Point(12, 150);
            this.labelFishWeight.Name = "labelFishWeight";
            this.labelFishWeight.Size = new System.Drawing.Size(131, 29);
            this.labelFishWeight.TabIndex = 12;
            this.labelFishWeight.Text = "Waga ryby:";
            // 
            // labelFishLenght
            // 
            this.labelFishLenght.AutoSize = true;
            this.labelFishLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFishLenght.Location = new System.Drawing.Point(12, 232);
            this.labelFishLenght.Name = "labelFishLenght";
            this.labelFishLenght.Size = new System.Drawing.Size(158, 29);
            this.labelFishLenght.TabIndex = 13;
            this.labelFishLenght.Text = "Rozmiar ryby:";
            // 
            // labelFishProtectionLenght
            // 
            this.labelFishProtectionLenght.AutoSize = true;
            this.labelFishProtectionLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFishProtectionLenght.Location = new System.Drawing.Point(16, 314);
            this.labelFishProtectionLenght.Name = "labelFishProtectionLenght";
            this.labelFishProtectionLenght.Size = new System.Drawing.Size(212, 29);
            this.labelFishProtectionLenght.TabIndex = 14;
            this.labelFishProtectionLenght.Text = "Rozmiar ochronny:";
            // 
            // checkBoxMyFishes
            // 
            this.checkBoxMyFishes.AutoSize = true;
            this.checkBoxMyFishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxMyFishes.Location = new System.Drawing.Point(21, 424);
            this.checkBoxMyFishes.Name = "checkBoxMyFishes";
            this.checkBoxMyFishes.Size = new System.Drawing.Size(125, 29);
            this.checkBoxMyFishes.TabIndex = 15;
            this.checkBoxMyFishes.Text = "Moje ryby";
            this.checkBoxMyFishes.UseVisualStyleBackColor = true;
            this.checkBoxMyFishes.CheckedChanged += new System.EventHandler(this.checkBoxMyFishes_CheckedChanged);
            // 
            // FormFishingCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 678);
            this.Controls.Add(this.checkBoxMyFishes);
            this.Controls.Add(this.labelFishProtectionLenght);
            this.Controls.Add(this.labelFishLenght);
            this.Controls.Add(this.labelFishWeight);
            this.Controls.Add(this.labelFishName);
            this.Controls.Add(this.labelEdit);
            this.Controls.Add(this.dataGridViewFishes);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxProtectionLenght);
            this.Controls.Add(this.textBoxLenght);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormFishingCentre";
            this.Text = "FishingCentre";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFishes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFishes;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxLenght;
        private System.Windows.Forms.TextBox textBoxProtectionLenght;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Label labelFishName;
        private System.Windows.Forms.Label labelFishWeight;
        private System.Windows.Forms.Label labelFishLenght;
        private System.Windows.Forms.Label labelFishProtectionLenght;
        private System.Windows.Forms.CheckBox checkBoxMyFishes;
    }
}
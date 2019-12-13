namespace WojciechWojtowiczLab4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonJumperAdd = new System.Windows.Forms.Button();
            this.dateTimePickerJumper = new System.Windows.Forms.DateTimePicker();
            this.textBoxJumperCountryId = new System.Windows.Forms.TextBox();
            this.textBoxJumperLastName = new System.Windows.Forms.TextBox();
            this.textBoxJumperFirstName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCountryAdd = new System.Windows.Forms.Button();
            this.textBoxCountryRecord = new System.Windows.Forms.TextBox();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.labelAllJumpers = new System.Windows.Forms.Label();
            this.labelAllCountries = new System.Windows.Forms.Label();
            this.dataGridViewJumpers = new System.Windows.Forms.DataGridView();
            this.dataGridViewCountries = new System.Windows.Forms.DataGridView();
            this.buttonJumperDelete = new System.Windows.Forms.Button();
            this.buttonJumperUpdate = new System.Windows.Forms.Button();
            this.buttonJumperShow = new System.Windows.Forms.Button();
            this.buttonCountryDelete = new System.Windows.Forms.Button();
            this.buttonCountryUpdate = new System.Windows.Forms.Button();
            this.buttonCountryShow = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUpdateJumperId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonJumperSaveChanges = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUpdateJumperLastName = new System.Windows.Forms.TextBox();
            this.textBoxUpdateCountryId = new System.Windows.Forms.TextBox();
            this.textBoxUpdateJumperFirstName = new System.Windows.Forms.TextBox();
            this.dateTimePickerUpdateJumper = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJumpers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonJumperAdd);
            this.panel1.Controls.Add(this.dateTimePickerJumper);
            this.panel1.Controls.Add(this.textBoxJumperCountryId);
            this.panel1.Controls.Add(this.textBoxJumperLastName);
            this.panel1.Controls.Add(this.textBoxJumperFirstName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 167);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Id kraju";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data urodzin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imię";
            // 
            // buttonJumperAdd
            // 
            this.buttonJumperAdd.Location = new System.Drawing.Point(110, 135);
            this.buttonJumperAdd.Name = "buttonJumperAdd";
            this.buttonJumperAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonJumperAdd.TabIndex = 5;
            this.buttonJumperAdd.Text = "Dodaj skoczka";
            this.buttonJumperAdd.UseVisualStyleBackColor = true;
            this.buttonJumperAdd.Click += new System.EventHandler(this.buttonJumperAdd_Click);
            // 
            // dateTimePickerJumper
            // 
            this.dateTimePickerJumper.Location = new System.Drawing.Point(110, 83);
            this.dateTimePickerJumper.Name = "dateTimePickerJumper";
            this.dateTimePickerJumper.Size = new System.Drawing.Size(190, 20);
            this.dateTimePickerJumper.TabIndex = 4;
            // 
            // textBoxJumperCountryId
            // 
            this.textBoxJumperCountryId.Location = new System.Drawing.Point(110, 109);
            this.textBoxJumperCountryId.Name = "textBoxJumperCountryId";
            this.textBoxJumperCountryId.Size = new System.Drawing.Size(100, 20);
            this.textBoxJumperCountryId.TabIndex = 3;
            // 
            // textBoxJumperLastName
            // 
            this.textBoxJumperLastName.Location = new System.Drawing.Point(110, 57);
            this.textBoxJumperLastName.Name = "textBoxJumperLastName";
            this.textBoxJumperLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxJumperLastName.TabIndex = 1;
            // 
            // textBoxJumperFirstName
            // 
            this.textBoxJumperFirstName.Location = new System.Drawing.Point(110, 31);
            this.textBoxJumperFirstName.Name = "textBoxJumperFirstName";
            this.textBoxJumperFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxJumperFirstName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.buttonCountryAdd);
            this.panel2.Controls.Add(this.textBoxCountryRecord);
            this.panel2.Controls.Add(this.textBoxCountryName);
            this.panel2.Location = new System.Drawing.Point(546, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 167);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rekord kraju";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nazwa kraju";
            // 
            // buttonCountryAdd
            // 
            this.buttonCountryAdd.Location = new System.Drawing.Point(155, 112);
            this.buttonCountryAdd.Name = "buttonCountryAdd";
            this.buttonCountryAdd.Size = new System.Drawing.Size(66, 23);
            this.buttonCountryAdd.TabIndex = 3;
            this.buttonCountryAdd.Text = "Dodaj kraj";
            this.buttonCountryAdd.UseVisualStyleBackColor = true;
            this.buttonCountryAdd.Click += new System.EventHandler(this.buttonCountryAdd_Click);
            // 
            // textBoxCountryRecord
            // 
            this.textBoxCountryRecord.Location = new System.Drawing.Point(155, 72);
            this.textBoxCountryRecord.Name = "textBoxCountryRecord";
            this.textBoxCountryRecord.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountryRecord.TabIndex = 2;
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.Location = new System.Drawing.Point(155, 31);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountryName.TabIndex = 1;
            // 
            // labelAllJumpers
            // 
            this.labelAllJumpers.AutoSize = true;
            this.labelAllJumpers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAllJumpers.Location = new System.Drawing.Point(67, 198);
            this.labelAllJumpers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAllJumpers.Name = "labelAllJumpers";
            this.labelAllJumpers.Size = new System.Drawing.Size(185, 24);
            this.labelAllJumpers.TabIndex = 3;
            this.labelAllJumpers.Text = "Wszyscy skoczkowie";
            // 
            // labelAllCountries
            // 
            this.labelAllCountries.AutoSize = true;
            this.labelAllCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAllCountries.Location = new System.Drawing.Point(598, 198);
            this.labelAllCountries.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAllCountries.Name = "labelAllCountries";
            this.labelAllCountries.Size = new System.Drawing.Size(137, 24);
            this.labelAllCountries.TabIndex = 4;
            this.labelAllCountries.Text = "Wszystkie kraje";
            // 
            // dataGridViewJumpers
            // 
            this.dataGridViewJumpers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJumpers.Location = new System.Drawing.Point(12, 224);
            this.dataGridViewJumpers.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewJumpers.Name = "dataGridViewJumpers";
            this.dataGridViewJumpers.RowTemplate.Height = 24;
            this.dataGridViewJumpers.Size = new System.Drawing.Size(469, 231);
            this.dataGridViewJumpers.TabIndex = 5;
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountries.Location = new System.Drawing.Point(485, 224);
            this.dataGridViewCountries.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            this.dataGridViewCountries.RowTemplate.Height = 24;
            this.dataGridViewCountries.Size = new System.Drawing.Size(355, 232);
            this.dataGridViewCountries.TabIndex = 6;
            // 
            // buttonJumperDelete
            // 
            this.buttonJumperDelete.Location = new System.Drawing.Point(14, 460);
            this.buttonJumperDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonJumperDelete.Name = "buttonJumperDelete";
            this.buttonJumperDelete.Size = new System.Drawing.Size(112, 24);
            this.buttonJumperDelete.TabIndex = 19;
            this.buttonJumperDelete.Text = "Usuń skoczka";
            this.buttonJumperDelete.UseVisualStyleBackColor = true;
            this.buttonJumperDelete.Click += new System.EventHandler(this.buttonJumperDelete_Click);
            // 
            // buttonJumperUpdate
            // 
            this.buttonJumperUpdate.Location = new System.Drawing.Point(130, 460);
            this.buttonJumperUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonJumperUpdate.Name = "buttonJumperUpdate";
            this.buttonJumperUpdate.Size = new System.Drawing.Size(110, 24);
            this.buttonJumperUpdate.TabIndex = 20;
            this.buttonJumperUpdate.Text = "Edytuj skoczka";
            this.buttonJumperUpdate.UseVisualStyleBackColor = true;
            this.buttonJumperUpdate.Click += new System.EventHandler(this.buttonJumperUpdate_Click);
            // 
            // buttonJumperShow
            // 
            this.buttonJumperShow.Location = new System.Drawing.Point(244, 460);
            this.buttonJumperShow.Margin = new System.Windows.Forms.Padding(2);
            this.buttonJumperShow.Name = "buttonJumperShow";
            this.buttonJumperShow.Size = new System.Drawing.Size(123, 24);
            this.buttonJumperShow.TabIndex = 21;
            this.buttonJumperShow.Text = "Wyświetl Kraj";
            this.buttonJumperShow.UseVisualStyleBackColor = true;
            this.buttonJumperShow.Click += new System.EventHandler(this.buttonJumperShow_Click);
            // 
            // buttonCountryDelete
            // 
            this.buttonCountryDelete.Location = new System.Drawing.Point(485, 460);
            this.buttonCountryDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCountryDelete.Name = "buttonCountryDelete";
            this.buttonCountryDelete.Size = new System.Drawing.Size(112, 24);
            this.buttonCountryDelete.TabIndex = 22;
            this.buttonCountryDelete.Text = "Usuń kraj";
            this.buttonCountryDelete.UseVisualStyleBackColor = true;
            this.buttonCountryDelete.Click += new System.EventHandler(this.buttonCountryDelete_Click);
            // 
            // buttonCountryUpdate
            // 
            this.buttonCountryUpdate.Location = new System.Drawing.Point(601, 460);
            this.buttonCountryUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCountryUpdate.Name = "buttonCountryUpdate";
            this.buttonCountryUpdate.Size = new System.Drawing.Size(90, 24);
            this.buttonCountryUpdate.TabIndex = 23;
            this.buttonCountryUpdate.Text = "Edytuj kraj";
            this.buttonCountryUpdate.UseVisualStyleBackColor = true;
            this.buttonCountryUpdate.Click += new System.EventHandler(this.buttonCountryUpdate_Click);
            // 
            // buttonCountryShow
            // 
            this.buttonCountryShow.Location = new System.Drawing.Point(697, 460);
            this.buttonCountryShow.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCountryShow.Name = "buttonCountryShow";
            this.buttonCountryShow.Size = new System.Drawing.Size(143, 24);
            this.buttonCountryShow.TabIndex = 24;
            this.buttonCountryShow.Text = "Wyświetl ilość skoczków";
            this.buttonCountryShow.UseVisualStyleBackColor = true;
            this.buttonCountryShow.Click += new System.EventHandler(this.buttonCountryShow_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxUpdateJumperId);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.buttonJumperSaveChanges);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBoxUpdateJumperLastName);
            this.panel3.Controls.Add(this.textBoxUpdateCountryId);
            this.panel3.Controls.Add(this.textBoxUpdateJumperFirstName);
            this.panel3.Controls.Add(this.dateTimePickerUpdateJumper);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(14, 502);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 211);
            this.panel3.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Id";
            // 
            // textBoxUpdateJumperId
            // 
            this.textBoxUpdateJumperId.Location = new System.Drawing.Point(148, 2);
            this.textBoxUpdateJumperId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUpdateJumperId.Name = "textBoxUpdateJumperId";
            this.textBoxUpdateJumperId.Size = new System.Drawing.Size(126, 20);
            this.textBoxUpdateJumperId.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Id kraju";
            // 
            // buttonJumperSaveChanges
            // 
            this.buttonJumperSaveChanges.Location = new System.Drawing.Point(148, 181);
            this.buttonJumperSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.buttonJumperSaveChanges.Name = "buttonJumperSaveChanges";
            this.buttonJumperSaveChanges.Size = new System.Drawing.Size(124, 26);
            this.buttonJumperSaveChanges.TabIndex = 32;
            this.buttonJumperSaveChanges.Text = "Zapisz zmiany";
            this.buttonJumperSaveChanges.UseVisualStyleBackColor = true;
            this.buttonJumperSaveChanges.Click += new System.EventHandler(this.buttonJumperSaveChanges_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 120);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Data urodzin";
            // 
            // textBoxUpdateJumperLastName
            // 
            this.textBoxUpdateJumperLastName.Location = new System.Drawing.Point(148, 82);
            this.textBoxUpdateJumperLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUpdateJumperLastName.Name = "textBoxUpdateJumperLastName";
            this.textBoxUpdateJumperLastName.Size = new System.Drawing.Size(126, 20);
            this.textBoxUpdateJumperLastName.TabIndex = 30;
            // 
            // textBoxUpdateCountryId
            // 
            this.textBoxUpdateCountryId.Location = new System.Drawing.Point(148, 148);
            this.textBoxUpdateCountryId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUpdateCountryId.Name = "textBoxUpdateCountryId";
            this.textBoxUpdateCountryId.Size = new System.Drawing.Size(126, 20);
            this.textBoxUpdateCountryId.TabIndex = 31;
            // 
            // textBoxUpdateJumperFirstName
            // 
            this.textBoxUpdateJumperFirstName.Location = new System.Drawing.Point(148, 41);
            this.textBoxUpdateJumperFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUpdateJumperFirstName.Name = "textBoxUpdateJumperFirstName";
            this.textBoxUpdateJumperFirstName.Size = new System.Drawing.Size(126, 20);
            this.textBoxUpdateJumperFirstName.TabIndex = 29;
            // 
            // dateTimePickerUpdateJumper
            // 
            this.dateTimePickerUpdateJumper.Location = new System.Drawing.Point(148, 116);
            this.dateTimePickerUpdateJumper.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerUpdateJumper.Name = "dateTimePickerUpdateJumper";
            this.dateTimePickerUpdateJumper.Size = new System.Drawing.Size(126, 20);
            this.dateTimePickerUpdateJumper.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Imię";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Nazwisko";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 819);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonCountryShow);
            this.Controls.Add(this.buttonCountryUpdate);
            this.Controls.Add(this.buttonCountryDelete);
            this.Controls.Add(this.buttonJumperShow);
            this.Controls.Add(this.buttonJumperUpdate);
            this.Controls.Add(this.buttonJumperDelete);
            this.Controls.Add(this.dataGridViewCountries);
            this.Controls.Add(this.dataGridViewJumpers);
            this.Controls.Add(this.labelAllCountries);
            this.Controls.Add(this.labelAllJumpers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJumpers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonJumperAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerJumper;
        private System.Windows.Forms.TextBox textBoxJumperCountryId;
        private System.Windows.Forms.TextBox textBoxJumperLastName;
        private System.Windows.Forms.TextBox textBoxJumperFirstName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCountryAdd;
        private System.Windows.Forms.TextBox textBoxCountryRecord;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.Label labelAllJumpers;
        private System.Windows.Forms.Label labelAllCountries;
        private System.Windows.Forms.DataGridView dataGridViewJumpers;
        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.Button buttonJumperDelete;
        private System.Windows.Forms.Button buttonJumperUpdate;
        private System.Windows.Forms.Button buttonJumperShow;
        private System.Windows.Forms.Button buttonCountryDelete;
        private System.Windows.Forms.Button buttonCountryUpdate;
        private System.Windows.Forms.Button buttonCountryShow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUpdateJumperId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonJumperSaveChanges;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUpdateJumperLastName;
        private System.Windows.Forms.TextBox textBoxUpdateCountryId;
        private System.Windows.Forms.TextBox textBoxUpdateJumperFirstName;
        private System.Windows.Forms.DateTimePicker dateTimePickerUpdateJumper;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}


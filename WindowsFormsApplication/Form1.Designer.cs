namespace WindowsFormsApplication
{
    partial class FormStud
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подклюитьсяКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьСоединениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btKol = new System.Windows.Forms.Button();
            this.btTransaction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbNewEntry = new System.Windows.Forms.GroupBox();
            this.tbCourse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btFaculty = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.btAllTable = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.gbNewEntry.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подклюитьсяКБДToolStripMenuItem,
            this.закрытьСоединениеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // подклюитьсяКБДToolStripMenuItem
            // 
            this.подклюитьсяКБДToolStripMenuItem.Name = "подклюитьсяКБДToolStripMenuItem";
            this.подклюитьсяКБДToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.подклюитьсяКБДToolStripMenuItem.Text = "Подключиться к БД";
            this.подклюитьсяКБДToolStripMenuItem.Click += new System.EventHandler(this.подклюитьсяКБДToolStripMenuItem_Click);
            // 
            // закрытьСоединениеToolStripMenuItem
            // 
            this.закрытьСоединениеToolStripMenuItem.Name = "закрытьСоединениеToolStripMenuItem";
            this.закрытьСоединениеToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.закрытьСоединениеToolStripMenuItem.Text = "Закрыть соединение";
            this.закрытьСоединениеToolStripMenuItem.Click += new System.EventHandler(this.закрытьСоединениеToolStripMenuItem_Click);
            // 
            // btKol
            // 
            this.btKol.Location = new System.Drawing.Point(12, 249);
            this.btKol.Name = "btKol";
            this.btKol.Size = new System.Drawing.Size(127, 38);
            this.btKol.TabIndex = 1;
            this.btKol.Text = "Количество записей в таблице";
            this.btKol.UseVisualStyleBackColor = true;
            this.btKol.Click += new System.EventHandler(this.button_kol_Click);
            // 
            // btTransaction
            // 
            this.btTransaction.Location = new System.Drawing.Point(274, 64);
            this.btTransaction.Name = "btTransaction";
            this.btTransaction.Size = new System.Drawing.Size(127, 41);
            this.btTransaction.TabIndex = 2;
            this.btTransaction.Text = "Вставить запись в таблицу";
            this.btTransaction.UseVisualStyleBackColor = true;
            this.btTransaction.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(79, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(162, 20);
            this.tbName.TabIndex = 4;
            // 
            // gbNewEntry
            // 
            this.gbNewEntry.Controls.Add(this.tbCourse);
            this.gbNewEntry.Controls.Add(this.label4);
            this.gbNewEntry.Controls.Add(this.tbGroup);
            this.gbNewEntry.Controls.Add(this.label3);
            this.gbNewEntry.Controls.Add(this.tbFam);
            this.gbNewEntry.Controls.Add(this.label2);
            this.gbNewEntry.Controls.Add(this.tbName);
            this.gbNewEntry.Controls.Add(this.label1);
            this.gbNewEntry.Location = new System.Drawing.Point(19, 39);
            this.gbNewEntry.Name = "gbNewEntry";
            this.gbNewEntry.Size = new System.Drawing.Size(253, 137);
            this.gbNewEntry.TabIndex = 5;
            this.gbNewEntry.TabStop = false;
            this.gbNewEntry.Text = "Введите данные";
            // 
            // tbCourse
            // 
            this.tbCourse.Location = new System.Drawing.Point(79, 107);
            this.tbCourse.Name = "tbCourse";
            this.tbCourse.Size = new System.Drawing.Size(162, 20);
            this.tbCourse.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Курс";
            // 
            // tbGroup
            // 
            this.tbGroup.Location = new System.Drawing.Point(79, 81);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(162, 20);
            this.tbGroup.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Группа";
            // 
            // tbFam
            // 
            this.tbFam.Location = new System.Drawing.Point(79, 55);
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(162, 20);
            this.tbFam.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фамилия";
            // 
            // btFaculty
            // 
            this.btFaculty.Location = new System.Drawing.Point(274, 158);
            this.btFaculty.Name = "btFaculty";
            this.btFaculty.Size = new System.Drawing.Size(127, 41);
            this.btFaculty.TabIndex = 8;
            this.btFaculty.Text = "Узнать факультет студента";
            this.btFaculty.UseVisualStyleBackColor = true;
            this.btFaculty.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(274, 17);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(127, 41);
            this.btSearch.TabIndex = 6;
            this.btSearch.Text = "Найти в таблице...";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btAllTable
            // 
            this.btAllTable.Location = new System.Drawing.Point(145, 249);
            this.btAllTable.Name = "btAllTable";
            this.btAllTable.Size = new System.Drawing.Size(127, 38);
            this.btAllTable.TabIndex = 7;
            this.btAllTable.Text = "Отобразить всю таблицу";
            this.btAllTable.UseVisualStyleBackColor = true;
            this.btAllTable.Click += new System.EventHandler(this.btAllTable_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(274, 111);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(127, 41);
            this.btUpdate.TabIndex = 9;
            this.btUpdate.Text = "Изменить данные студента";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btTransaction);
            this.groupBox1.Controls.Add(this.btFaculty);
            this.groupBox1.Controls.Add(this.btSearch);
            this.groupBox1.Controls.Add(this.btUpdate);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 211);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // FormStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 299);
            this.Controls.Add(this.btAllTable);
            this.Controls.Add(this.btKol);
            this.Controls.Add(this.gbNewEntry);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStud";
            this.Text = "Студенты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStud_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbNewEntry.ResumeLayout(false);
            this.gbNewEntry.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подклюитьсяКБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьСоединениеToolStripMenuItem;
        private System.Windows.Forms.Button btKol;
        private System.Windows.Forms.Button btTransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbNewEntry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAllTable;
        private System.Windows.Forms.Button btSearch;
        public System.Windows.Forms.TextBox tbCourse;
        private System.Windows.Forms.Button btFaculty;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


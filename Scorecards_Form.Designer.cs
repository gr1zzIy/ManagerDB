namespace ManagerDB
{
    partial class Scorecards_Form
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.editStudentId_cbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editTeacherId_cbx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.editDisciplineId_cbx = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editDateOfOffset_dtp = new System.Windows.Forms.DateTimePicker();
            this.BackEditBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.editGrade_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addStudentId_cbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addTeacherId_cbx = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addDateOfOffset_dtp = new System.Windows.Forms.DateTimePicker();
            this.addDisciplineId_cbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addGrade_text = new System.Windows.Forms.TextBox();
            this.BackAddBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.VisibleEditBtn = new System.Windows.Forms.Button();
            this.VisibleAddBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.scorecard_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discipline_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_offset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(950, 575);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(91, 36);
            this.BackBtn.TabIndex = 39;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.editStudentId_cbx);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.editTeacherId_cbx);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.editDisciplineId_cbx);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.editDateOfOffset_dtp);
            this.groupBox2.Controls.Add(this.BackEditBtn);
            this.groupBox2.Controls.Add(this.EditBtn);
            this.groupBox2.Controls.Add(this.editGrade_text);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(311, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 348);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редагувати";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Виберіть ID студента:";
            // 
            // editStudentId_cbx
            // 
            this.editStudentId_cbx.FormattingEnabled = true;
            this.editStudentId_cbx.Location = new System.Drawing.Point(6, 43);
            this.editStudentId_cbx.Name = "editStudentId_cbx";
            this.editStudentId_cbx.Size = new System.Drawing.Size(272, 26);
            this.editStudentId_cbx.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Виберіть ID викладача:";
            // 
            // editTeacherId_cbx
            // 
            this.editTeacherId_cbx.FormattingEnabled = true;
            this.editTeacherId_cbx.Location = new System.Drawing.Point(6, 93);
            this.editTeacherId_cbx.Name = "editTeacherId_cbx";
            this.editTeacherId_cbx.Size = new System.Drawing.Size(272, 26);
            this.editTeacherId_cbx.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Виберіть ID дисципліни:";
            // 
            // editDisciplineId_cbx
            // 
            this.editDisciplineId_cbx.FormattingEnabled = true;
            this.editDisciplineId_cbx.Location = new System.Drawing.Point(6, 143);
            this.editDisciplineId_cbx.Name = "editDisciplineId_cbx";
            this.editDisciplineId_cbx.Size = new System.Drawing.Size(272, 26);
            this.editDisciplineId_cbx.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Введіть дату проведення:";
            // 
            // editDateOfOffset_dtp
            // 
            this.editDateOfOffset_dtp.Location = new System.Drawing.Point(6, 193);
            this.editDateOfOffset_dtp.Name = "editDateOfOffset_dtp";
            this.editDateOfOffset_dtp.Size = new System.Drawing.Size(272, 26);
            this.editDateOfOffset_dtp.TabIndex = 12;
            // 
            // BackEditBtn
            // 
            this.BackEditBtn.Location = new System.Drawing.Point(6, 312);
            this.BackEditBtn.Name = "BackEditBtn";
            this.BackEditBtn.Size = new System.Drawing.Size(272, 29);
            this.BackEditBtn.TabIndex = 8;
            this.BackEditBtn.Text = "Відмінна";
            this.BackEditBtn.UseVisualStyleBackColor = true;
            this.BackEditBtn.Click += new System.EventHandler(this.BackEditBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(6, 275);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(272, 34);
            this.EditBtn.TabIndex = 7;
            this.EditBtn.Text = "Редагувати";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // editGrade_text
            // 
            this.editGrade_text.Location = new System.Drawing.Point(6, 243);
            this.editGrade_text.Name = "editGrade_text";
            this.editGrade_text.Size = new System.Drawing.Size(272, 26);
            this.editGrade_text.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Введіть оцінку:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.addStudentId_cbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addTeacherId_cbx);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addDateOfOffset_dtp);
            this.groupBox1.Controls.Add(this.addDisciplineId_cbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addGrade_text);
            this.groupBox1.Controls.Add(this.BackAddBtn);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 348);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Виберіть ID студента:";
            // 
            // addStudentId_cbx
            // 
            this.addStudentId_cbx.FormattingEnabled = true;
            this.addStudentId_cbx.Location = new System.Drawing.Point(12, 43);
            this.addStudentId_cbx.Name = "addStudentId_cbx";
            this.addStudentId_cbx.Size = new System.Drawing.Size(268, 26);
            this.addStudentId_cbx.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Виберіть ID викладача:";
            // 
            // addTeacherId_cbx
            // 
            this.addTeacherId_cbx.FormattingEnabled = true;
            this.addTeacherId_cbx.Location = new System.Drawing.Point(12, 93);
            this.addTeacherId_cbx.Name = "addTeacherId_cbx";
            this.addTeacherId_cbx.Size = new System.Drawing.Size(268, 26);
            this.addTeacherId_cbx.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Виберіть ID дисципліни:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Введіть дату проведення:";
            // 
            // addDateOfOffset_dtp
            // 
            this.addDateOfOffset_dtp.Location = new System.Drawing.Point(12, 193);
            this.addDateOfOffset_dtp.Name = "addDateOfOffset_dtp";
            this.addDateOfOffset_dtp.Size = new System.Drawing.Size(268, 26);
            this.addDateOfOffset_dtp.TabIndex = 10;
            // 
            // addDisciplineId_cbx
            // 
            this.addDisciplineId_cbx.FormattingEnabled = true;
            this.addDisciplineId_cbx.Location = new System.Drawing.Point(12, 143);
            this.addDisciplineId_cbx.Name = "addDisciplineId_cbx";
            this.addDisciplineId_cbx.Size = new System.Drawing.Size(268, 26);
            this.addDisciplineId_cbx.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть оцінку:";
            // 
            // addGrade_text
            // 
            this.addGrade_text.Location = new System.Drawing.Point(12, 243);
            this.addGrade_text.Name = "addGrade_text";
            this.addGrade_text.Size = new System.Drawing.Size(268, 26);
            this.addGrade_text.TabIndex = 2;
            // 
            // BackAddBtn
            // 
            this.BackAddBtn.Location = new System.Drawing.Point(12, 312);
            this.BackAddBtn.Name = "BackAddBtn";
            this.BackAddBtn.Size = new System.Drawing.Size(268, 29);
            this.BackAddBtn.TabIndex = 7;
            this.BackAddBtn.Text = "Відмінна";
            this.BackAddBtn.UseVisualStyleBackColor = true;
            this.BackAddBtn.Click += new System.EventHandler(this.BackAddBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 275);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(268, 34);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Додати";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(866, 153);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(175, 41);
            this.RefreshButton.TabIndex = 36;
            this.RefreshButton.Text = "Оновити таблицю";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(866, 106);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(175, 41);
            this.DelBtn.TabIndex = 35;
            this.DelBtn.Text = "Видалити вибраний";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // VisibleEditBtn
            // 
            this.VisibleEditBtn.Location = new System.Drawing.Point(866, 59);
            this.VisibleEditBtn.Name = "VisibleEditBtn";
            this.VisibleEditBtn.Size = new System.Drawing.Size(175, 41);
            this.VisibleEditBtn.TabIndex = 34;
            this.VisibleEditBtn.Text = "Змінити";
            this.VisibleEditBtn.UseVisualStyleBackColor = true;
            this.VisibleEditBtn.Click += new System.EventHandler(this.VisibleEditBtn_Click);
            // 
            // VisibleAddBtn
            // 
            this.VisibleAddBtn.Location = new System.Drawing.Point(866, 12);
            this.VisibleAddBtn.Name = "VisibleAddBtn";
            this.VisibleAddBtn.Size = new System.Drawing.Size(175, 41);
            this.VisibleAddBtn.TabIndex = 33;
            this.VisibleAddBtn.Text = "Добавити";
            this.VisibleAddBtn.UseVisualStyleBackColor = true;
            this.VisibleAddBtn.Click += new System.EventHandler(this.VisibleAddBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scorecard_id,
            this.student_id,
            this.teacher_id,
            this.discipline_id,
            this.grade,
            this.date_of_offset});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(823, 245);
            this.dataGridView1.TabIndex = 32;
            // 
            // scorecard_id
            // 
            this.scorecard_id.DataPropertyName = "scorecard_id";
            this.scorecard_id.HeaderText = "ID";
            this.scorecard_id.Name = "scorecard_id";
            this.scorecard_id.ReadOnly = true;
            this.scorecard_id.Width = 30;
            // 
            // student_id
            // 
            this.student_id.DataPropertyName = "student_id";
            this.student_id.HeaderText = "ID Студента";
            this.student_id.Name = "student_id";
            this.student_id.ReadOnly = true;
            this.student_id.Width = 140;
            // 
            // teacher_id
            // 
            this.teacher_id.DataPropertyName = "teacher_id";
            this.teacher_id.HeaderText = "ID Викладача";
            this.teacher_id.Name = "teacher_id";
            this.teacher_id.ReadOnly = true;
            this.teacher_id.Width = 145;
            // 
            // discipline_id
            // 
            this.discipline_id.DataPropertyName = "discipline_id";
            this.discipline_id.HeaderText = "ID дисципліни";
            this.discipline_id.Name = "discipline_id";
            this.discipline_id.ReadOnly = true;
            this.discipline_id.Width = 160;
            // 
            // grade
            // 
            this.grade.DataPropertyName = "grade";
            this.grade.HeaderText = "Оцінка";
            this.grade.Name = "grade";
            this.grade.ReadOnly = true;
            this.grade.Width = 125;
            // 
            // date_of_offset
            // 
            this.date_of_offset.DataPropertyName = "date_of_offset";
            this.date_of_offset.HeaderText = "Дата проведення";
            this.date_of_offset.Name = "date_of_offset";
            this.date_of_offset.ReadOnly = true;
            this.date_of_offset.Width = 180;
            // 
            // Scorecards_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1071, 623);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.VisibleEditBtn);
            this.Controls.Add(this.VisibleAddBtn);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Scorecards_Form";
            this.Text = "Scorecards_Form";
            this.Load += new System.EventHandler(this.Scorecards_Form_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox editDisciplineId_cbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker editDateOfOffset_dtp;
        private System.Windows.Forms.Button BackEditBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.TextBox editGrade_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox addStudentId_cbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox addTeacherId_cbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker addDateOfOffset_dtp;
        private System.Windows.Forms.ComboBox addDisciplineId_cbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addGrade_text;
        private System.Windows.Forms.Button BackAddBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button VisibleEditBtn;
        private System.Windows.Forms.Button VisibleAddBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox editStudentId_cbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox editTeacherId_cbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn scorecard_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn discipline_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_offset;
    }
}
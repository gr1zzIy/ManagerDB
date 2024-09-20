namespace ManagerDB
{
    partial class Auditoriums_Form
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
            this.edit_Faculty_cbx = new System.Windows.Forms.ComboBox();
            this.BackEditBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.editAuditorium_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_Faculty_cbx = new System.Windows.Forms.ComboBox();
            this.BackAddBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.addAuditorium_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.VisibleEditBtn = new System.Windows.Forms.Button();
            this.VisibleAddBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.auditorium_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditorium_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faculty_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(501, 587);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(91, 36);
            this.BackBtn.TabIndex = 15;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edit_Faculty_cbx);
            this.groupBox2.Controls.Add(this.BackEditBtn);
            this.groupBox2.Controls.Add(this.EditBtn);
            this.groupBox2.Controls.Add(this.editAuditorium_text);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(319, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 214);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редагувати";
            // 
            // edit_Faculty_cbx
            // 
            this.edit_Faculty_cbx.FormattingEnabled = true;
            this.edit_Faculty_cbx.Location = new System.Drawing.Point(9, 93);
            this.edit_Faculty_cbx.Name = "edit_Faculty_cbx";
            this.edit_Faculty_cbx.Size = new System.Drawing.Size(272, 26);
            this.edit_Faculty_cbx.TabIndex = 9;
            // 
            // BackEditBtn
            // 
            this.BackEditBtn.Location = new System.Drawing.Point(9, 170);
            this.BackEditBtn.Name = "BackEditBtn";
            this.BackEditBtn.Size = new System.Drawing.Size(272, 29);
            this.BackEditBtn.TabIndex = 8;
            this.BackEditBtn.Text = "Відмінна";
            this.BackEditBtn.UseVisualStyleBackColor = true;
            this.BackEditBtn.Click += new System.EventHandler(this.BackEditBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(9, 125);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(272, 39);
            this.EditBtn.TabIndex = 7;
            this.EditBtn.Text = "Редагувати";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // editAuditorium_text
            // 
            this.editAuditorium_text.Location = new System.Drawing.Point(9, 43);
            this.editAuditorium_text.Name = "editAuditorium_text";
            this.editAuditorium_text.Size = new System.Drawing.Size(272, 26);
            this.editAuditorium_text.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Введіть аудиторію:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введіть ID факультета:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_Faculty_cbx);
            this.groupBox1.Controls.Add(this.BackAddBtn);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.addAuditorium_text);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 214);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати";
            // 
            // add_Faculty_cbx
            // 
            this.add_Faculty_cbx.FormattingEnabled = true;
            this.add_Faculty_cbx.Location = new System.Drawing.Point(10, 93);
            this.add_Faculty_cbx.Name = "add_Faculty_cbx";
            this.add_Faculty_cbx.Size = new System.Drawing.Size(268, 26);
            this.add_Faculty_cbx.TabIndex = 7;
            // 
            // BackAddBtn
            // 
            this.BackAddBtn.Location = new System.Drawing.Point(10, 170);
            this.BackAddBtn.Name = "BackAddBtn";
            this.BackAddBtn.Size = new System.Drawing.Size(268, 29);
            this.BackAddBtn.TabIndex = 7;
            this.BackAddBtn.Text = "Відмінна";
            this.BackAddBtn.UseVisualStyleBackColor = true;
            this.BackAddBtn.Click += new System.EventHandler(this.BackAddBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(10, 125);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(268, 39);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Додати";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // addAuditorium_text
            // 
            this.addAuditorium_text.Location = new System.Drawing.Point(10, 43);
            this.addAuditorium_text.Name = "addAuditorium_text";
            this.addAuditorium_text.Size = new System.Drawing.Size(268, 26);
            this.addAuditorium_text.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введіть ID факультета:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть аудиторію:";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(425, 153);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(175, 41);
            this.RefreshButton.TabIndex = 12;
            this.RefreshButton.Text = "Оновити таблицю";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(425, 106);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(175, 41);
            this.DelBtn.TabIndex = 11;
            this.DelBtn.Text = "Видалити вибраний";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // VisibleEditBtn
            // 
            this.VisibleEditBtn.Location = new System.Drawing.Point(425, 59);
            this.VisibleEditBtn.Name = "VisibleEditBtn";
            this.VisibleEditBtn.Size = new System.Drawing.Size(175, 41);
            this.VisibleEditBtn.TabIndex = 10;
            this.VisibleEditBtn.Text = "Змінити";
            this.VisibleEditBtn.UseVisualStyleBackColor = true;
            this.VisibleEditBtn.Click += new System.EventHandler(this.VisibleEditBtn_Click);
            // 
            // VisibleAddBtn
            // 
            this.VisibleAddBtn.Location = new System.Drawing.Point(425, 12);
            this.VisibleAddBtn.Name = "VisibleAddBtn";
            this.VisibleAddBtn.Size = new System.Drawing.Size(175, 41);
            this.VisibleAddBtn.TabIndex = 9;
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
            this.auditorium_id,
            this.auditorium_name,
            this.faculty_id});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(398, 340);
            this.dataGridView1.TabIndex = 8;
            // 
            // auditorium_id
            // 
            this.auditorium_id.DataPropertyName = "auditorium_id";
            this.auditorium_id.HeaderText = "ID";
            this.auditorium_id.Name = "auditorium_id";
            this.auditorium_id.ReadOnly = true;
            this.auditorium_id.Width = 30;
            // 
            // auditorium_name
            // 
            this.auditorium_name.DataPropertyName = "auditorium_name";
            this.auditorium_name.HeaderText = "Номер аудиторії";
            this.auditorium_name.Name = "auditorium_name";
            this.auditorium_name.ReadOnly = true;
            this.auditorium_name.Width = 170;
            // 
            // faculty_id
            // 
            this.faculty_id.DataPropertyName = "faculty_id";
            this.faculty_id.HeaderText = "ID факультета";
            this.faculty_id.Name = "faculty_id";
            this.faculty_id.ReadOnly = true;
            this.faculty_id.Width = 155;
            // 
            // Auditoriums_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(621, 635);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.VisibleEditBtn);
            this.Controls.Add(this.VisibleAddBtn);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Auditoriums_Form";
            this.Text = "Аудиторії";
            this.Load += new System.EventHandler(this.Auditoriums_Form_Load);
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
        private System.Windows.Forms.ComboBox edit_Faculty_cbx;
        private System.Windows.Forms.Button BackEditBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.TextBox editAuditorium_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox add_Faculty_cbx;
        private System.Windows.Forms.Button BackAddBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox addAuditorium_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button VisibleEditBtn;
        private System.Windows.Forms.Button VisibleAddBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditorium_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditorium_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn faculty_id;
    }
}
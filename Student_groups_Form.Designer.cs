namespace ManagerDB
{
    partial class Student_groups_Form
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
            this.label6 = new System.Windows.Forms.Label();
            this.edit_OP_cbx = new System.Windows.Forms.ComboBox();
            this.BackEditBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.editStudent_groups_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_Faculty_cbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.add_OP_cbx = new System.Windows.Forms.ComboBox();
            this.BackAddBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.addStudent_groups_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.VisibleEditBtn = new System.Windows.Forms.Button();
            this.VisibleAddBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.group_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.op_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faculty_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(622, 587);
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
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.edit_OP_cbx);
            this.groupBox2.Controls.Add(this.BackEditBtn);
            this.groupBox2.Controls.Add(this.EditBtn);
            this.groupBox2.Controls.Add(this.editStudent_groups_text);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(423, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 260);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редагувати";
            // 
            // edit_Faculty_cbx
            // 
            this.edit_Faculty_cbx.FormattingEnabled = true;
            this.edit_Faculty_cbx.Location = new System.Drawing.Point(9, 143);
            this.edit_Faculty_cbx.Name = "edit_Faculty_cbx";
            this.edit_Faculty_cbx.Size = new System.Drawing.Size(272, 26);
            this.edit_Faculty_cbx.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Введіть ID факультета:";
            // 
            // edit_OP_cbx
            // 
            this.edit_OP_cbx.FormattingEnabled = true;
            this.edit_OP_cbx.Location = new System.Drawing.Point(9, 93);
            this.edit_OP_cbx.Name = "edit_OP_cbx";
            this.edit_OP_cbx.Size = new System.Drawing.Size(272, 26);
            this.edit_OP_cbx.TabIndex = 9;
            // 
            // BackEditBtn
            // 
            this.BackEditBtn.Location = new System.Drawing.Point(6, 220);
            this.BackEditBtn.Name = "BackEditBtn";
            this.BackEditBtn.Size = new System.Drawing.Size(272, 29);
            this.BackEditBtn.TabIndex = 8;
            this.BackEditBtn.Text = "Відмінна";
            this.BackEditBtn.UseVisualStyleBackColor = true;
            this.BackEditBtn.Click += new System.EventHandler(this.BackEditBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(9, 175);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(272, 39);
            this.EditBtn.TabIndex = 7;
            this.EditBtn.Text = "Редагувати";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // editStudent_groups_text
            // 
            this.editStudent_groups_text.Location = new System.Drawing.Point(9, 43);
            this.editStudent_groups_text.Name = "editStudent_groups_text";
            this.editStudent_groups_text.Size = new System.Drawing.Size(272, 26);
            this.editStudent_groups_text.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Введіть назву групи:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введіть ID ОП:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_Faculty_cbx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.add_OP_cbx);
            this.groupBox1.Controls.Add(this.BackAddBtn);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.addStudent_groups_text);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 260);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати";
            // 
            // add_Faculty_cbx
            // 
            this.add_Faculty_cbx.FormattingEnabled = true;
            this.add_Faculty_cbx.Location = new System.Drawing.Point(10, 143);
            this.add_Faculty_cbx.Name = "add_Faculty_cbx";
            this.add_Faculty_cbx.Size = new System.Drawing.Size(268, 26);
            this.add_Faculty_cbx.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Введіть ID факультета:";
            // 
            // add_OP_cbx
            // 
            this.add_OP_cbx.FormattingEnabled = true;
            this.add_OP_cbx.Location = new System.Drawing.Point(10, 93);
            this.add_OP_cbx.Name = "add_OP_cbx";
            this.add_OP_cbx.Size = new System.Drawing.Size(268, 26);
            this.add_OP_cbx.TabIndex = 7;
            // 
            // BackAddBtn
            // 
            this.BackAddBtn.Location = new System.Drawing.Point(10, 220);
            this.BackAddBtn.Name = "BackAddBtn";
            this.BackAddBtn.Size = new System.Drawing.Size(268, 29);
            this.BackAddBtn.TabIndex = 7;
            this.BackAddBtn.Text = "Відмінна";
            this.BackAddBtn.UseVisualStyleBackColor = true;
            this.BackAddBtn.Click += new System.EventHandler(this.BackAddBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(10, 175);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(268, 39);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Додати";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // addStudent_groups_text
            // 
            this.addStudent_groups_text.Location = new System.Drawing.Point(10, 43);
            this.addStudent_groups_text.Name = "addStudent_groups_text";
            this.addStudent_groups_text.Size = new System.Drawing.Size(268, 26);
            this.addStudent_groups_text.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введіть ID ОП:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть назву групи:";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(538, 183);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(175, 41);
            this.RefreshButton.TabIndex = 12;
            this.RefreshButton.Text = "Оновити таблицю";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(538, 124);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(175, 41);
            this.DelBtn.TabIndex = 11;
            this.DelBtn.Text = "Видалити вибраний";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // VisibleEditBtn
            // 
            this.VisibleEditBtn.Location = new System.Drawing.Point(538, 68);
            this.VisibleEditBtn.Name = "VisibleEditBtn";
            this.VisibleEditBtn.Size = new System.Drawing.Size(175, 41);
            this.VisibleEditBtn.TabIndex = 10;
            this.VisibleEditBtn.Text = "Змінити";
            this.VisibleEditBtn.UseVisualStyleBackColor = true;
            this.VisibleEditBtn.Click += new System.EventHandler(this.VisibleEditBtn_Click);
            // 
            // VisibleAddBtn
            // 
            this.VisibleAddBtn.Location = new System.Drawing.Point(538, 12);
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
            this.group_id,
            this.group_name,
            this.op_id,
            this.faculty_id});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(483, 294);
            this.dataGridView1.TabIndex = 8;
            // 
            // group_id
            // 
            this.group_id.DataPropertyName = "group_id";
            this.group_id.HeaderText = "ID";
            this.group_id.Name = "group_id";
            this.group_id.ReadOnly = true;
            this.group_id.Width = 30;
            // 
            // group_name
            // 
            this.group_name.DataPropertyName = "group_name";
            this.group_name.HeaderText = "Назва групи";
            this.group_name.Name = "group_name";
            this.group_name.ReadOnly = true;
            this.group_name.Width = 150;
            // 
            // op_id
            // 
            this.op_id.DataPropertyName = "op_id";
            this.op_id.HeaderText = "ID ОП";
            this.op_id.Name = "op_id";
            this.op_id.ReadOnly = true;
            // 
            // faculty_id
            // 
            this.faculty_id.DataPropertyName = "faculty_id";
            this.faculty_id.HeaderText = "ID Факультета";
            this.faculty_id.Name = "faculty_id";
            this.faculty_id.ReadOnly = true;
            this.faculty_id.Width = 160;
            // 
            // Student_groups_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(756, 635);
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
            this.Name = "Student_groups_Form";
            this.Text = "Групи студентів";
            this.Load += new System.EventHandler(this.Student_groups_Form_Load);
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
        private System.Windows.Forms.ComboBox edit_OP_cbx;
        private System.Windows.Forms.Button BackEditBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.TextBox editStudent_groups_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox add_OP_cbx;
        private System.Windows.Forms.Button BackAddBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox addStudent_groups_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button VisibleEditBtn;
        private System.Windows.Forms.Button VisibleAddBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox edit_Faculty_cbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox add_Faculty_cbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn op_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn faculty_id;
    }
}
namespace ManagerDB
{
    partial class Faculties_Form
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
            this.RefreshButton = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DelDtn = new System.Windows.Forms.Button();
            this.VisibleEditBtn = new System.Windows.Forms.Button();
            this.VisibleAddBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BackEditBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.editFaculty_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BackAddBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.addFaculty_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.faculty_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faculty_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(402, 192);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(174, 42);
            this.RefreshButton.TabIndex = 15;
            this.RefreshButton.Text = "Оновити таблицю";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(508, 562);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(91, 34);
            this.BackBtn.TabIndex = 14;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DelDtn
            // 
            this.DelDtn.Location = new System.Drawing.Point(402, 132);
            this.DelDtn.Name = "DelDtn";
            this.DelDtn.Size = new System.Drawing.Size(174, 42);
            this.DelDtn.TabIndex = 13;
            this.DelDtn.Text = "Видалити вибраний";
            this.DelDtn.UseVisualStyleBackColor = true;
            this.DelDtn.Click += new System.EventHandler(this.DelDtn_Click);
            // 
            // VisibleEditBtn
            // 
            this.VisibleEditBtn.Location = new System.Drawing.Point(402, 73);
            this.VisibleEditBtn.Name = "VisibleEditBtn";
            this.VisibleEditBtn.Size = new System.Drawing.Size(174, 42);
            this.VisibleEditBtn.TabIndex = 12;
            this.VisibleEditBtn.Text = "Змінити";
            this.VisibleEditBtn.UseVisualStyleBackColor = true;
            this.VisibleEditBtn.Click += new System.EventHandler(this.VisibleEditBtn_Click);
            // 
            // VisibleAddBtn
            // 
            this.VisibleAddBtn.Location = new System.Drawing.Point(402, 15);
            this.VisibleAddBtn.Name = "VisibleAddBtn";
            this.VisibleAddBtn.Size = new System.Drawing.Size(174, 42);
            this.VisibleAddBtn.TabIndex = 11;
            this.VisibleAddBtn.Text = "Добавити";
            this.VisibleAddBtn.UseVisualStyleBackColor = true;
            this.VisibleAddBtn.Click += new System.EventHandler(this.VisibleAddBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BackEditBtn);
            this.groupBox2.Controls.Add(this.EditBtn);
            this.groupBox2.Controls.Add(this.editFaculty_text);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(325, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 184);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редагувати";
            // 
            // BackEditBtn
            // 
            this.BackEditBtn.Location = new System.Drawing.Point(9, 143);
            this.BackEditBtn.Name = "BackEditBtn";
            this.BackEditBtn.Size = new System.Drawing.Size(265, 25);
            this.BackEditBtn.TabIndex = 10;
            this.BackEditBtn.Text = "Відмінна";
            this.BackEditBtn.UseVisualStyleBackColor = true;
            this.BackEditBtn.Click += new System.EventHandler(this.BackEditBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(9, 97);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(265, 40);
            this.EditBtn.TabIndex = 9;
            this.EditBtn.Text = "Редагувати";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // editFaculty_text
            // 
            this.editFaculty_text.Location = new System.Drawing.Point(9, 65);
            this.editFaculty_text.Name = "editFaculty_text";
            this.editFaculty_text.Size = new System.Drawing.Size(265, 26);
            this.editFaculty_text.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введіть факультет:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BackAddBtn);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.addFaculty_text);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 184);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати";
            // 
            // BackAddBtn
            // 
            this.BackAddBtn.Location = new System.Drawing.Point(6, 143);
            this.BackAddBtn.Name = "BackAddBtn";
            this.BackAddBtn.Size = new System.Drawing.Size(265, 25);
            this.BackAddBtn.TabIndex = 9;
            this.BackAddBtn.Text = "Відмінна";
            this.BackAddBtn.UseVisualStyleBackColor = true;
            this.BackAddBtn.Click += new System.EventHandler(this.BackAddBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(6, 97);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(265, 40);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Додати";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // addFaculty_text
            // 
            this.addFaculty_text.Location = new System.Drawing.Point(6, 65);
            this.addFaculty_text.Name = "addFaculty_text";
            this.addFaculty_text.Size = new System.Drawing.Size(265, 26);
            this.addFaculty_text.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введіть факультет:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faculty_id,
            this.faculty_name});
            this.dataGridView1.Location = new System.Drawing.Point(17, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(323, 350);
            this.dataGridView1.TabIndex = 8;
            // 
            // faculty_id
            // 
            this.faculty_id.DataPropertyName = "faculty_id";
            this.faculty_id.HeaderText = "ID";
            this.faculty_id.Name = "faculty_id";
            this.faculty_id.ReadOnly = true;
            this.faculty_id.Width = 30;
            // 
            // faculty_name
            // 
            this.faculty_name.DataPropertyName = "faculty_name";
            this.faculty_name.HeaderText = "Назва факультету";
            this.faculty_name.Name = "faculty_name";
            this.faculty_name.ReadOnly = true;
            this.faculty_name.Width = 250;
            // 
            // Faculties_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(623, 611);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DelDtn);
            this.Controls.Add(this.VisibleEditBtn);
            this.Controls.Add(this.VisibleAddBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Faculties_Form";
            this.Text = "Faculties_Form";
            this.Load += new System.EventHandler(this.Faculties_Form_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button DelDtn;
        private System.Windows.Forms.Button VisibleEditBtn;
        private System.Windows.Forms.Button VisibleAddBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BackEditBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.TextBox editFaculty_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BackAddBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox addFaculty_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn faculty_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn faculty_name;
    }
}
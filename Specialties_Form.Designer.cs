namespace ManagerDB
{
    partial class Specialties_Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.specialty_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialty_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BackAddBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.addSpecialty_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BackEditBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.editSpecialty_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VisibleAddBtn = new System.Windows.Forms.Button();
            this.VisibleEditBtn = new System.Windows.Forms.Button();
            this.DelDtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.specialty_id,
            this.specialty_name});
            this.dataGridView1.Location = new System.Drawing.Point(20, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(323, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // specialty_id
            // 
            this.specialty_id.DataPropertyName = "specialty_id";
            this.specialty_id.HeaderText = "ID";
            this.specialty_id.Name = "specialty_id";
            this.specialty_id.ReadOnly = true;
            this.specialty_id.Width = 30;
            // 
            // specialty_name
            // 
            this.specialty_name.DataPropertyName = "specialty_name";
            this.specialty_name.HeaderText = "Назва спеціальності";
            this.specialty_name.Name = "specialty_name";
            this.specialty_name.ReadOnly = true;
            this.specialty_name.Width = 250;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BackAddBtn);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.addSpecialty_text);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 184);
            this.groupBox1.TabIndex = 1;
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
            // addSpecialty_text
            // 
            this.addSpecialty_text.Location = new System.Drawing.Point(6, 65);
            this.addSpecialty_text.Name = "addSpecialty_text";
            this.addSpecialty_text.Size = new System.Drawing.Size(265, 26);
            this.addSpecialty_text.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введіть спеціальність:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BackEditBtn);
            this.groupBox2.Controls.Add(this.EditBtn);
            this.groupBox2.Controls.Add(this.editSpecialty_text);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(328, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 184);
            this.groupBox2.TabIndex = 2;
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
            // editSpecialty_text
            // 
            this.editSpecialty_text.Location = new System.Drawing.Point(9, 65);
            this.editSpecialty_text.Name = "editSpecialty_text";
            this.editSpecialty_text.Size = new System.Drawing.Size(265, 26);
            this.editSpecialty_text.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введіть спеціальність:";
            // 
            // VisibleAddBtn
            // 
            this.VisibleAddBtn.Location = new System.Drawing.Point(405, 18);
            this.VisibleAddBtn.Name = "VisibleAddBtn";
            this.VisibleAddBtn.Size = new System.Drawing.Size(174, 42);
            this.VisibleAddBtn.TabIndex = 3;
            this.VisibleAddBtn.Text = "Добавити";
            this.VisibleAddBtn.UseVisualStyleBackColor = true;
            this.VisibleAddBtn.Click += new System.EventHandler(this.VisibleAddBtn_Click);
            // 
            // VisibleEditBtn
            // 
            this.VisibleEditBtn.Location = new System.Drawing.Point(405, 76);
            this.VisibleEditBtn.Name = "VisibleEditBtn";
            this.VisibleEditBtn.Size = new System.Drawing.Size(174, 42);
            this.VisibleEditBtn.TabIndex = 4;
            this.VisibleEditBtn.Text = "Змінити";
            this.VisibleEditBtn.UseVisualStyleBackColor = true;
            this.VisibleEditBtn.Click += new System.EventHandler(this.VisibleEditBtn_Click);
            // 
            // DelDtn
            // 
            this.DelDtn.Location = new System.Drawing.Point(405, 135);
            this.DelDtn.Name = "DelDtn";
            this.DelDtn.Size = new System.Drawing.Size(174, 42);
            this.DelDtn.TabIndex = 5;
            this.DelDtn.Text = "Видалити вибраний";
            this.DelDtn.UseVisualStyleBackColor = true;
            this.DelDtn.Click += new System.EventHandler(this.DelDtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(511, 565);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(91, 34);
            this.BackBtn.TabIndex = 6;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(405, 195);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(174, 42);
            this.RefreshButton.TabIndex = 7;
            this.RefreshButton.Text = "Оновити таблицю";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Specialties_Form
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
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(639, 650);
            this.MinimumSize = new System.Drawing.Size(639, 650);
            this.Name = "Specialties_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спеціальності";
            this.Load += new System.EventHandler(this.Specialties_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button VisibleAddBtn;
        private System.Windows.Forms.Button VisibleEditBtn;
        private System.Windows.Forms.Button DelDtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addSpecialty_text;
        private System.Windows.Forms.TextBox editSpecialty_text;
        private System.Windows.Forms.Button BackAddBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button BackEditBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialty_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialty_name;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button RefreshButton;
    }
}
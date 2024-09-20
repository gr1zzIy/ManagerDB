namespace ManagerDB
{
    partial class ManagmentForm
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
            this.Specialties = new System.Windows.Forms.Button();
            this.op = new System.Windows.Forms.Button();
            this.Teachers = new System.Windows.Forms.Button();
            this.Scorecards = new System.Windows.Forms.Button();
            this.Student_groups = new System.Windows.Forms.Button();
            this.Students = new System.Windows.Forms.Button();
            this.Faculties = new System.Windows.Forms.Button();
            this.Disciplines = new System.Windows.Forms.Button();
            this.Auditoriums = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Specialties
            // 
            this.Specialties.Location = new System.Drawing.Point(18, 30);
            this.Specialties.Margin = new System.Windows.Forms.Padding(4);
            this.Specialties.Name = "Specialties";
            this.Specialties.Size = new System.Drawing.Size(175, 70);
            this.Specialties.TabIndex = 0;
            this.Specialties.Text = "Спеціальності";
            this.Specialties.UseVisualStyleBackColor = true;
            this.Specialties.Click += new System.EventHandler(this.Specialties_Click);
            // 
            // op
            // 
            this.op.Location = new System.Drawing.Point(226, 30);
            this.op.Margin = new System.Windows.Forms.Padding(4);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(175, 70);
            this.op.TabIndex = 1;
            this.op.Text = "Освітні програми";
            this.op.UseVisualStyleBackColor = true;
            this.op.Click += new System.EventHandler(this.op_Click);
            // 
            // Teachers
            // 
            this.Teachers.Location = new System.Drawing.Point(18, 226);
            this.Teachers.Margin = new System.Windows.Forms.Padding(4);
            this.Teachers.Name = "Teachers";
            this.Teachers.Size = new System.Drawing.Size(175, 70);
            this.Teachers.TabIndex = 2;
            this.Teachers.Text = "Викладачі";
            this.Teachers.UseVisualStyleBackColor = true;
            this.Teachers.Click += new System.EventHandler(this.Teachers_Click);
            // 
            // Scorecards
            // 
            this.Scorecards.Location = new System.Drawing.Point(18, 129);
            this.Scorecards.Margin = new System.Windows.Forms.Padding(4);
            this.Scorecards.Name = "Scorecards";
            this.Scorecards.Size = new System.Drawing.Size(175, 70);
            this.Scorecards.TabIndex = 3;
            this.Scorecards.Text = "Залікові відомості";
            this.Scorecards.UseVisualStyleBackColor = true;
            this.Scorecards.Click += new System.EventHandler(this.Scorecards_Click);
            // 
            // Student_groups
            // 
            this.Student_groups.Location = new System.Drawing.Point(434, 30);
            this.Student_groups.Margin = new System.Windows.Forms.Padding(4);
            this.Student_groups.Name = "Student_groups";
            this.Student_groups.Size = new System.Drawing.Size(175, 70);
            this.Student_groups.TabIndex = 4;
            this.Student_groups.Text = "Групи студентів";
            this.Student_groups.UseVisualStyleBackColor = true;
            this.Student_groups.Click += new System.EventHandler(this.Student_groups_Click);
            // 
            // Students
            // 
            this.Students.Location = new System.Drawing.Point(226, 129);
            this.Students.Margin = new System.Windows.Forms.Padding(4);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(175, 70);
            this.Students.TabIndex = 5;
            this.Students.Text = "Студенти";
            this.Students.UseVisualStyleBackColor = true;
            this.Students.Click += new System.EventHandler(this.Students_Click);
            // 
            // Faculties
            // 
            this.Faculties.Location = new System.Drawing.Point(434, 129);
            this.Faculties.Margin = new System.Windows.Forms.Padding(4);
            this.Faculties.Name = "Faculties";
            this.Faculties.Size = new System.Drawing.Size(175, 70);
            this.Faculties.TabIndex = 6;
            this.Faculties.Text = "Факультети";
            this.Faculties.UseVisualStyleBackColor = true;
            this.Faculties.Click += new System.EventHandler(this.Faculties_Click);
            // 
            // Disciplines
            // 
            this.Disciplines.Location = new System.Drawing.Point(226, 226);
            this.Disciplines.Margin = new System.Windows.Forms.Padding(4);
            this.Disciplines.Name = "Disciplines";
            this.Disciplines.Size = new System.Drawing.Size(175, 70);
            this.Disciplines.TabIndex = 7;
            this.Disciplines.Text = "Дисципліни";
            this.Disciplines.UseVisualStyleBackColor = true;
            this.Disciplines.Click += new System.EventHandler(this.Disciplines_Click);
            // 
            // Auditoriums
            // 
            this.Auditoriums.Location = new System.Drawing.Point(434, 226);
            this.Auditoriums.Margin = new System.Windows.Forms.Padding(4);
            this.Auditoriums.Name = "Auditoriums";
            this.Auditoriums.Size = new System.Drawing.Size(175, 70);
            this.Auditoriums.TabIndex = 8;
            this.Auditoriums.Text = "Аудиторії";
            this.Auditoriums.UseVisualStyleBackColor = true;
            this.Auditoriums.Click += new System.EventHandler(this.Auditoriums_Click);
            // 
            // ManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(636, 323);
            this.Controls.Add(this.Auditoriums);
            this.Controls.Add(this.Disciplines);
            this.Controls.Add(this.Faculties);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.Student_groups);
            this.Controls.Add(this.Scorecards);
            this.Controls.Add(this.Teachers);
            this.Controls.Add(this.op);
            this.Controls.Add(this.Specialties);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(652, 362);
            this.MinimumSize = new System.Drawing.Size(652, 362);
            this.Name = "ManagmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управління";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Specialties;
        private System.Windows.Forms.Button op;
        private System.Windows.Forms.Button Teachers;
        private System.Windows.Forms.Button Scorecards;
        private System.Windows.Forms.Button Student_groups;
        private System.Windows.Forms.Button Students;
        private System.Windows.Forms.Button Faculties;
        private System.Windows.Forms.Button Disciplines;
        private System.Windows.Forms.Button Auditoriums;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerDB
{
    public partial class Scorecards_Form : Form
    {
        public Scorecards_Form()
        {
            InitializeComponent();
        }

        private void Scorecards_Form_Load(object sender, EventArgs e)
        {
            LoadAddComboBox();
            LoadEditComboBox();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            Scorecards_Class.GetScorecards();
            dataGridView1.DataSource = Scorecards_Class.dtScorecards;
        }

        private void VisibleAddBtn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        static public string EditGrade;

        private void VisibleEditBtn_Click(object sender, EventArgs e)
        {
            EditGrade = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
            groupBox2.Visible = true;

            editGrade_text.Text = EditGrade;
        }

        private void LoadAddComboBox()
        {
            Students_Class.GetStudents();
            Teachers_Class.GetTeachers();
            Disciplines_Class.GetDisciplines();

            addStudentId_cbx.DataSource = Students_Class.dtStudents;
            addStudentId_cbx.DisplayMember = "student_name";
            addStudentId_cbx.ValueMember = "student_id";

            addTeacherId_cbx.DataSource = Teachers_Class.dtTeachers;
            addTeacherId_cbx.DisplayMember = "teacher_name";
            addTeacherId_cbx.ValueMember = "teacher_id";

            addDisciplineId_cbx.DataSource = Disciplines_Class.dtDisciplines;
            addDisciplineId_cbx.DisplayMember = "discipline_name";
            addDisciplineId_cbx.ValueMember = "discipline_id";
        }

        private void LoadEditComboBox()
        {
            Students_Class.GetStudents();
            Teachers_Class.GetTeachers();
            Disciplines_Class.GetDisciplines();

            editStudentId_cbx.DataSource = Students_Class.dtStudents;
            editStudentId_cbx.DisplayMember = "student_name";
            editStudentId_cbx.ValueMember = "student_id";

            editTeacherId_cbx.DataSource = Teachers_Class.dtTeachers;
            editTeacherId_cbx.DisplayMember = "teacher_name";
            editTeacherId_cbx.ValueMember = "teacher_id";

            editDisciplineId_cbx.DataSource = Disciplines_Class.dtDisciplines;
            editDisciplineId_cbx.DisplayMember = "discipline_name";
            editDisciplineId_cbx.ValueMember = "discipline_id";
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Scorecards_Class.GetScorecards();
            dataGridView1.DataSource = Scorecards_Class.dtScorecards;
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string select = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DialogResult del = MessageBox.Show("Ви точно хочете видалити дану заліковку?", "Підтвердити видалення",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    Scorecards_Class.DeleteScorecard(select);
                    Scorecards_Class.GetScorecards();
                    dataGridView1.DataSource = Scorecards_Class.dtScorecards;
                    MessageBox.Show("Заліковка видалена!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackAddBtn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void BackEditBtn_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int student_id = int.Parse(editStudentId_cbx.SelectedValue.ToString());
            int teacher_id = int.Parse(editTeacherId_cbx.SelectedValue.ToString());
            int discipline_id = int.Parse(editDisciplineId_cbx.SelectedValue.ToString());
            float grade = float.Parse(addGrade_text.Text);

            if (addGrade_text.Text != "" && addDateOfOffset_dtp.Text != "")
            {
                string sql = @"SELECT scorecard_id FROM scorecards WHERE student_id = " + student_id + " AND teacher_id = " + teacher_id + " AND discipline_id = " + discipline_id + " AND grade = " + grade + "";
                DBConnection.msCommand.CommandText = sql;
                Object result = DBConnection.msCommand.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("У вас вже є подібний запис!", "Дулювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addGrade_text.Text = "";
                }
                else
                {
                    if (Scorecards_Class.AddScorecard(student_id, teacher_id, discipline_id, grade, addDateOfOffset_dtp.Value.ToString("yyyy-MM-dd")))
                    {
                        MessageBox.Show("Залікова відомість успішно додана!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        groupBox1.Visible = false;
                        addGrade_text.Text = "";
                        Scorecards_Class.GetScorecards();
                    }
                    else
                    {
                        MessageBox.Show("Залікова відомість не була додана!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Заповніть усі обов'язкові поля!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(editGrade_text.Text))
            {
                MessageBox.Show("Заповніть усі обов'язкові поля!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int scorecard_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int student_id = int.Parse(editStudentId_cbx.SelectedValue.ToString());
            int teacher_id = int.Parse(editTeacherId_cbx.SelectedValue.ToString());
            int discipline_id = int.Parse(editDisciplineId_cbx.SelectedValue.ToString());
            float grade = float.Parse(editGrade_text.Text);

            if (editGrade_text.Text == EditGrade)
            {
                if (Scorecards_Class.EditScorecard(scorecard_id, student_id, teacher_id, discipline_id, grade, addDateOfOffset_dtp.Value.ToString("yyyy-MM-dd")))
                {
                    MessageBox.Show("ID студента, викладача та дисципліни; оцінка; час проведення успішно змінено!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Scorecards_Class.GetScorecards();
                    editGrade_text.Text = "";
                    groupBox2.Visible = false;
                }
                else
                {
                    MessageBox.Show("Помилка при редагуванні запису!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Очищаємо параметри перед додаванням нових
                DBConnection.msCommand.Parameters.Clear();

                string sql = "SELECT scorecard_id FROM scorecards WHERE student_id = @student_id AND teacher_id = @teacher_id AND discipline_id = @discipline_id AND grade = @grade";
                DBConnection.msCommand.CommandText = sql;
                DBConnection.msCommand.Parameters.AddWithValue("@student_id", student_id);
                DBConnection.msCommand.Parameters.AddWithValue("@teacher_id", teacher_id);
                DBConnection.msCommand.Parameters.AddWithValue("@discipline_id", discipline_id);
                DBConnection.msCommand.Parameters.AddWithValue("@grade", grade);

                Object result = DBConnection.msCommand.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("У вас вже є подібний запис!", "Дублювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    editGrade_text.Text = "";
                }
                else
                {
                    if (Scorecards_Class.EditScorecard(scorecard_id, student_id, teacher_id, discipline_id, grade, editDateOfOffset_dtp.Value.ToString("yyyy-MM-dd")))
                    {
                        MessageBox.Show("ID студента, викладача та дисципліни; оцінка; час проведення успішно змінено!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Scorecards_Class.GetScorecards();
                        editGrade_text.Text = "";
                        groupBox2.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Помилка при редагуванні запису!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagmentForm admin = new ManagmentForm();
            admin.Show();
        }

    }
}

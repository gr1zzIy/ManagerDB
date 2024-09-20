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
    public partial class Students_Form : Form
    {
        public Students_Form()
        {
            InitializeComponent();
        }

        private void Students_Form_Load(object sender, EventArgs e)
        {
            LoadAddComboBoxGroupId();
            LoadEditComboBoxGroupId();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            Students_Class.GetStudents();
            dataGridView1.DataSource = Students_Class.dtStudents;
        }

        private void VisibleAddBtn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        static public string EditStudentId, EditStudentName, EditStudentSurname;

        private void VisibleEditBtn_Click(object sender, EventArgs e)
        {
            EditStudentId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditStudentName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            EditStudentSurname = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            groupBox2.Visible = true;

            editStudentName_text.Text = EditStudentName;
            editStudentSurname_text.Text = EditStudentSurname;
        }

        private void LoadAddComboBoxGroupId()
        {
            Student_groups_Class.GetStudent_groups();

            addStdentGroup_cbx.DataSource = Student_groups_Class.dtStudent_groups;
            addStdentGroup_cbx.DisplayMember = "group_name";
            addStdentGroup_cbx.ValueMember = "group_id";
        }

        private void LoadEditComboBoxGroupId()
        {
            Student_groups_Class.GetStudent_groups();

            editStdentGroup_cbx.DataSource = Student_groups_Class.dtStudent_groups;
            editStdentGroup_cbx.DisplayMember = "group_name";
            editStdentGroup_cbx.ValueMember = "group_id";
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Students_Class.GetStudents();
            dataGridView1.DataSource = Students_Class.dtStudents;
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string select = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DialogResult del = MessageBox.Show("Ви точно хочете видалити даного студента?", "Підтвердити видалення",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    Students_Class.DeleteStudent(select);
                    Students_Class.GetStudents();
                    dataGridView1.DataSource = Students_Class.dtStudents;
                    MessageBox.Show("Студент видалений!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            int group_id = int.Parse(editStdentGroup_cbx.SelectedValue.ToString());

            if (addStudentName_text.Text != "" && addStudentSurname_text.Text != "" && addBirthday_dtp.Text != "" && addStdentGroup_cbx.Text != "")
            {
                string sql = @"SELECT student_id FROM students WHERE student_name = '" + addStudentName_text + "' AND student_surname = '" + addStudentSurname_text + "'";
                DBConnection.msCommand.CommandText = sql;
                Object result = DBConnection.msCommand.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("У вас вже є подібний запис!", "Дулювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addStudentName_text.Text = "";
                    addStudentSurname_text.Text = "";
                }
                else
                {
                    if (Students_Class.AddStudent(addStudentName_text.Text, addStudentSurname_text.Text, addBirthday_dtp.Value.ToString("yyyy-MM-dd"), group_id))
                    {
                        MessageBox.Show("Студент успішно доданий!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        groupBox1.Visible = false;
                        addStudentName_text.Text = "";
                        addStudentSurname_text.Text = "";
                        Students_Class.GetStudents();
                    }
                    else
                    {
                        MessageBox.Show("Студент не був доданий!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(editStudentName_text.Text) || string.IsNullOrEmpty(editStudentSurname_text.Text) || string.IsNullOrEmpty(editBirthday_dtp.Text) || string.IsNullOrEmpty(editStdentGroup_cbx.Text))
            {
                MessageBox.Show("Заповніть усі обов'язкові поля!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int group_id = int.Parse(editStdentGroup_cbx.SelectedValue.ToString());

            if (editStudentName_text.Text == EditStudentName && editStudentSurname_text.Text == EditStudentSurname)
            {
                if (Students_Class.EditStudent(int.Parse(EditStudentId), editStudentName_text.Text, editStudentSurname_text.Text, editBirthday_dtp.Value.ToString("yyyy-MM-dd"), group_id))
                {
                    MessageBox.Show("І'мя, фамілія та дата народження студента успішно змінено!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Students_Class.GetStudents();
                    editStudentName_text.Text = "";
                    editStudentSurname_text.Text = "";
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

                string sql = "SELECT student_id FROM students WHERE student_name = @student_name AND student_surname = @student_surname AND group_id = @group_id";
                DBConnection.msCommand.CommandText = sql;
                DBConnection.msCommand.Parameters.AddWithValue("@student_name", editStudentName_text.Text);
                DBConnection.msCommand.Parameters.AddWithValue("@student_surname", editStudentSurname_text.Text);
                DBConnection.msCommand.Parameters.AddWithValue("@group_id", group_id);

                Object result = DBConnection.msCommand.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("У вас вже є подібний запис!", "Дублювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    editStudentName_text.Text = "";
                    editStudentSurname_text.Text = "";
                }
                else
                {
                    if (Students_Class.EditStudent(int.Parse(EditStudentId), editStudentName_text.Text, editStudentSurname_text.Text, editBirthday_dtp.Value.ToString("yyyy-MM-dd"), group_id))
                    {
                        MessageBox.Show("І'мя, фамілія та дата народження студента успішно змінено!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Students_Class.GetStudents();
                        editStudentName_text.Text = "";
                        editStudentSurname_text.Text = "";
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

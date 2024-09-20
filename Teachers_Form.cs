using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ManagerDB
{
    public partial class Teachers_Form : Form
    {
        public Teachers_Form()
        {
            InitializeComponent();
        }
        private void Teachers_Form_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            Teachers_Class.GetTeachers();
            dataGridView1.DataSource = Teachers_Class.dtTeachers;
        }

        private void VisibleAddBtn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        static public string EditTeacherId, EditTeacherName, EditTeacherSurname;

        private void VisibleEditBtn_Click(object sender, EventArgs e)
        {
            EditTeacherId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditTeacherName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            EditTeacherSurname = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            groupBox2.Visible = true;

            editTeacherName_text.Text = EditTeacherName;
            editTeacherSurname_text.Text = EditTeacherSurname;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Teachers_Class.GetTeachers();
            dataGridView1.DataSource = Teachers_Class.dtTeachers;
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string select = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DialogResult del = MessageBox.Show("Ви точно хочете видалити даного викладача?", "Підтвердити видалення",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    Teachers_Class.DeleteTeacher(select);
                    Teachers_Class.GetTeachers();
                    dataGridView1.DataSource = Teachers_Class.dtTeachers;
                    MessageBox.Show("Викладач видалений!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (addTeacherName_text.Text != "" && addTeacherSurname_text.Text != "" && addBirthday_dtp.Text != "")
            {
                string sql = @"SELECT teacher_id FROM teachers WHERE teacher_name = '" + addTeacherName_text + "' AND teacher_surname = '" + addTeacherSurname_text + "'";
                DBConnection.msCommand.CommandText = sql;
                Object result = DBConnection.msCommand.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("У вас вже є подібний запис!", "Дулювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addTeacherName_text.Text = "";
                    addTeacherSurname_text.Text = "";
                }
                else
                {
                    if (Teachers_Class.AddTeacher(addTeacherName_text.Text, addTeacherSurname_text.Text, addBirthday_dtp.Value.ToString("yyyy-MM-dd")))
                    {
                        MessageBox.Show("Викладач успішно доданий!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        groupBox1.Visible = false;
                        addTeacherName_text.Text = "";
                        addTeacherSurname_text.Text = "";
                        Teachers_Class.GetTeachers();
                    }
                    else
                    {
                        MessageBox.Show("Викладач не був доданий!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(editTeacherName_text.Text) || string.IsNullOrEmpty(editTeacherSurname_text.Text) || string.IsNullOrEmpty(editBirthday_dtp.Text))
            {
                MessageBox.Show("Заповніть усі обов'язкові поля!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (editTeacherName_text.Text == EditTeacherName && editTeacherSurname_text.Text == EditTeacherSurname)
            {
                if (Teachers_Class.EditTeacher(int.Parse(EditTeacherId), editTeacherName_text.Text, editTeacherSurname_text.Text, editBirthday_dtp.Value.ToString("yyyy-MM-dd")))
                {
                    MessageBox.Show("І'мя, фамілія та дата народження викладача успішно змінено!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Auditoriums_Class.GetAuditoriums();
                    editTeacherName_text.Text = "";
                    editTeacherSurname_text.Text = "";
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

                string sql = "SELECT teacher_id FROM teachers WHERE teacher_name = @teacher_name AND teacher_surname = @teacher_surname";
                DBConnection.msCommand.CommandText = sql;
                DBConnection.msCommand.Parameters.AddWithValue("@teacher_name", editTeacherName_text.Text);
                DBConnection.msCommand.Parameters.AddWithValue("@teacher_surname", editTeacherSurname_text.Text);

                Object result = DBConnection.msCommand.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("У вас вже є подібний запис!", "Дублювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    editTeacherName_text.Text = "";
                    editTeacherSurname_text.Text = "";
                }
                else
                {
                    if (Teachers_Class.EditTeacher(int.Parse(EditTeacherId), editTeacherName_text.Text, editTeacherSurname_text.Text, editBirthday_dtp.Value.ToString("yyyy-MM-dd")))
                    {
                        MessageBox.Show("І'мя, фамілія та дата народження викладача успішно змінено!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Teachers_Class.GetTeachers();
                        editTeacherName_text.Text = "";
                        editTeacherSurname_text.Text = "";
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

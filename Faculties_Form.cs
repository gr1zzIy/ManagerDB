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
    public partial class Faculties_Form : Form
    {
        public Faculties_Form()
        {
            InitializeComponent();
        }

        private void Faculties_Form_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            Faculties_Class.GetFaculties();
            dataGridView1.DataSource = Faculties_Class.dtFaculties;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Specialties_Class.GetSpecialties();
            dataGridView1.DataSource = Specialties_Class.dtSpecialties;
        }

        private void VisibleAddBtn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }


        static public string EditFacultyId, EditFacultyName;

        private void VisibleEditBtn_Click(object sender, EventArgs e)
        {
            EditFacultyId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditFacultyName = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            groupBox2.Visible = true;

            editFaculty_text.Text = EditFacultyName;
        }

        private void BackAddBtn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void BackEditBtn_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void DelDtn_Click(object sender, EventArgs e)
        {
            try
            {
                string select = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DialogResult del = MessageBox.Show("Ви точно хочете видалити даний факультет?", "Підтвердити видалення",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    Faculties_Class.DeleteFaculty(select);
                    Faculties_Class.GetFaculties();
                    dataGridView1.DataSource = Faculties_Class.dtFaculties;
                    MessageBox.Show("Факультет видалений!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (addFaculty_text.Text != "")
            {
                string sql = @"SELECT faculty_id FROM faculties WHERE faculty_name = '" + addFaculty_text + "'";
                DBConnection.msCommand.CommandText = sql;
                Object result = DBConnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("У вас вже є подібний запис!", "Дулювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addFaculty_text.Text = "";
                }
                else
                {
                    if (Faculties_Class.AddFaculty(addFaculty_text.Text))
                    {
                        MessageBox.Show("Факультет успішно доданий!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        groupBox1.Visible = false;
                        Faculties_Class.GetFaculties();
                    }
                    else
                    {
                        MessageBox.Show("Факультет не був доданий!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (editFaculty_text.Text == "")
            {
                MessageBox.Show("Заповніть усі обов'язкові поля!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (editFaculty_text.Text == EditFacultyName)
            {
                string sql = "SELECT faculty_id FROM faculties WHERE faculty_name = @name";
                DBConnection.msCommand.CommandText = sql;
                DBConnection.msCommand.Parameters.AddWithValue("@name", editFaculty_text.Text);
                Object result = DBConnection.msCommand.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("У вас вже є подібний запис!", "Дублювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    editFaculty_text.Text = "";
                    return;
                }
            }

            if (Faculties_Class.EditFaculty(int.Parse(EditFacultyId), editFaculty_text.Text))
            {
                MessageBox.Show("Назва факультета успішно змінена!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Faculties_Class.GetFaculties();
                editFaculty_text.Text = "";
            }
            else
            {
                MessageBox.Show("Помилка при редагуванні запису!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

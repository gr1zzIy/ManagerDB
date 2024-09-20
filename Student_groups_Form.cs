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
    public partial class Student_groups_Form : Form
    {
        public Student_groups_Form()
        {
            InitializeComponent();
        }

        private void Student_groups_Form_Load(object sender, EventArgs e)
        {
            LoadAddComboBoxSpecialtyId();
            LoadEditComboBoxSpecialtyId();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            Student_groups_Class.GetStudent_groups();
            dataGridView1.DataSource = Student_groups_Class.dtStudent_groups;

        }

        private void VisibleAddBtn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        static public string EditStudentGroupId, EditStudentGroupName;

        private void VisibleEditBtn_Click(object sender, EventArgs e)
        {
            EditStudentGroupId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditStudentGroupName = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            groupBox2.Visible = true;

            editStudent_groups_text.Text = EditStudentGroupName;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            OP_Class.GetOP();
            dataGridView1.DataSource = OP_Class.dtOP;
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string select = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DialogResult del = MessageBox.Show("Ви точно хочете видалити дану ОП?", "Підтвердити видалення",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    Student_groups_Class.DeleteStudent_group(select);
                    Student_groups_Class.GetStudent_groups();
                    dataGridView1.DataSource = Student_groups_Class.dtStudent_groups;
                    MessageBox.Show("ОП видалена!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAddComboBoxSpecialtyId()
        {
            OP_Class.GetOP();
            Faculties_Class.GetFaculties();

            add_OP_cbx.DataSource = OP_Class.dtOP;
            add_OP_cbx.DisplayMember = "op_name";
            add_OP_cbx.ValueMember = "op_id";

            add_Faculty_cbx.DataSource = Faculties_Class.dtFaculties;
            add_Faculty_cbx.DisplayMember = "faculty_name";
            add_Faculty_cbx.ValueMember = "faculty_id";
        }

        private void LoadEditComboBoxSpecialtyId()
        {
            OP_Class.GetOP();
            Faculties_Class.GetFaculties();

            edit_OP_cbx.DataSource = OP_Class.dtOP;
            edit_OP_cbx.DisplayMember = "op_name";
            edit_OP_cbx.ValueMember = "op_id";

            edit_Faculty_cbx.DataSource = Faculties_Class.dtFaculties;
            edit_Faculty_cbx.DisplayMember = "faculty_name";
            edit_Faculty_cbx.ValueMember = "faculty_id";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string cbx_op = add_OP_cbx.SelectedValue.ToString();
            int op_id = int.Parse(cbx_op);

            string cbx_faculty = add_Faculty_cbx.SelectedValue.ToString();
            int faculty_id = int.Parse(cbx_faculty);

            if (addStudent_groups_text.Text != "" && add_OP_cbx.Text != "" && add_Faculty_cbx.Text != "")
            {
                string sql = @"SELECT group_id FROM student_groups WHERE group_name = '" + addStudent_groups_text + "'";
                DBConnection.msCommand.CommandText = sql;
                Object result = DBConnection.msCommand.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("У вас вже є подібний запис!", "Дулювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addStudent_groups_text.Text = "";
                }
                else
                {
                    if (Student_groups_Class.AddStudent_group(addStudent_groups_text.Text, op_id, faculty_id))
                    {
                        MessageBox.Show("Група студентів успішно додана!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        groupBox1.Visible = false;
                        Student_groups_Class.GetStudent_groups();
                    }
                    else
                    {
                        MessageBox.Show("Група студентів не була додана!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Заповніть усі обов'язкові поля!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(editStudent_groups_text.Text) || string.IsNullOrEmpty(edit_OP_cbx.Text) || string.IsNullOrEmpty(edit_Faculty_cbx.Text))
            {
                MessageBox.Show("Заповніть усі обов'язкові поля!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int op_id = int.Parse(edit_OP_cbx.SelectedValue.ToString());
            int faculty_id = int.Parse(edit_Faculty_cbx.SelectedValue.ToString());

            if (editStudent_groups_text.Text == EditStudentGroupName)
            {
                if (Student_groups_Class.EditStudent_group(int.Parse(EditStudentGroupId), editStudent_groups_text.Text, op_id, faculty_id))
                {
                    MessageBox.Show("Назва групи, ID ОП та ID Факультета успішно змінено!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Student_groups_Class.GetStudent_groups();
                    editStudent_groups_text.Text = "";
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

                string sql = "SELECT group_id FROM student_groups WHERE group_name = @group_name AND op_id = @op_id AND faculty_id = @faculty_id";
                DBConnection.msCommand.CommandText = sql;
                DBConnection.msCommand.Parameters.AddWithValue("@group_name", editStudent_groups_text.Text);
                DBConnection.msCommand.Parameters.AddWithValue("@op_id", op_id);
                DBConnection.msCommand.Parameters.AddWithValue("@faculty_id", faculty_id);

                Object result = DBConnection.msCommand.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("У вас вже є подібний запис!", "Дублювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    editStudent_groups_text.Text = "";
                }
                else
                {
                    if (Student_groups_Class.EditStudent_group(int.Parse(EditStudentGroupId), editStudent_groups_text.Text, op_id, faculty_id))
                    {
                        MessageBox.Show("Назва групи, ID ОП та ID Факультета успішно змінено!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Student_groups_Class.GetStudent_groups();
                        editStudent_groups_text.Text = "";
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

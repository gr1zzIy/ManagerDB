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
    public partial class Auditoriums_Form : Form
    {
        public Auditoriums_Form()
        {
            InitializeComponent();
        }

        private void Auditoriums_Form_Load(object sender, EventArgs e)
        {
            LoadAddComboBoxFacultyId();
            LoadEditComboBoxFacultyId();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            Auditoriums_Class.GetAuditoriums();
            dataGridView1.DataSource = Auditoriums_Class.dtAuditoriums;
        }


        private void VisibleAddBtn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        static public string EditAuditoriumId, EditAuditoriumName;

        private void VisibleEditBtn_Click(object sender, EventArgs e)
        {
            EditAuditoriumId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditAuditoriumName = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            groupBox2.Visible = true;

            editAuditorium_text.Text = EditAuditoriumName;
        }

        private void LoadAddComboBoxFacultyId()
        {
            Faculties_Class.GetFaculties();

            add_Faculty_cbx.DataSource = Faculties_Class.dtFaculties;
            add_Faculty_cbx.DisplayMember = "faculty_name";
            add_Faculty_cbx.ValueMember = "faculty_id";
        }

        private void LoadEditComboBoxFacultyId()
        {
            Faculties_Class.GetFaculties();

            edit_Faculty_cbx.DataSource = Faculties_Class.dtFaculties;
            edit_Faculty_cbx.DisplayMember = "faculty_name";
            edit_Faculty_cbx.ValueMember = "faculty_id";
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Auditoriums_Class.GetAuditoriums();
            dataGridView1.DataSource = Auditoriums_Class.dtAuditoriums;
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string select = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DialogResult del = MessageBox.Show("Ви точно хочете видалити дану аудиторію?", "Підтвердити видалення",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    Auditoriums_Class.DeleteAuditorium(select);
                    Auditoriums_Class.GetAuditoriums();
                    dataGridView1.DataSource = Auditoriums_Class.dtAuditoriums;
                    MessageBox.Show("Аудиторія видалена!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string cbx = add_Faculty_cbx.SelectedValue.ToString();
            int faculty_id = int.Parse(cbx);

            if (addAuditorium_text.Text != "" && add_Faculty_cbx.Text != "")
            {
                string sql = @"SELECT auditorium_id FROM auditoriums WHERE auditorium_name = '" + addAuditorium_text + "'";
                DBConnection.msCommand.CommandText = sql;
                Object result = DBConnection.msCommand.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("У вас вже є подібний запис!", "Дулювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addAuditorium_text.Text = "";
                }
                else
                {
                    if (Auditoriums_Class.AddAuditorium(addAuditorium_text.Text, faculty_id))
                    {
                        MessageBox.Show("Аудиторія успішно додана!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        groupBox1.Visible = false;
                        Auditoriums_Class.GetAuditoriums();
                    }
                    else
                    {
                        MessageBox.Show("Аудиторія не була додана!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(editAuditorium_text.Text) || string.IsNullOrEmpty(edit_Faculty_cbx.Text))
            {
                MessageBox.Show("Заповніть усі обов'язкові поля!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int faculty_id = int.Parse(edit_Faculty_cbx.SelectedValue.ToString());

            if (editAuditorium_text.Text == EditAuditoriumName)
            {
                if (Auditoriums_Class.EditAuditorium(int.Parse(EditAuditoriumId), editAuditorium_text.Text, faculty_id))
                {
                    MessageBox.Show("Номер аудиторії та ID факультету успішно змінено!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Auditoriums_Class.GetAuditoriums();
                    editAuditorium_text.Text = "";
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

                string sql = "SELECT auditorium_id FROM auditoriums WHERE auditorium_name = @auditorium_name AND faculty_id = @faculty_id";
                DBConnection.msCommand.CommandText = sql;
                DBConnection.msCommand.Parameters.AddWithValue("@auditorium_name", editAuditorium_text.Text);
                DBConnection.msCommand.Parameters.AddWithValue("@faculty_id", faculty_id);

                Object result = DBConnection.msCommand.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("У вас вже є подібний запис!", "Дублювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    editAuditorium_text.Text = "";
                }
                else
                {
                    if (Auditoriums_Class.EditAuditorium(int.Parse(EditAuditoriumId), editAuditorium_text.Text, faculty_id))
                    {
                        MessageBox.Show("Номер аудиторії та ID факультету успішно змінено!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Auditoriums_Class.GetAuditoriums();
                        editAuditorium_text.Text = "";
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

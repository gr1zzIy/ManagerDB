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
    public partial class Specialties_Form : Form
    {
        public Specialties_Form()
        {
            InitializeComponent();
        }
        private void Specialties_Form_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            Specialties_Class.GetSpecialties();
            dataGridView1.DataSource = Specialties_Class.dtSpecialties;
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


        static public string EditSpecialtyId, EditSpecialtyName;

        private void VisibleEditBtn_Click(object sender, EventArgs e)
        {
            EditSpecialtyId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditSpecialtyName = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            groupBox2.Visible = true;
            
            editSpecialty_text.Text = EditSpecialtyName;
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
            if (addSpecialty_text.Text != "")
            {
                string sql = @"SELECT specialty_id FROM specialties WHERE specialty_name = '" + addSpecialty_text + "'";
                DBConnection.msCommand.CommandText = sql;
                Object result = DBConnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("У вас вже є подібний запис!", "Дулювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addSpecialty_text.Text = "";
                }
                else
                {
                    if (Specialties_Class.AddSpecialty(addSpecialty_text.Text))
                    {
                        MessageBox.Show("Спеціальність успішно додана!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        groupBox1.Visible = false;
                        Specialties_Class.GetSpecialties();
                    }
                    else
                    {
                        MessageBox.Show("Спеціальність не була додана!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (editSpecialty_text.Text == "")
            {
                MessageBox.Show("Заповніть усі обов'язкові поля!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (editSpecialty_text.Text == EditSpecialtyName)
            {
                string sql = "SELECT specialty_id FROM specialties WHERE specialty_name = @name";
                DBConnection.msCommand.CommandText = sql;
                DBConnection.msCommand.Parameters.AddWithValue("@name", editSpecialty_text.Text);
                Object result = DBConnection.msCommand.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("У вас вже є подібний запис!", "Дублювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    editSpecialty_text.Text = "";
                    return;
                }
            }

            if (Specialties_Class.EditSpecialty(int.Parse(EditSpecialtyId), editSpecialty_text.Text))
            {
                MessageBox.Show("Назва спеціальності успішно змінена!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Specialties_Class.GetSpecialties();
                editSpecialty_text.Text = "";
            }
            else
            {
                MessageBox.Show("Помилка при редагуванні запису!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DelDtn_Click(object sender, EventArgs e)
        {
            try
            {
                string select = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DialogResult del = MessageBox.Show("Ви точно хочете видалити дану спеціальність?", "Підтвердити видалення", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    Specialties_Class.DeleteSpecialty(select);
                    Specialties_Class.GetSpecialties();
                    dataGridView1.DataSource = Specialties_Class.dtSpecialties;
                    MessageBox.Show("Спеціальність видалена!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

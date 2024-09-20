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
    public partial class Disciplines_Form : Form
    {
        public Disciplines_Form()
        {
            InitializeComponent();
        }
        private void Disciplines_Form_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            Disciplines_Class.GetDisciplines();
            dataGridView1.DataSource = Disciplines_Class.dtDisciplines;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Disciplines_Class.GetDisciplines();
            dataGridView1.DataSource = Disciplines_Class.dtDisciplines;
        }

        private void VisibleAddBtn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }


        static public string EditDisciplineId, EditDisciplineName;

        private void VisibleEditBtn_Click(object sender, EventArgs e)
        {
            EditDisciplineId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditDisciplineName = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            groupBox2.Visible = true;

            editDiscipline_text.Text = EditDisciplineName;
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
                DialogResult del = MessageBox.Show("Ви точно хочете видалити дану дисципліну?", "Підтвердити видалення",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    Disciplines_Class.DeleteDiscipline(select);
                    Disciplines_Class.GetDisciplines();
                    dataGridView1.DataSource = Disciplines_Class.dtDisciplines;
                    MessageBox.Show("Дисципліна видалена!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (addDiscipline_text.Text != "")
            {
                string sql = @"SELECT discipline_id FROM disciplines WHERE discipline_name = '" + addDiscipline_text + "'";
                DBConnection.msCommand.CommandText = sql;
                Object result = DBConnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("У вас вже є подібний запис!", "Дулювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addDiscipline_text.Text = "";
                }
                else
                {
                    if (Disciplines_Class.AddDiscipline(addDiscipline_text.Text))
                    {
                        MessageBox.Show("Дисципліна успішно додана!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        groupBox1.Visible = false;
                        Disciplines_Class.GetDisciplines();
                    }
                    else
                    {
                        MessageBox.Show("Дисципліна не була додана!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (editDiscipline_text.Text == "")
            {
                MessageBox.Show("Заповніть усі обов'язкові поля!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (editDiscipline_text.Text == EditDisciplineName)
            {
                string sql = "SELECT discipline_id FROM disciplines WHERE discipline_name = @name";
                DBConnection.msCommand.CommandText = sql;
                DBConnection.msCommand.Parameters.AddWithValue("@name", editDiscipline_text.Text);
                Object result = DBConnection.msCommand.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("У вас вже є подібний запис!", "Дублювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    editDiscipline_text.Text = "";
                    return;
                }
            }

            if (Disciplines_Class.EditDiscipline(int.Parse(EditDisciplineId), editDiscipline_text.Text))
            {
                MessageBox.Show("Назва дисципліни успішно змінена!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Disciplines_Class.GetDisciplines();
                editDiscipline_text.Text = "";
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

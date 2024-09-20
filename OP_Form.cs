using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerDB
{
    public partial class OP_Form : Form
    {
        public OP_Form()
        {
            InitializeComponent();
        }

        private void OP_Form_Load(object sender, EventArgs e)
        {
            LoadAddComboBoxSpecialtyId();
            LoadEditComboBoxSpecialtyId();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            OP_Class.GetOP();
            dataGridView1.DataSource = OP_Class.dtOP;
        }

        private void VisibleAddBtn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        static public string EditOPid, EditOPname;

        private void VisibleEditBtn_Click(object sender, EventArgs e)
        {
            EditOPid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditOPname = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            groupBox2.Visible = true;

            editOP_text.Text = EditOPname;
        }

        private void LoadAddComboBoxSpecialtyId()
        {
            Specialties_Class.GetSpecialties();

            add_Specialty_cbx.DataSource = Specialties_Class.dtSpecialties;
            add_Specialty_cbx.DisplayMember = "specialty_name";
            add_Specialty_cbx.ValueMember = "specialty_id";
        }

        private void LoadEditComboBoxSpecialtyId()
        {
            Specialties_Class.GetSpecialties();

            edit_Specialty_cbx.DataSource = Specialties_Class.dtSpecialties;
            edit_Specialty_cbx.DisplayMember = "specialty_name";
            edit_Specialty_cbx.ValueMember = "specialty_id";
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
                    OP_Class.DeleteOP(select);
                    OP_Class.GetOP();
                    dataGridView1.DataSource = OP_Class.dtOP;
                    MessageBox.Show("ОП видалена!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string cbx = add_Specialty_cbx.SelectedValue.ToString();
            int specialty_id = int.Parse(cbx);

            if (addOP_text.Text != "" && add_Specialty_cbx.Text != "")
            {
                string sql = @"SELECT op_id FROM op WHERE op_name = '" + addOP_text + "'";
                DBConnection.msCommand.CommandText = sql;
                Object result = DBConnection.msCommand.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("У вас вже є подібний запис!", "Дулювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addOP_text.Text = "";
                }
                else
                {
                    if (OP_Class.AddOP(addOP_text.Text, specialty_id))
                    {
                        MessageBox.Show("ОП успішно додана!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        groupBox1.Visible = false;
                        OP_Class.GetOP();
                    }
                    else
                    {
                        MessageBox.Show("ОП не була додана!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(editOP_text.Text) || string.IsNullOrEmpty(edit_Specialty_cbx.Text))
            {
                MessageBox.Show("Заповніть усі обов'язкові поля!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int specialty_id = int.Parse(edit_Specialty_cbx.SelectedValue.ToString());

            if (editOP_text.Text == EditOPname)
            {
                if (OP_Class.EditOP(int.Parse(EditOPid), editOP_text.Text, specialty_id))
                {
                    MessageBox.Show("Назва ОП і ID Спеціальності успішно змінено!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    OP_Class.GetOP();
                    editOP_text.Text = "";
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

                string sql = "SELECT op_id FROM op WHERE op_name = @op_name AND specialty_id = @specialty_id";
                DBConnection.msCommand.CommandText = sql;
                DBConnection.msCommand.Parameters.AddWithValue("@op_name", editOP_text.Text);
                DBConnection.msCommand.Parameters.AddWithValue("@specialty_id", specialty_id);

                Object result = DBConnection.msCommand.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("У вас вже є подібний запис!", "Дублювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    editOP_text.Text = "";
                }
                else
                {
                    if (OP_Class.EditOP(int.Parse(EditOPid), editOP_text.Text, specialty_id))
                    {
                        MessageBox.Show("Назва ОП і ID Спеціальності успішно змінено!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        OP_Class.GetOP();
                        editOP_text.Text = "";
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

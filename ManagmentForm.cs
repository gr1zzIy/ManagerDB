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
    public partial class ManagmentForm : Form
    {
        public ManagmentForm()
        {
            InitializeComponent();

            if (!DBConnection.ConnectionDB())
            {
                MessageBox.Show("Не вдалося підключитися до бази даних.");
                this.Close();
            }
        }

        private void Specialties_Click(object sender, EventArgs e)
        {
            this.Hide();
            Specialties_Form specialties = new Specialties_Form();
            specialties.Show();
        }

        private void Students_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students_Form students = new Students_Form();
            students.Show();
        }

        private void op_Click(object sender, EventArgs e)
        {
            this.Hide();
            OP_Form op = new OP_Form();
            op.Show();
        }

        private void Student_groups_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_groups_Form student_groups = new Student_groups_Form();
            student_groups.Show();
        }

        private void Faculties_Click(object sender, EventArgs e)
        {
            this.Hide();
            Faculties_Form faculties = new Faculties_Form();
            faculties.Show();
        }

        private void Disciplines_Click(object sender, EventArgs e)
        {
            this.Hide();
            Disciplines_Form disciplines = new Disciplines_Form();
            disciplines.Show();
        }

        private void Auditoriums_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auditoriums_Form auditoriums = new Auditoriums_Form();
            auditoriums.Show();
        }

        private void Teachers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teachers_Form teachers = new Teachers_Form();
            teachers.Show();
        }

        private void Scorecards_Click(object sender, EventArgs e)
        {
            this.Hide();
            Scorecards_Form scorecards = new Scorecards_Form();
            scorecards.Show();
        }
    }
}

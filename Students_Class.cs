using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerDB
{
    internal class Students_Class : DBConnection
    {
        static public DataTable dtStudents = new DataTable();

        static public void GetStudents()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM `students`";
                dtStudents.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtStudents);
            }
            catch
            {
                MessageBox.Show("Помилка при отриманні даних!", "Помилка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddStudent(string student_name, string student_surname, string date_of_birthday, int group_id)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO students VALUES(null, '" + student_name + "', '" + student_surname + "', '" + date_of_birthday + "', '" + group_id + "'); ";
                if (msCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Помилка при додавані запису!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool EditStudent(int student_id, string student_name, string student_surname, string date_of_birthday, int group_id)
        {
            try
            {
                msCommand.CommandText = "UPDATE students SET student_name = '" + student_name + "', student_surname = '" + student_surname + "', date_of_birthday = '" + date_of_birthday + "', group_id = '" + group_id + "' WHERE student_id = '" + student_id + "';";
                if (msCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Помилка при редагуванні запису!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public void DeleteStudent(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM students WHERE student_id = '" + del + "';";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні запису!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

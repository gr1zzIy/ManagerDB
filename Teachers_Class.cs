using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerDB
{
    internal class Teachers_Class : DBConnection
    {
        static public DataTable dtTeachers = new DataTable();

        static public void GetTeachers()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM `teachers`";
                dtTeachers.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtTeachers);
            }
            catch
            {
                MessageBox.Show("Помилка при отриманні даних!", "Помилка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddTeacher(string teacher_name, string teacher_surname, string date_of_birthday)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO teachers VALUES(null, '" + teacher_name + "', '" + teacher_surname + "', '" + date_of_birthday + "'); ";
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

        static public bool EditTeacher(int teacher_id, string teacher_name, string teacher_surname, string date_of_birthday)
        {
            try
            {
                msCommand.CommandText = "UPDATE teachers SET teacher_name = '" + teacher_name + "', teacher_surname = '" + teacher_surname + "', date_of_birthday = '" + date_of_birthday + "' WHERE teacher_id = '" + teacher_id + "';";
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

        static public void DeleteTeacher(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM teachers WHERE teacher_id = '" + del + "';";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні запису!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

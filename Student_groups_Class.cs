using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerDB
{
    internal class Student_groups_Class : DBConnection
    {
        static public DataTable dtStudent_groups = new DataTable();

        static public void GetStudent_groups()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM `student_groups`";
                dtStudent_groups.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtStudent_groups);
            }
            catch
            {
                MessageBox.Show("Помилка при отримані даних!", "Помилка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddStudent_group(string group_name, int op_id, int faculty_id)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO student_groups VALUES(null, '" + group_name + "', " + op_id + ", " + faculty_id + ")";
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

        static public bool EditStudent_group(int group_id, string group_name, int op_id, int faculty_id)
        {
            try
            {
                msCommand.CommandText = "UPDATE student_groups SET group_name = '" + group_name + "', op_id = '" + op_id + "', faculty_id = '" + faculty_id + "' WHERE group_id = '" + group_id + "';";
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

        static public void DeleteStudent_group(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM student_groups WHERE group_id = '" + del + "';";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні запису!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerDB
{
    internal class Faculties_Class : DBConnection
    {
        static public DataTable dtFaculties = new DataTable();

        static public void GetFaculties()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM `faculties`";
                dtFaculties.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtFaculties);
            }
            catch
            {
                MessageBox.Show("Помилка при отриманні даних!", "Помилка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddFaculty(string faculty_name)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO faculties VALUES(null, '" + faculty_name + "');";
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

        static public bool EditFaculty(int faculty_id, string faculty_name)
        {
            try
            {
                msCommand.CommandText = "UPDATE faculties SET faculty_name = '" + faculty_name + "' WHERE faculty_id = '" + faculty_id + "';";
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

        static public void DeleteFaculty(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM faculties WHERE faculty_id = '" + del + "';";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні запису!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

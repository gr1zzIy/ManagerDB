using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerDB
{
    internal class Auditoriums_Class : DBConnection
    {
        static public DataTable dtAuditoriums = new DataTable();

        static public void GetAuditoriums()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM `auditoriums`";
                dtAuditoriums.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtAuditoriums);
            }
            catch
            {
                MessageBox.Show("Помилка при отримані даних!", "Помилка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddAuditorium(string auditorium_name, int faculty_id)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO auditoriums VALUES(null, '" + auditorium_name + "', " + faculty_id + ")";
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

        static public bool EditAuditorium(int auditorium_id, string auditorium_name, int faculty_id)
        {
            try
            {
                msCommand.CommandText = "UPDATE auditoriums SET auditorium_name = '" + auditorium_name + "', faculty_id = '" + faculty_id + "' WHERE auditorium_id = '" + auditorium_id + "';";
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

        static public void DeleteAuditorium(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM auditoriums WHERE auditorium_id = '" + del + "';";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні запису!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

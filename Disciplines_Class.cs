using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerDB
{
    internal class Disciplines_Class : DBConnection
    {
        static public DataTable dtDisciplines = new DataTable();

        static public void GetDisciplines()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM `disciplines`";
                dtDisciplines.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtDisciplines);
            }
            catch
            {
                MessageBox.Show("Помилка при отриманні даних!", "Помилка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddDiscipline(string discipline_name)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO disciplines VALUES(null, '" + discipline_name + "');";
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

        static public bool EditDiscipline(int discipline_id, string discipline_name)
        {
            try
            {
                msCommand.CommandText = "UPDATE disciplines SET discipline_name = '" + discipline_name + "' WHERE discipline_id = '" + discipline_id + "';";
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

        static public void DeleteDiscipline(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM disciplines WHERE discipline_id = '" + del + "';";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні запису!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

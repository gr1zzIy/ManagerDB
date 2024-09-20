using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerDB
{
    internal class Specialties_Class : DBConnection
    {
        static public DataTable dtSpecialties = new DataTable();

        static public void GetSpecialties()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM `specialties`";
                dtSpecialties.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtSpecialties);
            }
            catch
            {
                MessageBox.Show("Помилка при отриманні даних!", "Помилка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddSpecialty(string specialty_name)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO specialties VALUES(null, '" + specialty_name + "');";
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

        static public bool EditSpecialty(int specialty_id, string specialty_name)
        {
            try
            {
                msCommand.CommandText = "UPDATE specialties SET specialty_name = '" + specialty_name + "' WHERE specialty_id = '" + specialty_id + "';";
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

        static public void DeleteSpecialty(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM specialties WHERE specialty_id = '" + del + "';";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні запису!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

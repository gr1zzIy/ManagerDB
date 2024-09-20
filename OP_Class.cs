using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerDB
{
    internal class OP_Class : DBConnection
    {
        static public DataTable dtOP = new DataTable();

        static public void GetOP()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM `op`";
                dtOP.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtOP);
            }
            catch
            {
                MessageBox.Show("Помилка при отримані даних!", "Помилка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddOP(string op_name, int specialty_id)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO op VALUES(null, '" + op_name + "', " + specialty_id + ")";
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

        static public bool EditOP(int op_id, string op_name, int specialty_id)
        {
            try
            {
                msCommand.CommandText = "UPDATE op SET op_name = '" + op_name + "', specialty_id = '" + specialty_id + "' WHERE op_id = '" + op_id + "';";
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

        static public void DeleteOP(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM op WHERE op_id = '" + del + "';";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні запису!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

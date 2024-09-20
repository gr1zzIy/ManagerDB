using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerDB
{
    internal class Scorecards_Class : DBConnection
    {
        static public DataTable dtScorecards = new DataTable();

        static public void GetScorecards()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM `scorecards`";
                dtScorecards.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtScorecards);
            }
            catch
            {
                MessageBox.Show("Помилка при отриманні даних!", "Помилка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddScorecard(int student_id, int teacher_id, int discipline_id, float grade, string date_of_offset)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO scorecards VALUES(null, " + student_id + ", " + teacher_id + ", " + discipline_id + ", " + grade + ", '" + date_of_offset + "'); ";
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

        static public bool EditScorecard(int scorecard_id, int student_id, int teacher_id, int discipline_id, float grade, string date_of_offset)
        {
            try
            {
                msCommand.CommandText = "UPDATE scorecards SET student_id = " + student_id + ", teacher_id = " + teacher_id + ", discipline_id = " + discipline_id + ", grade = " + grade + ", date_of_offset = '" + date_of_offset + "' WHERE scorecard_id = " + scorecard_id + ";";
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

        static public void DeleteScorecard(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM scorecards WHERE scorecard_id = '" + del + "';";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні запису!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

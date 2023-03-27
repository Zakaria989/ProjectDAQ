using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using NationalInstruments.DAQmx;

namespace Project_DAQ
{
    public class Database
    {
        public Database()
        {

        }

        public void ViewDataInGridView(DataGridView dvg, bool autoUpdateOff)
        {
            bool emptyTable;
            try
            {
                string Database = ConfigurationManager.ConnectionStrings["DatabaseD"].ConnectionString;
                SqlConnection con = new SqlConnection(Database);
                DataTable dataTable;
                dvg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (autoUpdateOff == false)
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT [Row],[MeasurementValue],[SensorName] FROM SensorData", con);
                    dataTable = new DataTable();
                    sda.Fill(dataTable);

                    dvg.DataSource = dataTable;
                    con.Close();
                    if (dataTable.Rows.Count == 0)         // Viser om tabllen er tom
                    {
                        emptyTable = true;
                    }
                }
            }
            catch (Exception error)
            {

                System.Windows.Forms.MessageBox.Show(error.Message);
            }

        }
        public void AddDataToDatabase(double value,int sensorId) //Rekkefølge for stored procedure for å fylle inn dato,verdi,sensorId
        {
            try
            {
                DateTime dateTime = DateTime.Now;
                string Database = ConfigurationManager.ConnectionStrings["DatabaseD"].ConnectionString;
                SqlConnection con = new SqlConnection(Database);
                SqlCommand sql = new SqlCommand("uspInsertSensorValue", con);
                sql.CommandType = CommandType.StoredProcedure;
                con.Open();

                sql.Parameters.Add(new SqlParameter("@measurementTime", dateTime));
                sql.Parameters.Add(new SqlParameter("@measurementValue", value));
                sql.Parameters.Add(new SqlParameter("@sensorId", sensorId));
                sql.ExecuteNonQuery();
                con.Close();
            }
                catch (Exception error)
            {

                System.Windows.Forms.MessageBox.Show(error.Message);
                }
        }
        public void CalculateAverage(int sensorId) //Først sjekker om sensorene er inne fra før hvis ja så updater den ellers så lager den en ny
        {
            try
            {
                bool sensorExists = false;
                string sqlQuery;
                int numberOfRows;
                string Database = ConfigurationManager.ConnectionStrings["DatabaseD"].ConnectionString;
                SqlConnection con = new SqlConnection(Database);
                sqlQuery =
                    @"SELECT COUNT(sensorId)
                    FROM STATISTICSDATA
                    WHERE sensorId = " + "'" + sensorId + "'" + "";
                SqlCommand sql = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader dr = sql.ExecuteReader();
                dr.Read();
                numberOfRows = Convert.ToInt32(dr[0]);
                if (numberOfRows > 0)
                {
                    sensorExists = true;
                }
                con.Close();
                if (sensorExists == false)
                {
                    SqlCommand sql1 = new SqlCommand("uspInsertCalculateStatisticValues", con);
                    sql1.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    sql1.Parameters.Add(new SqlParameter("@sensorId", sensorId));
                    sql1.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    SqlCommand sql1 = new SqlCommand("uspUpdateCalculateStatisticValues", con);
                    sql1.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    sql1.Parameters.Add(new SqlParameter("@sensorId", sensorId));
                    sql1.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception error)
            {

                System.Windows.Forms.MessageBox.Show(error.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace School
{
    class Connection
    {
        public static SqlConnection connections = new SqlConnection("Data Source=DESKTOP-FNV545N;Initial Catalog=UrkPoshta;Integrated Security=True");

        public static DataTable LoadData(string NameProcedure)
        {
            try
            {
                Connection.connections.Open();

                SqlCommand command = connections.CreateCommand();
                command.CommandText = NameProcedure;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(rdr);
                Connection.connections.Close();
                return data;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                connections.Close();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n");
                }
                XtraMessageBox.Show(errorMessages.ToString());
                return null;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
                return null;
            }


        }
        public static DataTable LoadData(string NameProcedure, DataTable data)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(NameProcedure);
                cmd.Connection = Connection.connections;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet dataSet = new DataSet("Table");
                dataSet.Tables.Add(data);
                cmd.Parameters.AddWithValue("@filterSet", dataSet.GetXml());
                SqlDataReader rdr;
                connections.Open();
                rdr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(rdr);
                connections.Close();
                return dataTable;
            }
            catch (SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                connections.Close();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n");
                }
                XtraMessageBox.Show(errorMessages.ToString());
                return null;
            }
        }
        public static void EditData(string NameProcedure, DataTable data)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(NameProcedure); // NameProcedure - имя процедуры которая полетик в SQL
                cmd.Connection = Connection.connections;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet dataSet = new DataSet("Table");
                dataSet.Tables.Add(data);
                cmd.Parameters.AddWithValue("@filterSet", dataSet.GetXml());
                connections.Open();
                cmd.ExecuteNonQuery();
                connections.Close();
            }
            catch (SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                connections.Close();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n");
                }
                XtraMessageBox.Show(errorMessages.ToString());
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }
        public static DataTable Adapter(string NameProcedure)
        {
            try
            {
                Connection.connections.Open();
                SqlCommand command = connections.CreateCommand();
                command.CommandText = NameProcedure;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(rdr);
                Connection.connections.Close();
                return data;
            }
            catch (SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                connections.Close();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n");
                }
                XtraMessageBox.Show(errorMessages.ToString());
                return null;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}

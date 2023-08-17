using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poshta2._0
{
    public static class ProjectAdapter
    {
        #region Adapter Project
        public static DataTable AdapterPost()
        {
            try
            {
                Connection.connection.Open();
                #region Query Employer
                string query = @"SELECT   Post.ID_Post as 'ID_Post'
			                                ,Post.Name as 'Name_Post'
	                             FROM Post";
                #endregion
                SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
                SQLiteDataReader rdr;
                rdr = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(rdr);
                Connection.connection.Close();
                return data;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static DataTable AdapterDepartment()
        {
            try
            {
                Connection.connection.Open();
                #region Query Employer
                string query = @"
	                        SELECT   Department.ID_Department as 'ID_Department'
			                        ,Department.Name as 'Name_Department'
	                        FROM Department";
                #endregion
                SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
                SQLiteDataReader rdr;
                rdr = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(rdr);
                Connection.connection.Close();
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static DataTable AdapterIKP()
        {
            try
            {
                Connection.connection.Open();
                #region Query Employer
                string query = @"
	                        SELECT   ifnull(KPI.Name || '-' || KPI.Percent,'0') as Name_KPI
		                    ,KPI.[Name] as 'Percent'
                    FROM KPI";
                #endregion
                SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
                SQLiteDataReader rdr;
                rdr = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(rdr);
                Connection.connection.Close();
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        #endregion
        #region Grid Project
        public static DataTable GridEmployer()
        {
            Connection.connection.Open();
            #region Query Employer
            string query = @"SELECT	 
                         Employer.ID as 'Код Працівника'
                                ,Employer.FirstName as 'Ім''я'
		                        ,Employer.MiddleName as 'Прізвище'
		                        ,Employer.LastName as 'По батькові'
		                        ,Employer.Address as 'Адреса'
		                        ,ifnull(Post.Salary, '0') as 'Оклад'
		                        ,ifnull(KPI.Name,' ') as 'Тип КРІ'
		                        ,Ifnull(Post.NAME,' ') as 'Посада'
		                        ,Ifnull(Department.NAME,' ') as 'Департамент'
                FROM Employer
	            LEFT OUTER JOIN Post ON Employer.ID_Post = Post.ID_Post
	             LEFT OUTER JOIN KPI ON ifnull(KPI.[Name],' ') = ifnull(Employer.KPI,' ')
	              LEFT OUTER JOIN Department ON Department.ID_Department = Employer.ID_Department;";
            #endregion
            SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
            SQLiteDataReader rdr;
            rdr = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(rdr);
            Connection.connection.Close();
          
            
            return data;
        }
        public static DataTable GridDepartment()
        {
            Connection.connection.Open();
            #region Query Employer
            string query = @"select	 Department.ID_Department as 'Код департаменту'
		                            ,Department.Name as 'Назва департаменту'
                            from Department";
            #endregion
            SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
            SQLiteDataReader rdr;
            rdr = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(rdr);
            Connection.connection.Close();
            return data;
        }
        public static DataTable GridPost()
        {
            Connection.connection.Open();
            #region Query Employer
            string query = @"select	 Post.ID_Post as 'Код посту'
		                            ,Post.Name as 'Назва посту'
                                    ,Post.Salary as 'Оклад'
                            from Post";
            #endregion
            SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
            SQLiteDataReader rdr;
            rdr = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(rdr);
            Connection.connection.Close();
            return data;
        }
        public static DataTable GridKPI()
        {
            Connection.connection.Open();
            #region Query Employer
            string query = @"select	 
		                            IFNULL(Name,'0') as 'Назва KPI'
,                                   Percent 'Відсоток'
                            from KPI";
            #endregion
            SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
            SQLiteDataReader rdr;
            rdr = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(rdr);
            Connection.connection.Close();
            return data;
        }
        #endregion
        #region Edit Department
        public static void UpdateDepartment(DataTable dataTable)
        {
            Connection.connection.Open();
            #region Query 
            string query = @"UPDATE Department SET Name = @Name_Department		
	                         WHERE ID_Department = @ID_Department";
            #endregion
            SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
            command.Parameters.AddWithValue("@ID_Department",dataTable.Rows[1]["ID_Department"].ToString());
            command.Parameters.AddWithValue("@Name_Department", dataTable.Rows[1]["Name_Department"].ToString());
            command.ExecuteNonQuery();
            Connection.connection.Close();
        }
        public static void DeleteDepartment(DataTable dataTable)
        {
           
            Connection.connection.Open();
            #region Query
            string query = @"DELETE FROM Department
	                        WHERE ID_Department = @ID";
            #endregion
            SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
            command.Parameters.AddWithValue("@ID", dataTable.Rows[1]["ID_Department"].ToString());
            command.ExecuteNonQuery();
            Connection.connection.Close();
        }
        public static void InsertDepartment(DataTable dataTable)
        {
            Connection.connection.Open();
            #region Query Employer
            string query = @"INSERT INTO Department(Name)
                             VALUES(@Name_Department)";
            #endregion
            SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
            command.Parameters.AddWithValue("@Name_Department", dataTable.Rows[1]["Name_Department"].ToString());
            command.ExecuteNonQuery();
            Connection.connection.Close();
        }
        #endregion
        #region Edit Post
        public static void UpdatePost(DataTable dataTable)
        {
            Connection.connection.Open();
            #region Query 
            string query = @"UPDATE Post SET Name = @Name_Post, Salary = @Salary
	                         WHERE ID_Post = @ID_Post";
            #endregion
            SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
            command.Parameters.AddWithValue("@ID_Post", dataTable.Rows[1]["ID_Post"].ToString());
            command.Parameters.AddWithValue("@Name_Post", dataTable.Rows[1]["Name_Post"].ToString());
            command.Parameters.AddWithValue("@Salary", dataTable.Rows[1]["Salary"].ToString());
            command.ExecuteNonQuery();
            Connection.connection.Close();
        }
        public static void DeletePost(DataTable dataTable)
        {
            Connection.connection.Open();
            #region Query
            string query = @"DELETE FROM Post
	                        WHERE ID_Post = @ID_Post";
            #endregion
            SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
            command.Parameters.AddWithValue("@ID_Post", dataTable.Rows[1]["ID_Post"].ToString());
            command.ExecuteNonQuery();
            Connection.connection.Close();
        }
        public static void InsertPost(DataTable dataTable)
        {
            Connection.connection.Open();
            #region Query Employer
            string query = @"INSERT INTO Post(Name,Salary)
                             VALUES(@Name_Post,@Salary)";
            #endregion
            SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
            command.Parameters.AddWithValue("@Name_Post", dataTable.Rows[1]["Name_Post"].ToString());
            command.Parameters.AddWithValue("@Salary", dataTable.Rows[1]["Salary"].ToString());
            command.ExecuteNonQuery();
            Connection.connection.Close();
        }
        #endregion
        #region Edit KPI
        public static void UpdateKPI(DataTable dataTable)
        {
            try{
            Connection.connection.Open();
            #region Query 
            string query = @"UPDATE KPI SET Name = @Name, Percent = @Percent *1.0
	                         WHERE Name = @Name";
            #endregion
            SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
            command.Parameters.AddWithValue("@Name", dataTable.Rows[1]["Name"].ToString());
            command.Parameters.AddWithValue("@Percent", dataTable.Rows[1]["Percent"].ToString());
            command.ExecuteNonQuery();
            Connection.connection.Close();
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        public static void DeleteKPI(DataTable dataTable)
        {
            try
            {
            Connection.connection.Open();
            #region Query
            string query = @"DELETE FROM KPI
	                        WHERE Name = @Name";
            #endregion
            SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
            command.Parameters.AddWithValue("@Name", dataTable.Rows[1]["Name"].ToString());
            command.ExecuteNonQuery();
            Connection.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void InsertKPI(DataTable dataTable)
        {
            try
            {
                Connection.connection.Open();
                #region Query Employer
                string query = @"INSERT INTO Post(Name,Percent)
                             VALUES(@Name, @Percent*1.0";
                #endregion
                SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
                command.Parameters.AddWithValue("@Name", dataTable.Rows[1]["Name"].ToString());
                command.Parameters.AddWithValue("@Percent", dataTable.Rows[1]["Percent"].ToString());
                command.ExecuteNonQuery();
                Connection.connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        #endregion
        #region Edit Employer
        public static void UpdateEmployer(DataTable dataTable)
        {
            Connection.connection.Open();
            #region Query 
            string query = @"UPDATE Employer SET  
                                                 [FirstName] = @FirstName
					                            ,[MiddleName] = @MiddleName
					                            ,[LastName] = @LastName
					                            ,[Address] = @Address
					                            ,[KPI]= @KPI
					                            ,[ID_Post]= @ID_Post
					                            ,[ID_Department]= @ID_Department
                            WHERE ID = @ID;";
            #endregion
            SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
            command.Parameters.AddWithValue("@ID", dataTable.Rows[1]["ID"].ToString());
            command.Parameters.AddWithValue("@FirstName", dataTable.Rows[1]["FirstName"].ToString());
            command.Parameters.AddWithValue("@MiddleName", dataTable.Rows[1]["MiddleName"].ToString());
            command.Parameters.AddWithValue("@LastName", dataTable.Rows[1]["LastName"].ToString());
            command.Parameters.AddWithValue("@Address", dataTable.Rows[1]["Address"].ToString());
            command.Parameters.AddWithValue("@KPI", dataTable.Rows[1]["KPI"].ToString());
            command.Parameters.AddWithValue("@ID_Post", dataTable.Rows[1]["ID_Post"].ToString());
            command.Parameters.AddWithValue("@ID_Department", dataTable.Rows[1]["ID_Department"].ToString());
            command.ExecuteNonQuery();
            Connection.connection.Close();
        }
        public static void DeleteEmployer(DataTable dataTable)
        {
            Connection.connection.Open();
            #region Query
            string query = @"DELETE FROM Employer 
	                        WHERE ID = @ID";
            #endregion
            SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
            command.Parameters.AddWithValue("@ID", dataTable.Rows[1]["ID"].ToString());
            command.ExecuteNonQuery();
            Connection.connection.Close();
        }
        public static void InsertEmployer(DataTable dataTable)
        {
            Connection.connection.Open();
            #region Query Employer
            string query = @"INSERT INTO Employer([FirstName]
					                            ,[MiddleName]
					                            ,[LastName]
					                            ,[Address]
					                            ,[KPI]
					                            ,[ID_Post]
					                            ,[ID_Department])
                            VALUES(	 @FirstName
		                            ,@MiddleName
		                            ,@LastName
		                            ,@Address
		                            ,@KPI
		                            ,@ID_Post
		                            ,@ID_Department)";
            #endregion
            SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
            command.Parameters.AddWithValue("@FirstName", dataTable.Rows[1]["FirstName"].ToString());
            command.Parameters.AddWithValue("@MiddleName", dataTable.Rows[1]["MiddleName"].ToString());
            command.Parameters.AddWithValue("@LastName", dataTable.Rows[1]["LastName"].ToString());
            command.Parameters.AddWithValue("@Address", dataTable.Rows[1]["Address"].ToString());
            command.Parameters.AddWithValue("@KPI", dataTable.Rows[1]["KPI"].ToString());
            command.Parameters.AddWithValue("@ID_Post", dataTable.Rows[1]["ID_Post"].ToString());
            command.Parameters.AddWithValue("@ID_Department", dataTable.Rows[1]["ID_Department"].ToString());
            command.ExecuteNonQuery();
            Connection.connection.Close();
        }
        #endregion
        #region Function
        public static DataTable FilterGrid(int i, DataTable datatable)
        {
            try
            {
                Connection.connection.Open();
                #region Query Employer
                string query = @"SELECT	 
                                 Employer.ID as 'Код Працівника'
                                ,Employer.FirstName as 'Ім''я'
		                        ,Employer.MiddleName as 'Прізвище'
		                        ,Employer.LastName as 'По батькові'
		                        ,Employer.Address as 'Адреса'
		                        ,ifnull(Post.Salary, '0') as 'Оклад'
		                        ,ifnull(KPI.Name,' ') as 'Тип КРІ'
		                        ,Ifnull(Post.NAME,' ') as 'Посада'
		                        ,Ifnull(Department.NAME,' ') as 'Департамент'
                FROM Employer
	            LEFT OUTER JOIN Post ON Employer.ID_Post = Post.ID_Post
	             LEFT OUTER JOIN KPI ON ifnull(KPI.[Name],' ') = ifnull(Employer.KPI,' ')
	              LEFT OUTER JOIN Department ON Department.ID_Department = Employer.ID_Department ";
                    query += (i == 2) ? " WHERE Post.ID_Post = @ID_Post"
                    : (i == 1) ? " WHERE Department.ID_Department = @ID_Department"
                    : "WHERE Post.ID_Post = @ID_Post and Department.ID_Department = @ID_Department ";

                #endregion
                SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
                SQLiteDataReader rdr;
                command.Parameters.AddWithValue("@ID_Post", datatable.Rows[1]["Post"].ToString());
                command.Parameters.AddWithValue("@ID_Department", datatable.Rows[1]["Department"].ToString());
                rdr = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(rdr);
                Connection.connection.Close();
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static DataTable SumGridEmployer()
        {
            try
            {
                Connection.connection.Open();
                #region Query Employer
                string query = @"SELECT	 
                                 Employer.ID as 'Код Працівника'
                                ,Employer.FirstName as 'Ім''я'
		                        ,Employer.MiddleName as 'Прізвище'
		                        ,Employer.LastName as 'По батькові'
		                        ,Employer.Address as 'Адреса'
	                            ,ifnull(Post.Salary,'0') + (ifnull(Post.Salary, '0') * KPI.[Percent]) as 'Оклад_КРІ'
                                ,ifnull(Post.Salary, '0') as 'Оклад'
                                ,KPI.Percent as 'Відсоток'
		                        ,ifnull(KPI.Name,' ') as 'Тип КРІ'
		                        ,Ifnull(Post.NAME,' ') as 'Посада'
		                        ,Ifnull(Department.NAME,' ') as 'Департамент'
                        FROM Employer
	                    LEFT OUTER JOIN Post ON Employer.ID_Post = Post.ID_Post
	                     LEFT OUTER JOIN KPI ON ifnull(KPI.[Name],' ') = ifnull(Employer.KPI,' ')
	                      LEFT OUTER JOIN Department ON Department.ID_Department = Employer.ID_Department;";

                #endregion
                SQLiteCommand command = new SQLiteCommand(query, Connection.connection);
                SQLiteDataReader rdr;
                rdr = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(rdr);
                Connection.connection.Close();
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        #endregion
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Main_Form
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        SqlConnection connections = new SqlConnection("Data Source=DESKTOP-FNV545N;Initial Catalog=WMS;Integrated Security=True");
        private void Order_Load(object sender, EventArgs e)
        {
            GridInfo();
            CreateID_EmployeeAdapter();
        }
        public void GridInfo()
        {
            connections.Open();
            string query = @"Select	ID_Order
		                            ,CONCAT(E.MName,' ', SUBSTRING(E.FName,1 ,1),'.',' ',SUBSTRING(E.LName,1,1),'.') AS 'ПІБ'
		                            ,Order_Status
		                            ,Date_Orders
		                    from Orders as o
		                    join Employees as E on o.ID_Employee = e.ID";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connections);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataSet();
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
            ColumName();
            connections.Close();
        }
        public void ColumName()
        {
            dataGridView1.Columns[0].HeaderText = "Код замовлення";
            dataGridView1.Columns[1].HeaderText = "Працівник";
            dataGridView1.Columns[2].HeaderText = "Статус";
            dataGridView1.Columns[3].HeaderText = "Дата";
        }
        public void CreateID_EmployeeAdapter()
        {
            try
            {
                connections.Open();
                SqlCommand command = new SqlCommand(@"Select	E.ID
		                                            ,CONCAT(E.MName,' ', SUBSTRING(E.FName,1 ,1),'.',' ',SUBSTRING(E.LName,1,1),'.') AS 'ПІБ'
		                                            from Employees E", connections);
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable data = new DataTable();
                data.Load(rdr);
                ID_Employee.ValueMember = "ID";
                ID_Employee.DisplayMember = "ПІБ";
                ID_Employee.DataSource = data;
                connections.Close();
            }
            catch (Exception exc)
            {
                connections.Close();
                MessageBox.Show(exc.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    ID.Text = row.Cells["ID_Order"].Value.ToString();
                    ID_Employee.Text = row.Cells["ПІБ"].Value.ToString();
                    Order_Status.Text = row.Cells["Order_Status"].Value.ToString();
                    Data.Text = row.Cells["Date_Orders"].Value.ToString();
                   
                }
            }
            catch (Exception exc)
            {
              
                MessageBox.Show(exc.ToString());
            }
           
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = "INSERT INTO Orders(ID_Employee, Order_Status, Date_Orders) VALUES(" + ID_Employee.SelectedValue + "," + Order_Status.Text + ", @Date )";
                SqlCommand command = new SqlCommand(query, connections);
                command.Parameters.Add("@Date", SqlDbType.Date).Value = Data.Value.Date;
                command.ExecuteNonQuery();
                MessageBox.Show("Додано замовлення");
                connections.Close();

                connections.Open();
                query = @"Select TOP 1 ID_Order FROM Orders order by ID_Order desc ";
                command = new SqlCommand(query, connections);
                SqlDataReader rd = command.ExecuteReader();
                while(rd.Read())
                {
                    string result = rd["ID_order"].ToString();
                    ID.Text = result;
                }
                connections.Close();
                GridInfo();
            }catch(Exception exc)
            {
                connections.Close();
                MessageBox.Show(exc.ToString());
            }
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = "Update Orders Set ID_Employee = " + ID_Employee.SelectedValue + ", Order_Status =" + Order_Status.Text + ", Date_Orders = @Date where ID_Order = " + ID.Text + ";";
                SqlCommand command = new SqlCommand(query, connections);
                command.Parameters.Add("@Date", SqlDbType.Date).Value = Data.Value.Date;
                command.ExecuteNonQuery();
                MessageBox.Show("Оновлення замовлення");
                connections.Close();
                GridInfo();
            }
            catch (Exception exc)
            {
                connections.Close();
                MessageBox.Show(exc.ToString());
            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = "delete from Orders where ID_Order = " + ID.Text + ";";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                connections.Close();
                GridInfo();
                MessageBox.Show("Видалено");

            }
            catch(Exception exc)
            {
                connections.Close();
                MessageBox.Show(exc.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Show_formOrder_Click(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                MessageBox.Show("Заповніть поле код");
            }
            else
            {
                FormOrder formOrder = new FormOrder();
                formOrder.ID_Order.SelectedValue = ID.Text;
                formOrder.ID_Order.Text = ID.Text;
                formOrder.Data.Value = Convert.ToDateTime( Data.Text);
                formOrder.ID_Employee.SelectedValue = ID_Employee.SelectedValue;
                formOrder.Order_Status.SelectedValue = Order_Status.SelectedValue;
                formOrder.Order_Status.Text = Order_Status.Text;
                formOrder.Show();
            }
        }

        private void Search_date(object sender, EventArgs e)
        {
            if(button1.Text == "Пошук")
            {
                connections.Open();
                string query = @"Select	ID_Order
		                            ,CONCAT(E.MName,' ', SUBSTRING(E.FName,1 ,1),'.',' ',SUBSTRING(E.LName,1,1),'.') AS 'ПІБ'
		                            ,Order_Status
		                            ,Date_Orders
		                    from Orders as o
		                    join Employees as E on o.ID_Employee = e.ID
                            Where o.date_orders between @Data1 and @Data2";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connections);
                adapter.SelectCommand.Parameters.Add("@Data1", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                adapter.SelectCommand.Parameters.Add("@Data2", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var data = new DataSet();
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
                ColumName();
                connections.Close();
                button1.Text = "Повернути";
            }
            else
            {
                button1.Text = "Пошук";
                GridInfo();
            }
        }
    }
}

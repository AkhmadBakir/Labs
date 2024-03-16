using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NorthwindApp
{
    public partial class Form2 : Form
    {
        private OleDbConnection conn;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connectionstring = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False; Initial Catalog=Northwind;Data Source=(local)";
            conn = new OleDbConnection(connectionstring);
            try
            {
                this.conn.Open();
                MessageBox.Show("Status: Connection opened succesfully");
            }
            catch (SqlException)
            {
                MessageBox.Show("Status: Unable to open connection");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Status: Unable to open connection due to invalid connection string");
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (radioBtnOrder.Checked)
            {
                lstView.Items.Clear();

                OleDbDataReader readerOrder = null;
                OleDbCommand command = new OleDbCommand("SELECT * FROM [Orders]", conn);
                try
                {
                    readerOrder = command.ExecuteReader();
                    while (readerOrder.Read())
                    {
                        lstView.Items.Add(Convert.ToString(readerOrder["OrderID"]) + " " + Convert.ToString(readerOrder["CustomerID"]) + " " + Convert.ToString(readerOrder["ShipName"]) + " " + Convert.ToString(readerOrder["ShipAddress"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (readerOrder != null) 
                        readerOrder.Close();
                }

            }
            if (radioBtnEmployees.Checked)
            {
                lstView.Items.Clear();

                OleDbDataReader readerEmployees = null;
                OleDbCommand command = new OleDbCommand("SELECT * FROM [Employees]", conn);
                try
                {
                    readerEmployees = command.ExecuteReader();
                    while (readerEmployees.Read())
                    {
                        lstView.Items.Add(Convert.ToString(readerEmployees["LastName"]) + " " + Convert.ToString(readerEmployees["FirstName"]) + " " + Convert.ToString(readerEmployees["Title"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (readerEmployees != null)
                        readerEmployees.Close();
                }
                //MessageBox.Show("Employees button");
            }
            if (radioBtnCustomers.Checked)
            {
                lstView.Items.Clear();


                OleDbDataReader readerCustomers = null;
                OleDbCommand command = new OleDbCommand("SELECT * FROM [Customers]", conn);
                try
                {
                    readerCustomers = command.ExecuteReader();
                    while (readerCustomers.Read())
                    {
                        lstView.Items.Add(Convert.ToString(readerCustomers["CustomerID"]) + " " + Convert.ToString(readerCustomers["CompanyName"]) + " " + Convert.ToString(readerCustomers["ContactName"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (readerCustomers != null)
                        readerCustomers.Close();
                }
                //MessageBox.Show("Customers button");
            }

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("INSERT INTO [Customers] (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode)VALUES(?CustomerID, ?CompanyName, ?ContactName, ?ContactTitle, ?Address, ?City, ?Region, ?PostalCode)", conn);

            command.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
            command.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text);
            command.Parameters.AddWithValue("@ContactName", txtContactName.Text);
            command.Parameters.AddWithValue("@ContactTitle", txtContactTitle.Text);
            command.Parameters.AddWithValue("@Address", txtAddress.Text);
            command.Parameters.AddWithValue("@City", txtCity.Text);
            command.Parameters.AddWithValue("@Region", txtRegion.Text);
            command.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text);
            command.ExecuteNonQuery();
        }
    }
}

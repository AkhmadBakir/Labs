using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;
using System.Data.Common;



namespace NorthwindApp
{
    public partial class Welcome : Form
    {

        public Welcome()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //this.connection.StateChange += new System.Data.StateChangeEventHandler(this.connection_StateChange);
        }

        private void txtDBServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            string connectionstring = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=True;User ID= " + txtLogin.Text + "; Password= " + txtPassword.Text + "; Initial Catalog=Northwind;Data Source=(local)";
            OleDbConnection conn = new OleDbConnection(connectionstring);

            try
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    Form2 form = new Form2();
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failure: " + ex.Message);
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }

            }
        }

    }
}

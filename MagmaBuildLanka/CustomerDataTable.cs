using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MagmaBuildLanka
{
    public partial class CustomerDataTable : Form
    {
        public CustomerDataTable()
        {
            InitializeComponent();
        }
         SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=MyConstractionProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");

        private void buttonLoad_Click(object sender, EventArgs e)
        {try
            {
                string load_Query = "SELECT * FROM Customer";
                SqlCommand cmd = new SqlCommand(load_Query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridViewCustomer.DataSource = bsource;
                dataGridViewCustomer.ReadOnly = true;

            }
            catch (Exception ex)
            {
                  MessageBox.Show(ex.Message, "Error!");
            }
                 finally


            { con.Close(); }


            }

        private void CustomerDataTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myConstractionProjectDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.myConstractionProjectDataSet.Customer);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.customerTableAdapter.FillBy(this.myConstractionProjectDataSet.Customer, nameToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.customerTableAdapter.FillBy(this.myConstractionProjectDataSet.Customer, textBoxSearch.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        }
    }


        
    


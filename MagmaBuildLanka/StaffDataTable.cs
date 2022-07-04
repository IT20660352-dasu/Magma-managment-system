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
    public partial class StaffDataTable : Form
    {
        public StaffDataTable()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=MyConstractionProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");

        private void StaffDataTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myConstractionProjectDataSet2.StaffData' table. You can move, or remove it, as needed.
            this.staffDataTableAdapter.Fill(this.myConstractionProjectDataSet2.StaffData);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.staffDataTableAdapter.FillBy1(this.myConstractionProjectDataSet2.StaffData, fullNameToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string load_Query = "SELECT * FROM Staff";
                    SqlCommand cmd = new SqlCommand(load_Query, con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    BindingSource bsource = new BindingSource();
                    bsource.DataSource = dt;
                    dataGridViewStaff.DataSource = bsource;
                    dataGridViewStaff.ReadOnly = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                }
                finally


                { con.Close(); }


            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.staffDataTableAdapter.FillBy1(this.myConstractionProjectDataSet2.StaffData, textBoxSearch.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}

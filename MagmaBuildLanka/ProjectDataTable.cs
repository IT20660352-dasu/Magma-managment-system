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
    public partial class ProjectDataTable : Form
    {
        public ProjectDataTable()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=MyConstractionProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");

        private void buttonLoadprojects_Click(object sender, EventArgs e)
        {
             {try
            {
                string load_Query = "SELECT * FROM Project";
                SqlCommand cmd = new SqlCommand(load_Query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridViewProjects.DataSource = bsource;
                dataGridViewProjects.ReadOnly = true;

            }
            catch (Exception ex)
            {
                  MessageBox.Show(ex.Message, "Error!");
            }
                 finally


            { con.Close(); }


            }

        }

        private void dataGridViewProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void ProjectDataTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myConstractionProjectDataSet.NewProject' table. You can move, or remove it, as needed.
            this.newProjectTableAdapter.Fill(this.myConstractionProjectDataSet.NewProject);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.newProjectTableAdapter.FillBy(this.myConstractionProjectDataSet.NewProject, nameToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            try
            {
                this.newProjectTableAdapter.FillBy(this.myConstractionProjectDataSet.NewProject, textBoxSearch.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }


        
    


        }
    


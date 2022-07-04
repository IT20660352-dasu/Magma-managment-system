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
    public partial class LabourDetailsForm : Form
    {
        public LabourDetailsForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=MyConstractionProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        
        private void buttonSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                Labour labour = new Labour();
                labour.LabourID = new Random().Next();
                labour.Name = textBoxNAME.Text;
                labour.Address = textBoxADDRESS.Text;
                labour.NICNO = textBoxNICNo.Text;
                labour.TPNO = Convert.ToInt32(textBoxTPNO.Text);

                string labour_insert_query = "INSERT INTO [labour] VALUES('" + labour.LabourID + "','" + labour.Name + "','" + labour.Address + "','" + labour.TPNO+ "','" + labour.NICNO+ "')";
                SqlCommand command = new SqlCommand(labour_insert_query, con);
                con.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Saved", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error!");
            }
            finally
            {
                con.Close();

            }

        }


        private void buttonLOAD_Click(object sender, EventArgs e)
        {
            try
            {
                string load_Query = "SELECT * FROM Labour";
                SqlCommand cmd = new SqlCommand(load_Query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridViewlabour.DataSource = bsource;
                dataGridViewlabour.ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            finally


            { con.Close(); }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBoxNAME.Clear();
            textBoxTPNO.Clear();
            textBoxADDRESS.Clear();
            textBoxNICNo.Clear();
        }

        private void LabourDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}

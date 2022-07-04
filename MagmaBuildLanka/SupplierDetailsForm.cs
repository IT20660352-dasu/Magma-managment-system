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
    public partial class SupplierDetailsForm : Form
    {
        public SupplierDetailsForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=MyConstractionProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        { try
            {

  
                Supplier supplier =new Supplier ();
                supplier.SupplierID  = new Random().Next();
                supplier.SupplierName = textBoxSupplierName.Text;
                supplier.CompanyName = textboxcname.Text;
                supplier.Email = textBoxEmail.Text;
                supplier.WebSite = textBoxWebsite.Text;
                supplier.TPNO = Convert.ToInt32(textBoxTPNO.Text);

                string supplier_insert_query = "INSERT INTO Supplier VALUES('" +   supplier.SupplierID + "','" +   supplier.SupplierName + "','" +   supplier.TPNO+ "','" +   supplier.Email + "','" +   supplier.CompanyName + "','" +   supplier.WebSite + "')";
                SqlCommand command = new SqlCommand(supplier_insert_query, con);
                con.Open();
                command.ExecuteNonQuery();





                MessageBox.Show("Record inserted succusfully", "successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
              

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

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
        {
            string load_Query = "SELECT * FROM Supplier";
                SqlCommand cmd = new SqlCommand(load_Query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridViewSupplier.DataSource = bsource;
                dataGridViewSupplier.ReadOnly = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            finally


            { con.Close(); }


        
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSupplierName.Clear();
            textboxcname.Clear();
            textBoxEmail.Clear();
            textBoxTPNO.Clear();
            textBoxWebsite.Clear();
        }

        private void dataGridViewSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        }
    }


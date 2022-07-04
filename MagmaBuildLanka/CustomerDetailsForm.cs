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
    public partial class CustomerDetailsForm : Form
    {
        public CustomerDetailsForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=MyConstractionProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {

                Customer customer = new Customer();
                customer.CustomerID = new Random().Next();
                customer.Name = textBoxName.Text;
                customer.Address = textBoxAddress.Text;
                customer.Email = textBoxEMail.Text;
                customer.TPNO = Convert.ToInt32(textBoxTPNO.Text);

                string customer_insert_query = "INSERT INTO [customer] VALUES('" + customer.CustomerID + "','" + customer.Name + "','" + customer.Address + "','" + customer.Email + "','" + customer.TPNO + "')";
                SqlCommand command = new SqlCommand(customer_insert_query, con);
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxAddress.Clear();
            textBoxTPNO.Clear();
            textBoxEMail.Clear();
            

        }

        private void buttonBACK_Click(object sender, EventArgs e)
        {
            Magma _magma = new Magma();
            _magma.Show();
            this.Hide();

           

        }

        private void CustomerDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}

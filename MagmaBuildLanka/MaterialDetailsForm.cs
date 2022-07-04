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
    public partial class MaterialDetailsForm : Form
    {
        public MaterialDetailsForm()
        {
            InitializeComponent();
        }
             SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=MyConstractionProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {

               Material material = new Material();
               material.MaterialID = new Random().Next();
               material.MaterialName = textBoxMaterialName.Text;
               material.BrandName = textBoxBrandName.Text;
               material.price = textBoxPrice.Text;
               material.Quantity = textBoxQuantity.Text;
               material.Discount = textBoxDiscount.Text;
               string material_insert_query = "INSERT INTO [material] VALUES('" + material.MaterialID + "','" + material.price + "','" + material.MaterialName + "','" + material.BrandName + "','" + material.Quantity + "','" + material.Discount + "')";
               SqlCommand command = new SqlCommand(material_insert_query, con);
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
            textBoxBrandName.Clear();
            textBoxMaterialName.Clear();
            textBoxDiscount.Clear();
            textBoxPrice.Clear();
            textBoxQuantity.Clear();
                
        }
        
    }
}

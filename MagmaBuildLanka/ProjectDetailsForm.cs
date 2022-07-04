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
    public partial class ProjectDetailsForm : Form
    {
        public ProjectDetailsForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=MyConstractionProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        
        private void buttonClear_Click(object sender, EventArgs e)
        {
             textBoxName.Clear();
            textBoxAddress.Clear();
            textBoxTPNO.Clear();
            textBoxEmail.Clear();
            textBoxPassword.Clear();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                NewProject newproject = new NewProject();
                newproject.ProjectID = new Random().Next();
                newproject.Name = textBoxName.Text;
                newproject.Address = textBoxAddress.Text;
                newproject.TPNO = Convert.ToInt32(textBoxTPNO.Text);
                newproject.Email = textBoxEmail.Text;
                newproject.Password = textBoxPassword.Text;

                string newproject_insert_query = "INSERT INTO [newproject] VALUES('" + newproject.ProjectID + "','" + newproject.Name + "','" + newproject.Address + "','" + newproject.TPNO + "','" + newproject.Email + "','" + newproject.Password + "')";
                SqlCommand command = new SqlCommand(newproject_insert_query, con);
                con.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Registered!", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {MessageBox.Show(ex.Message.ToString(), "Error!");
            }
            finally
            {
                con.Close();

                
            }
        }

        }
    }


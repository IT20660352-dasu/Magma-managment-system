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
    public partial class ServiceDetailsForm : Form
    {
        public ServiceDetailsForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=MyConstractionProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
              try
            {

                Service service = new Service();
                service.ServiceID = new Random().Next();
                service.ProjectName = textBoxPname.Text;
                service.ServiceType = textBoxServiceType.Text;
                service.Sdate = dateTimePickerSDate.Value;
                service.Fdate = dateTimePickerFDate.Value;
                service.Fullpayment = Convert.ToInt32(textBoxFullPayment.Text);

                string service_insert_query = "INSERT INTO [service] VALUES('" + service.ServiceID + "','" + service.ProjectName + "','" + service.ServiceType + "','" + service.Fullpayment + "','" + service.Sdate + "','" + service.Fdate + "')";
                SqlCommand command = new SqlCommand(service_insert_query, con);
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
            textBoxFullPayment.Clear();
            textBoxPname.Clear();
            textBoxServiceType.Clear();
            
        }

        private void Next_Click(object sender, EventArgs e)
        {

        }

        }
    }


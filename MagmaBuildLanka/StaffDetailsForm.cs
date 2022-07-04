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
    public partial class StaffDetailsForm : Form
    {
        public StaffDetailsForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=MyConstractionProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        int StaffID;
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
             try
            {
               Staff Staff = new Staff();
                Staff.StaffID= new Random().Next();
                Staff.FullName = textBoxNAME.Text;
                Staff.Department = textBoxDEPARTMENT.Text;
                Staff.Desingtion = textBoxDesignation.Text;
                Staff.Email = textBoxEMAIL.Text;
                if (RadioButtonMale.Checked)
                {
                    Staff.Gender  = true;
                }
                else
                {
                    Staff.Gender = false;
                }

                Staff.TPNO = Convert.ToInt32(textBoxTPNO.Text);
               

                con.Open();
                string Update_Quary = "UPDATE StaffData SET  FullName='" + Staff.FullName + "',Department ='" + Staff.Department + "' ,Desingtion ='" + Staff.Desingtion + "'  , Gender='" + Staff.Gender + "', Email='" + Staff.Email + "', TPNO = '" + Staff.TPNO + "' WHERE StaffID='" + Staff.StaffID + "'";
                SqlCommand command = new SqlCommand(Update_Quary, con);
                command.ExecuteReader();
                MessageBox.Show("Record Update Succsefully", "Succsefull");
                textBoxNAME.Clear(); //We cant cleat date time picker
                textBoxDEPARTMENT.Clear();
                textBoxDesignation.Clear();
                textBoxEMAIL.Clear();
                textBoxTPNO.Clear();
                
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string delete_quary = "DELETE FROM [StaffData] WHERE StaffID = '" + StaffID + "'";
                SqlCommand command = new SqlCommand(delete_quary, con);
                con.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Record Delete Successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNAME.Clear(); //We cant cleat date time picker
            textBoxDEPARTMENT.Clear();
            textBoxDesignation.Clear();
            textBoxEMAIL.Clear();
            textBoxTPNO.Clear();
                

        }

     
        }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagmaBuildLanka
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            if (userName == "admin" && password == "abc")
            {
                Magma _magma = new Magma();
                _magma.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect LogInForm credentials", "Information", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUserName.Clear();
            textBoxPassword.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


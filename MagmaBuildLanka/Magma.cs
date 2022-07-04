using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MagmaBuildLanka
{
    public partial class Magma : Form
    {
        public Magma()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnmaximize.Visible = true;
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximize.Visible = false;
            btnRestaurar.Visible = true;

        }

        private void Menuvertical_Paint(object sender, PaintEventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void customizeDesing()
        {
            SubmenuDetails.Visible = false;
            SubmenuTables.Visible = false;
        }
        private void hideSubMenu()
        {
            if (SubmenuDetails.Visible == true)
                SubmenuDetails.Visible = false;
            if (SubmenuTables.Visible == true)
                SubmenuTables.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void buttonDetailsForms_Click(object sender, EventArgs e)
        {
            showSubMenu(SubmenuDetails);
        }

        private void buttonSupplierDetails_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new SupplierDetailsForm());
            hideSubMenu();
        }

        private void buttonLabourDetails_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new LabourDetailsForm());
            hideSubMenu();
        }

        private void buttonStaffDetails_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new StaffDetailsForm());
            hideSubMenu();
        }

        private void buttonCustomerDetails_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CustomerDetailsForm());

            hideSubMenu();
        }

        private void buttonProjectsDetails_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ProjectDetailsForm());
            hideSubMenu();
        }

        private void buttonMaterialDetails_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new MaterialDetailsForm());
            hideSubMenu();
        }

        private void buttonDetailsTables_Click(object sender, EventArgs e)
        {
            showSubMenu(SubmenuTables);
        }

        private void buttonmaterialTable_Click(object sender, EventArgs e)
        {

            AbrirFormEnPanel(new MaterialDataTable());
            hideSubMenu();
        }

        private void buttonStaffTable_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new StaffDataTable());
            hideSubMenu();
        }

        private void buttonCustomerTable_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CustomerDataTable());
            hideSubMenu();
        }

        private void buttonProjectTable_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ProjectDataTable());
            hideSubMenu();
        }

        private void buttonCustomerD_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new CustomerDetailsForm());

        }

        private void buttonServiceDetails_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ServiceDetailsForm());
            hideSubMenu();

        }

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

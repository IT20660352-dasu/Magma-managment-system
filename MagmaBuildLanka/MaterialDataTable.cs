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
    public partial class MaterialDataTable : Form
    {
        public MaterialDataTable()
        {
            InitializeComponent();
        }

        private void MaterialDataTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myConstractionProjectDataSet.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.myConstractionProjectDataSet.Material);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.materialTableAdapter.FillBy(this.myConstractionProjectDataSet.Material, materialNameToolStripTextBox.Text);
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
                this.materialTableAdapter.FillBy(this.myConstractionProjectDataSet.Material, textBoxSearch.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}

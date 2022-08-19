using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPCA_gui
{
    public partial class frmHome : Form
    {
        AnimalManager am;
        public frmHome(AnimalManager am)
        {
            this.am = am;
            InitializeComponent();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddAnimal window = new frmAddAnimal(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnCostSummary_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCostSummary window = new frmCostSummary(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnSearchAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnimalDatabase window = new frmAnimalDatabase(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}

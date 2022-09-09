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
    public partial class frmCostSummary : Form
    {
        AnimalManager am;
        public frmCostSummary(AnimalManager am)
        {
            this.am = am;
            InitializeComponent();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome window = new frmHome(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
        private void frmCostSummary_Load(object sender, EventArgs e)
        {
            rtbCostOutput.Text = $"{am.AllAnimalsCostSummary()}";
        }
    }
}

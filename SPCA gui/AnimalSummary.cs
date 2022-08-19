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
    public partial class frmAnimalSummary : Form
    {
        AnimalManager am;
        int selectedId;
        public frmAnimalSummary(AnimalManager am, int selectedId)
        {
            this.am = am;
            this.selectedId = selectedId;
            InitializeComponent();

            rtbSummaryOutput.Text = am.AnimalSummary(selectedId);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnimalDatabase window = new frmAnimalDatabase(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

    }
}

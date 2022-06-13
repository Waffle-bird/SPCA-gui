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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAnimal window = new AddAnimal();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnAnimalSummary_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalSummary window = new AnimalSummary();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnSearchAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchAnimal window = new SearchAnimal();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnAddAnimalConsumption_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalConsumption window = new AnimalConsumption();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}

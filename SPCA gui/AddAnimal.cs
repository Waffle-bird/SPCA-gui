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
    public partial class AddAnimal : Form
    {
        private AnimalManager am;
        public AddAnimal(AnimalManager am)
        {
            this.am = am;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home window = new Home(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnAddAnimalEnter_Click(object sender, EventArgs e)
        {
            am.AddOneAnimal(new Animal(tbxAddName.Text, Convert.ToInt32(nudAddAge.Value),cbxAddSpecies.Text));

            tbxAddName.Text = "";
            nudAddAge.Value = 0;
            cbxAddSpecies.Text = "";

            MessageBox.Show("Animal Added Successfully");
        }
    }
}

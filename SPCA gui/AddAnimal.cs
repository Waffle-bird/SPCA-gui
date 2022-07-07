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
    public partial class frmAddAnimal : Form
    {
        private AnimalManager am;
        public frmAddAnimal(AnimalManager am)
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

        private void btnAddAnimalEnter_Click(object sender, EventArgs e)
        {
            am.AddOneAnimal(new Animal(tbxAddName.Text, Convert.ToInt32(nudAddAge.Value),cbxAddSpecies.Text));

            tbxAddName.Text = "";
            nudAddAge.Value = 0;
            cbxAddSpecies.Text = "";

            MessageBox.Show("Animal Added Successfully");
        }

        //private void frmAddAnimal_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == Convert.ToChar(Keys.Return))
        //    {
        //        MessageBox.Show("Key pressed");
        //    }

        //    if (e.KeyChar == (char)13)
        //    {
        //        am.AddOneAnimal(new Animal(tbxAddName.Text, Convert.ToInt32(nudAddAge.Value), cbxAddSpecies.Text));

        //        tbxAddName.Text = "";
        //        nudAddAge.Value = 0;
        //        cbxAddSpecies.Text = "";

        //        MessageBox.Show("Animal Added Successfully");
        //    }
        //}
    }
}

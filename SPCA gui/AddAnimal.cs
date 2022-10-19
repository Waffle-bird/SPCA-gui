﻿using System;
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
        //constructor
        public frmAddAnimal(AnimalManager am)
        {
            this.am = am;
            InitializeComponent();
        }

        //methods
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome window = new frmHome(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private bool CheckSpecies()
        {
            string ERROR = "Please enter a valid species";
            if (cbxAddSpecies.Text.All(char.IsLetter))
            {
                return true;
            }

            else 
            MessageBox.Show(ERROR);
            cbxAddSpecies.Text = "";
            return false;
        }

        private void btnAddAnimalEnter_Click(object sender, EventArgs e)
        {
            if (CheckSpecies() == true)
            {
                am.AddOneAnimal(new Animal(tbxAddName.Text, Convert.ToInt32(nudAddAge.Value), cbxAddSpecies.Text));

                tbxAddName.Text = "";
                nudAddAge.Value = 0;
                cbxAddSpecies.Text = "";

                MessageBox.Show("Animal Added Successfully");
            }
        }        
    }
}

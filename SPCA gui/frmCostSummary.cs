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
    public partial class frmCostSummary : Form
    {
        AnimalManager am;
        public frmCostSummary(AnimalManager am)
        {
            this.am = am;
            InitializeComponent();
        }
    }
}

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
    public partial class frmAnimalDatabase : Form
    {
        AnimalManager am;
        private DataTable dt;
        private DataView dv;
        int selectedId = -1;

        public frmAnimalDatabase(AnimalManager am)
        {
            this.am = am;
            InitializeComponent();


            //Listview Properties
            lsvAnimalList.View = View.Details;
            lsvAnimalList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //Add Columns
            lsvAnimalList.Columns.Add("ID");
            lsvAnimalList.Columns.Add("Name");
            lsvAnimalList.Columns.Add("Age");
            lsvAnimalList.Columns.Add("Species");
            //Initialise Datatable and add Columns
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Species");

            List<Animal> animals = am.GetAnimals();

            foreach (var animal in animals)   //Code from Microsoft Teams
            {

                dt.Rows.Add(animal.GetId(), animal.GetName(), animal.GetAge(), animal.GetSpecies());

            }

            //Fill Datatable
            dv = new DataView(dt);
            PopulateListView(dv);
        }

        private void PopulateListView(DataView dv)
        {
            lsvAnimalList.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                lsvAnimalList.Items.Add(new ListViewItem(new String[] {row[0].ToString(), row[1].ToString(), row[2].ToString(),
                    row[3].ToString()}));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome window = new frmHome(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void lsvAnimalList_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("TEST");
        }


    }
}

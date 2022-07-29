
namespace SPCA_gui
{
    partial class frmAnimalDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddConsumption = new System.Windows.Forms.Button();
            this.btnAnimalSummary = new System.Windows.Forms.Button();
            this.lsvAnimalList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddConsumption
            // 
            this.btnAddConsumption.Enabled = false;
            this.btnAddConsumption.Location = new System.Drawing.Point(12, 331);
            this.btnAddConsumption.Name = "btnAddConsumption";
            this.btnAddConsumption.Size = new System.Drawing.Size(109, 31);
            this.btnAddConsumption.TabIndex = 2;
            this.btnAddConsumption.Text = "Add Consumpion";
            this.btnAddConsumption.UseVisualStyleBackColor = true;
            this.btnAddConsumption.Click += new System.EventHandler(this.btnAddConsumption_Click);
            // 
            // btnAnimalSummary
            // 
            this.btnAnimalSummary.Enabled = false;
            this.btnAnimalSummary.Location = new System.Drawing.Point(127, 331);
            this.btnAnimalSummary.Name = "btnAnimalSummary";
            this.btnAnimalSummary.Size = new System.Drawing.Size(109, 31);
            this.btnAnimalSummary.TabIndex = 3;
            this.btnAnimalSummary.Text = "Summary";
            this.btnAnimalSummary.UseVisualStyleBackColor = true;
            // 
            // lsvAnimalList
            // 
            this.lsvAnimalList.FullRowSelect = true;
            this.lsvAnimalList.HideSelection = false;
            this.lsvAnimalList.Location = new System.Drawing.Point(12, 41);
            this.lsvAnimalList.Name = "lsvAnimalList";
            this.lsvAnimalList.Size = new System.Drawing.Size(397, 270);
            this.lsvAnimalList.TabIndex = 4;
            this.lsvAnimalList.UseCompatibleStateImageBehavior = false;
            this.lsvAnimalList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lsvAnimalList_ItemSelectionChanged);
            this.lsvAnimalList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvAnimalList_MouseClick);
            // 
            // frmAnimalDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 376);
            this.Controls.Add(this.lsvAnimalList);
            this.Controls.Add(this.btnAnimalSummary);
            this.Controls.Add(this.btnAddConsumption);
            this.Controls.Add(this.btnBack);
            this.Name = "frmAnimalDatabase";
            this.Text = "Animal Database";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddConsumption;
        private System.Windows.Forms.Button btnAnimalSummary;
        private System.Windows.Forms.ListView lsvAnimalList;
    }
}
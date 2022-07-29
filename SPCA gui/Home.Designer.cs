
namespace SPCA_gui
{
    partial class frmHome
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
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnAnimalDatabase = new System.Windows.Forms.Button();
            this.btnAnimalSummary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(12, 360);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(149, 78);
            this.btnAddAnimal.TabIndex = 0;
            this.btnAddAnimal.Text = "Add Animal\r\n";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnAnimalDatabase
            // 
            this.btnAnimalDatabase.Location = new System.Drawing.Point(167, 360);
            this.btnAnimalDatabase.Name = "btnAnimalDatabase";
            this.btnAnimalDatabase.Size = new System.Drawing.Size(149, 78);
            this.btnAnimalDatabase.TabIndex = 1;
            this.btnAnimalDatabase.Text = "Animal Database";
            this.btnAnimalDatabase.UseVisualStyleBackColor = true;
            this.btnAnimalDatabase.Click += new System.EventHandler(this.btnSearchAnimal_Click);
            // 
            // btnAnimalSummary
            // 
            this.btnAnimalSummary.Location = new System.Drawing.Point(322, 360);
            this.btnAnimalSummary.Name = "btnAnimalSummary";
            this.btnAnimalSummary.Size = new System.Drawing.Size(149, 78);
            this.btnAnimalSummary.TabIndex = 3;
            this.btnAnimalSummary.Text = "Animal Summary";
            this.btnAnimalSummary.UseVisualStyleBackColor = true;
            this.btnAnimalSummary.Click += new System.EventHandler(this.btnAnimalSummary_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.btnAnimalSummary);
            this.Controls.Add(this.btnAnimalDatabase);
            this.Controls.Add(this.btnAddAnimal);
            this.Name = "frmHome";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnAnimalDatabase;
        private System.Windows.Forms.Button btnAnimalSummary;
    }
}


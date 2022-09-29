
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
            this.btnCostSummary = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(120)))), ((int)(((byte)(198)))));
            this.btnAddAnimal.FlatAppearance.BorderSize = 0;
            this.btnAddAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnimal.ForeColor = System.Drawing.Color.White;
            this.btnAddAnimal.Location = new System.Drawing.Point(12, 360);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(149, 78);
            this.btnAddAnimal.TabIndex = 0;
            this.btnAddAnimal.Text = "Add Animal\r\n";
            this.btnAddAnimal.UseVisualStyleBackColor = false;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnAnimalDatabase
            // 
            this.btnAnimalDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(120)))), ((int)(((byte)(198)))));
            this.btnAnimalDatabase.FlatAppearance.BorderSize = 0;
            this.btnAnimalDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimalDatabase.ForeColor = System.Drawing.Color.White;
            this.btnAnimalDatabase.Location = new System.Drawing.Point(167, 360);
            this.btnAnimalDatabase.Name = "btnAnimalDatabase";
            this.btnAnimalDatabase.Size = new System.Drawing.Size(149, 78);
            this.btnAnimalDatabase.TabIndex = 1;
            this.btnAnimalDatabase.Text = "Animal Database";
            this.btnAnimalDatabase.UseVisualStyleBackColor = false;
            this.btnAnimalDatabase.Click += new System.EventHandler(this.btnSearchAnimal_Click);
            // 
            // btnCostSummary
            // 
            this.btnCostSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(120)))), ((int)(((byte)(198)))));
            this.btnCostSummary.FlatAppearance.BorderSize = 0;
            this.btnCostSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCostSummary.ForeColor = System.Drawing.Color.White;
            this.btnCostSummary.Location = new System.Drawing.Point(322, 360);
            this.btnCostSummary.Name = "btnCostSummary";
            this.btnCostSummary.Size = new System.Drawing.Size(149, 78);
            this.btnCostSummary.TabIndex = 3;
            this.btnCostSummary.Text = "Cost Summary";
            this.btnCostSummary.UseVisualStyleBackColor = false;
            this.btnCostSummary.Click += new System.EventHandler(this.btnCostSummary_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(2, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(482, 55);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "SPCA Food Manager";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCostSummary);
            this.Controls.Add(this.btnAnimalDatabase);
            this.Controls.Add(this.btnAddAnimal);
            this.Name = "frmHome";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnAnimalDatabase;
        private System.Windows.Forms.Button btnCostSummary;
        private System.Windows.Forms.Label lblTitle;
    }
}


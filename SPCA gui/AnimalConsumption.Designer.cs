
namespace SPCA_gui
{
    partial class frmAnimalConsumption
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
            this.btnConsumptionEnter = new System.Windows.Forms.Button();
            this.dtpConsumptionDate = new System.Windows.Forms.DateTimePicker();
            this.btnConsumptionBack = new System.Windows.Forms.Button();
            this.nudConsumptionWeight = new System.Windows.Forms.NumericUpDown();
            this.lblConsumptionWeight = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsumptionWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsumptionEnter
            // 
            this.btnConsumptionEnter.Location = new System.Drawing.Point(12, 122);
            this.btnConsumptionEnter.Name = "btnConsumptionEnter";
            this.btnConsumptionEnter.Size = new System.Drawing.Size(75, 23);
            this.btnConsumptionEnter.TabIndex = 0;
            this.btnConsumptionEnter.Text = "Enter";
            this.btnConsumptionEnter.UseVisualStyleBackColor = true;
            this.btnConsumptionEnter.Click += new System.EventHandler(this.btnConsumptionEnter_Click);
            // 
            // dtpConsumptionDate
            // 
            this.dtpConsumptionDate.Location = new System.Drawing.Point(48, 47);
            this.dtpConsumptionDate.Name = "dtpConsumptionDate";
            this.dtpConsumptionDate.Size = new System.Drawing.Size(200, 20);
            this.dtpConsumptionDate.TabIndex = 1;
            // 
            // btnConsumptionBack
            // 
            this.btnConsumptionBack.Location = new System.Drawing.Point(12, 12);
            this.btnConsumptionBack.Name = "btnConsumptionBack";
            this.btnConsumptionBack.Size = new System.Drawing.Size(75, 23);
            this.btnConsumptionBack.TabIndex = 2;
            this.btnConsumptionBack.Text = "Back";
            this.btnConsumptionBack.UseVisualStyleBackColor = true;
            this.btnConsumptionBack.Click += new System.EventHandler(this.btnConsumptionBack_Click);
            // 
            // nudConsumptionWeight
            // 
            this.nudConsumptionWeight.Location = new System.Drawing.Point(64, 83);
            this.nudConsumptionWeight.Name = "nudConsumptionWeight";
            this.nudConsumptionWeight.Size = new System.Drawing.Size(184, 20);
            this.nudConsumptionWeight.TabIndex = 3;
            // 
            // lblConsumptionWeight
            // 
            this.lblConsumptionWeight.AutoSize = true;
            this.lblConsumptionWeight.Location = new System.Drawing.Point(12, 85);
            this.lblConsumptionWeight.Name = "lblConsumptionWeight";
            this.lblConsumptionWeight.Size = new System.Drawing.Size(46, 13);
            this.lblConsumptionWeight.TabIndex = 4;
            this.lblConsumptionWeight.Text = "Food (g)";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 47);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // frmAnimalConsumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 160);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblConsumptionWeight);
            this.Controls.Add(this.nudConsumptionWeight);
            this.Controls.Add(this.btnConsumptionBack);
            this.Controls.Add(this.dtpConsumptionDate);
            this.Controls.Add(this.btnConsumptionEnter);
            this.Name = "frmAnimalConsumption";
            this.Text = "AnimalConsumption";
            ((System.ComponentModel.ISupportInitialize)(this.nudConsumptionWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsumptionEnter;
        private System.Windows.Forms.DateTimePicker dtpConsumptionDate;
        private System.Windows.Forms.Button btnConsumptionBack;
        private System.Windows.Forms.NumericUpDown nudConsumptionWeight;
        private System.Windows.Forms.Label lblConsumptionWeight;
        private System.Windows.Forms.Label lblDate;
    }
}
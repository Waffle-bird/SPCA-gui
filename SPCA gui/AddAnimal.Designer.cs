
namespace SPCA_gui
{
    partial class frmAddAnimal
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
            this.tbxAddName = new System.Windows.Forms.TextBox();
            this.lblAddName = new System.Windows.Forms.Label();
            this.cbxAddSpecies = new System.Windows.Forms.ComboBox();
            this.lblAddSpecies = new System.Windows.Forms.Label();
            this.nudAddAge = new System.Windows.Forms.NumericUpDown();
            this.lblAddAge = new System.Windows.Forms.Label();
            this.btnAddAnimalEnter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddAge)).BeginInit();
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
            // tbxAddName
            // 
            this.tbxAddName.Location = new System.Drawing.Point(105, 47);
            this.tbxAddName.Name = "tbxAddName";
            this.tbxAddName.Size = new System.Drawing.Size(146, 20);
            this.tbxAddName.TabIndex = 1;
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(15, 50);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(66, 13);
            this.lblAddName.TabIndex = 2;
            this.lblAddName.Text = "Enter Name:";
            // 
            // cbxAddSpecies
            // 
            this.cbxAddSpecies.FormattingEnabled = true;
            this.cbxAddSpecies.Items.AddRange(new object[] {
            "Dog",
            "Cat",
            "Rabbit",
            "Guinea Pig",
            "Chicken"});
            this.cbxAddSpecies.Location = new System.Drawing.Point(105, 116);
            this.cbxAddSpecies.Name = "cbxAddSpecies";
            this.cbxAddSpecies.Size = new System.Drawing.Size(146, 21);
            this.cbxAddSpecies.TabIndex = 3;
            // 
            // lblAddSpecies
            // 
            this.lblAddSpecies.AutoSize = true;
            this.lblAddSpecies.Location = new System.Drawing.Point(12, 119);
            this.lblAddSpecies.Name = "lblAddSpecies";
            this.lblAddSpecies.Size = new System.Drawing.Size(81, 13);
            this.lblAddSpecies.TabIndex = 4;
            this.lblAddSpecies.Text = "Select Species:";
            // 
            // nudAddAge
            // 
            this.nudAddAge.Location = new System.Drawing.Point(105, 82);
            this.nudAddAge.Name = "nudAddAge";
            this.nudAddAge.Size = new System.Drawing.Size(146, 20);
            this.nudAddAge.TabIndex = 5;
            // 
            // lblAddAge
            // 
            this.lblAddAge.AutoSize = true;
            this.lblAddAge.Location = new System.Drawing.Point(15, 84);
            this.lblAddAge.Name = "lblAddAge";
            this.lblAddAge.Size = new System.Drawing.Size(57, 13);
            this.lblAddAge.TabIndex = 6;
            this.lblAddAge.Text = "Enter Age:";
            // 
            // btnAddAnimalEnter
            // 
            this.btnAddAnimalEnter.Location = new System.Drawing.Point(12, 148);
            this.btnAddAnimalEnter.Name = "btnAddAnimalEnter";
            this.btnAddAnimalEnter.Size = new System.Drawing.Size(75, 23);
            this.btnAddAnimalEnter.TabIndex = 7;
            this.btnAddAnimalEnter.Text = "Enter";
            this.btnAddAnimalEnter.UseVisualStyleBackColor = true;
            this.btnAddAnimalEnter.Click += new System.EventHandler(this.btnAddAnimalEnter_Click);
            // 
            // frmAddAnimal
            // 
            this.AcceptButton = this.btnAddAnimalEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 193);
            this.Controls.Add(this.btnAddAnimalEnter);
            this.Controls.Add(this.lblAddAge);
            this.Controls.Add(this.nudAddAge);
            this.Controls.Add(this.lblAddSpecies);
            this.Controls.Add(this.cbxAddSpecies);
            this.Controls.Add(this.lblAddName);
            this.Controls.Add(this.tbxAddName);
            this.Controls.Add(this.btnBack);
            this.Name = "frmAddAnimal";
            this.Text = "AddAnimal";
            ((System.ComponentModel.ISupportInitialize)(this.nudAddAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbxAddName;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.ComboBox cbxAddSpecies;
        private System.Windows.Forms.Label lblAddSpecies;
        private System.Windows.Forms.NumericUpDown nudAddAge;
        private System.Windows.Forms.Label lblAddAge;
        private System.Windows.Forms.Button btnAddAnimalEnter;
    }
}
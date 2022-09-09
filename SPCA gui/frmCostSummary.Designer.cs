
namespace SPCA_gui
{
    partial class frmCostSummary
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
            this.rtbCostOutput = new System.Windows.Forms.RichTextBox();
            this.btnConsumptionEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rtbCostOutput
            // 
            this.rtbCostOutput.Location = new System.Drawing.Point(12, 41);
            this.rtbCostOutput.Name = "rtbCostOutput";
            this.rtbCostOutput.Size = new System.Drawing.Size(366, 347);
            this.rtbCostOutput.TabIndex = 2;
            this.rtbCostOutput.Text = "";
            // 
            // btnConsumptionEnter
            // 
            this.btnConsumptionEnter.Location = new System.Drawing.Point(12, 394);
            this.btnConsumptionEnter.Name = "btnConsumptionEnter";
            this.btnConsumptionEnter.Size = new System.Drawing.Size(75, 23);
            this.btnConsumptionEnter.TabIndex = 3;
            this.btnConsumptionEnter.Text = "Enter";
            this.btnConsumptionEnter.UseVisualStyleBackColor = true;
            // 
            // frmCostSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 432);
            this.Controls.Add(this.btnConsumptionEnter);
            this.Controls.Add(this.rtbCostOutput);
            this.Controls.Add(this.btnBack);
            this.Name = "frmCostSummary";
            this.Text = "CostSummary";
            this.Load += new System.EventHandler(this.frmCostSummary_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox rtbCostOutput;
        private System.Windows.Forms.Button btnConsumptionEnter;
    }
}
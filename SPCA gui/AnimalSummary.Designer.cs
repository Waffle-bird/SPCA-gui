﻿
namespace SPCA_gui
{
    partial class frmAnimalSummary
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
            this.rtbSummaryOutput = new System.Windows.Forms.RichTextBox();
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
            // rtbSummaryOutput
            // 
            this.rtbSummaryOutput.Location = new System.Drawing.Point(12, 41);
            this.rtbSummaryOutput.Name = "rtbSummaryOutput";
            this.rtbSummaryOutput.Size = new System.Drawing.Size(361, 332);
            this.rtbSummaryOutput.TabIndex = 1;
            this.rtbSummaryOutput.Text = "";
            // 
            // frmAnimalSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 393);
            this.Controls.Add(this.rtbSummaryOutput);
            this.Controls.Add(this.btnBack);
            this.Name = "frmAnimalSummary";
            this.Text = "AnimalSummary";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox rtbSummaryOutput;
    }
}
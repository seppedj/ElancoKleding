namespace Kleding_presentation_testGrid
{
    partial class Form1
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
            this.gdvKleding01 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdvKleding01)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvKleding01
            // 
            this.gdvKleding01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvKleding01.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.gdvKleding01.Location = new System.Drawing.Point(12, 12);
            this.gdvKleding01.Name = "gdvKleding01";
            this.gdvKleding01.Size = new System.Drawing.Size(726, 322);
            this.gdvKleding01.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Afbeelding";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 261);
            this.Controls.Add(this.gdvKleding01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvKleding01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvKleding01;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


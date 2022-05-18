namespace ATM_Project
{
    partial class Tranzactii
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NrCont = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.accNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridViewTranzactii = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTranzactii)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 77);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(768, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(334, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tranzactii";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NrCont
            // 
            this.NrCont.AutoSize = true;
            this.NrCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NrCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.NrCont.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NrCont.Location = new System.Drawing.Point(285, 80);
            this.NrCont.Name = "NrCont";
            this.NrCont.Size = new System.Drawing.Size(141, 29);
            this.NrCont.TabIndex = 13;
            this.NrCont.Text = "Numar Cont";
            this.NrCont.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 12);
            this.panel2.TabIndex = 18;
            // 
            // accNum
            // 
            this.accNum.AutoSize = true;
            this.accNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNum.Location = new System.Drawing.Point(445, 83);
            this.accNum.Name = "accNum";
            this.accNum.Size = new System.Drawing.Size(70, 25);
            this.accNum.TabIndex = 19;
            this.accNum.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(381, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Back";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gridViewTranzactii
            // 
            this.gridViewTranzactii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTranzactii.Location = new System.Drawing.Point(112, 123);
            this.gridViewTranzactii.Name = "gridViewTranzactii";
            this.gridViewTranzactii.Size = new System.Drawing.Size(577, 292);
            this.gridViewTranzactii.TabIndex = 21;
            // 
            // Tranzactii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.gridViewTranzactii);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accNum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NrCont);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tranzactii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tranzactii";
            this.Load += new System.EventHandler(this.Tranzactii_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTranzactii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NrCont;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label accNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridViewTranzactii;
    }
}
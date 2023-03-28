namespace UykuSaatiTakip
{
    partial class FRM_AnaPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AnaPanel));
            this.lblGirisYap = new System.Windows.Forms.Label();
            this.lblKayitOl = new System.Windows.Forms.Label();
            this.pboxGirisYap = new System.Windows.Forms.PictureBox();
            this.pboxKayitOl = new System.Windows.Forms.PictureBox();
            this.pboxCikis = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGirisYap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKayitOl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGirisYap
            // 
            this.lblGirisYap.AutoSize = true;
            this.lblGirisYap.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGirisYap.ForeColor = System.Drawing.Color.Black;
            this.lblGirisYap.Location = new System.Drawing.Point(164, 434);
            this.lblGirisYap.Name = "lblGirisYap";
            this.lblGirisYap.Size = new System.Drawing.Size(111, 24);
            this.lblGirisYap.TabIndex = 2;
            this.lblGirisYap.Text = "GİRİŞ YAP";
            // 
            // lblKayitOl
            // 
            this.lblKayitOl.AutoSize = true;
            this.lblKayitOl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitOl.ForeColor = System.Drawing.Color.Black;
            this.lblKayitOl.Location = new System.Drawing.Point(581, 434);
            this.lblKayitOl.Name = "lblKayitOl";
            this.lblKayitOl.Size = new System.Drawing.Size(104, 24);
            this.lblKayitOl.TabIndex = 3;
            this.lblKayitOl.Text = "KAYIT OL";
            // 
            // pboxGirisYap
            // 
            this.pboxGirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxGirisYap.Image = ((System.Drawing.Image)(resources.GetObject("pboxGirisYap.Image")));
            this.pboxGirisYap.Location = new System.Drawing.Point(17, 140);
            this.pboxGirisYap.Name = "pboxGirisYap";
            this.pboxGirisYap.Size = new System.Drawing.Size(389, 289);
            this.pboxGirisYap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxGirisYap.TabIndex = 4;
            this.pboxGirisYap.TabStop = false;
            this.pboxGirisYap.Click += new System.EventHandler(this.pboxGirisYap_Click);
            // 
            // pboxKayitOl
            // 
            this.pboxKayitOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxKayitOl.Image = ((System.Drawing.Image)(resources.GetObject("pboxKayitOl.Image")));
            this.pboxKayitOl.Location = new System.Drawing.Point(437, 140);
            this.pboxKayitOl.Name = "pboxKayitOl";
            this.pboxKayitOl.Size = new System.Drawing.Size(359, 289);
            this.pboxKayitOl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxKayitOl.TabIndex = 5;
            this.pboxKayitOl.TabStop = false;
            this.pboxKayitOl.Click += new System.EventHandler(this.pboxKayitOl_Click);
            // 
            // pboxCikis
            // 
            this.pboxCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxCikis.Image = ((System.Drawing.Image)(resources.GetObject("pboxCikis.Image")));
            this.pboxCikis.Location = new System.Drawing.Point(788, 1);
            this.pboxCikis.Name = "pboxCikis";
            this.pboxCikis.Size = new System.Drawing.Size(35, 24);
            this.pboxCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxCikis.TabIndex = 6;
            this.pboxCikis.TabStop = false;
            this.pboxCikis.Click += new System.EventHandler(this.pboxCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 106);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sleep Well UP";
            // 
            // FRM_AnaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(824, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboxCikis);
            this.Controls.Add(this.pboxKayitOl);
            this.Controls.Add(this.pboxGirisYap);
            this.Controls.Add(this.lblKayitOl);
            this.Controls.Add(this.lblGirisYap);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_AnaPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pboxGirisYap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKayitOl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGirisYap;
        private System.Windows.Forms.Label lblKayitOl;
        private System.Windows.Forms.PictureBox pboxGirisYap;
        private System.Windows.Forms.PictureBox pboxKayitOl;
        private System.Windows.Forms.PictureBox pboxCikis;
        private System.Windows.Forms.Label label1;
    }
}


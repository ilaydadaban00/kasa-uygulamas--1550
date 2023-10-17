namespace odevv15_uygulama_1550
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.gbOdemeSekli = new System.Windows.Forms.GroupBox();
            this.rbTekCekim = new System.Windows.Forms.RadioButton();
            this.rb1Taksitli = new System.Windows.Forms.RadioButton();
            this.rb2Taksitli = new System.Windows.Forms.RadioButton();
            this.rb3Taksitli = new System.Windows.Forms.RadioButton();
            this.rb4Taksitli = new System.Windows.Forms.RadioButton();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.gbOdemeSekli.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "toplam tutar:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(169, 36);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 20);
            this.txtTutar.TabIndex = 2;
            // 
            // gbOdemeSekli
            // 
            this.gbOdemeSekli.Controls.Add(this.rb4Taksitli);
            this.gbOdemeSekli.Controls.Add(this.rb3Taksitli);
            this.gbOdemeSekli.Controls.Add(this.rb2Taksitli);
            this.gbOdemeSekli.Controls.Add(this.rb1Taksitli);
            this.gbOdemeSekli.Controls.Add(this.rbTekCekim);
            this.gbOdemeSekli.Location = new System.Drawing.Point(26, 74);
            this.gbOdemeSekli.Name = "gbOdemeSekli";
            this.gbOdemeSekli.Size = new System.Drawing.Size(200, 172);
            this.gbOdemeSekli.TabIndex = 4;
            this.gbOdemeSekli.TabStop = false;
            this.gbOdemeSekli.Text = "ödeme şekli";
            // 
            // rbTekCekim
            // 
            this.rbTekCekim.AutoSize = true;
            this.rbTekCekim.Location = new System.Drawing.Point(7, 20);
            this.rbTekCekim.Name = "rbTekCekim";
            this.rbTekCekim.Size = new System.Drawing.Size(71, 17);
            this.rbTekCekim.TabIndex = 0;
            this.rbTekCekim.TabStop = true;
            this.rbTekCekim.Text = "tek çekim";
            this.rbTekCekim.UseVisualStyleBackColor = true;
            // 
            // rb1Taksitli
            // 
            this.rb1Taksitli.AutoSize = true;
            this.rb1Taksitli.Location = new System.Drawing.Point(7, 43);
            this.rb1Taksitli.Name = "rb1Taksitli";
            this.rb1Taksitli.Size = new System.Drawing.Size(105, 17);
            this.rb1Taksitli.TabIndex = 1;
            this.rb1Taksitli.TabStop = true;
            this.rb1Taksitli.Text = "2 taksitli(%5 fiyat)";
            this.rb1Taksitli.UseVisualStyleBackColor = true;
            this.rb1Taksitli.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb2Taksitli
            // 
            this.rb2Taksitli.AutoSize = true;
            this.rb2Taksitli.Location = new System.Drawing.Point(7, 66);
            this.rb2Taksitli.Name = "rb2Taksitli";
            this.rb2Taksitli.Size = new System.Drawing.Size(105, 17);
            this.rb2Taksitli.TabIndex = 2;
            this.rb2Taksitli.TabStop = true;
            this.rb2Taksitli.Text = "3 taksitli (%5fiyat)";
            this.rb2Taksitli.UseVisualStyleBackColor = true;
            // 
            // rb3Taksitli
            // 
            this.rb3Taksitli.AutoSize = true;
            this.rb3Taksitli.Location = new System.Drawing.Point(6, 89);
            this.rb3Taksitli.Name = "rb3Taksitli";
            this.rb3Taksitli.Size = new System.Drawing.Size(111, 17);
            this.rb3Taksitli.TabIndex = 3;
            this.rb3Taksitli.TabStop = true;
            this.rb3Taksitli.Text = "4 taksitli(%10 fiyat)";
            this.rb3Taksitli.UseVisualStyleBackColor = true;
            // 
            // rb4Taksitli
            // 
            this.rb4Taksitli.AutoSize = true;
            this.rb4Taksitli.Location = new System.Drawing.Point(6, 112);
            this.rb4Taksitli.Name = "rb4Taksitli";
            this.rb4Taksitli.Size = new System.Drawing.Size(111, 17);
            this.rb4Taksitli.TabIndex = 4;
            this.rb4Taksitli.TabStop = true;
            this.rb4Taksitli.Text = "5 taksitli(%10 fiyat)";
            this.rb4Taksitli.UseVisualStyleBackColor = true;
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Location = new System.Drawing.Point(41, 282);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(173, 80);
            this.btnOdemeYap.TabIndex = 5;
            this.btnOdemeYap.Text = "ödeme yap";
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.gbOdemeSekli);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbOdemeSekli.ResumeLayout(false);
            this.gbOdemeSekli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.GroupBox gbOdemeSekli;
        private System.Windows.Forms.RadioButton rb2Taksitli;
        private System.Windows.Forms.RadioButton rb1Taksitli;
        private System.Windows.Forms.RadioButton rbTekCekim;
        private System.Windows.Forms.RadioButton rb4Taksitli;
        private System.Windows.Forms.RadioButton rb3Taksitli;
        private System.Windows.Forms.Button btnOdemeYap;
    }
}


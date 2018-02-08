namespace WFA_BauWissenProjectHastaneUI
{
    partial class frmGirisYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGirisYap));
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.pBoxReload = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.lblGuvenlikKodu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuvenlikKodu = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxReload)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxLogo
            // 
            this.pboxLogo.Image = global::WFA_BauWissenProjectHastaneUI.Properties.Resources.Logo4;
            resources.ApplyResources(this.pboxLogo, "pboxLogo");
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.TabStop = false;
            // 
            // pBoxReload
            // 
            this.pBoxReload.Image = global::WFA_BauWissenProjectHastaneUI.Properties.Resources.gmenu_reload;
            resources.ApplyResources(this.pBoxReload, "pBoxReload");
            this.pBoxReload.Name = "pBoxReload";
            this.pBoxReload.TabStop = false;
            this.pBoxReload.Click += new System.EventHandler(this.pBoxReload_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnGirisYap
            // 
            resources.ApplyResources(this.btnGirisYap, "btnGirisYap");
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // lblGuvenlikKodu
            // 
            resources.ApplyResources(this.lblGuvenlikKodu, "lblGuvenlikKodu");
            this.lblGuvenlikKodu.Name = "lblGuvenlikKodu";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtGuvenlikKodu
            // 
            resources.ApplyResources(this.txtGuvenlikKodu, "txtGuvenlikKodu");
            this.txtGuvenlikKodu.Name = "txtGuvenlikKodu";
            this.txtGuvenlikKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuvenlikKodu_KeyPress);
            // 
            // txtKullaniciAdi
            // 
            resources.ApplyResources(this.txtKullaniciAdi, "txtKullaniciAdi");
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtSifre
            // 
            resources.ApplyResources(this.txtSifre, "txtSifre");
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // frmGirisYap
            // 
            this.AcceptButton = this.btnGirisYap;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.pboxLogo);
            this.Controls.Add(this.pBoxReload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.lblGuvenlikKodu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGuvenlikKodu);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGirisYap";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form_Giris_Yap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxReload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.PictureBox pBoxReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label lblGuvenlikKodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuvenlikKodu;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifre;
    }
}
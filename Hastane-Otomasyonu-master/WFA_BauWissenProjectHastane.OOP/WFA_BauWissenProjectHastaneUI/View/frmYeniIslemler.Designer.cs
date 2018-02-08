namespace WFA_BauWissenProjectHastaneUI.View
{
    partial class frmYeniIslemler
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
            WFA_BauWissenProjectHastane.OOP.Model.Kisi kisi1 = new WFA_BauWissenProjectHastane.OOP.Model.Kisi();
            this.ucIslem1 = new WFA_BauWissenProjectHastaneUI.ucIslem();
            this.SuspendLayout();
            // 
            // ucIslem1
            // 
            this.ucIslem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucIslem1.Location = new System.Drawing.Point(0, 0);
            this.ucIslem1.Margin = new System.Windows.Forms.Padding(5);
            this.ucIslem1.Name = "ucIslem1";
            kisi1.Ad = "";
            kisi1.Cinsiyet = WFA_BauWissenProjectHastane.OOP.Model.Enums.EnumsHastane.EnumCinsiyet.Erkek;
            kisi1.DogumTarihi = new System.DateTime(((long)(0)));
            kisi1.Email = "";
            kisi1.ID = new System.Guid("95f6f3b8-3d4b-403e-a32c-38ad42940d26");
            kisi1.Soyad = "";
            kisi1.TC = "";
            kisi1.TelefonNumarasi = "";
            this.ucIslem1.secilenKisi = kisi1;
            this.ucIslem1.Size = new System.Drawing.Size(1307, 862);
            this.ucIslem1.TabIndex = 0;
            // 
            // frmYeniIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 862);
            this.Controls.Add(this.ucIslem1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYeniIslemler";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmYeniIslemler";
            this.ResumeLayout(false);

        }

        #endregion

        private ucIslem ucIslem1;
    }
}
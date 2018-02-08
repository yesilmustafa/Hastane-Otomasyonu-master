namespace WFA_BauWissenProjectHastaneUI
{
    partial class ucRandevu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHastaTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHastaGetir = new System.Windows.Forms.Button();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.lblBolum = new System.Windows.Forms.Label();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.lblHastaAdi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tlpRandevu = new System.Windows.Forms.TableLayoutPanel();
            this.grp1.SuspendLayout();
            this.grp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHastaTC
            // 
            this.txtHastaTC.Location = new System.Drawing.Point(29, 46);
            this.txtHastaTC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHastaTC.Name = "txtHastaTC";
            this.txtHastaTC.Size = new System.Drawing.Size(333, 22);
            this.txtHastaTC.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen Hasta TC Kimlik Numarası Giriniz:";
            // 
            // btnHastaGetir
            // 
            this.btnHastaGetir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaGetir.ForeColor = System.Drawing.Color.Black;
            this.btnHastaGetir.Location = new System.Drawing.Point(29, 76);
            this.btnHastaGetir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHastaGetir.Name = "btnHastaGetir";
            this.btnHastaGetir.Size = new System.Drawing.Size(333, 37);
            this.btnHastaGetir.TabIndex = 2;
            this.btnHastaGetir.Text = "Tamam";
            this.btnHastaGetir.UseVisualStyleBackColor = true;
            this.btnHastaGetir.Click += new System.EventHandler(this.btnHastaGetir_Click);
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.label1);
            this.grp1.Controls.Add(this.btnHastaGetir);
            this.grp1.Controls.Add(this.txtHastaTC);
            this.grp1.Location = new System.Drawing.Point(0, 0);
            this.grp1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp1.Name = "grp1";
            this.grp1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp1.Size = new System.Drawing.Size(387, 126);
            this.grp1.TabIndex = 3;
            this.grp1.TabStop = false;
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.label3);
            this.grp2.Controls.Add(this.cmbDoktor);
            this.grp2.Controls.Add(this.lblBolum);
            this.grp2.Controls.Add(this.cmbBolum);
            this.grp2.Controls.Add(this.lblHastaAdi);
            this.grp2.Controls.Add(this.label2);
            this.grp2.Location = new System.Drawing.Point(4, 134);
            this.grp2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp2.Name = "grp2";
            this.grp2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp2.Size = new System.Drawing.Size(383, 210);
            this.grp2.TabIndex = 4;
            this.grp2.TabStop = false;
            this.grp2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doktor Adı:";
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(133, 164);
            this.cmbDoktor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(231, 31);
            this.cmbDoktor.TabIndex = 4;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktorAdi_SelectedIndexChanged);
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolum.ForeColor = System.Drawing.Color.Black;
            this.lblBolum.Location = new System.Drawing.Point(13, 121);
            this.lblBolum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(67, 23);
            this.lblBolum.TabIndex = 3;
            this.lblBolum.Text = "Bölüm:";
            // 
            // cmbBolum
            // 
            this.cmbBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBolum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(133, 118);
            this.cmbBolum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(231, 31);
            this.cmbBolum.TabIndex = 2;
            this.cmbBolum.SelectedIndexChanged += new System.EventHandler(this.cmbBolum_SelectedIndexChanged);
            // 
            // lblHastaAdi
            // 
            this.lblHastaAdi.AutoSize = true;
            this.lblHastaAdi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaAdi.ForeColor = System.Drawing.Color.Black;
            this.lblHastaAdi.Location = new System.Drawing.Point(115, 62);
            this.lblHastaAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHastaAdi.Name = "lblHastaAdi";
            this.lblHastaAdi.Size = new System.Drawing.Size(0, 23);
            this.lblHastaAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(131, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Randevu Ekle";
            // 
            // tlpRandevu
            // 
            this.tlpRandevu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpRandevu.ColumnCount = 6;
            this.tlpRandevu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpRandevu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpRandevu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpRandevu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpRandevu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpRandevu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpRandevu.Location = new System.Drawing.Point(395, 2);
            this.tlpRandevu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpRandevu.Name = "tlpRandevu";
            this.tlpRandevu.RowCount = 11;
            this.tlpRandevu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlpRandevu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlpRandevu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlpRandevu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlpRandevu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlpRandevu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlpRandevu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlpRandevu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlpRandevu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlpRandevu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlpRandevu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlpRandevu.Size = new System.Drawing.Size(603, 457);
            this.tlpRandevu.TabIndex = 5;
            // 
            // ucRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpRandevu);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.grp1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucRandevu";
            this.Size = new System.Drawing.Size(999, 465);
            this.Load += new System.EventHandler(this.Randevu_Ekle_Us_Load);
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.grp2.ResumeLayout(false);
            this.grp2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtHastaTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHastaGetir;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHastaAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.Label lblBolum;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.TableLayoutPanel tlpRandevu;
    }
}

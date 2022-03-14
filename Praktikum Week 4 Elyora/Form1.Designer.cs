namespace Praktikum_Week_4_Elyora
{
    partial class FormUtama
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNama = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelTelp = new System.Windows.Forms.Label();
            this.txtBoxNamah = new System.Windows.Forms.TextBox();
            this.txtBoxAlamath = new System.Windows.Forms.TextBox();
            this.txtBoxTelph = new System.Windows.Forms.TextBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonLihat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(58, 80);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(68, 25);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "Nama: ";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(58, 136);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(72, 25);
            this.labelAlamat.TabIndex = 1;
            this.labelAlamat.Text = "Alamat:";
            // 
            // labelTelp
            // 
            this.labelTelp.AutoSize = true;
            this.labelTelp.Location = new System.Drawing.Point(58, 190);
            this.labelTelp.Name = "labelTelp";
            this.labelTelp.Size = new System.Drawing.Size(47, 25);
            this.labelTelp.TabIndex = 2;
            this.labelTelp.Text = "Telp:";
            // 
            // txtBoxNamah
            // 
            this.txtBoxNamah.Location = new System.Drawing.Point(160, 80);
            this.txtBoxNamah.Name = "txtBoxNamah";
            this.txtBoxNamah.Size = new System.Drawing.Size(448, 31);
            this.txtBoxNamah.TabIndex = 3;
            // 
            // txtBoxAlamath
            // 
            this.txtBoxAlamath.Location = new System.Drawing.Point(160, 136);
            this.txtBoxAlamath.Name = "txtBoxAlamath";
            this.txtBoxAlamath.Size = new System.Drawing.Size(539, 31);
            this.txtBoxAlamath.TabIndex = 4;
            // 
            // txtBoxTelph
            // 
            this.txtBoxTelph.Location = new System.Drawing.Point(160, 190);
            this.txtBoxTelph.Name = "txtBoxTelph";
            this.txtBoxTelph.Size = new System.Drawing.Size(448, 31);
            this.txtBoxTelph.TabIndex = 5;
            this.txtBoxTelph.TextChanged += new System.EventHandler(this.txtBoxTelph_TextChanged);
            this.txtBoxTelph.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTelph_KeyPress);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(58, 298);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(112, 34);
            this.buttonSimpan.TabIndex = 6;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonLihat
            // 
            this.buttonLihat.Location = new System.Drawing.Point(232, 298);
            this.buttonLihat.Name = "buttonLihat";
            this.buttonLihat.Size = new System.Drawing.Size(112, 34);
            this.buttonLihat.TabIndex = 7;
            this.buttonLihat.Text = "Lihat Data";
            this.buttonLihat.UseVisualStyleBackColor = true;
            this.buttonLihat.Click += new System.EventHandler(this.buttonLihat_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLihat);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.txtBoxTelph);
            this.Controls.Add(this.txtBoxAlamath);
            this.Controls.Add(this.txtBoxNamah);
            this.Controls.Add(this.labelTelp);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.labelNama);
            this.Name = "FormUtama";
            this.Text = "Form Penambahan Data";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNama;
        private Label labelAlamat;
        private Label labelTelp;
        private TextBox txtBoxNamah;
        private TextBox txtBoxAlamath;
        private TextBox txtBoxTelph;
        private Button buttonSimpan;
        private Button buttonLihat;
    }
}
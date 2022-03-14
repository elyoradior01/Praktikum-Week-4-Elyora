namespace Praktikum_Week_4_Elyora
{
    partial class FormKedua
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
            this.labelNamaku = new System.Windows.Forms.Label();
            this.labelAlamatku = new System.Windows.Forms.Label();
            this.labelTelpku = new System.Windows.Forms.Label();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.txtBoxNamaku = new System.Windows.Forms.TextBox();
            this.txtBoxAlamatku = new System.Windows.Forms.TextBox();
            this.txtBoxTelpku = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNamaku
            // 
            this.labelNamaku.AutoSize = true;
            this.labelNamaku.Location = new System.Drawing.Point(47, 76);
            this.labelNamaku.Name = "labelNamaku";
            this.labelNamaku.Size = new System.Drawing.Size(63, 25);
            this.labelNamaku.TabIndex = 0;
            this.labelNamaku.Text = "Nama:";
            // 
            // labelAlamatku
            // 
            this.labelAlamatku.AutoSize = true;
            this.labelAlamatku.Location = new System.Drawing.Point(47, 132);
            this.labelAlamatku.Name = "labelAlamatku";
            this.labelAlamatku.Size = new System.Drawing.Size(72, 25);
            this.labelAlamatku.TabIndex = 1;
            this.labelAlamatku.Text = "Alamat:";
            // 
            // labelTelpku
            // 
            this.labelTelpku.AutoSize = true;
            this.labelTelpku.Location = new System.Drawing.Point(47, 188);
            this.labelTelpku.Name = "labelTelpku";
            this.labelTelpku.Size = new System.Drawing.Size(47, 25);
            this.labelTelpku.TabIndex = 2;
            this.labelTelpku.Text = "Telp:";
            // 
            // buttonKembali
            // 
            this.buttonKembali.Location = new System.Drawing.Point(47, 301);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(112, 34);
            this.buttonKembali.TabIndex = 3;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(218, 301);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(112, 34);
            this.buttonPrev.TabIndex = 4;
            this.buttonPrev.Text = "Prev Data";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(388, 301);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(112, 34);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "Next Data";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // txtBoxNamaku
            // 
            this.txtBoxNamaku.Location = new System.Drawing.Point(158, 76);
            this.txtBoxNamaku.Name = "txtBoxNamaku";
            this.txtBoxNamaku.Size = new System.Drawing.Size(448, 31);
            this.txtBoxNamaku.TabIndex = 6;
            this.txtBoxNamaku.TextChanged += new System.EventHandler(this.txtBoxNamaku_TextChanged);
            // 
            // txtBoxAlamatku
            // 
            this.txtBoxAlamatku.Location = new System.Drawing.Point(158, 132);
            this.txtBoxAlamatku.Name = "txtBoxAlamatku";
            this.txtBoxAlamatku.Size = new System.Drawing.Size(497, 31);
            this.txtBoxAlamatku.TabIndex = 7;
            // 
            // txtBoxTelpku
            // 
            this.txtBoxTelpku.Location = new System.Drawing.Point(158, 188);
            this.txtBoxTelpku.Name = "txtBoxTelpku";
            this.txtBoxTelpku.Size = new System.Drawing.Size(448, 31);
            this.txtBoxTelpku.TabIndex = 8;
            // 
            // FormKedua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxTelpku);
            this.Controls.Add(this.txtBoxAlamatku);
            this.Controls.Add(this.txtBoxNamaku);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.labelTelpku);
            this.Controls.Add(this.labelAlamatku);
            this.Controls.Add(this.labelNamaku);
            this.Name = "FormKedua";
            this.Text = "Form Tampilan Data";
            this.Load += new System.EventHandler(this.FormKedua_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNamaku;
        private Label labelAlamatku;
        private Label labelTelpku;
        private Button buttonKembali;
        private Button buttonPrev;
        private Button buttonNext;
        private TextBox txtBoxNamaku;
        private TextBox txtBoxAlamatku;
        private TextBox txtBoxTelpku;
    }
}
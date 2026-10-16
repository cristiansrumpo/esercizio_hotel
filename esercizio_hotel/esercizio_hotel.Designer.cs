namespace esercizio_hotel
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.cmb_n1 = new System.Windows.Forms.ComboBox();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.cmb_n2 = new System.Windows.Forms.ComboBox();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.pictur1 = new System.Windows.Forms.PictureBox();
            this.lbl_n5 = new System.Windows.Forms.Label();
            this.chk_n1 = new System.Windows.Forms.CheckBox();
            this.btn_n1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictur1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_n1.Location = new System.Drawing.Point(12, 9);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(188, 26);
            this.lbl_n1.TabIndex = 3;
            this.lbl_n1.Text = "HOTEL THE PLAZA";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_n2.Location = new System.Drawing.Point(12, 35);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(436, 594);
            this.lbl_n2.TabIndex = 5;
            this.lbl_n2.Text = resources.GetString("lbl_n2.Text");
            // 
            // cmb_n1
            // 
            this.cmb_n1.FormattingEnabled = true;
            this.cmb_n1.Items.AddRange(new object[] {
            "BASE",
            "MEDIA",
            "ALTA"});
            this.cmb_n1.Location = new System.Drawing.Point(12, 181);
            this.cmb_n1.Name = "cmb_n1";
            this.cmb_n1.Size = new System.Drawing.Size(115, 21);
            this.cmb_n1.TabIndex = 6;
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.ForeColor = System.Drawing.Color.Coral;
            this.lbl_n3.Location = new System.Drawing.Point(14, 165);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(120, 13);
            this.lbl_n3.TabIndex = 7;
            this.lbl_n3.Text = "inserisci il tipo di camera";
            // 
            // cmb_n2
            // 
            this.cmb_n2.FormattingEnabled = true;
            this.cmb_n2.Items.AddRange(new object[] {
            "Bassa stagione (BS)",
            "Media stagione (MS)",
            "Alta stagione (AS)"});
            this.cmb_n2.Location = new System.Drawing.Point(12, 234);
            this.cmb_n2.Name = "cmb_n2";
            this.cmb_n2.Size = new System.Drawing.Size(121, 21);
            this.cmb_n2.TabIndex = 8;
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.ForeColor = System.Drawing.Color.Coral;
            this.lbl_n4.Location = new System.Drawing.Point(14, 218);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(98, 13);
            this.lbl_n4.TabIndex = 9;
            this.lbl_n4.Text = "inserisci la stagione";
            // 
            // pictur1
            // 
            this.pictur1.Image = global::esercizio_hotel.Properties.Resources.THE_PLAZA;
            this.pictur1.Location = new System.Drawing.Point(455, 40);
            this.pictur1.Name = "pictur1";
            this.pictur1.Size = new System.Drawing.Size(318, 326);
            this.pictur1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictur1.TabIndex = 10;
            this.pictur1.TabStop = false;
            // 
            // lbl_n5
            // 
            this.lbl_n5.AutoSize = true;
            this.lbl_n5.ForeColor = System.Drawing.Color.Coral;
            this.lbl_n5.Location = new System.Drawing.Point(12, 271);
            this.lbl_n5.Name = "lbl_n5";
            this.lbl_n5.Size = new System.Drawing.Size(143, 13);
            this.lbl_n5.TabIndex = 11;
            this.lbl_n5.Text = "vuoi usufruire del parcheggio";
            // 
            // chk_n1
            // 
            this.chk_n1.AutoSize = true;
            this.chk_n1.ForeColor = System.Drawing.Color.Coral;
            this.chk_n1.Location = new System.Drawing.Point(12, 288);
            this.chk_n1.Name = "chk_n1";
            this.chk_n1.Size = new System.Drawing.Size(97, 17);
            this.chk_n1.TabIndex = 12;
            this.chk_n1.Text = "PARCHEGGIO";
            this.chk_n1.UseVisualStyleBackColor = true;
            // 
            // btn_n1
            // 
            this.btn_n1.BackColor = System.Drawing.Color.Silver;
            this.btn_n1.ForeColor = System.Drawing.Color.Coral;
            this.btn_n1.Location = new System.Drawing.Point(12, 325);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(75, 23);
            this.btn_n1.TabIndex = 13;
            this.btn_n1.Text = "PRENOTA";
            this.btn_n1.UseVisualStyleBackColor = false;
            this.btn_n1.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_n1);
            this.Controls.Add(this.chk_n1);
            this.Controls.Add(this.lbl_n5);
            this.Controls.Add(this.pictur1);
            this.Controls.Add(this.lbl_n4);
            this.Controls.Add(this.cmb_n2);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.cmb_n1);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictur1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.ComboBox cmb_n1;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.ComboBox cmb_n2;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.PictureBox pictur1;
        private System.Windows.Forms.Label lbl_n5;
        private System.Windows.Forms.CheckBox chk_n1;
        private System.Windows.Forms.Button btn_n1;
    }
}


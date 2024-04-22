namespace ScrapingVoli
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCartina = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnMeteo = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnIndicazioni = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panelPartenza = new System.Windows.Forms.Panel();
            this.dtRitorno = new System.Windows.Forms.DateTimePicker();
            this.dtPartenza = new System.Windows.Forms.DateTimePicker();
            this.rbSpecifica = new System.Windows.Forms.RadioButton();
            this.rbIntervallo = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnVolo = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.cbBudget = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtPartenza = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panelPartenza.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1724, 631);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnCartina);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1716, 602);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Inserire una città per visualizzare i dati desiderati:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 22);
            this.textBox1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(377, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(719, 439);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnCartina
            // 
            this.btnCartina.Location = new System.Drawing.Point(16, 100);
            this.btnCartina.Name = "btnCartina";
            this.btnCartina.Size = new System.Drawing.Size(340, 106);
            this.btnCartina.TabIndex = 6;
            this.btnCartina.Text = "CARTINA";
            this.btnCartina.UseVisualStyleBackColor = true;
            this.btnCartina.Click += new System.EventHandler(this.btnCartina_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnMeteo);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1716, 602);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnMeteo
            // 
            this.btnMeteo.Location = new System.Drawing.Point(18, 19);
            this.btnMeteo.Name = "btnMeteo";
            this.btnMeteo.Size = new System.Drawing.Size(382, 106);
            this.btnMeteo.TabIndex = 3;
            this.btnMeteo.Text = "METEO";
            this.btnMeteo.UseVisualStyleBackColor = true;
            this.btnMeteo.Click += new System.EventHandler(this.btnMeteo_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(424, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1271, 563);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.btnIndicazioni);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1716, 602);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(382, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1315, 564);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // btnIndicazioni
            // 
            this.btnIndicazioni.Location = new System.Drawing.Point(16, 18);
            this.btnIndicazioni.Name = "btnIndicazioni";
            this.btnIndicazioni.Size = new System.Drawing.Size(348, 106);
            this.btnIndicazioni.TabIndex = 8;
            this.btnIndicazioni.Text = "INDICAZIONI";
            this.btnIndicazioni.UseVisualStyleBackColor = true;
            this.btnIndicazioni.Click += new System.EventHandler(this.btnIndicazioni_Click_1);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panelPartenza);
            this.tabPage4.Controls.Add(this.listView1);
            this.tabPage4.Controls.Add(this.btnVolo);
            this.tabPage4.Controls.Add(this.txtLink);
            this.tabPage4.Controls.Add(this.cbBudget);
            this.tabPage4.Controls.Add(this.cbCategoria);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.txtPartenza);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1716, 602);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panelPartenza
            // 
            this.panelPartenza.Controls.Add(this.dtRitorno);
            this.panelPartenza.Controls.Add(this.dtPartenza);
            this.panelPartenza.Controls.Add(this.rbSpecifica);
            this.panelPartenza.Controls.Add(this.rbIntervallo);
            this.panelPartenza.Location = new System.Drawing.Point(420, 96);
            this.panelPartenza.Name = "panelPartenza";
            this.panelPartenza.Size = new System.Drawing.Size(302, 130);
            this.panelPartenza.TabIndex = 21;
            // 
            // dtRitorno
            // 
            this.dtRitorno.Location = new System.Drawing.Point(132, 46);
            this.dtRitorno.Name = "dtRitorno";
            this.dtRitorno.Size = new System.Drawing.Size(153, 22);
            this.dtRitorno.TabIndex = 16;
            this.dtRitorno.ValueChanged += new System.EventHandler(this.dtRitorno_ValueChanged);
            // 
            // dtPartenza
            // 
            this.dtPartenza.Location = new System.Drawing.Point(133, 16);
            this.dtPartenza.Name = "dtPartenza";
            this.dtPartenza.Size = new System.Drawing.Size(152, 22);
            this.dtPartenza.TabIndex = 15;
            this.dtPartenza.ValueChanged += new System.EventHandler(this.dtPartenza_ValueChanged);
            // 
            // rbSpecifica
            // 
            this.rbSpecifica.AutoSize = true;
            this.rbSpecifica.Location = new System.Drawing.Point(13, 16);
            this.rbSpecifica.Name = "rbSpecifica";
            this.rbSpecifica.Size = new System.Drawing.Size(114, 20);
            this.rbSpecifica.TabIndex = 13;
            this.rbSpecifica.TabStop = true;
            this.rbSpecifica.Text = "Data specifica";
            this.rbSpecifica.UseVisualStyleBackColor = true;
            this.rbSpecifica.CheckedChanged += new System.EventHandler(this.rbSpecifica_CheckedChanged);
            // 
            // rbIntervallo
            // 
            this.rbIntervallo.AutoSize = true;
            this.rbIntervallo.Location = new System.Drawing.Point(13, 46);
            this.rbIntervallo.Name = "rbIntervallo";
            this.rbIntervallo.Size = new System.Drawing.Size(112, 20);
            this.rbIntervallo.TabIndex = 14;
            this.rbIntervallo.TabStop = true;
            this.rbIntervallo.Text = "Intervallo date";
            this.rbIntervallo.UseVisualStyleBackColor = true;
            this.rbIntervallo.CheckedChanged += new System.EventHandler(this.rbIntervallo_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(935, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(313, 219);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnVolo
            // 
            this.btnVolo.Location = new System.Drawing.Point(20, 273);
            this.btnVolo.Name = "btnVolo";
            this.btnVolo.Size = new System.Drawing.Size(261, 98);
            this.btnVolo.TabIndex = 19;
            this.btnVolo.Text = "Trova il mio volo";
            this.btnVolo.UseVisualStyleBackColor = true;
            this.btnVolo.Click += new System.EventHandler(this.btnVolo_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(20, 230);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(360, 22);
            this.txtLink.TabIndex = 18;
            // 
            // cbBudget
            // 
            this.cbBudget.FormattingEnabled = true;
            this.cbBudget.Items.AddRange(new object[] {
            "20",
            "50",
            "60",
            "80",
            "100",
            "150"});
            this.cbBudget.Location = new System.Drawing.Point(282, 52);
            this.cbBudget.Name = "cbBudget";
            this.cbBudget.Size = new System.Drawing.Size(98, 24);
            this.cbBudget.TabIndex = 17;
            this.cbBudget.SelectedIndexChanged += new System.EventHandler(this.cbBudget_SelectedIndexChanged_1);
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "CITTA\'",
            "FAMIGLIA",
            "GOLF",
            "VITA NOTTURNA",
            "ALL\'APERTO",
            "MARE"});
            this.cbCategoria.Location = new System.Drawing.Point(759, 52);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(98, 24);
            this.cbCategoria.TabIndex = 11;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(420, 52);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(98, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(152, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(98, 22);
            this.textBox3.TabIndex = 9;
            // 
            // txtPartenza
            // 
            this.txtPartenza.Location = new System.Drawing.Point(20, 52);
            this.txtPartenza.Name = "txtPartenza";
            this.txtPartenza.Size = new System.Drawing.Size(98, 22);
            this.txtPartenza.TabIndex = 8;
            this.txtPartenza.Click += new System.EventHandler(this.txtPartenza_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Parti:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Budget:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(756, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Categoria Viaggio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Da:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1771, 679);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panelPartenza.ResumeLayout(false);
            this.panelPartenza.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCartina;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnIndicazioni;
        private System.Windows.Forms.Button btnMeteo;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbBudget;
        private System.Windows.Forms.RadioButton rbIntervallo;
        private System.Windows.Forms.RadioButton rbSpecifica;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtPartenza;
        private System.Windows.Forms.Button btnVolo;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panelPartenza;
        private System.Windows.Forms.DateTimePicker dtRitorno;
        private System.Windows.Forms.DateTimePicker dtPartenza;
    }
}


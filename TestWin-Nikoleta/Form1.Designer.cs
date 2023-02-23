namespace TestWin_Nikoleta
{
    partial class cmbsferaNaRabota
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
            this.lbIme = new System.Windows.Forms.Label();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.lbFamiliq = new System.Windows.Forms.Label();
            this.grbPol = new System.Windows.Forms.GroupBox();
            this.rbmen = new System.Windows.Forms.RadioButton();
            this.rbwoman = new System.Windows.Forms.RadioButton();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.lbEGN = new System.Windows.Forms.Label();
            this.cmbSfera = new System.Windows.Forms.ComboBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grbPol.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.BackColor = System.Drawing.Color.DarkGray;
            this.lbIme.Location = new System.Drawing.Point(12, 21);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(34, 16);
            this.lbIme.TabIndex = 0;
            this.lbIme.Text = "Име";
            // 
            // lbPrezime
            // 
            this.lbPrezime.AutoSize = true;
            this.lbPrezime.BackColor = System.Drawing.Color.DarkGray;
            this.lbPrezime.Location = new System.Drawing.Point(12, 81);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(66, 16);
            this.lbPrezime.TabIndex = 1;
            this.lbPrezime.Text = "Презиме";
            // 
            // lbFamiliq
            // 
            this.lbFamiliq.AutoSize = true;
            this.lbFamiliq.BackColor = System.Drawing.Color.DarkGray;
            this.lbFamiliq.Location = new System.Drawing.Point(12, 154);
            this.lbFamiliq.Name = "lbFamiliq";
            this.lbFamiliq.Size = new System.Drawing.Size(66, 16);
            this.lbFamiliq.TabIndex = 2;
            this.lbFamiliq.Text = "Фамилия";
            // 
            // grbPol
            // 
            this.grbPol.BackColor = System.Drawing.Color.DarkGray;
            this.grbPol.Controls.Add(this.rbwoman);
            this.grbPol.Controls.Add(this.rbmen);
            this.grbPol.Location = new System.Drawing.Point(674, 225);
            this.grbPol.Name = "grbPol";
            this.grbPol.Size = new System.Drawing.Size(151, 141);
            this.grbPol.TabIndex = 3;
            this.grbPol.TabStop = false;
            this.grbPol.Text = "Пол";
            // 
            // rbmen
            // 
            this.rbmen.AutoSize = true;
            this.rbmen.Location = new System.Drawing.Point(17, 49);
            this.rbmen.Name = "rbmen";
            this.rbmen.Size = new System.Drawing.Size(57, 20);
            this.rbmen.TabIndex = 0;
            this.rbmen.TabStop = true;
            this.rbmen.Text = "Мъж";
            this.rbmen.UseVisualStyleBackColor = true;
            // 
            // rbwoman
            // 
            this.rbwoman.AutoSize = true;
            this.rbwoman.Location = new System.Drawing.Point(17, 102);
            this.rbwoman.Name = "rbwoman";
            this.rbwoman.Size = new System.Drawing.Size(65, 20);
            this.rbwoman.TabIndex = 1;
            this.rbwoman.TabStop = true;
            this.rbwoman.Text = "Жена";
            this.rbwoman.UseVisualStyleBackColor = true;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(12, 40);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(129, 22);
            this.tb1.TabIndex = 5;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(15, 118);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(128, 22);
            this.tb2.TabIndex = 6;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(15, 190);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(128, 22);
            this.tb3.TabIndex = 7;
            // 
            // lbEGN
            // 
            this.lbEGN.AutoSize = true;
            this.lbEGN.BackColor = System.Drawing.Color.DarkGray;
            this.lbEGN.Location = new System.Drawing.Point(21, 234);
            this.lbEGN.Name = "lbEGN";
            this.lbEGN.Size = new System.Drawing.Size(35, 16);
            this.lbEGN.TabIndex = 8;
            this.lbEGN.Text = "ЕГН";
            // 
            // cmbSfera
            // 
            this.cmbSfera.FormattingEnabled = true;
            this.cmbSfera.Items.AddRange(new object[] {
            "Учащ",
            "Държавен служител",
            "Работник в частна фирма",
            "Безработен"});
            this.cmbSfera.Location = new System.Drawing.Point(303, 40);
            this.cmbSfera.Name = "cmbSfera";
            this.cmbSfera.Size = new System.Drawing.Size(222, 24);
            this.cmbSfera.TabIndex = 9;
            this.cmbSfera.Text = "Сфера на работа";
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.DarkGray;
            this.btnClick.Location = new System.Drawing.Point(505, 423);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(227, 69);
            this.btnClick.TabIndex = 10;
            this.btnClick.Text = "Отпечатване";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 262);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 11;
            // 
            // cmbsferaNaRabota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1012, 607);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.cmbSfera);
            this.Controls.Add(this.lbEGN);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.grbPol);
            this.Controls.Add(this.lbFamiliq);
            this.Controls.Add(this.lbPrezime);
            this.Controls.Add(this.lbIme);
            this.Name = "cmbsferaNaRabota";
            this.Text = "Име";
            this.Load += new System.EventHandler(this.cmbsferaNaRabota_Load);
            this.grbPol.ResumeLayout(false);
            this.grbPol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.Label lbFamiliq;
        private System.Windows.Forms.GroupBox grbPol;
        private System.Windows.Forms.RadioButton rbwoman;
        private System.Windows.Forms.RadioButton rbmen;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label lbEGN;
        private System.Windows.Forms.ComboBox cmbSfera;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox textBox1;
    }
}


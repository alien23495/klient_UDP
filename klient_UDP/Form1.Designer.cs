namespace klient_UDP
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
            this.adres = new System.Windows.Forms.TextBox();
            this.my_port = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.info_o_polaczeniu = new System.Windows.Forms.ListBox();
            this.wiadomosc = new System.Windows.Forms.TextBox();
            this.przycisk_wyslij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).BeginInit();
            this.SuspendLayout();
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(51, 9);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(188, 20);
            this.adres.TabIndex = 0;
            // 
            // my_port
            // 
            this.my_port.Location = new System.Drawing.Point(301, 10);
            this.my_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.my_port.Name = "my_port";
            this.my_port.Size = new System.Drawing.Size(120, 20);
            this.my_port.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "porcik";
            // 
            // info_o_polaczeniu
            // 
            this.info_o_polaczeniu.FormattingEnabled = true;
            this.info_o_polaczeniu.Location = new System.Drawing.Point(15, 131);
            this.info_o_polaczeniu.Name = "info_o_polaczeniu";
            this.info_o_polaczeniu.Size = new System.Drawing.Size(406, 173);
            this.info_o_polaczeniu.TabIndex = 4;
            // 
            // wiadomosc
            // 
            this.wiadomosc.Location = new System.Drawing.Point(15, 45);
            this.wiadomosc.Multiline = true;
            this.wiadomosc.Name = "wiadomosc";
            this.wiadomosc.Size = new System.Drawing.Size(406, 80);
            this.wiadomosc.TabIndex = 5;
            this.wiadomosc.Text = "Wpisz wiadomosc";
            // 
            // przycisk_wyslij
            // 
            this.przycisk_wyslij.Location = new System.Drawing.Point(13, 311);
            this.przycisk_wyslij.Name = "przycisk_wyslij";
            this.przycisk_wyslij.Size = new System.Drawing.Size(408, 37);
            this.przycisk_wyslij.TabIndex = 6;
            this.przycisk_wyslij.Text = "Wyslij";
            this.przycisk_wyslij.UseVisualStyleBackColor = true;
            this.przycisk_wyslij.Click += new System.EventHandler(this.przycisk_wyslij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 366);
            this.Controls.Add(this.przycisk_wyslij);
            this.Controls.Add(this.wiadomosc);
            this.Controls.Add(this.info_o_polaczeniu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.my_port);
            this.Controls.Add(this.adres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.NumericUpDown my_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox info_o_polaczeniu;
        private System.Windows.Forms.TextBox wiadomosc;
        private System.Windows.Forms.Button przycisk_wyslij;
    }
}


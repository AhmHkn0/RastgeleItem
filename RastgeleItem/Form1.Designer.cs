namespace RastgeleItem
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buton_ekle = new System.Windows.Forms.Button();
            this.buton_cikart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.baslik = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(198, 171);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 94);
            this.listBox1.TabIndex = 1;
            // 
            // buton_ekle
            // 
            this.buton_ekle.Location = new System.Drawing.Point(317, 99);
            this.buton_ekle.Name = "buton_ekle";
            this.buton_ekle.Size = new System.Drawing.Size(75, 23);
            this.buton_ekle.TabIndex = 2;
            this.buton_ekle.Text = "Ekle";
            this.buton_ekle.UseVisualStyleBackColor = true;
            this.buton_ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // buton_cikart
            // 
            this.buton_cikart.Location = new System.Drawing.Point(398, 98);
            this.buton_cikart.Name = "buton_cikart";
            this.buton_cikart.Size = new System.Drawing.Size(118, 24);
            this.buton_cikart.TabIndex = 3;
            this.buton_cikart.Text = "Son ekleneni sil";
            this.buton_cikart.UseVisualStyleBackColor = true;
            this.buton_cikart.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 65);
            this.button1.TabIndex = 5;
            this.button1.Text = "Rastgele seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.baslik.Location = new System.Drawing.Point(12, 28);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(766, 23);
            this.baslik.TabIndex = 6;
            this.baslik.Text = "Seçeneklerinizi belirtin arasından rastgele bir tanesini seçin.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seçenekleri girin";
            // 
            // sonuc
            // 
            this.sonuc.AutoSize = true;
            this.sonuc.Location = new System.Drawing.Point(198, 305);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(0, 15);
            this.sonuc.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.baslik);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buton_cikart);
            this.Controls.Add(this.buton_ekle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private Button buton_ekle;
        private Button buton_cikart;
        private Label label1;
        private Button button1;
        private Label baslik;
        private Label label2;
        private Label sonuc;
    }
}
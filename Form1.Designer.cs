
namespace Formuygörn8
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.textBoxsoyad = new System.Windows.Forms.TextBox();
            this.textBoxfinal = new System.Windows.Forms.TextBox();
            this.textBoxproje = new System.Windows.Forms.TextBox();
            this.textBoxvize = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Final";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Proje";
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(188, 16);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(166, 26);
            this.textBoxad.TabIndex = 5;
            // 
            // textBoxsoyad
            // 
            this.textBoxsoyad.Location = new System.Drawing.Point(188, 91);
            this.textBoxsoyad.Name = "textBoxsoyad";
            this.textBoxsoyad.Size = new System.Drawing.Size(166, 26);
            this.textBoxsoyad.TabIndex = 6;
            // 
            // textBoxfinal
            // 
            this.textBoxfinal.Location = new System.Drawing.Point(567, 86);
            this.textBoxfinal.Name = "textBoxfinal";
            this.textBoxfinal.Size = new System.Drawing.Size(170, 26);
            this.textBoxfinal.TabIndex = 7;
            // 
            // textBoxproje
            // 
            this.textBoxproje.Location = new System.Drawing.Point(567, 150);
            this.textBoxproje.Name = "textBoxproje";
            this.textBoxproje.Size = new System.Drawing.Size(170, 26);
            this.textBoxproje.TabIndex = 8;
            // 
            // textBoxvize
            // 
            this.textBoxvize.Location = new System.Drawing.Point(567, 14);
            this.textBoxvize.Name = "textBoxvize";
            this.textBoxvize.Size = new System.Drawing.Size(170, 26);
            this.textBoxvize.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(446, 62);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(101, 357);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(722, 148);
            this.listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 557);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxvize);
            this.Controls.Add(this.textBoxproje);
            this.Controls.Add(this.textBoxfinal);
            this.Controls.Add(this.textBoxsoyad);
            this.Controls.Add(this.textBoxad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.TextBox textBoxsoyad;
        private System.Windows.Forms.TextBox textBoxfinal;
        private System.Windows.Forms.TextBox textBoxproje;
        private System.Windows.Forms.TextBox textBoxvize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}


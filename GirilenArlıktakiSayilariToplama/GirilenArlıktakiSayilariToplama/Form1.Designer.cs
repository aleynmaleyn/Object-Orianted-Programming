namespace GirilenArlıktakiSayilariToplama
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
            this.hesapla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbitiş = new System.Windows.Forms.TextBox();
            this.txtbaşlangıç = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tektoplam = new System.Windows.Forms.TextBox();
            this.çifttoplam = new System.Windows.Forms.TextBox();
            this.geneltoplam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hesapla
            // 
            this.hesapla.BackColor = System.Drawing.Color.White;
            this.hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapla.Location = new System.Drawing.Point(117, 241);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(140, 45);
            this.hesapla.TabIndex = 0;
            this.hesapla.Text = "HESAPLA";
            this.hesapla.UseVisualStyleBackColor = false;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.txtbitiş);
            this.groupBox1.Controls.Add(this.txtbaşlangıç);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hesapla);
            this.groupBox1.Location = new System.Drawing.Point(34, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 338);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Bilgileri";
            // 
            // txtbitiş
            // 
            this.txtbitiş.Location = new System.Drawing.Point(276, 160);
            this.txtbitiş.Name = "txtbitiş";
            this.txtbitiş.Size = new System.Drawing.Size(100, 22);
            this.txtbitiş.TabIndex = 3;
            // 
            // txtbaşlangıç
            // 
            this.txtbaşlangıç.Location = new System.Drawing.Point(276, 78);
            this.txtbaşlangıç.Name = "txtbaşlangıç";
            this.txtbaşlangıç.Size = new System.Drawing.Size(100, 22);
            this.txtbaşlangıç.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(99, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş Değeri:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Değeri:";
            // 
            // tektoplam
            // 
            this.tektoplam.Location = new System.Drawing.Point(603, 103);
            this.tektoplam.Name = "tektoplam";
            this.tektoplam.Size = new System.Drawing.Size(100, 22);
            this.tektoplam.TabIndex = 2;
            // 
            // çifttoplam
            // 
            this.çifttoplam.Location = new System.Drawing.Point(603, 222);
            this.çifttoplam.Name = "çifttoplam";
            this.çifttoplam.Size = new System.Drawing.Size(100, 22);
            this.çifttoplam.TabIndex = 3;
            // 
            // geneltoplam
            // 
            this.geneltoplam.Location = new System.Drawing.Point(603, 341);
            this.geneltoplam.Name = "geneltoplam";
            this.geneltoplam.Size = new System.Drawing.Size(100, 22);
            this.geneltoplam.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(596, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tek Toplam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(596, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Çift Toplam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(598, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Genel Toplam";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.geneltoplam);
            this.Controls.Add(this.çifttoplam);
            this.Controls.Add(this.tektoplam);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbitiş;
        private System.Windows.Forms.TextBox txtbaşlangıç;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tektoplam;
        private System.Windows.Forms.TextBox çifttoplam;
        private System.Windows.Forms.TextBox geneltoplam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


namespace sorguTestProjesi
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCalistir = new System.Windows.Forms.Button();
            this.btnEkleSilGuncelle = new System.Windows.Forms.Button();
            this.btnSqlHakkinda = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(425, 175);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnCalistir
            // 
            this.btnCalistir.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCalistir.Location = new System.Drawing.Point(432, 12);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(196, 50);
            this.btnCalistir.TabIndex = 1;
            this.btnCalistir.Text = "ÇALIŞTIR";
            this.btnCalistir.UseVisualStyleBackColor = false;
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // btnEkleSilGuncelle
            // 
            this.btnEkleSilGuncelle.BackColor = System.Drawing.Color.Moccasin;
            this.btnEkleSilGuncelle.Location = new System.Drawing.Point(432, 68);
            this.btnEkleSilGuncelle.Name = "btnEkleSilGuncelle";
            this.btnEkleSilGuncelle.Size = new System.Drawing.Size(196, 50);
            this.btnEkleSilGuncelle.TabIndex = 2;
            this.btnEkleSilGuncelle.Text = "EKLE-SİL-GÜNCELLE";
            this.btnEkleSilGuncelle.UseVisualStyleBackColor = false;
            this.btnEkleSilGuncelle.Click += new System.EventHandler(this.btnEkleSilGuncelle_Click);
            // 
            // btnSqlHakkinda
            // 
            this.btnSqlHakkinda.BackColor = System.Drawing.Color.Teal;
            this.btnSqlHakkinda.Location = new System.Drawing.Point(432, 124);
            this.btnSqlHakkinda.Name = "btnSqlHakkinda";
            this.btnSqlHakkinda.Size = new System.Drawing.Size(196, 50);
            this.btnSqlHakkinda.TabIndex = 3;
            this.btnSqlHakkinda.Text = "SQL HAKKINDA";
            this.btnSqlHakkinda.UseVisualStyleBackColor = false;
            this.btnSqlHakkinda.Click += new System.EventHandler(this.btnSqlHakkinda_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 222);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(630, 408);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSqlHakkinda);
            this.Controls.Add(this.btnEkleSilGuncelle);
            this.Controls.Add(this.btnCalistir);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Sorguları Çalışma";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCalistir;
        private System.Windows.Forms.Button btnEkleSilGuncelle;
        private System.Windows.Forms.Button btnSqlHakkinda;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


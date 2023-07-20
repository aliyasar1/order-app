namespace AllyGano
{
    partial class Urunler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urunler));
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uKategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPaketAdetiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisTakibiDataSet = new AllyGano.siparisTakibiDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.urunlerTableAdapter = new AllyGano.siparisTakibiDataSetTableAdapters.urunlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisTakibiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(13, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(947, 35);
            this.button5.TabIndex = 11;
            this.button5.Text = "Yenile";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uIDDataGridViewTextBoxColumn,
            this.uKategoriDataGridViewTextBoxColumn,
            this.uAdiDataGridViewTextBoxColumn,
            this.uPaketAdetiDataGridViewTextBoxColumn,
            this.uFiyatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(947, 543);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uIDDataGridViewTextBoxColumn
            // 
            this.uIDDataGridViewTextBoxColumn.DataPropertyName = "u_ID";
            this.uIDDataGridViewTextBoxColumn.HeaderText = "Ürün Kodu";
            this.uIDDataGridViewTextBoxColumn.Name = "uIDDataGridViewTextBoxColumn";
            this.uIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uKategoriDataGridViewTextBoxColumn
            // 
            this.uKategoriDataGridViewTextBoxColumn.DataPropertyName = "u_Kategori";
            this.uKategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.uKategoriDataGridViewTextBoxColumn.Name = "uKategoriDataGridViewTextBoxColumn";
            this.uKategoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uAdiDataGridViewTextBoxColumn
            // 
            this.uAdiDataGridViewTextBoxColumn.DataPropertyName = "u_Adi";
            this.uAdiDataGridViewTextBoxColumn.HeaderText = "Ürün Adı";
            this.uAdiDataGridViewTextBoxColumn.Name = "uAdiDataGridViewTextBoxColumn";
            this.uAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uPaketAdetiDataGridViewTextBoxColumn
            // 
            this.uPaketAdetiDataGridViewTextBoxColumn.DataPropertyName = "u_PaketAdeti";
            this.uPaketAdetiDataGridViewTextBoxColumn.HeaderText = "Paket Adeti";
            this.uPaketAdetiDataGridViewTextBoxColumn.Name = "uPaketAdetiDataGridViewTextBoxColumn";
            this.uPaketAdetiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uFiyatiDataGridViewTextBoxColumn
            // 
            this.uFiyatiDataGridViewTextBoxColumn.DataPropertyName = "u_Fiyati";
            this.uFiyatiDataGridViewTextBoxColumn.HeaderText = "Fiyatı";
            this.uFiyatiDataGridViewTextBoxColumn.Name = "uFiyatiDataGridViewTextBoxColumn";
            this.uFiyatiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "urunler";
            this.urunlerBindingSource.DataSource = this.siparisTakibiDataSet;
            // 
            // siparisTakibiDataSet
            // 
            this.siparisTakibiDataSet.DataSetName = "siparisTakibiDataSet";
            this.siparisTakibiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::AllyGano.Properties.Resources.geri_png_3;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(759, 13);
            this.button4.MaximumSize = new System.Drawing.Size(200, 200);
            this.button4.MinimumSize = new System.Drawing.Size(200, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 200);
            this.button4.TabIndex = 9;
            this.button4.Text = "Geri Çık";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::AllyGano.Properties.Resources.urunguncelle;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(508, 13);
            this.button3.MaximumSize = new System.Drawing.Size(200, 200);
            this.button3.MinimumSize = new System.Drawing.Size(200, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 200);
            this.button3.TabIndex = 8;
            this.button3.Text = "Ürün Güncelle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::AllyGano.Properties.Resources.urunsil;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(258, 13);
            this.button2.MaximumSize = new System.Drawing.Size(200, 200);
            this.button2.MinimumSize = new System.Drawing.Size(200, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 200);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ürün Sil";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AllyGano.Properties.Resources.urunekle;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.MaximumSize = new System.Drawing.Size(200, 200);
            this.button1.MinimumSize = new System.Drawing.Size(200, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 200);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ürün Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 816);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(988, 855);
            this.MinimumSize = new System.Drawing.Size(988, 855);
            this.Name = "Urunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisTakibiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private siparisTakibiDataSet siparisTakibiDataSet;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private siparisTakibiDataSetTableAdapters.urunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uKategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPaketAdetiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFiyatiDataGridViewTextBoxColumn;
    }
}
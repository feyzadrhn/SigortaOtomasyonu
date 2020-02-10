namespace VeriTabaniÖdev
{
    partial class sigortaekle
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.veritabaniDataSet2 = new VeriTabaniÖdev.veritabaniDataSet2();
            this.sigortaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sigorta_TableAdapter = new VeriTabaniÖdev.veritabaniDataSet2TableAdapters.sigorta_TableAdapter();
            this.sigortaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigortaturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigortaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.sigortaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.veritabaniDataSet1 = new VeriTabaniÖdev.veritabaniDataSet2();
            this.sigorta_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sigortaTableAdapter = new VeriTabaniÖdev.veritabaniDataSet2TableAdapters.sigorta_TableAdapter();
            this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musterilerTableAdapter = new VeriTabaniÖdev.veritabaniDataSet2TableAdapters.musterilerTableAdapter();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigortaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigortaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigortaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigortaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigorta_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(39, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(42, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(42, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sigorta Türü";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ev",
            "Araba"});
            this.comboBox1.Location = new System.Drawing.Point(137, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // veritabaniDataSet2
            // 
            this.veritabaniDataSet2.DataSetName = "veritabaniDataSet2";
            this.veritabaniDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sigortaBindingSource1
            // 
            this.sigortaBindingSource1.DataMember = "sigorta_";
            this.sigortaBindingSource1.DataSource = this.veritabaniDataSet2;
            // 
            // sigorta_TableAdapter
            // 
            this.sigorta_TableAdapter.ClearBeforeFill = true;
            // 
            // sigortaBindingSource2
            // 
            this.sigortaBindingSource2.DataMember = "sigorta_";
            this.sigortaBindingSource2.DataSource = this.veritabaniDataSet2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.sigortaturuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sigortaBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(284, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 260);
            this.dataGridView1.TabIndex = 6;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sigortaturuDataGridViewTextBoxColumn
            // 
            this.sigortaturuDataGridViewTextBoxColumn.DataPropertyName = "sigorta_turu";
            this.sigortaturuDataGridViewTextBoxColumn.HeaderText = "sigorta_turu";
            this.sigortaturuDataGridViewTextBoxColumn.Name = "sigortaturuDataGridViewTextBoxColumn";
            // 
            // sigortaBindingSource4
            // 
            this.sigortaBindingSource4.DataMember = "sigorta_";
            this.sigortaBindingSource4.DataSource = this.veritabaniDataSet2;
            // 
            // sigortaBindingSource3
            // 
            this.sigortaBindingSource3.DataMember = "sigorta_";
            this.sigortaBindingSource3.DataSource = this.veritabaniDataSet2;
            // 
            // veritabaniDataSet1
            // 
            this.veritabaniDataSet1.DataSetName = "veritabaniDataSet1";
            this.veritabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sigorta_BindingSource
            // 
            this.sigorta_BindingSource.DataMember = "sigorta";
            this.sigorta_BindingSource.DataSource = this.veritabaniDataSet1;
            // 
            // sigortaTableAdapter
            // 
            this.sigortaTableAdapter.ClearBeforeFill = true;
            // 
            // musterilerBindingSource
            // 
            this.musterilerBindingSource.DataMember = "musteriler";
            this.musterilerBindingSource.DataSource = this.veritabaniDataSet1;
            // 
            // musterilerTableAdapter
            // 
            this.musterilerTableAdapter.ClearBeforeFill = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(141, 85);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(78, 20);
            this.textBox5.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(38, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Silinecek Id";
            // 
            // sigortaekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "sigortaekle";
            this.Text = "sigortaekle";
            this.Load += new System.EventHandler(this.sigortaekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigortaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigortaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigortaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigortaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigortaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private veritabaniDataSet2 veritabaniDataSet1;
        private System.Windows.Forms.BindingSource sigorta_BindingSource;
        private veritabaniDataSet2TableAdapters.sigorta_TableAdapter sigortaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource musterilerBindingSource;
        private veritabaniDataSet2TableAdapters.musterilerTableAdapter musterilerTableAdapter;
        private veritabaniDataSet2 veritabaniDataSet2;
        private System.Windows.Forms.BindingSource sigortaBindingSource1;
        private veritabaniDataSet2TableAdapters.sigorta_TableAdapter sigorta_TableAdapter;
        private System.Windows.Forms.BindingSource sigortaBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigortaturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sigortaBindingSource3;
        private System.Windows.Forms.BindingSource sigortaBindingSource4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
    }
}
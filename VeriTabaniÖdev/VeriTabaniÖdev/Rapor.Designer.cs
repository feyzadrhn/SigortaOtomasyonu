namespace VeriTabaniÖdev
{
    partial class Rapor
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
            this.musterilerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.veritabaniDataSet2 = new VeriTabaniÖdev.veritabaniDataSet2();
            this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musterilerTableAdapter = new VeriTabaniÖdev.veritabaniDataSet2TableAdapters.musterilerTableAdapter();
            this.veritabaniDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.policeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policeTableAdapter = new VeriTabaniÖdev.veritabaniDataSet2TableAdapters.policeTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // musterilerBindingSource1
            // 
            this.musterilerBindingSource1.DataMember = "musteriler";
            this.musterilerBindingSource1.DataSource = this.veritabaniDataSet2;
            // 
            // veritabaniDataSet2
            // 
            this.veritabaniDataSet2.DataSetName = "veritabaniDataSet2";
            this.veritabaniDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musterilerBindingSource
            // 
            this.musterilerBindingSource.DataMember = "musteriler";
            this.musterilerBindingSource.DataSource = this.veritabaniDataSet2;
            // 
            // musterilerTableAdapter
            // 
            this.musterilerTableAdapter.ClearBeforeFill = true;
            // 
            // veritabaniDataSet2BindingSource
            // 
            this.veritabaniDataSet2BindingSource.DataSource = this.veritabaniDataSet2;
            this.veritabaniDataSet2BindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tüm Müşteriler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // policeBindingSource
            // 
            this.policeBindingSource.DataMember = "police";
            this.policeBindingSource.DataSource = this.veritabaniDataSet2;
            // 
            // policeTableAdapter
            // 
            this.policeTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "En Çok Tercih Edilen Sigorta Türü";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "En Pahalı  10 Poliçe Listesi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(280, 290);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private veritabaniDataSet2 veritabaniDataSet2;
        private System.Windows.Forms.BindingSource musterilerBindingSource;
        private veritabaniDataSet2TableAdapters.musterilerTableAdapter musterilerTableAdapter;
        private System.Windows.Forms.BindingSource musterilerBindingSource1;
        private System.Windows.Forms.BindingSource veritabaniDataSet2BindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource policeBindingSource;
        private veritabaniDataSet2TableAdapters.policeTableAdapter policeTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
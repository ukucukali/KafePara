
namespace KafePara
{
    partial class GecmisSiparislerForm
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
            this.spcGEcmisSiparisler = new System.Windows.Forms.SplitContainer();
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSiparisDetaylar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spcGEcmisSiparisler)).BeginInit();
            this.spcGEcmisSiparisler.Panel1.SuspendLayout();
            this.spcGEcmisSiparisler.Panel2.SuspendLayout();
            this.spcGEcmisSiparisler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).BeginInit();
            this.SuspendLayout();
            // 
            // spcGEcmisSiparisler
            // 
            this.spcGEcmisSiparisler.Location = new System.Drawing.Point(2, 23);
            this.spcGEcmisSiparisler.Name = "spcGEcmisSiparisler";
            this.spcGEcmisSiparisler.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcGEcmisSiparisler.Panel1
            // 
            this.spcGEcmisSiparisler.Panel1.Controls.Add(this.dgvSiparisler);
            this.spcGEcmisSiparisler.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // spcGEcmisSiparisler.Panel2
            // 
            this.spcGEcmisSiparisler.Panel2.Controls.Add(this.label2);
            this.spcGEcmisSiparisler.Panel2.Controls.Add(this.dgvSiparisDetaylar);
            this.spcGEcmisSiparisler.Size = new System.Drawing.Size(756, 404);
            this.spcGEcmisSiparisler.SplitterDistance = 176;
            this.spcGEcmisSiparisler.TabIndex = 0;
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.AllowUserToAddRows = false;
            this.dgvSiparisler.AllowUserToDeleteRows = false;
            this.dgvSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(3, 3);
            this.dgvSiparisler.MultiSelect = false;
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.ReadOnly = true;
            this.dgvSiparisler.RowHeadersVisible = false;
            this.dgvSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisler.Size = new System.Drawing.Size(750, 168);
            this.dgvSiparisler.TabIndex = 3;
            this.dgvSiparisler.SelectionChanged += new System.EventHandler(this.dgvSiparisler_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Siparis Detaylari";
            // 
            // dgvSiparisDetaylar
            // 
            this.dgvSiparisDetaylar.AllowUserToAddRows = false;
            this.dgvSiparisDetaylar.AllowUserToDeleteRows = false;
            this.dgvSiparisDetaylar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisDetaylar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSiparisDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylar.Location = new System.Drawing.Point(3, 32);
            this.dgvSiparisDetaylar.MultiSelect = false;
            this.dgvSiparisDetaylar.Name = "dgvSiparisDetaylar";
            this.dgvSiparisDetaylar.ReadOnly = true;
            this.dgvSiparisDetaylar.RowHeadersVisible = false;
            this.dgvSiparisDetaylar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisDetaylar.Size = new System.Drawing.Size(750, 189);
            this.dgvSiparisDetaylar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(12, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Siparisler";
            // 
            // GecmisSiparislerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.spcGEcmisSiparisler);
            this.Name = "GecmisSiparislerForm";
            this.Text = "GecmisSiparislerForm";
            this.spcGEcmisSiparisler.Panel1.ResumeLayout(false);
            this.spcGEcmisSiparisler.Panel2.ResumeLayout(false);
            this.spcGEcmisSiparisler.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcGEcmisSiparisler)).EndInit();
            this.spcGEcmisSiparisler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcGEcmisSiparisler;
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSiparisDetaylar;
        private System.Windows.Forms.Label label3;
    }
}
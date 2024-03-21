namespace C5
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.idRFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rFDS = new C5.RFDS();
            this.rFTableAdapter = new C5.RFDSTableAdapters.RFTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRFDataGridViewTextBoxColumn,
            this.dRFDataGridViewTextBoxColumn,
            this.monedaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rFBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(54, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(662, 509);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.AllowUserToDeleteRowsChanged += new System.EventHandler(this.btnActualizare_Click);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(116, 36);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(111, 45);
            this.btnActualizare.TabIndex = 1;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(320, 46);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(111, 45);
            this.btnSalvare.TabIndex = 2;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(529, 46);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(103, 45);
            this.btnRenuntare.TabIndex = 3;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // idRFDataGridViewTextBoxColumn
            // 
            this.idRFDataGridViewTextBoxColumn.DataPropertyName = "IdRF";
            this.idRFDataGridViewTextBoxColumn.HeaderText = "IdRF";
            this.idRFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idRFDataGridViewTextBoxColumn.Name = "idRFDataGridViewTextBoxColumn";
            this.idRFDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRFDataGridViewTextBoxColumn.Width = 125;
            // 
            // dRFDataGridViewTextBoxColumn
            // 
            this.dRFDataGridViewTextBoxColumn.DataPropertyName = "DRF";
            this.dRFDataGridViewTextBoxColumn.HeaderText = "DRF";
            this.dRFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dRFDataGridViewTextBoxColumn.Name = "dRFDataGridViewTextBoxColumn";
            this.dRFDataGridViewTextBoxColumn.ReadOnly = true;
            this.dRFDataGridViewTextBoxColumn.Width = 125;
            // 
            // monedaDataGridViewTextBoxColumn
            // 
            this.monedaDataGridViewTextBoxColumn.DataPropertyName = "Moneda";
            this.monedaDataGridViewTextBoxColumn.HeaderText = "Moneda";
            this.monedaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monedaDataGridViewTextBoxColumn.Name = "monedaDataGridViewTextBoxColumn";
            this.monedaDataGridViewTextBoxColumn.ReadOnly = true;
            this.monedaDataGridViewTextBoxColumn.Width = 125;
            // 
            // rFBindingSource
            // 
            this.rFBindingSource.DataMember = "RF";
            this.rFBindingSource.DataSource = this.rFDS;
            // 
            // rFDS
            // 
            this.rFDS.DataSetName = "RFDS";
            this.rFDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rFTableAdapter
            // 
            this.rFTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 675);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RFDS rFDS;
        private System.Windows.Forms.BindingSource rFBindingSource;
        private RFDSTableAdapters.RFTableAdapter rFTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnRenuntare;
    }
}


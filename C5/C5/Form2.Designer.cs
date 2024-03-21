namespace C5
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idRezervareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSosireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPlecareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rHDS = new C5.RHDS();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ziDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocupareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtGradOcupare = new System.Windows.Forms.TextBox();
            this.txtProcent = new System.Windows.Forms.TextBox();
            this.rezervariTableAdapter = new C5.RHDSTableAdapters.RezervariTableAdapter();
            this.ocupareTableAdapter = new C5.RHDSTableAdapters.OcupareTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocupareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRezervareDataGridViewTextBoxColumn,
            this.dataSosireDataGridViewTextBoxColumn,
            this.dataPlecareDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn,
            this.cameraDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rezervariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(607, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // idRezervareDataGridViewTextBoxColumn
            // 
            this.idRezervareDataGridViewTextBoxColumn.DataPropertyName = "IdRezervare";
            this.idRezervareDataGridViewTextBoxColumn.HeaderText = "IdRezervare";
            this.idRezervareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idRezervareDataGridViewTextBoxColumn.Name = "idRezervareDataGridViewTextBoxColumn";
            this.idRezervareDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRezervareDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataSosireDataGridViewTextBoxColumn
            // 
            this.dataSosireDataGridViewTextBoxColumn.DataPropertyName = "DataSosire";
            this.dataSosireDataGridViewTextBoxColumn.HeaderText = "DataSosire";
            this.dataSosireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataSosireDataGridViewTextBoxColumn.Name = "dataSosireDataGridViewTextBoxColumn";
            this.dataSosireDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataSosireDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataPlecareDataGridViewTextBoxColumn
            // 
            this.dataPlecareDataGridViewTextBoxColumn.DataPropertyName = "DataPlecare";
            this.dataPlecareDataGridViewTextBoxColumn.HeaderText = "DataPlecare";
            this.dataPlecareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataPlecareDataGridViewTextBoxColumn.Name = "dataPlecareDataGridViewTextBoxColumn";
            this.dataPlecareDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataPlecareDataGridViewTextBoxColumn.Width = 125;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // cameraDataGridViewTextBoxColumn
            // 
            this.cameraDataGridViewTextBoxColumn.DataPropertyName = "Camera";
            this.cameraDataGridViewTextBoxColumn.HeaderText = "Camera";
            this.cameraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cameraDataGridViewTextBoxColumn.Name = "cameraDataGridViewTextBoxColumn";
            this.cameraDataGridViewTextBoxColumn.ReadOnly = true;
            this.cameraDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeDataGridViewTextBoxColumn.Width = 125;
            // 
            // rezervariBindingSource
            // 
            this.rezervariBindingSource.DataMember = "Rezervari";
            this.rezervariBindingSource.DataSource = this.rHDS;
            // 
            // rHDS
            // 
            this.rHDS.DataSetName = "RHDS";
            this.rHDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ziDataGridViewTextBoxColumn,
            this.c1DataGridViewTextBoxColumn,
            this.c2DataGridViewTextBoxColumn,
            this.c3DataGridViewTextBoxColumn,
            this.c4DataGridViewTextBoxColumn,
            this.c5DataGridViewTextBoxColumn,
            this.c6DataGridViewTextBoxColumn,
            this.c7DataGridViewTextBoxColumn,
            this.c8DataGridViewTextBoxColumn,
            this.c9DataGridViewTextBoxColumn,
            this.c10DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.ocupareBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(639, 70);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(777, 210);
            this.dataGridView2.TabIndex = 1;
            // 
            // ziDataGridViewTextBoxColumn
            // 
            this.ziDataGridViewTextBoxColumn.DataPropertyName = "Zi";
            this.ziDataGridViewTextBoxColumn.HeaderText = "Zi";
            this.ziDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ziDataGridViewTextBoxColumn.Name = "ziDataGridViewTextBoxColumn";
            this.ziDataGridViewTextBoxColumn.ReadOnly = true;
            this.ziDataGridViewTextBoxColumn.Width = 125;
            // 
            // c1DataGridViewTextBoxColumn
            // 
            this.c1DataGridViewTextBoxColumn.DataPropertyName = "C1";
            this.c1DataGridViewTextBoxColumn.HeaderText = "C1";
            this.c1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.c1DataGridViewTextBoxColumn.Name = "c1DataGridViewTextBoxColumn";
            this.c1DataGridViewTextBoxColumn.ReadOnly = true;
            this.c1DataGridViewTextBoxColumn.Width = 125;
            // 
            // c2DataGridViewTextBoxColumn
            // 
            this.c2DataGridViewTextBoxColumn.DataPropertyName = "C2";
            this.c2DataGridViewTextBoxColumn.HeaderText = "C2";
            this.c2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.c2DataGridViewTextBoxColumn.Name = "c2DataGridViewTextBoxColumn";
            this.c2DataGridViewTextBoxColumn.ReadOnly = true;
            this.c2DataGridViewTextBoxColumn.Width = 125;
            // 
            // c3DataGridViewTextBoxColumn
            // 
            this.c3DataGridViewTextBoxColumn.DataPropertyName = "C3";
            this.c3DataGridViewTextBoxColumn.HeaderText = "C3";
            this.c3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.c3DataGridViewTextBoxColumn.Name = "c3DataGridViewTextBoxColumn";
            this.c3DataGridViewTextBoxColumn.ReadOnly = true;
            this.c3DataGridViewTextBoxColumn.Width = 125;
            // 
            // c4DataGridViewTextBoxColumn
            // 
            this.c4DataGridViewTextBoxColumn.DataPropertyName = "C4";
            this.c4DataGridViewTextBoxColumn.HeaderText = "C4";
            this.c4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.c4DataGridViewTextBoxColumn.Name = "c4DataGridViewTextBoxColumn";
            this.c4DataGridViewTextBoxColumn.ReadOnly = true;
            this.c4DataGridViewTextBoxColumn.Width = 125;
            // 
            // c5DataGridViewTextBoxColumn
            // 
            this.c5DataGridViewTextBoxColumn.DataPropertyName = "C5";
            this.c5DataGridViewTextBoxColumn.HeaderText = "C5";
            this.c5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.c5DataGridViewTextBoxColumn.Name = "c5DataGridViewTextBoxColumn";
            this.c5DataGridViewTextBoxColumn.ReadOnly = true;
            this.c5DataGridViewTextBoxColumn.Width = 125;
            // 
            // c6DataGridViewTextBoxColumn
            // 
            this.c6DataGridViewTextBoxColumn.DataPropertyName = "C6";
            this.c6DataGridViewTextBoxColumn.HeaderText = "C6";
            this.c6DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.c6DataGridViewTextBoxColumn.Name = "c6DataGridViewTextBoxColumn";
            this.c6DataGridViewTextBoxColumn.ReadOnly = true;
            this.c6DataGridViewTextBoxColumn.Width = 125;
            // 
            // c7DataGridViewTextBoxColumn
            // 
            this.c7DataGridViewTextBoxColumn.DataPropertyName = "C7";
            this.c7DataGridViewTextBoxColumn.HeaderText = "C7";
            this.c7DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.c7DataGridViewTextBoxColumn.Name = "c7DataGridViewTextBoxColumn";
            this.c7DataGridViewTextBoxColumn.ReadOnly = true;
            this.c7DataGridViewTextBoxColumn.Width = 125;
            // 
            // c8DataGridViewTextBoxColumn
            // 
            this.c8DataGridViewTextBoxColumn.DataPropertyName = "C8";
            this.c8DataGridViewTextBoxColumn.HeaderText = "C8";
            this.c8DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.c8DataGridViewTextBoxColumn.Name = "c8DataGridViewTextBoxColumn";
            this.c8DataGridViewTextBoxColumn.ReadOnly = true;
            this.c8DataGridViewTextBoxColumn.Width = 125;
            // 
            // c9DataGridViewTextBoxColumn
            // 
            this.c9DataGridViewTextBoxColumn.DataPropertyName = "C9";
            this.c9DataGridViewTextBoxColumn.HeaderText = "C9";
            this.c9DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.c9DataGridViewTextBoxColumn.Name = "c9DataGridViewTextBoxColumn";
            this.c9DataGridViewTextBoxColumn.ReadOnly = true;
            this.c9DataGridViewTextBoxColumn.Width = 125;
            // 
            // c10DataGridViewTextBoxColumn
            // 
            this.c10DataGridViewTextBoxColumn.DataPropertyName = "C10";
            this.c10DataGridViewTextBoxColumn.HeaderText = "C10";
            this.c10DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.c10DataGridViewTextBoxColumn.Name = "c10DataGridViewTextBoxColumn";
            this.c10DataGridViewTextBoxColumn.ReadOnly = true;
            this.c10DataGridViewTextBoxColumn.Width = 125;
            // 
            // ocupareBindingSource
            // 
            this.ocupareBindingSource.DataMember = "Ocupare";
            this.ocupareBindingSource.DataSource = this.rHDS;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcul ocupare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Calcul grad ocupare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtGradOcupare
            // 
            this.txtGradOcupare.Location = new System.Drawing.Point(806, 36);
            this.txtGradOcupare.Name = "txtGradOcupare";
            this.txtGradOcupare.Size = new System.Drawing.Size(159, 22);
            this.txtGradOcupare.TabIndex = 4;
            // 
            // txtProcent
            // 
            this.txtProcent.Location = new System.Drawing.Point(1017, 36);
            this.txtProcent.Name = "txtProcent";
            this.txtProcent.Size = new System.Drawing.Size(159, 22);
            this.txtProcent.TabIndex = 5;
            // 
            // rezervariTableAdapter
            // 
            this.rezervariTableAdapter.ClearBeforeFill = true;
            // 
            // ocupareTableAdapter
            // 
            this.ocupareTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.ocupareBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 286);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "C2";
            series1.YValueMembers = "Zi";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1352, 412);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 744);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.txtProcent);
            this.Controls.Add(this.txtGradOcupare);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocupareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtGradOcupare;
        private System.Windows.Forms.TextBox txtProcent;
        private RHDS rHDS;
        private System.Windows.Forms.BindingSource rezervariBindingSource;
        private RHDSTableAdapters.RezervariTableAdapter rezervariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRezervareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSosireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPlecareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ocupareBindingSource;
        private RHDSTableAdapters.OcupareTableAdapter ocupareTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ziDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
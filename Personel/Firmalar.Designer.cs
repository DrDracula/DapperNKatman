namespace Personel
{
    partial class Firmalar
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
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new Personel.testDataSet();
            this.firmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmaTableAdapter = new Personel.testDataSetTableAdapters.FirmaTableAdapter();
            this.firmaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergidairesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verginoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmaIdDataGridViewTextBoxColumn,
            this.unvaniDataGridViewTextBoxColumn,
            this.firmaTipiDataGridViewTextBoxColumn,
            this.adres1DataGridViewTextBoxColumn,
            this.adres2DataGridViewTextBoxColumn,
            this.vergidairesiDataGridViewTextBoxColumn,
            this.verginoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.firmaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 353);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // testDataSetBindingSource
            // 
            this.testDataSetBindingSource.DataSource = this.testDataSet;
            this.testDataSetBindingSource.Position = 0;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmaBindingSource
            // 
            this.firmaBindingSource.DataMember = "Firma";
            this.firmaBindingSource.DataSource = this.testDataSetBindingSource;
            // 
            // firmaTableAdapter
            // 
            this.firmaTableAdapter.ClearBeforeFill = true;
            // 
            // firmaIdDataGridViewTextBoxColumn
            // 
            this.firmaIdDataGridViewTextBoxColumn.DataPropertyName = "firmaId";
            this.firmaIdDataGridViewTextBoxColumn.HeaderText = "firmaId";
            this.firmaIdDataGridViewTextBoxColumn.Name = "firmaIdDataGridViewTextBoxColumn";
            this.firmaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unvaniDataGridViewTextBoxColumn
            // 
            this.unvaniDataGridViewTextBoxColumn.DataPropertyName = "Unvani";
            this.unvaniDataGridViewTextBoxColumn.HeaderText = "Unvani";
            this.unvaniDataGridViewTextBoxColumn.Name = "unvaniDataGridViewTextBoxColumn";
            // 
            // firmaTipiDataGridViewTextBoxColumn
            // 
            this.firmaTipiDataGridViewTextBoxColumn.DataPropertyName = "firmaTipi";
            this.firmaTipiDataGridViewTextBoxColumn.HeaderText = "firmaTipi";
            this.firmaTipiDataGridViewTextBoxColumn.Name = "firmaTipiDataGridViewTextBoxColumn";
            // 
            // adres1DataGridViewTextBoxColumn
            // 
            this.adres1DataGridViewTextBoxColumn.DataPropertyName = "adres1";
            this.adres1DataGridViewTextBoxColumn.HeaderText = "adres1";
            this.adres1DataGridViewTextBoxColumn.Name = "adres1DataGridViewTextBoxColumn";
            // 
            // adres2DataGridViewTextBoxColumn
            // 
            this.adres2DataGridViewTextBoxColumn.DataPropertyName = "adres2";
            this.adres2DataGridViewTextBoxColumn.HeaderText = "adres2";
            this.adres2DataGridViewTextBoxColumn.Name = "adres2DataGridViewTextBoxColumn";
            // 
            // vergidairesiDataGridViewTextBoxColumn
            // 
            this.vergidairesiDataGridViewTextBoxColumn.DataPropertyName = "vergidairesi";
            this.vergidairesiDataGridViewTextBoxColumn.HeaderText = "vergidairesi";
            this.vergidairesiDataGridViewTextBoxColumn.Name = "vergidairesiDataGridViewTextBoxColumn";
            // 
            // verginoDataGridViewTextBoxColumn
            // 
            this.verginoDataGridViewTextBoxColumn.DataPropertyName = "vergino";
            this.verginoDataGridViewTextBoxColumn.HeaderText = "vergino";
            this.verginoDataGridViewTextBoxColumn.Name = "verginoDataGridViewTextBoxColumn";
            // 
            // Firmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Firmalar";
            this.Text = "Firmalar";
            this.Load += new System.EventHandler(this.Firmalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource testDataSetBindingSource;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource firmaBindingSource;
        private testDataSetTableAdapters.FirmaTableAdapter firmaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergidairesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verginoDataGridViewTextBoxColumn;
    }
}
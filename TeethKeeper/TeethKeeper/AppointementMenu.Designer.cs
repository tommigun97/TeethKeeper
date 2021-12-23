namespace TeethKeeper
{
    partial class AppointementMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointementMenu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPUNTAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tKDataBaseDataSet = new TeethKeeper.TKDataBaseDataSet();
            this.aPPUNTAMENTOTableAdapter = new TeethKeeper.TKDataBaseDataSetTableAdapters.APPUNTAMENTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPUNTAMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKDataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codPersonaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.oraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aPPUNTAMENTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(91, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codPersonaDataGridViewTextBoxColumn
            // 
            this.codPersonaDataGridViewTextBoxColumn.DataPropertyName = "CodPersona";
            this.codPersonaDataGridViewTextBoxColumn.HeaderText = "CodPersona";
            this.codPersonaDataGridViewTextBoxColumn.Name = "codPersonaDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data_";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data_";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // oraDataGridViewTextBoxColumn
            // 
            this.oraDataGridViewTextBoxColumn.DataPropertyName = "Ora";
            this.oraDataGridViewTextBoxColumn.HeaderText = "Ora";
            this.oraDataGridViewTextBoxColumn.Name = "oraDataGridViewTextBoxColumn";
            // 
            // aPPUNTAMENTOBindingSource
            // 
            this.aPPUNTAMENTOBindingSource.DataMember = "APPUNTAMENTO";
            this.aPPUNTAMENTOBindingSource.DataSource = this.tKDataBaseDataSet;
            // 
            // tKDataBaseDataSet
            // 
            this.tKDataBaseDataSet.DataSetName = "TKDataBaseDataSet";
            this.tKDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPPUNTAMENTOTableAdapter
            // 
            this.aPPUNTAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // AppointementMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppointementMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teeth Keeper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AppointementMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPUNTAMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKDataBaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TKDataBaseDataSet tKDataBaseDataSet;
        private System.Windows.Forms.BindingSource aPPUNTAMENTOBindingSource;
        private TKDataBaseDataSetTableAdapters.APPUNTAMENTOTableAdapter aPPUNTAMENTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oraDataGridViewTextBoxColumn;
    }
}
namespace TeethKeeper
{
    partial class ClinicalCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClinicalCard));
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.sportLabel = new System.Windows.Forms.Label();
            this.alcolLabel = new System.Windows.Forms.Label();
            this.smokeLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codFarmacoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fARMACOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tkDataBaseDataSet = new TeethKeeper.TKDataBaseDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codEsameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSAMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fARMACOTableAdapter = new TeethKeeper.TKDataBaseDataSetTableAdapters.FARMACOTableAdapter();
            this.schedA_CLINICATableAdapter = new TeethKeeper.TKDataBaseDataSetTableAdapters.SCHEDA_CLINICATableAdapter();
            this.esameTableAdapter = new TeethKeeper.TKDataBaseDataSetTableAdapters.ESAMETableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.codPazienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDiagnosiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipologiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATOLOGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patologiaTableAdapter = new TeethKeeper.TKDataBaseDataSetTableAdapters.PATOLOGIATableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSAMEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATOLOGIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(51, 31);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 18);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nome";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLabel.Location = new System.Drawing.Point(169, 31);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(74, 18);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Cognome";
            // 
            // sportLabel
            // 
            this.sportLabel.AutoSize = true;
            this.sportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sportLabel.Location = new System.Drawing.Point(567, 31);
            this.sportLabel.Name = "sportLabel";
            this.sportLabel.Size = new System.Drawing.Size(28, 18);
            this.sportLabel.TabIndex = 2;
            this.sportLabel.Text = "No";
            // 
            // alcolLabel
            // 
            this.alcolLabel.AutoSize = true;
            this.alcolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alcolLabel.Location = new System.Drawing.Point(719, 31);
            this.alcolLabel.Name = "alcolLabel";
            this.alcolLabel.Size = new System.Drawing.Size(28, 18);
            this.alcolLabel.TabIndex = 3;
            this.alcolLabel.Text = "No";
            // 
            // smokeLabel
            // 
            this.smokeLabel.AutoSize = true;
            this.smokeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smokeLabel.Location = new System.Drawing.Point(403, 31);
            this.smokeLabel.Name = "smokeLabel";
            this.smokeLabel.Size = new System.Drawing.Size(28, 18);
            this.smokeLabel.TabIndex = 4;
            this.smokeLabel.Text = "No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codFarmacoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fARMACOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(592, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 178);
            this.dataGridView1.TabIndex = 5;
            // 
            // codFarmacoDataGridViewTextBoxColumn
            // 
            this.codFarmacoDataGridViewTextBoxColumn.DataPropertyName = "CodFarmaco";
            this.codFarmacoDataGridViewTextBoxColumn.HeaderText = "CodFarmaco";
            this.codFarmacoDataGridViewTextBoxColumn.Name = "codFarmacoDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // fARMACOBindingSource
            // 
            this.fARMACOBindingSource.DataMember = "FARMACO";
            this.fARMACOBindingSource.DataSource = this.tkDataBaseDataSet;
            // 
            // tkDataBaseDataSet
            // 
            this.tkDataBaseDataSet.DataSetName = "TKDataBaseDataSet";
            this.tkDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEsameDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.eSAMEBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(861, 94);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(246, 178);
            this.dataGridView2.TabIndex = 6;
            // 
            // codEsameDataGridViewTextBoxColumn
            // 
            this.codEsameDataGridViewTextBoxColumn.DataPropertyName = "CodEsame";
            this.codEsameDataGridViewTextBoxColumn.HeaderText = "CodEsame";
            this.codEsameDataGridViewTextBoxColumn.Name = "codEsameDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            // 
            // eSAMEBindingSource
            // 
            this.eSAMEBindingSource.DataMember = "ESAME";
            this.eSAMEBindingSource.DataSource = this.tkDataBaseDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fumatore:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(646, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alcolista:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sportivo:";
            // 
            // fARMACOTableAdapter
            // 
            this.fARMACOTableAdapter.ClearBeforeFill = true;
            // 
            // schedA_CLINICATableAdapter
            // 
            this.schedA_CLINICATableAdapter.ClearBeforeFill = true;
            // 
            // esameTableAdapter
            // 
            this.esameTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codPazienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn2,
            this.dataDiagnosiDataGridViewTextBoxColumn,
            this.tipologiaDataGridViewTextBoxColumn,
            this.descrizioneDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.pATOLOGIABindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 94);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(544, 178);
            this.dataGridView3.TabIndex = 10;
            // 
            // codPazienteDataGridViewTextBoxColumn
            // 
            this.codPazienteDataGridViewTextBoxColumn.DataPropertyName = "CodPaziente";
            this.codPazienteDataGridViewTextBoxColumn.HeaderText = "CodPaziente";
            this.codPazienteDataGridViewTextBoxColumn.Name = "codPazienteDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn2
            // 
            this.nomeDataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn2.Name = "nomeDataGridViewTextBoxColumn2";
            // 
            // dataDiagnosiDataGridViewTextBoxColumn
            // 
            this.dataDiagnosiDataGridViewTextBoxColumn.DataPropertyName = "DataDiagnosi";
            this.dataDiagnosiDataGridViewTextBoxColumn.HeaderText = "DataDiagnosi";
            this.dataDiagnosiDataGridViewTextBoxColumn.Name = "dataDiagnosiDataGridViewTextBoxColumn";
            // 
            // tipologiaDataGridViewTextBoxColumn
            // 
            this.tipologiaDataGridViewTextBoxColumn.DataPropertyName = "Tipologia";
            this.tipologiaDataGridViewTextBoxColumn.HeaderText = "Tipologia";
            this.tipologiaDataGridViewTextBoxColumn.Name = "tipologiaDataGridViewTextBoxColumn";
            // 
            // descrizioneDataGridViewTextBoxColumn
            // 
            this.descrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.Name = "descrizioneDataGridViewTextBoxColumn";
            // 
            // pATOLOGIABindingSource
            // 
            this.pATOLOGIABindingSource.DataMember = "PATOLOGIA";
            this.pATOLOGIABindingSource.DataSource = this.tkDataBaseDataSet;
            // 
            // patologiaTableAdapter
            // 
            this.patologiaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(903, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Annulla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClinicalCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1128, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.smokeLabel);
            this.Controls.Add(this.alcolLabel);
            this.Controls.Add(this.sportLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClinicalCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teeth Keeper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClinicalCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSAMEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATOLOGIABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label sportLabel;
        private System.Windows.Forms.Label alcolLabel;
        private System.Windows.Forms.Label smokeLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private TKDataBaseDataSetTableAdapters.FARMACOTableAdapter fARMACOTableAdapter;
        private TKDataBaseDataSetTableAdapters.SCHEDA_CLINICATableAdapter schedA_CLINICATableAdapter;
        private TKDataBaseDataSetTableAdapters.ESAMETableAdapter esameTableAdapter;
        private TKDataBaseDataSet tkDataBaseDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFarmacoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fARMACOBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEsameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource eSAMEBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private TKDataBaseDataSetTableAdapters.PATOLOGIATableAdapter patologiaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPazienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDiagnosiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipologiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pATOLOGIABindingSource;
        private System.Windows.Forms.Button button1;
    }
}
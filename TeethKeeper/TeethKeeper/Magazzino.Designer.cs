namespace TeethKeeper
{
    partial class Magazzino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Magazzino));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezzoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTTREZZATURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tKDataBaseDataSet = new TeethKeeper.TKDataBaseDataSet();
            this.Cerca = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cerca2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.aTTREZZATURATableAdapter = new TeethKeeper.TKDataBaseDataSetTableAdapters.ATTREZZATURATableAdapter();
            this.codiceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezzoUnitarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTREZZATURABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codiceDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.prezzoUnitarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aTTREZZATURABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codiceDataGridViewTextBoxColumn
            // 
            this.codiceDataGridViewTextBoxColumn.DataPropertyName = "Codice";
            this.codiceDataGridViewTextBoxColumn.HeaderText = "Codice";
            this.codiceDataGridViewTextBoxColumn.Name = "codiceDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // prezzoUnitarioDataGridViewTextBoxColumn
            // 
            this.prezzoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "Prezzo_Unitario";
            this.prezzoUnitarioDataGridViewTextBoxColumn.HeaderText = "Prezzo_Unitario";
            this.prezzoUnitarioDataGridViewTextBoxColumn.Name = "prezzoUnitarioDataGridViewTextBoxColumn";
            // 
            // aTTREZZATURABindingSource
            // 
            this.aTTREZZATURABindingSource.DataMember = "ATTREZZATURA";
            this.aTTREZZATURABindingSource.DataSource = this.tKDataBaseDataSet;
            // 
            // tKDataBaseDataSet
            // 
            this.tKDataBaseDataSet.DataSetName = "TKDataBaseDataSet";
            this.tKDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cerca
            // 
            this.Cerca.Location = new System.Drawing.Point(551, 58);
            this.Cerca.Name = "Cerca";
            this.Cerca.Size = new System.Drawing.Size(75, 23);
            this.Cerca.TabIndex = 1;
            this.Cerca.Text = "Cerca";
            this.Cerca.UseVisualStyleBackColor = true;
            this.Cerca.Click += new System.EventHandler(this.Cerca_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(551, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "\r\n";
            // 
            // Cerca2
            // 
            this.Cerca2.Location = new System.Drawing.Point(562, 327);
            this.Cerca2.Name = "Cerca2";
            this.Cerca2.Size = new System.Drawing.Size(75, 23);
            this.Cerca2.TabIndex = 3;
            this.Cerca2.Text = "Cerca";
            this.Cerca2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codiceDataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn1,
            this.prezzoUnitarioDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.aTTREZZATURABindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(43, 327);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(472, 150);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Appunti per Rifornimenti";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Magazzino";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(562, 356);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(811, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Menù";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aTTREZZATURATableAdapter
            // 
            this.aTTREZZATURATableAdapter.ClearBeforeFill = true;
            // 
            // codiceDataGridViewTextBoxColumn1
            // 
            this.codiceDataGridViewTextBoxColumn1.DataPropertyName = "Codice";
            this.codiceDataGridViewTextBoxColumn1.HeaderText = "Codice";
            this.codiceDataGridViewTextBoxColumn1.Name = "codiceDataGridViewTextBoxColumn1";
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            // 
            // prezzoUnitarioDataGridViewTextBoxColumn1
            // 
            this.prezzoUnitarioDataGridViewTextBoxColumn1.DataPropertyName = "Prezzo_Unitario";
            this.prezzoUnitarioDataGridViewTextBoxColumn1.HeaderText = "Prezzo_Unitario";
            this.prezzoUnitarioDataGridViewTextBoxColumn1.Name = "prezzoUnitarioDataGridViewTextBoxColumn1";
            // 
            // Magazzino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(946, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Cerca2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Cerca);
            this.Controls.Add(this.dataGridView1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Magazzino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazzino";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Magazzino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTREZZATURABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TKDataBaseDataSet tKDataBaseDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Cerca;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Cerca2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource aTTREZZATURABindingSource;
        private TKDataBaseDataSetTableAdapters.ATTREZZATURATableAdapter aTTREZZATURATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezzoUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezzoUnitarioDataGridViewTextBoxColumn1;
    }
}
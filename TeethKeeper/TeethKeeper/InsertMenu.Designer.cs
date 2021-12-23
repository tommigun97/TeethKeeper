namespace TeethKeeper
{
    partial class InsertMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertMenu));
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cfBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cellBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.roadBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.capBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sexBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cityBornBox = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.pazienteTableAdapter = new TeethKeeper.TKDataBaseDataSetTableAdapters.PAZIENTETableAdapter();
            this.tkDataBaseDataSet1 = new TeethKeeper.TKDataBaseDataSet();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tkDataBaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(54, 107);
            this.nameBox.MaxLength = 20;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 0;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inserimento Paziente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cognome";
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(203, 107);
            this.surnameBox.MaxLength = 30;
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(100, 20);
            this.surnameBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codice Fiscale";
            // 
            // cfBox
            // 
            this.cfBox.Location = new System.Drawing.Point(359, 107);
            this.cfBox.MaxLength = 16;
            this.cfBox.Name = "cfBox";
            this.cfBox.Size = new System.Drawing.Size(100, 20);
            this.cfBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono";
            // 
            // cellBox
            // 
            this.cellBox.Location = new System.Drawing.Point(55, 208);
            this.cellBox.MaxLength = 12;
            this.cellBox.Name = "cellBox";
            this.cellBox.Size = new System.Drawing.Size(100, 20);
            this.cellBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(200, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Via";
            // 
            // roadBox
            // 
            this.roadBox.Location = new System.Drawing.Point(203, 208);
            this.roadBox.MaxLength = 50;
            this.roadBox.Name = "roadBox";
            this.roadBox.Size = new System.Drawing.Size(100, 20);
            this.roadBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(356, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Num. Civico";
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(359, 208);
            this.numBox.MaxLength = 3;
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(100, 20);
            this.numBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(511, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Città Residenza";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(514, 208);
            this.cityBox.MaxLength = 30;
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 20);
            this.cityBox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(656, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "CAP";
            // 
            // capBox
            // 
            this.capBox.Location = new System.Drawing.Point(659, 208);
            this.capBox.MaxLength = 5;
            this.capBox.Name = "capBox";
            this.capBox.Size = new System.Drawing.Size(100, 20);
            this.capBox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(51, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Data Nascita";
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(54, 331);
            this.dateBox.MaxLength = 10;
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(100, 20);
            this.dateBox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(511, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Sesso";
            // 
            // sexBox
            // 
            this.sexBox.Location = new System.Drawing.Point(514, 107);
            this.sexBox.MaxLength = 1;
            this.sexBox.Name = "sexBox";
            this.sexBox.Size = new System.Drawing.Size(100, 20);
            this.sexBox.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(200, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "CIttà Nascita";
            // 
            // cityBornBox
            // 
            this.cityBornBox.Location = new System.Drawing.Point(203, 331);
            this.cityBornBox.MaxLength = 30;
            this.cityBornBox.Name = "cityBornBox";
            this.cityBornBox.Size = new System.Drawing.Size(100, 20);
            this.cityBornBox.TabIndex = 21;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(434, 319);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(154, 43);
            this.insertButton.TabIndex = 23;
            this.insertButton.Text = "Inserisci";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // pazienteTableAdapter
            // 
            this.pazienteTableAdapter.ClearBeforeFill = true;
            // 
            // tkDataBaseDataSet1
            // 
            this.tkDataBaseDataSet1.DataSetName = "TKDataBaseDataSet";
            this.tkDataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(619, 319);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(154, 43);
            this.backButton.TabIndex = 24;
            this.backButton.Text = "Annulla";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // InsertMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cityBornBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sexBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.capBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.roadBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cellBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cfBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserimento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InsertMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkDataBaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cfBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cellBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox roadBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox capBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox sexBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cityBornBox;
        private System.Windows.Forms.Button insertButton;
        private TKDataBaseDataSetTableAdapters.PAZIENTETableAdapter pazienteTableAdapter;
        private TKDataBaseDataSet tkDataBaseDataSet1;
        private System.Windows.Forms.Button backButton;
    }
}
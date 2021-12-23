using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeethKeeper
{
    public partial class Magazzino : Form
    {
        public Magazzino()
        {
            InitializeComponent();
        }

        private void Magazzino_Load(object sender, EventArgs e)
        {
          
            // TODO: questa riga di codice carica i dati nella tabella 'tKDataBaseDataSet.ATTREZZATURA'. È possibile spostarla o rimuoverla se necessario.
            this.aTTREZZATURATableAdapter.FillByToolsAndCapacity(this.tKDataBaseDataSet.ATTREZZATURA);

        }

        private void fillByToolsAndCapacityToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.aTTREZZATURATableAdapter.FillByToolsAndCapacity(this.tKDataBaseDataSet.ATTREZZATURA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolsAndCapacityToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.aTTREZZATURATableAdapter.FillByToolsAndCapacity(this.tKDataBaseDataSet.ATTREZZATURA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            Hide();
        }

        private void Cerca_Click(object sender, EventArgs e)
        {
            if (this.Cerca.Text != "")
            {
                aTTREZZATURATableAdapter.FindTool(this.Cerca.Text);
            }
            else
            {
                aTTREZZATURATableAdapter.Fill(this.tKDataBaseDataSet.ATTREZZATURA);
            }
        }

        private void tKDataBaseDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {
                    }
    }
}

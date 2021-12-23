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
    public partial class AppointementMenu : Form
    {
        private string codFiscale;

        public AppointementMenu(string cod)
        {
            codFiscale = cod;
            InitializeComponent();
        }

        private void AppointementMenu_Load(object sender, EventArgs e)
        {
            aPPUNTAMENTOTableAdapter.FillAppointement(tKDataBaseDataSet.APPUNTAMENTO, codFiscale);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string code = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if(code != null)
            {
                new Treatment(code).Show();
                Hide();
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace TeethKeeper
{
    public partial class ClinicalCard : Form
    {
        private string codFiscale;

        public ClinicalCard(string cod)
        {
            codFiscale = cod;
            InitializeComponent();
        }

        private void ClinicalCard_Load(object sender, EventArgs e)
        {
            fARMACOTableAdapter.FillAssumeMedicine(tkDataBaseDataSet.FARMACO, codFiscale);
            alcolLabel.Text = schedA_CLINICATableAdapter.Alcolism(codFiscale).ToString();
            smokeLabel.Text = schedA_CLINICATableAdapter.Smoker(codFiscale).ToString();
            sportLabel.Text = schedA_CLINICATableAdapter.Sport(codFiscale).ToString();
            nameLabel.Text = schedA_CLINICATableAdapter.Name(codFiscale).ToString();
            surnameLabel.Text = schedA_CLINICATableAdapter.Surname(codFiscale).ToString();
            esameTableAdapter.FillExecutedExam(tkDataBaseDataSet.ESAME, codFiscale);
            patologiaTableAdapter.FillPatologies(tkDataBaseDataSet.PATOLOGIA, codFiscale);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PatientMenu().Show();
            Hide();
        }
    }
}

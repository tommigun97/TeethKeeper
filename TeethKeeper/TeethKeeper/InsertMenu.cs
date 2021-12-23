using System;
using System.Windows.Forms;

namespace TeethKeeper
{
    public partial class InsertMenu : Form
    {

        public InsertMenu()
        {
            InitializeComponent();
        }

        private void InsertMenu_Load(object sender, EventArgs e)
        {

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text.Equals("") || surnameBox.Text.Equals("") || cfBox.Text.Equals("") || cellBox.Text.Equals("") ||
                sexBox.Text.Equals("") || roadBox.Text.Equals("") || numBox.Text.Equals("") || cityBox.Text.Equals("") ||
                capBox.Text.Equals("") || cityBornBox.Text.Equals("") || dateBox.Text.Equals(""))
            {
                MessageBox.Show("Campi vuoti. Riempire", "Errore di inserimento", MessageBoxButtons.OK);
            }
            else
            {
                if(pazienteTableAdapter.checkDuplicate(cfBox.Text) == 0)
                {
                    pazienteTableAdapter.Insert(nameBox.Text, surnameBox.Text, cfBox.Text, cellBox.Text, sexBox.Text,
                    roadBox.Text, Convert.ToInt32(numBox.Text), cityBox.Text, capBox.Text, cityBornBox.Text, Convert.ToDateTime(dateBox.Text));
                    nameBox.ResetText();
                    surnameBox.ResetText();
                    cfBox.ResetText();
                    cellBox.ResetText();
                    sexBox.ResetText();
                    roadBox.ResetText();
                    numBox.ResetText();
                    cityBox.ResetText();
                    capBox.ResetText();
                    cityBornBox.ResetText();
                    dateBox.ResetText();
                    new PatientMenu().Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Paziente già inserito", "Errore di inserimento", MessageBoxButtons.OK);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new PatientMenu().Show();
            Hide();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

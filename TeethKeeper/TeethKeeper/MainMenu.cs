using System;
using System.Windows.Forms;

namespace TeethKeeper
{
    public partial class MainMenu: Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
        }

        private void PatButton_Click(object sender, EventArgs e)
        {
            new PatientMenu().Show();
            Hide();
        }

        private void MagButton_Click(object sender, EventArgs e)
        {
            new Magazzino().Show();
            Hide();
        }
    }
}

namespace CatAsService
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void buscarRa�asToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscaRacas BR = new BuscaRacas();
            BR.ShowDialog();
        }
    }
}
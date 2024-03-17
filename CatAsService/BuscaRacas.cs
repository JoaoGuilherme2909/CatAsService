using CatAsService.api;
using Newtonsoft.Json;

namespace CatAsService
{
    public partial class BuscaRacas : Form
    {
        public BuscaRacas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BuscaRacas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "pelo curto inglês"){
                CatModel resultado = ApiCon.apiGet("bsho");
                MessageBox.Show(resultado.temperament);
            }
            else if (comboBox1.Text == "Maine coon"){
        
            }
        }
    }
}

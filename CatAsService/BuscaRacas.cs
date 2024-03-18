using CatAsService.api;
using Newtonsoft.Json;
using QuickType;

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
                List<BreedsJson> content = ApiCon.apiGet("bsho");
                
                foreach (BreedsJson breed in content)
                {
                    label8.Text = breed.Breeds[0].Temperament;
                    label9.Text = breed.Breeds[0].Origin;
                    label10.Text = breed.Breeds[0].Description;
                }
                
            }
            else if (comboBox1.Text == "Maine coon"){
        
            }
        }
    }
}

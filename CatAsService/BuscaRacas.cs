using CatAsService.api;
using Newtonsoft.Json;
using QuickType;

namespace CatAsService
{
    public partial class BuscaRacas : Form
    {

        BreedsJson raca = new BreedsJson();

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
            if (comboBox1.Text == "pelo curto inglês")
            {
                List<BreedsJson> content = ApiCon.apiGet("bsho");
                raca = content[0];
                foreach (BreedsJson breed in content)
                {
                    label8.Text = breed.Breeds[0].Temperament;
                    label9.Text = breed.Breeds[0].Origin;
                    label10.Text = breed.Breeds[0].Description;
                    
                }

            }
            else if (comboBox1.Text == "Maine coon")
            {
                List<BreedsJson> content = ApiCon.apiGet("mcoo");
                raca = content[0];
                foreach (BreedsJson breed in content)
                {
                    label8.Text = breed.Breeds[0].Temperament;
                    label9.Text = breed.Breeds[0].Origin;
                    label10.Text = breed.Breeds[0].Description;
                    
                }
            }
            else if(comboBox1.Text == "Bengal")
            {
                List<BreedsJson> content = ApiCon.apiGet("beng");
                raca = content[0];
                foreach (BreedsJson breed in content)
                {
                    label8.Text = breed.Breeds[0].Temperament;
                    label9.Text = breed.Breeds[0].Origin;
                    label10.Text = breed.Breeds[0].Description;

                }
            }else if (comboBox1.Text == "Cyprus")
            {
                List<BreedsJson> content = ApiCon.apiGet("cypr");
                raca = content[0];
                foreach (BreedsJson breed in content)
                {
                    label8.Text = breed.Breeds[0].Temperament;
                    label9.Text = breed.Breeds[0].Origin;
                    label10.Text = breed.Breeds[0].Description;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (raca != null)
            {
                List<Favourites> favourites = ApiCon.GetFavourites();
                ApiCon.ApiPost(raca, (favourites.Count + 1).ToString());
            }
            else
            {
                MessageBox.Show("Erro: Não foi selecionada nenhuma raça");
            }
        }
    }
}

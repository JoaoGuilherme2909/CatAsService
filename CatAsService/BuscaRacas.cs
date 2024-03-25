using Newtonsoft.Json;
using api;
using CatAsService.api;

namespace CatAsService
{
    public partial class BuscaRacas : Form
    {

        private BreedsJson raca = new BreedsJson();
        private ApiCon apicon = new ApiCon();

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
                List<BreedsJson> content = apicon.apiGet("bsho");
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
                List<BreedsJson> content = apicon.apiGet("mcoo");
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
                List<BreedsJson> content = apicon.apiGet("beng");
                raca = content[0];
                foreach (BreedsJson breed in content)
                {
                    label8.Text = breed.Breeds[0].Temperament;
                    label9.Text = breed.Breeds[0].Origin;
                    label10.Text = breed.Breeds[0].Description;

                }
            }else if (comboBox1.Text == "Cyprus")
            {
                List<BreedsJson> content = apicon.apiGet("cypr");
                raca = content[0];
                foreach (BreedsJson breed in content)
                {
                    label8.Text = breed.Breeds[0].Temperament;
                    label9.Text = breed.Breeds[0].Origin;
                    label10.Text = breed.Breeds[0].Description;

                }
            }
            else
            {
                MessageBox.Show("Escolha uma raça", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (raca != null)
            {
                List<Favourites> favourites = apicon.GetFavourites();
                apicon.ApiPost(raca, (favourites.Count + 1).ToString());
            }
            else
            {
                MessageBox.Show("Não foi selecionada nenhuma raça", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

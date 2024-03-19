using CatAsService.api;
using QuickType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatAsService
{
    public partial class BuscarRacasFavoritas : Form
    {
        public BuscarRacasFavoritas()
        {
            InitializeComponent();
        }

        private void BuscarRacasFavoritas_Load(object sender, EventArgs e)
        {
            List<Favourites> favourites = ApiCon.GetFavourites();
            List<FavouriteBreeds> FB = new List<FavouriteBreeds>();
            foreach (var item in favourites)
            {
                BreedsJson content = ApiCon.apiGetbyImage(item.ImageId);
                FavouriteBreeds favouriteBreeds = new FavouriteBreeds();
                favouriteBreeds.cat_name = content.Breeds[0].Name;
                favouriteBreeds.image_id = item.ImageId;
                favouriteBreeds.sub_id = item.SubId;
                FB.Add(favouriteBreeds);
            }

            foreach (var item in FB)
            {
                listBox1.Items.Add(item.cat_name);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedIndex);
            ApiCon.DeleteFavourites((listBox1.SelectedIndex + 1).ToString());
        }
    }
}

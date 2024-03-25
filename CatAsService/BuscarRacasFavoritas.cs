using CatAsService.api;
using api;
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

        private ApiCon apicon = new ApiCon();

        public BuscarRacasFavoritas()
        {
            InitializeComponent();
        }

        private void BuscarRacasFavoritas_Load(object sender, EventArgs e)
        {
            List<Favourites> favourites = apicon.GetFavourites();
            List<FavouriteBreeds> FB = new List<FavouriteBreeds>();
            if (favourites.Count >= 0)
            {
                
                foreach (var item in favourites)
                {
                    BreedsJson content = apicon.apiGetbyImage(item.ImageId);
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count >= 0)
            {
                var selectedItems = listBox1.SelectedItems;
                foreach (string s in listBox1.SelectedItems.OfType<string>().ToList())
                {
                    listBox1.Items.Remove(s);
                }
                apicon.DeleteFavourites((listBox1.SelectedIndex + 1).ToString());
            }
        }
    }
}

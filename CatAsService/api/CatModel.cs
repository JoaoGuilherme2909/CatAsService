namespace api
{

    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;


    public partial class BreedsJson
    {
        [JsonProperty("breeds")]
        public List<Breed> Breeds { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }

    public partial class Breed
    {

       [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("temperament")]
        public string Temperament { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class FavouriteBreeds {
        
        public string image_id { get; set; }
        public string cat_name { get; set; }
        public string sub_id { get; set;}

    }

    public partial class Favourites
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("image_id")]
        public string ImageId { get; set; }

        [JsonProperty("sub_id")]
        public string SubId { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

}

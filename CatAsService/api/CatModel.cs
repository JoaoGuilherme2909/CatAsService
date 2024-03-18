namespace QuickType
{

    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;


    public partial class BreedsJson
    {
        [JsonProperty("breeds")]
        public List<Breed> Breeds { get; set; }
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

    
}

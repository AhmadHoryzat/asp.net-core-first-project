using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace AspWebApplication1.wwwroot.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Makder { get; set; }
        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Rating { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);

    }
}

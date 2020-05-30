using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SwapUp.Model
{
    public class Product
    {
        public string Id { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        public string Href { get; set; }

        public string Title { get; set; }
    }
}
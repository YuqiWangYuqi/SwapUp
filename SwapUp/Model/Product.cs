using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SwapUp.Model
{
    /*
     * this class is the product list attributes to list on the 
     * main page as user uploaded items
     */
    public class Product
    {
        //item ID
        public string Id { get; set; }
        //Item image from json file
        [JsonPropertyName("img")]
        public string Image { get; set; }
        //Item referrence link
        public string Href { get; set; }
        //Item title
        public string Title { get; set; }

        public int[] Ratings { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
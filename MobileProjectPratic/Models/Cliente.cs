using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileProjectPratic.Models
{
    public class Cliente
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("endereco")]
        public string Endereco { get; set; }
    }
}

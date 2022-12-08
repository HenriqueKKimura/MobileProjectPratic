using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileProjectPratic.Models
{
   public class Clientes
    {
        [JsonProperty("pagina")]
        public int pagina { get; set; }

        [JsonProperty("cli")]
        public List<Cliente> cliente { get; set; }

        public Clientes()
        {
            cliente = new List<Cliente>();
        }
    }
}

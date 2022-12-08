using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileProjectPratic.Models
{
   public class UserCredential
    {
        [JsonProperty("CPF")]
        public string Cpf { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }
    }
}

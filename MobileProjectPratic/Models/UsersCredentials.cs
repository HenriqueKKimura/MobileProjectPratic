using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileProjectPratic.Models
{
   public class UsersCredentials
    {
        [JsonProperty("Usuarios")]
        public List<UserCredential> Usuario { get; set; }

        public UsersCredentials()
        {
            Usuario = new List<UserCredential>();
        }
    }
}

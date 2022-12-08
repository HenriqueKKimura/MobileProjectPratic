using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileProjectPratic.Models
{
    public class EmpresaResponse
    {
        // Informações Empresa //

        [JsonProperty("cnpj")]

        public string Cnpj { get; set; }
        [JsonProperty("nome")]

        public string Nome { get; set; }
        [JsonProperty("fantasia")]

        public string Fantasia { get; set; }
        [JsonProperty("logradouro")]

        public string Logradouro { get; set; }
        [JsonProperty("numero")]

        public string Numero { get; set; }
        [JsonProperty("complemento")]

        public string Complemento { get; set; }
        [JsonProperty("cep")]

        public string Cep { get; set; }
        [JsonProperty("bairro")]

        public string Bairro { get; set; }
        [JsonProperty("municipio")]

        public string Municipio { get; set; }
        [JsonProperty("uf")]

        public string Uf { get; set; }

        // Informações de Contato //
        [JsonProperty("nome_rep_legal")]
        public string Nome_Rep_Legal { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("telefone")]
        public string Telefone { get; set; }



        //IE só está disponível na Sintegra, Porém implementação é Complexa, necessita de mais conhecimento.
        [JsonProperty("inscricaoestadual")]
        public string InscricaoEstadual { get; set; }
    }
}

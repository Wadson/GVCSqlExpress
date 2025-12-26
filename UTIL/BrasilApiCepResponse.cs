using System.Text.Json.Serialization;

namespace GVC.UTIL
{
    public class BrasilApiCepResponse
    {    /// <summary>
         /// Modelo de resposta da BrasilAPI (API oficial do governo)
         /// </summary>
        public class BrasilApiResponse
        {
            [JsonPropertyName("cep")]
            public string Cep { get; set; } = string.Empty;

            [JsonPropertyName("state")]
            public string Estado { get; set; } = string.Empty;

            [JsonPropertyName("city")]
            public string Cidade { get; set; } = string.Empty;

            [JsonPropertyName("neighborhood")]
            public string Bairro { get; set; } = string.Empty;

            [JsonPropertyName("street")]
            public string Logradouro { get; set; } = string.Empty;

            [JsonPropertyName("service")]
            public string Servico { get; set; } = string.Empty;

            // Propriedade calculada para sigla do estado (últimos 2 caracteres)
            [JsonIgnore]
            public string SiglaEstado =>
                Estado?.Length > 2 ? Estado.Substring(Estado.Length - 2) : Estado;

            // Verifica se a resposta é válida
            [JsonIgnore]
            public bool EhValido =>
                !string.IsNullOrWhiteSpace(Cep) &&
                !string.IsNullOrWhiteSpace(Cidade);

            // Formata o CEP para exibição
            [JsonIgnore]
            public string CepFormatado => FormatarCep(Cep);

            private static string FormatarCep(string cep)
            {
                if (string.IsNullOrWhiteSpace(cep) || cep.Length != 8)
                    return cep;

                return $"{cep.Substring(0, 5)}-{cep.Substring(5, 3)}";
            }
        }
    }
}

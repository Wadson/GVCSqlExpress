using Krypton.Toolkit;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using static GVC.UTIL.BrasilApiCepResponse;

namespace GVC.UTIL
{
    public static class CepService
    {
        private static readonly HttpClient _httpClient = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(15)
        };

        /// <summary>
        /// Busca endereço pelo CEP usando a BrasilAPI
        /// </summary>
        public static async Task<BrasilApiResponse> BuscarEnderecoPorCepAsync(string cep)
        {
            // Validação básica
            if (!ValidarCep(cep))
            {
                return new BrasilApiResponse();
            }

            try
            {
                string cepLimpo = LimparCep(cep);
                string url = $"https://brasilapi.com.br/api/cep/v1/{cepLimpo}";

                // Faz a requisição
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    var resultado = JsonSerializer.Deserialize<BrasilApiResponse>(json, options);

                    return resultado ?? new BrasilApiResponse();
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    // CEP não encontrado
                    return new BrasilApiResponse();
                }
                else
                {
                    // Outro erro HTTP
                    Console.WriteLine($"Erro HTTP {response.StatusCode} ao buscar CEP {cep}");
                    return new BrasilApiResponse();
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Erro de conexão ao buscar CEP {cep}: {ex.Message}");
                return new BrasilApiResponse();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado ao buscar CEP {cep}: {ex.Message}");
                return new BrasilApiResponse();
            }
        }

        /// <summary>
        /// Valida se um CEP tem formato correto
        /// </summary>
        public static bool ValidarCep(string cep)
        {
            cep = LimparCep(cep);
            return cep.Length == 8 && long.TryParse(cep, out _);
        }

        /// <summary>
        /// Limpa o CEP, mantendo apenas números
        /// </summary>
        public static string LimparCep(string cep)
        {
            if (string.IsNullOrWhiteSpace(cep))
                return string.Empty;

            return new string(cep.Where(char.IsDigit).ToArray());
        }

        /// <summary>
        /// Formata o CEP no padrão 00000-000
        /// </summary>
        public static string FormatarCep(string cep)
        {
            string cepLimpo = LimparCep(cep);

            if (cepLimpo.Length != 8)
                return cep;

            return $"{cepLimpo.Substring(0, 5)}-{cepLimpo.Substring(5, 3)}";
        }

        /// <summary>
        /// Valida e formata CEP em um TextBox
        /// </summary>
        public static bool ValidarEFormatarCEPnoTextbox(KryptonTextBox txtCep)
        {
            if (txtCep == null || txtCep.IsDisposed)
                return false;

            string cepLimpo = LimparCep(txtCep.Text);

            if (!ValidarCep(cepLimpo))
            {
                // Visualização de erro
                if (txtCep.InvokeRequired)
                {
                    txtCep.Invoke(new Action(() =>
                    {
                        txtCep.ForeColor = Color.Red;
                    }));
                }
                else
                {
                    txtCep.ForeColor = Color.Red;
                }
                return false;
            }

            // Formata o CEP
            string cepFormatado = FormatarCep(cepLimpo);

            if (txtCep.InvokeRequired)
            {
                txtCep.Invoke(new Action(() =>
                {
                    txtCep.Text = cepFormatado;
                    txtCep.ForeColor = Color.Black;
                    txtCep.SelectionStart = txtCep.Text.Length;
                }));
            }
            else
            {
                txtCep.Text = cepFormatado;
                txtCep.ForeColor = Color.Black;
                txtCep.SelectionStart = txtCep.Text.Length;
            }

            return true;
        }

        /// <summary>
        /// Testa a conexão com a BrasilAPI
        /// </summary>
        public static async Task<bool> TestarConexao()
        {
            try
            {
                using (var client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) })
                {
                    var response = await client.GetAsync("https://brasilapi.com.br/api/cep/v1/01001000");
                    return response.IsSuccessStatusCode;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}


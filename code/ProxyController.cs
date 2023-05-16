using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

public class ParametrosController : ApiController
{
    [HttpPost]
    [Route("api/parametros")]
    public async Task<IHttpActionResult> ObterParametrosERealizarRequisicao()
    {
        Dictionary<string, string> parametros = new Dictionary<string, string>();

        // Obter os parâmetros da requisição
        foreach (var param in Request.GetQueryNameValuePairs())
        {
            parametros.Add(param.Key, param.Value);
        }

        // Obter a rota atual
        string rotaAtual = Request.RequestUri.AbsolutePath;

        // Obter o verbo HTTP da requisição original
        HttpMethod verboHttp = Request.Method;

        // Realizar uma nova requisição com as mesmas informações
        using (HttpClient httpClient = new HttpClient())
        {
            // Construir a URL da nova requisição
            string urlNovaRequisicao = "http://sua-url-api" + rotaAtual;

            // Criar um objeto StringContent com o corpo da requisição original
            string corpoRequisicao = await Request.Content.ReadAsStringAsync();
            StringContent conteudo = new StringContent(corpoRequisicao, System.Text.Encoding.UTF8, "application/json");

            // Criar a nova requisição com o verbo HTTP e o conteúdo
            HttpRequestMessage novaRequisicao = new HttpRequestMessage(verboHttp, urlNovaRequisicao);
            novaRequisicao.Content = conteudo;

            // Enviar a nova requisição
            HttpResponseMessage response = await httpClient.SendAsync(novaRequisicao);

            // Ler a resposta como uma string
            string resposta = await response.Content.ReadAsStringAsync();

            // Retornar a resposta da nova requisição
            return Ok(resposta);
        }
    }
}

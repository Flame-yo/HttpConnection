using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequisitionTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            await Post();
        }


        public static async Task Post()
        {
            var httpClient = new HttpClient();

            var objeto = new { nome = "GustavoHenriqueFrançaFernandesSouza", email = "gustavohffs@gmail.com", cpf = 19002579713 };

            var content = ToRequest(objeto);

            var response = await httpClient.PostAsync("https://tranquil-rex-405218.rj.r.appspot.com/hashCodeServer?nome=GustavoHenriqueFrançaFernandesSouza&email=gustavohffs@gmail.com&cpf=190.025.797-13", content);
        }

        private static StringContent ToRequest(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            return data;
        }
    }
}

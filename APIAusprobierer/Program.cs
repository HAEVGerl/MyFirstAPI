using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace APIAusprobierer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           await abx();



        }

        private static async Task abx()
        {
            var client = new System.Net.Http.HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync("https://api.thecatapi.com/v1/images/search");
            var json = await response.Content.ReadAsStringAsync();


            var setting = new JsonSerializerSettings
            {
                MissingMemberHandling =  MissingMemberHandling.Ignore
            };

          
            var catarray = JsonConvert.DeserializeObject<CatModel[]>(json, setting);
            var cat = catarray[0];

            var options = new System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault,
                nul
            };

            var abc = System.Text.Json.JsonSerializer.Deserialize<CatModel[]>(json, options);
           
        } 
    }
}

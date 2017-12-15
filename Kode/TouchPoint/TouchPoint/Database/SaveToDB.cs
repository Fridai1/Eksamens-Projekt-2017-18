using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace TouchPoint.Database {
    public class SaveToDB<T> where T : ISaveable {
        private HttpClientHandler _handler;

        public SaveToDB() {
            _handler = new HttpClientHandler();
            _handler.UseDefaultCredentials = true;
        }
        
        
        public async Task Save(int id, T item, string table) {
            using(var client = new HttpClient(_handler, false)) {
                client.BaseAddress = new Uri(_GLOBALS.ServerUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string serialised = JsonConvert.SerializeObject(item);
                StringContent content = new StringContent(serialised, Encoding.UTF8, "application/json");
                string pluralised = table + "s";

                if (item.Id == 0) {
                    await client.PostAsync($"api/{pluralised}", content);
                } else {
                    await client.PutAsync($"api/{pluralised}/{item.Id}", content);
                }
            }
        }
    }
}

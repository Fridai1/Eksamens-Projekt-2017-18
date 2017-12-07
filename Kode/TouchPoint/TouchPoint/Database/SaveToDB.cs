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
        
        
        public async Task Save(T item) {
            using(var client = new HttpClient(_handler)) {
                client.BaseAddress = new Uri(_GLOBALS.ServerUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string serialised = JsonConvert.SerializeObject(item);
                StringContent content = new StringContent(serialised, Encoding.UTF8, " ");
                string pluralised = typeof(T).Name + "s";

                if (item.Id == -1) {
                    await client.PostAsync($"{client.BaseAddress}/{pluralised}", content);
                } else {
                    await client.PutAsync($"{client.BaseAddress}/{pluralised}/{item.Id}", content);
                }
            }
        }
    }
}

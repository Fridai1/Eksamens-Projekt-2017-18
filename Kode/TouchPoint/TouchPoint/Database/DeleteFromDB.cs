using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace TouchPoint.Database {
    public class DeleteFromDB<T> where T : ISaveable {
        private HttpClientHandler _handler;

        public DeleteFromDB() {
            _handler = new HttpClientHandler();
            _handler.UseDefaultCredentials = true;
        }


        public async Task DeleteSingle(int id, string table) {
            using (var client = new HttpClient(_handler, false)) {
                client.BaseAddress = new Uri(_GLOBALS.ServerUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string pluralised = table + "s";

                Task<HttpResponseMessage> response = client.DeleteAsync($"api/{pluralised}/{id}");
                await response;
            }
        }
    }
}

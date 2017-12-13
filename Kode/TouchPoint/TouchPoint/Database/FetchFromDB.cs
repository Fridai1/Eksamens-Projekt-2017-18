using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TouchPoint.Database {
    public class FetchFromDB<T> where T : ISaveable {
        private HttpClientHandler _handler;

        public FetchFromDB() {
            _handler = new HttpClientHandler();
            _handler.UseDefaultCredentials = true;
        }


        public async Task<T> FetchSingle(string table, int id) {
            table = PluraliseTableName(table);

            using (var client = new HttpClient(_handler)) {
                client.BaseAddress = new Uri(_GLOBALS.ServerUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                Task<HttpResponseMessage> response = client.GetAsync($"api/{table}/{id}");
                await response;

                if(response.Result.IsSuccessStatusCode) {
                    Task<T> read = response.Result.Content.ReadAsAsync<T>();
                    await read;
                    return read.Result;
                }
                return default(T);
            }
        }

        public async Task<List<T>> FetchMultiple(string table) {
            table = PluraliseTableName(table);

            using (var client = new HttpClient(_handler)) {
                client.BaseAddress = new Uri(_GLOBALS.ServerUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                Task<HttpResponseMessage> response = client.GetAsync($"api/{table}");
                await response;

                if(response.Result.IsSuccessStatusCode) {
                    Task<IEnumerable<T>> read = response.Result.Content.ReadAsAsync<IEnumerable<T>>();
                    await read;
                    return read.Result.ToList();
                }
                return null;
            }
        }

        //pluralise
        public string PluraliseTableName(string table) {
            table += "s";
            return table;
        }
    }
}

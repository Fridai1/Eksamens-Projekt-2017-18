using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TouchPoint.Database {
    public class DatabaseFacade<T> where T : ISaveable {
        //instance fields
        public static string _serverUrl;
        public static string _apiId;
        public static string _apiPrefix;
        public static HttpClientHandler _httpClientHandler;
        public static HttpClient _httpClient;

        //constructor
        public DatabaseFacade(string serverUrl, string apiId, string apiPrefix) {
            _serverUrl = serverUrl;
            _apiId = apiId;
            _apiPrefix = apiPrefix;
            _httpClientHandler = new HttpClientHandler();
            _httpClientHandler.UseDefaultCredentials = true;
            _httpClient = new HttpClient(_httpClientHandler);
            _httpClient.BaseAddress = new Uri(_serverUrl);
        }

        //SaveSingle
        public async Task SaveSingle(int id, T item) {
            await SaveToDB<T>.Save(item);
        }

        //LoadSingle
        public async Task<T> LoadSingle(string table, int id) {

            return await FetchFromDB<T>.FetchSingle(table, id);
        }

        //LoadMultiple
        public async Task<List<T>> LoadMultiple(string table) {
            return await FetchFromDB<T>.FetchMultiple(table);
        }
        //Delete
        //not implemented
    }
}

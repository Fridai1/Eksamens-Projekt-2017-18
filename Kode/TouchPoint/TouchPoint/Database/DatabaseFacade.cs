using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TouchPoint.Database {
    public class DatabaseFacade<T> {
        //instance fields
        private string _serverUrl;
        private string _apiId;
        private string _apiPrefix;
        private HttpClientHandler _httpClientHandler;
        private HttpClient _httpClient;

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
        //public async Task SaveSingle(int id, T item) {
        //    await SaveToDB.Save(item);
        //}

        ////LoadSingle
        //public async Task<T> LoadSingle(string table, int id) {
        //    return await FetchFromDB.FetchSingle(table, id);
        //}

        ////LoadMultiple
        //public async Task<List<T>> LoadMultiple(string table) {
        //    return await FetchFromDB.FetchMultiple(table);
        //}
        //Delete
        //not implemented
    }
}

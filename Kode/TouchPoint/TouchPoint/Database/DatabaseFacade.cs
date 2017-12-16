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
        SaveToDB<T> save = new SaveToDB<T>();
        FetchFromDB<T> fetch = new FetchFromDB<T>();
        DeleteFromDB<T> delete = new DeleteFromDB<T>();

        //constructor
        public DatabaseFacade() {
            
        }

        //SaveSingle
        public async Task SaveSingle(int id, T item, string table) {
            await save.Save(id, item, table);
        }

        //LoadSingle
        public async Task<T> LoadSingle(string table, int id) {
            return await fetch.FetchSingle(table, id);
        }

        //LoadMultiple
        public async Task<List<T>> LoadMultiple(string table) {
            return await fetch.FetchMultiple(table);
        }

        //Delete
        public async Task DeleteSingle(int id, string table) {
           await delete.DeleteSingle(id, table);
        }



    }
}

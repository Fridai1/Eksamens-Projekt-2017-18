using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchPoint.Database {
    public static class FetchFromDB<T> where T : ISaveable {
        public static Task<T> FetchSingle(string table, int id) {
            throw new NotImplementedException();
        }

        public static Task<T> FetchMultiple(string table) {
            throw new NotImplementedException();
        }
    }
}

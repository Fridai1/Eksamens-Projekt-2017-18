using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchPoint.Database {
    public static class FetchFromDB<T> where T : ISaveable {
        public static T FetchSingle(string table, int id) {
            throw new NotImplementedException();
        }

        public static List<T> FetchMultiple(string table) {
            throw new NotImplementedException();
        }
    }
}

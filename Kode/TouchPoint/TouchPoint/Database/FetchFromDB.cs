using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchPoint.Database {
    public class FetchFromDB<T> where T : ISaveable {
        public T FetchSingle(string table, int id) {
            throw new NotImplementedException();
        }

        public List<T> FetchMultiple() {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchPoint.Database {
    class SaveToDB<T> where T : ISaveable {
        public void Save(T item) {
            string query = "";

            if(item.Id == -1) {
                query += "INSERT INTO ";
            } else {
                query += "UPDATE ";
            }
            query += FormatObjToStringPlural(item);
            query += " VALUES ";
            query += item.PropertyString();

            //put into db

        }


        //public string FormatPropertiesToSQLInsert(T item) {
        //    string query = "INSERT INTO ";
        //    return query;
        //}

        //public string FormatPropertiesToSQLUpdate() {
        //    string query = "UPDATE ";
        //    return query;
        //}

        public string FormatObjToStringPlural(T item) {
            string tableName = item.GetType().ToString();
            tableName += "s";
            return tableName;
        }
    }
}

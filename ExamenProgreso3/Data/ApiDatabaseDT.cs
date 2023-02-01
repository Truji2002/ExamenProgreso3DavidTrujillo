using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenProgreso3.Models;

namespace ExamenProgreso3.Data
{
    public class ApiDatabaseDT

    {
        string _dbPath;
        private SQLiteConnection conn;
        public ApiDatabaseDT(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<APIDT>();
        }
        //
        //List<APIDT>
        public int AddNew(List<APIDT> listApis)
        {
            Init();
            //int result = conn.Insert(burger);
            //return result;
            //return.conn.Ins
            
            
            return conn.Insert(listApis);
            
        }
        public int AddNewB(APIDT api)
        {
            Init();
            //int result = conn.Insert(burger);
            //return result;
            if (api.Id != 0)
            {
                return conn.Update(api);
            }
            else
            {
                return conn.Insert(api);
            }
        }
        public List<APIDT> GetAllB()
        {
            Init();
            List<APIDT> burgers = conn.Table<APIDT>().ToList();
            return burgers;
        }
        public int Delete(APIDT item)
        {
            Init();
            return conn.Delete(item);
        }
    }
}

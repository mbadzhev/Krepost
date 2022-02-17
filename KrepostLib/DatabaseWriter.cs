using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrepostLib
{
    public static class DatabaseWriter
    {
        public static object CreateDatabase()
        {
            // TODO: Complete implementation
            Database db = new Database();
            DatabaseHead dbHead = new DatabaseHead();
            dbHead.hashId = "SHA256";
            dbHead.accessHash = "passwordhash";
            dbHead.cipherId = "AES256";
            dbHead.databaseIv = "myIv";
            dbHead.integrityHash = "jhfguuhtrkjk";
            db.Items = dbHead;
            return db;
        }
    }
}

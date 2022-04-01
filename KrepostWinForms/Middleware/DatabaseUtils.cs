using KrepostLib.Storage;

namespace KrepostWinForms.Middleware
{
    internal class DatabaseUtils
    {
        public static DatabaseEntry? FindEntry(string uuid, Database db)
        {
            DatabaseEntry? entry = db.Body.EntryList.Find(x => x.Uid == uuid);
            if (entry == null)
                return null;
            return entry;
        }
        public static DatabaseEntry? FindEntry(TreeNode trn, Database db)
        {
            DatabaseEntry? entry = db.Body.EntryList.Find(x => x.Uid == (string)trn.Tag);
            if (entry == null)
                return null;
            return entry;
        }
    }
}

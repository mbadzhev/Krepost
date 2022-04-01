using KrepostLib.Storage;

namespace KrepostWinForms.Middleware
{
    internal class DisplayUtils
    {
        /// <summary>
        /// Clears the <see cref="TreeView"/> and fills it with every <see cref="DatabaseEntry"/> present in the <see cref="Database"/>.
        /// </summary>
        /// <param name="trv">The <see cref="TreeView"/> to be modified.</param>
        /// <param name="db">The <see cref="Database"/> to get the entries from.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void DisplayEntryList(TreeView trv, Database db)
        {
            if (trv == null)
                throw new ArgumentNullException();
            if (db == null)
                throw new ArgumentNullException();

            trv.Nodes.Clear();

            trv.Nodes.Add("passwords", "Passwords");
            foreach (var item in db.Body.EntryList)
            {
                TreeNode trn = new TreeNode();
                trn.Text = item.Title;
                trn.Tag = item.Uid;
                trv.Nodes["passwords"].Nodes.Add(trn);
            }
        }
        public static void DisplayEntryHeader(TreeNode trn, Database db, Label title, Label doC, Label doM)
        {
            DatabaseEntry? entry = db.Body.EntryList.Find(x => x.Uid == (string)trn.Tag);
            if (entry == null)
                return;

            title.Text = entry.Title;
            doC.Text = entry.DateCreated;
            doM.Text = entry.DateModified;
        }
    }
}

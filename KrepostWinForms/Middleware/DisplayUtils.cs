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
        /// <summary>
        /// Extracts title and dates from a <see cref="DatabaseEntry"/> and displays it in the correct controls.
        /// </summary>
        /// <param name="trn"><see cref="TreeNode"/> that represents the <see cref="DatabaseEntry"/> to be accessed.</param>
        /// <param name="db"><see cref="Database"/> that contains the <see cref="DatabaseEntry"/> to be accessed.</param>
        /// <param name="title"><see cref="Label"/> that will display the entry's title.</param>
        /// <param name="doC"><see cref="Label"/>that will display the entry's creation date.</param>
        /// <param name="doM"><see cref="Label"/>that will display the entry's midification date.</param>
        /// <returns>True, if the entry was found and task completed, false if the entry was not found.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool DisplayEntryHeader(TreeNode trn, Database db, Label title, Label doC, Label doM)
        {
            if (trn == null)
                throw new ArgumentNullException();
            if (db == null)
                throw new ArgumentNullException();
            if (title == null)
                throw new ArgumentNullException();
            if (doC == null)
                throw new ArgumentNullException();
            if (doM == null)
                throw new ArgumentNullException();

            // Find the selected entry.
            DatabaseEntry? entry = DatabaseUtils.FindEntry(trn, db);
            if (entry == null)
                return false;

            // Mark this entry as the currently selected.
            Program.SelectedEntry = entry;

            // Format the dates for readability.
            // DateTime is stored in the format "yyyyMMddHHmmssffff"
            // Final string is in the format "Created: 01/01/0001, 01:01:01"
            string dateC = entry.DateCreated;
            string dateM = entry.DateModified;
            string dateCFormat = String.Format("Created: {0}{1}/{2}{3}/{4}{5}{6}{7}, {8}{9}:{10}{11}:{12}{13}",
                dateC[6], dateC[7], dateC[4], dateC[5], dateC[0], dateC[1], dateC[2], dateC[3],
                dateC[8], dateC[9], dateC[10], dateC[11], dateC[12], dateC[13]);
            string dateMFormat = String.Format("Modified: {0}{1}/{2}{3}/{4}{5}{6}{7}, {8}{9}:{10}{11}:{12}{13}",
                dateM[6], dateM[7], dateM[4], dateM[5], dateM[0], dateM[1], dateM[2], dateM[3],
                dateM[8], dateM[9], dateM[10], dateM[11], dateM[12], dateM[13]);

            // Assign values to display
            title.Text = entry.Title;
            doC.Text = dateCFormat;
            doM.Text = dateMFormat;

            return true;
        }
    }
}

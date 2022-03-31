﻿using KrepostLib.Storage;

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
                trv.Nodes["passwords"].Nodes.Add(item.Title);
            }
        }
    }
}
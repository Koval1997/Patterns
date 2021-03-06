﻿using Patterns.Ex05.ExternalLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex05.SubEx_02
{
    class DatabaseSaverListener
    {
        private readonly IDatabaseSaver databaseSaver;
        public event EventHandler DataSaved;
        public DatabaseSaverListener(IDatabaseSaver databaseSaver)
        {
            this.databaseSaver = databaseSaver;
        }

        protected virtual void OnDataSaved()
        {
            DataSaved?.Invoke(this, EventArgs.Empty);
        }

        public void SaveData(object data)
        {
            this.databaseSaver.SaveData(data);
            OnDataSaved();
        }
    }
}

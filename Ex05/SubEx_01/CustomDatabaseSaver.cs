using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Ex05.ExternalLibs;

namespace Patterns.Ex05.SubEx_01
{
    class CustomDatabaseSaver : IDatabaseSaver
    {
        private IDatabaseSaver saver;
        public CustomDatabaseSaver(IDatabaseSaver saver)
        {
            this.saver = saver;
        }
        public void SaveData(object data)
        {
            this.saver.SaveData(data);
        }
    }
}

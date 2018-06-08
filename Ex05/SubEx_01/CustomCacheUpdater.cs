﻿using Patterns.Ex05.ExternalLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex05.SubEx_01
{
    class CustomCacheUpdater : CustomDatabaseSaver
    {
        private CacheUpdater cacheUpdater;
        public CustomCacheUpdater(IDatabaseSaver saver, CacheUpdater cacheUpdater) : base(saver)
        {
            this.cacheUpdater = cacheUpdater;
        }
        public new void SaveData(object data)
        {
            base.SaveData(data);
            this.cacheUpdater.UpdateCache();
        }
    }
}

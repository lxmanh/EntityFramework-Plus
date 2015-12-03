﻿// Description: EF Bulk Operations & Utilities | Bulk Insert, Update, Delete, Merge from database.
// Website & Documentation: https://github.com/zzzprojects/Entity-Framework-Plus
// Forum: http://zzzprojects.uservoice.com/forums/283924-entity-framework-plus
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using Microsoft.Extensions.Caching.Memory;
using Z.EntityFramework.Plus;

namespace Z.Test.EntityFramework.Plus
{
    public static class QueryCacheManagerHelper
    {
        public static long GetCacheCount()
        {
            return (QueryCacheManager.Cache as MemoryCache).Count;
        }
    }
}
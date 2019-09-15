﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pediacai.Repository
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();
    }
}

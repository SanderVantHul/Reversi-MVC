﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReversiMvcApp.Services
{
    public interface IService<T>
    {
        Task<List<T>> GetAsync(string path);
        Task<T> GetAsync(string id, string path);
        Task<string> AddAsync(T item, string path);
        Task<bool> UpdateAsync(int id, T item, string path);
        Task<bool> UpdateSpecialAsync(int id, object item, string path);
        Task<bool> DeleteAsync(int id, string path);
    }
}

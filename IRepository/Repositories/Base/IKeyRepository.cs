using System;
using System.Collections.Generic;
using System.Text;

namespace IRepository.Repositories.Base
{
    public interface IKeyRepository<T, K> : IRepositoryBase<T>
        where T : class
    {
        T Get(K key);
        void Delete(K key);
    }
}

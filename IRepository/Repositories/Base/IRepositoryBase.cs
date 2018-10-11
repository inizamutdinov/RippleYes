using System;
using System.Collections.Generic;
using System.Text;

namespace IRepository.Repositories.Base
{
    public interface IRepositoryBase<T> where T : class
    {
        void Clear();
    }
}

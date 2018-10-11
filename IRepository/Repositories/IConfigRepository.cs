using IRepository.Repositories.Base;
using System;

namespace IRepository
{
    public interface IConfigRepository : IKeyRepository<string, string>
    {
        bool Save(string key, string value);
    }
}

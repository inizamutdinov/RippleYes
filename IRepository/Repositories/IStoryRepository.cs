using IRepository.Repositories.Base;
using System;

namespace IRepository
{
    public interface IStoryRepository : IKeyRepository<string, string>
    {
        bool Save(string key, string value);
    }
}

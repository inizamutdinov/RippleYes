using IBusinessLogic;
using IRepository;
using System;

namespace BusinessLogic
{
    public class BLConfigFile : IBLConfigFile
    {
        public BLConfigFile(IStoryRepository storyRepository)
        {
            StoryRepository = storyRepository ?? throw new ArgumentNullException(nameof(storyRepository));
        }

        private readonly IStoryRepository StoryRepository;

        public string PIN
        {
            get
            {
                var value = StoryRepository.Get(PIN_KEY);
                return value;
            }
            set
            {
                StoryRepository.Save(PIN_KEY, value);
            }
        }
        private const string PIN_KEY = "{A4D52940-C03B-4662-ACC5-854E419D2A35}";

        public bool CheckPIN(string pin)
        {
            return string.Equals(PIN, pin);
        }

        public void Clear()
        {
            StoryRepository.Clear();
        }
    }
}

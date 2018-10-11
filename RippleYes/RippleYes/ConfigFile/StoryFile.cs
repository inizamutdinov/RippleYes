using IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RippleYes
{
    internal class StoryFile : IStoryFile
    {
        public StoryFile(IConfigRepository configRepository)
        {
            ConfigRepository = configRepository ?? throw new ArgumentNullException(nameof(configRepository));
        }

        private readonly IConfigRepository ConfigRepository;

        public string Email
        {
            get
            {
                var value = ConfigRepository.Get(EMAIL_KEY);
                return value;
            }
            set
            {
                ConfigRepository.Save(EMAIL_KEY, value);
            }
        }
        private string _email;
        private const string EMAIL_KEY = "{A4D52940-C03B-4662-ACC5-854E419D2A35}";
    }
}

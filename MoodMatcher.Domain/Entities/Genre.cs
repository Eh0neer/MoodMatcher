using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodMatcher.Domain.Entities
{
    public class Genre
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }
        public ICollection<MoodTag> MoodTags { get; private set; } = new List<MoodTag>();

        public ICollection<MediaItem> MediaItems { get; private set; } = new List<MediaItem>();

        private Genre() { }

        public Genre(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        // Domain methods, e.g., AssociateMoodTag
        public void AddMoodTag(MoodTag moodTag)
        {
            if (moodTag != null && !MoodTags.Contains(moodTag))
            {
                MoodTags.Add(moodTag);
            }
        }
    }
}

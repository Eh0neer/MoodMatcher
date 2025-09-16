using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodMatcher.Domain.Entities
{
    public class UserActivity
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public Guid UserId { get; private set; }
        public UserAction Action { get; private set; } // e.g., "Viewed", "Rated", etc.
        public Guid? MediaId { get; private set; }
        public DateTime Timestamp { get; private set; } = DateTime.UtcNow;

        public User User { get; private set; }
        public MediaItem? MediaItem { get; private set; }

        private UserActivity() { }

        public UserActivity(Guid userId, UserAction action, Guid? mediaId = null)
        {
            UserId = userId;
            Action = action;
            MediaId = mediaId;
        }
    }
}

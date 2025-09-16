using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodMatcher.Domain.Entities
{
    public class WatchlistItem
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public Guid UserId { get; private set; }
        public Guid MediaId { get; private set; }

        public User User { get; private set; }
        public MediaItem MediaItem { get; private set; }

        private WatchlistItem() { }

        public WatchlistItem(Guid userId, Guid mediaId)
        {
            UserId = userId;
            MediaId = mediaId;
        }
    }
}

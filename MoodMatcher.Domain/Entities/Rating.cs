using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodMatcher.Domain.Entities
{
    public class Rating
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public Guid UserId { get; private set; }
        public Guid MediaId { get; private set; }
        public decimal Value { get; private set; } // e.g., 1-10 scale

        public User User { get; private set; }
        public MediaItem MediaItem { get; private set; }

        private Rating() { }

        public Rating(Guid userId, Guid mediaId, int value)
        {
            UserId = userId;
            MediaId = mediaId;
            Value = value > 0 && value <= 10 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Rating must be between 1 and 10.");
        }
    }
}

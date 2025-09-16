using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MoodMatcher.Domain.Entities
{
    public class MediaItem
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int Year { get; private set; }
        public int Runtime { get; private set; }
        public double RatingImdb { get; private set; }
        public string PosterUrl { get; private set; }
        public MediaType Type { get; private set; } // Enum: Film, Series

        public ICollection<Genre> Genres { get; private set; } = new List<Genre>();
        public ICollection<Rating> Ratings { get; private set; } = new List<Rating>();
        public ICollection<Comment> Comments { get; private set; } = new List<Comment>();
        public ICollection<WatchlistItem> WatchlistItems { get; private set; } = new List<WatchlistItem>();

        private MediaItem() { }

        public MediaItem(string title, string description, int year, int runtime, double ratingImdb, string posterUrl, MediaType type)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Year = year;
            Runtime = runtime;
            RatingImdb = ratingImdb;
            PosterUrl = posterUrl ?? throw new ArgumentNullException(nameof(posterUrl));
            Type = type;
        }

        // Domain methods, e.g., AddGenre
        public void AddGenre(Genre genre)
        {
            if (genre != null && !Genres.Contains(genre))
            {
                Genres.Add(genre);
            }
        }
    }
}

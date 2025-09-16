using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MoodMatcher.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Username { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public Guid RoleId { get; private set; }

        public Role Role { get; private set; }
        public ICollection<UserActivity> Activities { get; private set; } = new List<UserActivity>();
        public ICollection<Rating> Ratings { get; private set; } = new List<Rating>();
        public ICollection<Comment> Comments { get; private set; } = new List<Comment>();
        public ICollection<WatchlistItem> WatchlistItems { get; private set; } = new List<WatchlistItem>();

        private User() { }

        public User(string username, string email, string passwordHash, string? avatarUrl = null, Guid? roleId = null)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            PasswordHash = passwordHash ?? throw new ArgumentNullException(nameof(passwordHash));
            RoleId = roleId ?? Guid.Empty; // Default to guest or similar if not provided
        }
    }
}

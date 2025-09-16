using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodMatcher.Domain.Entities
{
    public class Role
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }

        public ICollection<User> Users { get; private set; } = new List<User>();

        private Role() { }

        public Role(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}

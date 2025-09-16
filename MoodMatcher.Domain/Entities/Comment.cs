using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodMatcher.Domain.Entities
{
    public class Comment
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public Guid UserId { get; private set; }
        public Guid MediaId { get; private set; }
        public string Text { get; private set; }
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public Guid? ParentId { get; private set; } // Null для корневого комментария, иначе указывает на родителя

        public User User { get; private set; }
        public MediaItem MediaItem { get; private set; }
        public Comment? Parent { get; private set; } // Родительский комментарий
        public ICollection<Comment> Replies { get; private set; } = new List<Comment>(); // Дочерние комментарии

        private Comment() { }

        public Comment(Guid userId, Guid mediaId, string text, Guid? parentId = null)
        {
            UserId = userId;
            MediaId = mediaId;
            Text = text ?? throw new ArgumentNullException(nameof(text));
            ParentId = parentId;
        }

        // Метод для добавления ответа
        public void AddReply(Comment reply)
        {
            if (reply != null && reply.ParentId == this.Id)
            {
                Replies.Add(reply);
            }
        }
    }
}

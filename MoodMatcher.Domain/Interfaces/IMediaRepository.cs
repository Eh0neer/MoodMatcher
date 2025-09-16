using MoodMatcher.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodMatcher.Domain.Interfaces
{
    public interface IMediaRepository : IRepository<MediaItem>
    {
        Task<IEnumerable<MediaItem>> GetAll();
        Task<IEnumerable<MediaItem>> GetByMoodAsync(MoodTag mood);
        Task <MediaItem> GetByTitleAsync(string title);
        Task <IEnumerable<MediaItem>> GetByYearAsync(int year);
        Task <IEnumerable<MediaItem>> GetByTypeAsync(MediaType type);
    }
}

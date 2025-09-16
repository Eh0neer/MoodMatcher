using MoodMatcher.Domain.Entities;

namespace MoodMatcher.Domain.Interfaces
{
    public interface IUserActivityRepository : IRepository<UserActivity>
    {
        Task<UserActivity> GetUserByActionsAsync(UserAction action);
    }
}

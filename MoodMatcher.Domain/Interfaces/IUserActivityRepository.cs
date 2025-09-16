using MoodMatcher.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodMatcher.Domain.Interfaces
{
    public interface IUserActivityRepository : IRepository<UserActivity>
    {
        Task<UserActivity> GetUserByActionsAsync(UserAction action);
    }
}

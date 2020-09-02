using ITHS_DB_Lab4.Models;
using System.Collections.Generic;

namespace ITHS_DB_Lab4.Repository
{
    public interface IApplicationRepository
    {
        void AddActivity(Activity activity);
        IEnumerable<Activity> GetActivitiesByCategory(Category category);
        IEnumerable<Activity> GetAllActivities();
        IEnumerable<Category> GetAllCategories();
        bool SaveAll();
    }
}
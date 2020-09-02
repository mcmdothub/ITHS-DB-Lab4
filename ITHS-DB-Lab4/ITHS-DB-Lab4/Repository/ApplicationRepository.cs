using ITHS_DB_Lab4.Data;
using ITHS_DB_Lab4.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ITHS_DB_Lab4.Repository
{
    public class ApplicationRepository: IApplicationRepository
    {
        private readonly ApplicationDbContext _context;
        public ApplicationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Activity> GetAllActivities()
        {
            return _context.Activities
                .OrderBy(a => a.Name)
                .Include(a => a.Category)
                .ToList();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories
                .OrderBy(c => c.Id)
                .ToList();
        }

        public IEnumerable<Activity> GetActivitiesByCategory(Category category)
        {
            return _context.Activities
                .Where(a => a.Category == category)
                .ToList();
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }

        public void AddActivity(Activity activity)
        {
            _context.Activities.Add(activity);
        }
    }
}

using AcmeWidgetAPI.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeWidgetAPI.Repositories
{
    public class ActivitySignUpRepository : IActivitySignUpRepository
    {
        private readonly ActivityDbContext _context;
        public ActivitySignUpRepository(ActivityDbContext context)
        {
            _context = context;
        }
        public async Task<ActivitySignUpForm> Create(ActivitySignUpForm details)
        {
            _context.ActivitySignUpForms.Add(details);
            await _context.SaveChangesAsync();
            return details;
        }

        public async Task Delete(int id)
        {
            var form = await _context.ActivitySignUpForms.FirstOrDefaultAsync(h => h.Id == id);
            if (form != null)
            {
                _context.ActivitySignUpForms.Remove(form);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<ActivitySignUpForm> Get(int id)
        {
            return await _context.ActivitySignUpForms.FirstOrDefaultAsync(h => h.Id == id);
        }

        public async Task<IEnumerable<ActivitySignUpForm>> GetAllSignUpForms()
        {
            return await _context.ActivitySignUpForms.ToListAsync();
        }

        public async Task<bool> Update(int id, ActivitySignUpForm details)
        {
            var form = await _context.ActivitySignUpForms.FindAsync(id);
            if(form != null)
            {
                form.FirstName = details.FirstName;
                form.LastName = details.LastName;
                form.EmailAddress = details.EmailAddress;
                form.Comments = details.Comments;
                form.Activity = details.Activity;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}

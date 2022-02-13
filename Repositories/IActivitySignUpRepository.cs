using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeWidgetAPI.Repositories
{
    public interface IActivitySignUpRepository
    {
        Task<IEnumerable<ActivitySignUpForm>> GetAllSignUpForms();
        Task<ActivitySignUpForm> Get(int id);
        Task<ActivitySignUpForm> Create(ActivitySignUpForm details);
        Task<bool> Update(int id, ActivitySignUpForm details);
        Task Delete(int id);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcmeWidgetAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcmeWidgetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitySignUpController : ControllerBase
    {
        private readonly IActivitySignUpRepository _repository;
        public ActivitySignUpController(IActivitySignUpRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("")]
        public async Task<IEnumerable<ActivitySignUpForm>> GetForms()
        {
            return await _repository.GetAllSignUpForms();
        }

        [HttpGet("{id}")]
        public async Task<ActivitySignUpForm> GetForm(int id) => await _repository.Get(id);

        [HttpPost("")]
        public async Task<ActivitySignUpForm> Create([FromBody]ActivitySignUpForm form)
        {
           return await _repository.Create(form);
        }

        [HttpPut("{id}")]
        public async Task<bool> Update([FromRoute]int id, [FromBody] ActivitySignUpForm form)
        {
            return await _repository.Update(id, form);
        }
    }
}

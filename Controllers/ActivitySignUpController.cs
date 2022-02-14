using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcmeWidgetAPI.Repositories;
using AcmeWidgetAPI.Validation;
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
        public async Task<ActivitySignUpForm> Create([FromBody] ActivitySignUpForm form)
        {
            var validator = new ActivitySignUpFormValidator();
            var result = await validator.ValidateAsync(form);
            if (!result.IsValid) throw new Exception(string.Join(",", result.Errors));
            return await _repository.Create(form);
        }

        [HttpPut("{id}")]
        public async Task<bool> Update([FromRoute] int id, [FromBody] ActivitySignUpForm form)
        {
            var validator = new ActivitySignUpFormValidator();
            var result = await validator.ValidateAsync(form);
            if (!result.IsValid) throw new Exception(string.Join(",",result.Errors));
            return await _repository.Update(id, form);
        }

        [HttpDelete("{id}")]
        public async Task Delete([FromRoute] int id)
        {
              await _repository.Delete(id);
        }
    }
}

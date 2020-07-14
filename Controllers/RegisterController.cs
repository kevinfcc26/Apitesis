using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiTesis.Models.Register;


namespace Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly heroku_851e4397b87123bContext _heroku;
        public RegisterController( heroku_851e4397b87123bContext heroku ){
            _heroku = heroku;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = _heroku.Register.Where(s => s.Id >= 1 && s.Id <=50 ).ToArray();
            return Ok(response);
        }

    }
}
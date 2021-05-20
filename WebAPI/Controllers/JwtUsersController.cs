using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JwtUsersController : ControllerBase
    {
        IJwtUserService _jwtUserService;

        public JwtUsersController(IJwtUserService jwtUserService)
        {
            _jwtUserService = jwtUserService;
        }

        [HttpPost("add")]
        public IActionResult Add(JwtUser jwtUser)
        {
            var result = _jwtUserService.Add(jwtUser);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(JwtUser jwtUser)
        {
            var result = _jwtUserService.Update(jwtUser);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(JwtUser jwtUser)
        {
            var result = _jwtUserService.Delete(jwtUser);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

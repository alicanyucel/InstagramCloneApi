using InstagramCloneApi.Models;
using InstagramCloneApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System;

namespace InstagramCloneApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private IRepository _apprepository;
        public UsersController(IRepository repository)
        {
            _apprepository = repository;
        }
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            // 201 data eklendi http kodu 200 basarılı
            try
            {
                _apprepository.Add(user);

                return Ok(user);
            }
            catch (System.Exception)
            {

                return BadRequest();
            }

        }
      
        [HttpGet]
        public IActionResult Get()
        {
            var users = _apprepository.GetUsers();

            return Ok(users);

        }
        [HttpDelete]
        public IActionResult Delete(int userid)
        {
            try
            {
                _apprepository.Delete(new User { Id = userid });
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpPut]
        public IActionResult Update([FromBody] User user)
        {
            try
            {
                _apprepository.Update(user);
                return Ok(user);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
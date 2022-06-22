using InstagramCloneApi.Models;
using InstagramCloneApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System;

namespace InstagramCloneApi.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/[controller]")]
    public class CommentsController : ControllerBase
    {

        private  IRepository _apprRepository;

        public CommentsController(IRepository repository)
        {
            _apprRepository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var commnets = _apprRepository.GetComments();

            return Ok(commnets);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Comment comment)
        {
            // 201 data eklendi http kodu 200 basarılı
            try
            {
                _apprRepository.Add(comment);
                return Ok(comment);
            }
            catch (Exception)
            {

                return BadRequest();
            }

        }
        [HttpPut]
        public IActionResult Put([FromBody] Comment comment)
        {
            try
            {
                _apprRepository.Update(comment);
                return Ok(comment);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _apprRepository.Delete(new Comment { Id = id });
                return Ok();
                
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }


    }
}
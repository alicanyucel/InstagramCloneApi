using AutoMapper;
using InstagramCloneApi.Models;
using InstagramCloneApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System;

namespace InstagramCloneApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class PhotosController : ControllerBase
    {
        private IRepository _appRepository;


        public PhotosController(IRepository apprRepository)
        {
            _appRepository = apprRepository;

        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            var photos = _appRepository.GetPhoto(id);

            return Ok(photos);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Photo photo)
        {
            // 201 data eklendi http kodu 200 basarılı
            try
            {
                _appRepository.Add(photo);
                return Ok(photo);
            }
            catch (Exception)
            {

                return BadRequest();
            }

        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Photo photo,int id)
        {
            try
            {
                _appRepository.Update(photo);
                return Ok(photo);

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
                _appRepository.Delete(new Photo { Id = id });
                return Ok();

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }



    }
}
using Core.Entities;
using Core.Interfaces;
using Infractructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace API.Controllers
{
    public class UserController : BaseAPIController
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task <ActionResult<IEnumerable<UserBank>>> Get()
        {
            var user = await _userRepository.GetAll();
            return Ok(user);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult> Get(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return Ok(user);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<UserBank>> Post(UserBank user)
        {
             _userRepository.Add(user);
         
            if (user == null)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(Post), new { ud = user.UserId }, user);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<UserBank>> Put(int id,[FromBody] UserBank user)
        {
    

            if (user == null)
                return NotFound();
            _userRepository.Update(user);
          

            return user;
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<UserBank>> Delete(int id)
        {



            var user = await _userRepository.GetByIdAsync(id);

            if (user == null)
                return NotFound();
            _userRepository.Delete(user);



            return NoContent();
        }
    }
}

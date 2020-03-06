using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Repository;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {


        private readonly Unit _unitOfWork;

        public UsersController(Unit unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_unitOfWork.UserRepository.GetUsersAll());
        }

        [HttpGet("{id:int}")]
        public ActionResult GetById([FromRoute]int id)
        {

            return Ok(_unitOfWork.UserRepository.GetUserById(id));

        }

        
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementDAL;
using UserManagementDAL.Factories;
using UserManagementDTO;

namespace UserManagementCore.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {

        IUserService _userService;
        IModelFactory _modelFactory;

        public UserController(IUserService userService, IModelFactory modelFactory)
        {
            _userService = userService;
            _modelFactory = modelFactory;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var userEntities = _userService.Users.Get();

                var userModels = new List<UserModel>();

                foreach (var userEntity in userEntities)
                {
                    userModels.Add(_modelFactory.Create(userEntity));
                }

                return Ok(userModels);
            }
            catch (Exception e)
            {

                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                var userEntity = _userService.Users.Get(id);
                var userModel = _modelFactory.Create(userEntity);
                return Ok(userModel);
            }
            catch (Exception e)
            {

                return BadRequest();
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody]UserModel userModel)
        {
            try
            {

                if (userModel == null || !ModelState.IsValid)
                {
                    return BadRequest();
                }
                var userEntity = _modelFactory.Create(userModel);
                var userResult = _userService.Users.Insert(userEntity);
                return Ok(userResult);
            }
            catch (Exception e)
            {

                return BadRequest();
            }
        }

        public ActionResult Put([FromBody]UserModel userModel)
        {
            try
            {
                if (userModel == null || !ModelState.IsValid)
                {
                    return BadRequest();
                }
                var userEntity = _modelFactory.Create(userModel);
                var userResult = _userService.Users.Update(userEntity);
                return Ok(userResult);
            }
            catch (Exception e)
            {

                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var user = _userService.Users.Get(id);
                if (user != null)
                {
                    int userID = _userService.Users.Delete(user);
                    return Ok(userID);
                }
                else
                {
                    return NotFound();

                }

            }
            catch (Exception e)
            {

                return BadRequest();
            }
        }
    }
}

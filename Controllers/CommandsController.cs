using System.Collections;
using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;
namespace Commander.Controllers
{
    //api/commands
    [Route("api/commands")]
    [ApiController]
    public partial class CommanderController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();

            return Ok(value: commandItems);
        }

        

        //GET api/commands/5
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItems = _repository.GetCommandById(id);
            return Ok(value: commandItems);
        }
    }
}
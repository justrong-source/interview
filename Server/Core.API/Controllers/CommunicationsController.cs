using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Core.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunicationsController : ControllerBase
    {
        private readonly ICoreService coreService;

        public CommunicationsController(ICoreService coreService)
        {
            this.coreService = coreService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Communication>> GetCommunications()
        {
            var communications = coreService.GetCommunications();
            return Ok(communications);
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Communication>> GetCommunicationById(int id)
        {
            //TODO: Get record by Id
            throw new NotImplementedException();
        }

        [HttpPut]
        public ActionResult UpdateCommunication([FromBody] Communication communication)
        {
            //TODO: Update record
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult CreateCommunication([FromBody] Communication communication)
        {
            //TODO: Create record
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCommunication(int id)
        {
            //TODO: Delete record
            throw new NotImplementedException();
        }
    }
}
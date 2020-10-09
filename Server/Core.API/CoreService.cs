using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Core.Infrastructure;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Application
{
    public class CoreService : ICoreService
    {
        private readonly CommunicatorDbContext dbContext;
        private readonly ILogger<CoreService> logger;

        public CoreService(CommunicatorDbContext dbContext, ILogger<CoreService> logger)
        {
            this.logger = logger;
            this.dbContext = dbContext;
        }

        public List<Communication> GetCommunications()
        {
            return dbContext.Communications.ToList();
        }

        public Communication GetCommunicationById(int id)
        {
            //TODO: finish method
            throw new NotImplementedException();
        }

        public void CreateCommunication(Communication communication)
        {
            //TODO: finish method
            throw new NotImplementedException();
        }

        public void UpdateCommunication(Communication communication)
        {
            //TODO: finish method
            throw new NotImplementedException();
        }

        public void DeleteCommunication(int id)
        {
            //TODO: finish method
            throw new NotImplementedException();
        }
    }
}
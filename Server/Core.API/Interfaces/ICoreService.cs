using Core.Domain.Entities;
using System.Collections.Generic;

namespace Core.Domain.Interfaces
{
    public interface ICoreService
    {
        List<Communication> GetCommunications();
        Communication GetCommunicationById(int id);
        void CreateCommunication(Communication communication);
        void DeleteCommunication(int id);
        void UpdateCommunication(Communication communication);
    }
}
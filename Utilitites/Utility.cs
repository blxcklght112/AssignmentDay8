using Day8.DTO;
using Day8.Models;

namespace Day8.Utilitites
{
    public static class Utility
    {
        public static TaskModel DTOToEntity(this DTOTask dto)
        {
            return new TaskModel() { Title = dto.Title, IsCompleted = dto.IsCompleted };
        }
    }
}
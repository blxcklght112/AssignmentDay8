using Day8.DTO;
using Day8.Models;

namespace Day8.Services
{
    public interface ITaskService
    {
        void AddTask(DTOTask task);

        TaskModel GetTaskById(int id);

        List<TaskModel> GetAllTask();

        void DeleteTask(int id);

        void EditTask(TaskModel model);

        void DeleteTasks(List<int> ids);

        void AddTasks(List<DTOTask> tasks);
    }
}
using Day8.DB;
using Day8.DTO;
using Day8.Models;
using Day8.Utilitites;

namespace Day8.Services
{
    public class TaskService : ITaskService
    {
        private TaskContext _context;

        public TaskService(TaskContext context)
        {
            _context = context;
        }

        public void AddTask(DTOTask task)
        {
            _context.Tasks.Add(new TaskModel() { Title = task.Title, IsCompleted = task.IsCompleted });
            _context.SaveChanges();
        }

        public TaskModel GetTaskById(int id)
        {
            return _context.Tasks.FirstOrDefault(x => x.Id == id);
        }

        public List<TaskModel> GetAllTask()
        {
            return _context.Tasks.ToList();
        }

        public void DeleteTask(int id)
        {
            var item = _context.Tasks.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _context.Tasks.Remove(item);
                _context.SaveChanges();
            }
        }

        public void EditTask(TaskModel model)
        {
            var item = _context.Tasks.FirstOrDefault(x => x.Id == model.Id);
            if (item != null)
            {
                item.Title = model.Title;
                item.IsCompleted = model.IsCompleted;
                _context.SaveChanges();
            }
        }

        public void DeleteTasks(List<int> ids)
        {
            var items = _context.Tasks.Where(x => ids.Contains(x.Id));
            if (items.Any())
            {
                _context.Tasks.RemoveRange(items);
                _context.SaveChanges();
            }
        }

        public void AddTasks(List<DTOTask> tasks)
        {
            var addingTasks = tasks.Select(x => x.DTOToEntity());
            _context.Tasks.AddRange(addingTasks);
            _context.SaveChanges();
        }
    }
}
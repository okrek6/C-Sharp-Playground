using CSharpPlayground.Models;

namespace CSharpPlayground.Service
{
    public class TaskService
    {
        List<TaskModel> databaseLOL;
        public TaskService() 
        {
            databaseLOL = new();
        }
        public TaskModel CreateTask(TaskModel task) // add it to the list
        {
            throw new NotImplementedException();
        }
        public TaskModel UpdateTask(TaskModel task) // some fields shouldn't be editable create a new model for updates
        {
            throw new NotImplementedException();
        }
        public bool DeleteTask(Guid id) // remove it from the list
        {
            throw new NotImplementedException();
        }
        public TaskModel GetTaskById(Guid id) //select it from the list
        {
            throw new NotImplementedException();
        }
        public IEnumerable<TaskModel> GetTasks()// send the whole list
        {
            throw new NotImplementedException();
        }
    }
}

using C_Sharp_Playground.Models;


namespace C_Sharp_Playground.Service
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
            task.Id = Guid.NewGuid();
            databaseLOL.Add(task);
            return task;
        }
        public TaskModel UpdateTask(TaskModel task) // some fields shouldn't be editable create a new model for updates
        {

            //TODO Test if by Reference or by Value
            var existingTask = databaseLOL.FirstOrDefault(existingTask => existingTask.Id == task.Id);

            if (existingTask == null)
                return null;

            existingTask.Title = task.Title;
            existingTask.Description = task.Description;
            existingTask.DueDate = task.DueDate;
            existingTask.Assignee = task.Assignee;

            return existingTask;
        }
        public bool DeleteTask(Guid id) // remove it from the list
        {
            var task = databaseLOL.FirstOrDefault(existingTask => existingTask.Id == task.Id);

            if (task == null)
                return false;

            databaseLOL.Remove(task);

            return true;

        }
        public TaskModel GetTaskById(Guid id) //select it from the list
        {
            //Find task by I.D.
            var task = databaseLOL.FirstOrDefault(existingTask => existingTask.Id == task.Id);

            return task;
        }
        public IEnumerable<TaskModel> GetTasks()// send the whole list
        {
            return databaseLOL;

        }
    }
}

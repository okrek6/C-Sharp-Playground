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
            if (task.Creator == string.Empty)
                throw new ArgumentException("Cannot create Task without a Creator");
            if (task.Title == string.Empty)
                throw new ArgumentException("Cannot create Task without a Title");

            task.Id = Guid.NewGuid();
            databaseLOL.Add(task);

            var taskReturn = new TaskModel();
            taskReturn.Id = task.Id;
            taskReturn.Assignee = task.Assignee;
            taskReturn.Creator = task.Creator;
            taskReturn.Secret = task.Secret;
            taskReturn.Description = task.Description;
            taskReturn.DueDate = task.DueDate;
            taskReturn.Title = task.Title;

            return taskReturn;
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
            // databaseLOL is a list, existingTask is considered a member of that list in this case
            var task = databaseLOL.FirstOrDefault(existingTask => existingTask.Id == id);

            if (task == null)
                return false;

            databaseLOL.Remove(task);

            return true;

        }
        public TaskModel GetTaskById(Guid id) //select it from the list
        {
            // Find task by I.D.
            // databaseLOL is a list, existingTask is considered a member of that list in this case
            var task = databaseLOL.FirstOrDefault(existingTask => existingTask.Id == id);

            return task;
        }
        public IEnumerable<TaskModel> GetTasks()// send the whole list
        {
            return databaseLOL;

        }
    }
}

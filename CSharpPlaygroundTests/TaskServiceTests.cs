using C_Sharp_Playground.Models;
using C_Sharp_Playground.Service;

namespace CSharpPlaygroundsTest
{
    /// Valid means:
    ///     Creator must be populated, tasks cannot exist initially without an assignee
    ///     Title must be populated, tasks cannot exist initially without a Title

    public class TaskServiceTests
    {
        TaskService subject;
        public TaskServiceTests()
        {
            subject = new();
        }

        /// <summary>
        /// Given we have a list for a database
        /// When we pass a valid task to the CreateTask method
        /// Then we add that task to the list
        /// </summary>
        [Fact]
        public void CreateTask_GivenATask_ItAddsTheTaskToTheList()
        {
            var task = new TaskModel();
            task.Id = Guid.NewGuid();
            var result = subject.CreateTask(task);
            Assert.Equal(task.Id, result.Id);
        }

        /// <summary>
        /// Given we have a list for a database
        /// When we pass a task to the CreateTask method that is invalid because it has an empty creator
        /// Then we do NOT add that task to the list
        /// 
        /// </summary>
        [Fact]
        public void CreateTask_CreatorEmpty_Errors()
        {
            var task = new TaskModel();
            // I added the below line to demonstrate that the 'Creator' is an empty string explicitly.
            // It was already empty because we hadn't yet assigned value to it, but the point is to make it clear at a glance
            task.Creator = string.Empty;

            Assert.Throws<ArgumentException>(() => subject.CreateTask(task));
        }
        /// <summary>
        /// Given we have a list for a database
        /// When we pass a task to the CreateTask method that is invalid because it has an empty Title
        /// Then we do NOT add that task to the list
        /// </summary>
        [Fact]
        public void CreateTask_TitleEmpty_Errors()
        {
            var task = new TaskModel();
            // I added the below line to demonstrate that the 'Title' is an empty string explicitly.
            // It was already empty because we hadn't yet assigned value to it, but the point is to make it clear at a glance
            task.Title = "";
            Assert.Throws<ArgumentException>(() => subject.CreateTask(task));
        }
        [Fact]
        public void UpdateTask_GivenATask_UpdateItFromTheList()
        {
            // Arrange 
            var existingTask = new TaskModel
            {
                Id = Guid.NewGuid(),
                Title = "Existing Task",
                Description = "This has stuff",
                DueDate = DateTime.Parse("2023-07-08 12:34:56"),
                Assignee = "Jordan",
                Creator = "Brendan",
                Secret = "So live."
            };

            subject.CreateTask(existingTask);

            var updatedTask = new TaskModel
            {
                Id = existingTask.Id,
                Title = "Updated Task",
                Description = "This has more stuff",
                DueDate = DateTime.Parse("2023-07-09 12:34:56"),
                Assignee = "Jordan",
                Creator = "Brendan",
                Secret = "So live, Brother."
            };

            // Act
            var result = subject.UpdateTask(updatedTask);

            // Assert
            Assert.Equal(updatedTask.Id, result.Id);

            Assert.Equal(updatedTask.Title, result.Title);
            Assert.Equal(updatedTask.Description, result.Description);
            Assert.Equal(updatedTask.DueDate, result.DueDate);
            Assert.Equal(updatedTask.Assignee, result.Assignee);
            Assert.Equal(updatedTask.Creator, result.Creator);
            Assert.Equal(updatedTask.Secret, result.Secret);

        }
    }
}
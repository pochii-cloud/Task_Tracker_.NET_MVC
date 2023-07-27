using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Models.AddTask;
using Todo.Models.Domain;
using Task = Todo.Models.Domain.Task;

namespace Todo.Controllers
{
    public class AddTodo : Controller
    {
        private readonly TodoDbContext todoDbContext;

        public AddTodo(TodoDbContext todoDbContext)
        {
            this.todoDbContext = todoDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddTaskRequest addTaskRequest)
        {

            var todo = new Task
            {
                Name=addTaskRequest.Title,
                Description = addTaskRequest.Description,
                Is_Complete = false,
            };

            todoDbContext.Tasks.Add(todo);
            todoDbContext.SaveChanges();
            Console.WriteLine("todo added successfully");
            return View("Add");
        }

    }
}

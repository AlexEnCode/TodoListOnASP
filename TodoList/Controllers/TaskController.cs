using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoList.Data;
using TodoList.Models;
using TodoList.Repository;

namespace TodoList.Controllers
{
    public class TaskController : Controller
    {
        private readonly TaskRepository _TaskFromDb;

        public TaskController(TaskRepository TaskFromDb)
        {
            _TaskFromDb = TaskFromDb;
        }


        public IActionResult Index()
        {
            return View(_TaskFromDb.GetAll());
        }
        public IActionResult UpdateState(int id)
        {
            MyTask? updateTask = _TaskFromDb.GetById(id);

            if (updateTask.TaskState == State.Finished)
                updateTask.TaskState = 0;
            else
                updateTask.TaskState++;
            _TaskFromDb.Update(updateTask);
            return RedirectToAction(nameof(Index));
        }



        public IActionResult Add(MyTask aTask)
        {
            _TaskFromDb.Add(aTask);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteByID(int id)
        {

            MyTask? taskToDelete = _TaskFromDb.GetById(id);

            if (taskToDelete == null)
                return RedirectToAction(nameof(Index));


            _TaskFromDb.DeleteByID(id);
            return RedirectToAction(nameof(Index));

        }
    }
}


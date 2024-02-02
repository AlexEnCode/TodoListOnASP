using TodoList.Data;

namespace TodoList.Repository
{
    public class TaskRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Models.MyTask> GetAll()
        {
            return _context.Set<Models.MyTask>().ToList();
        }


        public Models.MyTask? GetById(int id)
        {
            return _context.Set<Models.MyTask>().FirstOrDefault(c => c.Id == id);
        }

        public bool Add(Models.MyTask task)
        {

            _context.Set<Models.MyTask>().Add(task);
            _context.SaveChanges();
            return true;
        }

        public bool Update(Models.MyTask task)
        {
            var TaskFromDb = GetById(task.Id);
            if (TaskFromDb == null)
            {
                return false;
            }
            else
            {
                _context.SaveChanges();
                return true;
        }

}

public bool DeleteByID(int id)
        {
            var task = GetById(id);

            if (task == null)
                return false;
            _context.Set<Models.MyTask>().Remove(task);
            _context.SaveChanges();
            return true;

        }
    }
}


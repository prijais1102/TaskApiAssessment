using TaskApiAssessment.IRepo;
using TaskApiAssessment.Models;

namespace TaskApiAssessment.Repo
{
    public class TaskRepo : ITaskRepo
    {
        TaskDbContext _db;
        public TaskRepo(TaskDbContext db)
        {
            _db = db;
        }
        public void Add(Taskk task)
        {
           
            _db.Tasks.Add(task);
            _db.SaveChanges();

        }
        public Taskk GetTask(int id)
        {
            return _db.Tasks.Where(x => x.TaskId == id).FirstOrDefault();
        }
        public List<Taskk> AllTasks()
        {
            return _db.Tasks.ToList();
        }

        public void DeleteTask(int id)
        {
            Taskk task = _db.Tasks.Where(x => x.TaskId == id).FirstOrDefault();
            _db.Tasks.Remove(task);
            _db.SaveChanges();
        }
        public void EditTask(int id, Taskk task)
        {
            var data = _db.Tasks.Where(e => e.TaskId == id).FirstOrDefault();
            if (data != null)
            {
                data.Name = task.Name;
                data.Description = task.Description;
                data.CreateBy = task.CreateBy;
                data.CreatedOn = task.CreatedOn;
                
                _db.Tasks.Update(data);
                _db.SaveChanges();
            }
        }


    }
}

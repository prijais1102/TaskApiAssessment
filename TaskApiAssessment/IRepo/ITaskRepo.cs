using TaskApiAssessment.Models;

namespace TaskApiAssessment.IRepo
{
    public interface ITaskRepo
    {
        void Add(Taskk task);
        Taskk GetTask(int id);
        List<Taskk> AllTasks();
        void DeleteTask(int id);
        void EditTask(int id, Taskk task);
    }
}

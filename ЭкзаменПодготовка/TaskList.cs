using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЭкзаменПодготовка
{
    public class TaskList
    {
        private string Name;
        private List<Task> Tasks;
        public TaskList(string name)
        {
            Name = name;
            Tasks = new List<Task>();
        }
        public string GetName()
        {
            return Name;
        }
        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }
        public List<Task> GetTasks()
        {
            return Tasks;
        }
        public void Remove(Task task)
        {
            Tasks.Remove(task);
        }
        public List<Task> GetTasksByToday()
        {
            return Tasks.Where(x => x.Due == DateTime.Now).ToList();
        }
        public List<Task> GetTasksByFuture()
        {
            return Tasks.Where(x => x.Due > DateTime.Now).ToList();
        }
    }
}

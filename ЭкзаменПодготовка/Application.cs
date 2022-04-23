using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЭкзаменПодготовка
{
    public class Application
    {
        private Application application;
        private List<TaskList> taskLists;
        private Application()
        {
            TaskList taskList = new TaskList("Входящие");
            taskLists.Add(taskList);
        }
        public Application GetApplication()
        {
            if (application != null) return application; 
            else return application = new Application();
        }
        public void CreateTaskList(string name)
        {
            TaskList taskList = new TaskList(name);
            taskLists.Add(taskList);
        }
        public List<string> GetTaskListNames()
        {
            List<string> names = new List<string>();
            foreach (var list in taskLists)
            {
                names.Add(list.GetName());
            }
            return names;
        }
        public TaskList GetTaskListByName(string name)
        {
            return taskLists.FirstOrDefault(x => x.GetName() == name);
        }
        public List<Task> GetTasksByToday()
        {
            List<Task> tasks = new List<Task>();
            foreach (var list in taskLists)
            {
                tasks.AddRange(list.GetTasksByToday());
            }
            return tasks;
        }
        public List<Task> GetTasksByFuture()
        {
            List<Task> tasks = new List<Task>();
            foreach (var list in taskLists)
            {
                tasks.AddRange(list.GetTasksByFuture());
            }
            return tasks;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emx
{
    class TaskList
    {
        private string name { get; set }
        private List<Task> tasks { get; set }
        public TaskList(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Имя списка
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Получение всех задач
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasks()
        {
            return tasks;
        }


       /// <summary>
       /// Добавление задачи
       /// </summary>
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        /// <summary>
        /// Удаление задачи
        /// </summary>
        /// <param name="task"></param>
        public void Remove(Task task)
        {
            if (tasks.Contains(task))
            {
                tasks.Remove(task);
            }
        }
    }
}

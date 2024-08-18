using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerApp.Data;
using TaskManagerApp.Models;

namespace TaskManagerApp.ViewModels
{
    internal class MainViewModel
    {
        public ObservableCollection<TaskModel> Tasks { get; set; }
        private TaskRepository _taskRepository;

        public MainViewModel()
        {
            _taskRepository = new TaskRepository();
            Tasks = new ObservableCollection<TaskModel>(_taskRepository.LoadTasks());
        }

        public void AddTask(TaskModel task)
        {
            task.Id = Tasks.Count > 0 ? Tasks.Max(t => t.Id) + 1 : 1;
            Tasks.Add(task);
            _taskRepository.SaveTasks(Tasks.ToList());
        }

        public void DeleteTask(TaskModel task)
        {
            Tasks.Remove(task);
            _taskRepository.SaveTasks(Tasks.ToList());
        }

        public void UpdateTask(TaskModel task)
        {
            var taskToUpdate = Tasks.FirstOrDefault(t => t.Id == task.Id);
            if (taskToUpdate != null)
            {
                taskToUpdate.Title = task.Title;
                taskToUpdate.IsCompleted = task.IsCompleted;
                _taskRepository.SaveTasks(Tasks.ToList());
            }
        }
    }
}

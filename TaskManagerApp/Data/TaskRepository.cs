using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TaskManagerApp.Models;

namespace TaskManagerApp.Data
{
    internal class TaskRepository
    {
        private readonly string _filePath = "tasks.json";

        public List<TaskModel> LoadTasks()
        {
            if (!File.Exists(_filePath))
            {
                return new List<TaskModel>();
            }

            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<TaskModel>>(json);
        }

        public void SaveTasks(List<TaskModel> tasks)
        {
            var json = JsonConvert.SerializeObject(tasks, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}

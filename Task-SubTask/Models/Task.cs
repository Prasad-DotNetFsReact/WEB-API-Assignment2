﻿namespace Task_SubTask.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public string AssignedBy { get; set; }

        public List<SubTask> SubTasks { get; set; }
    }
}


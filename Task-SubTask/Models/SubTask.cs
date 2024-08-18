namespace Task_SubTask.Models

{
    public class SubTask
    {
        public int SubTaskId { get; set; }
        public string SubTaskName { get; set; }
        public string SubTaskDescription { get; set; }
        public int TaskID { get; set; }
        public Task Task { get; set; }
    }
}


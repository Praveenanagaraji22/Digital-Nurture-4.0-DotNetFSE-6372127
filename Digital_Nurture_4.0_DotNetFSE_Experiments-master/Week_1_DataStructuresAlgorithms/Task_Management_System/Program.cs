class Program
{
    static void Main()
    {
        TaskManagement taskManager = new TaskManagement();

        taskManager.AddTask(new Task(1, "Design Module", "Pending"));
        taskManager.AddTask(new Task(2, "Implement Feature", "In Progress"));
        taskManager.AddTask(new Task(3, "Testing", "Pending"));

        Console.WriteLine("All Tasks:");
        taskManager.TraverseTasks();

        Console.WriteLine("\nSearching for Task ID 2:");
        var task = taskManager.SearchTask(2);
        if (task != null)
            Console.WriteLine(task);
        else
            Console.WriteLine("Task not found.");

        Console.WriteLine("\nDeleting Task ID 2...");
        taskManager.DeleteTask(2);

        Console.WriteLine("\nAll Tasks after deletion:");
        taskManager.TraverseTasks();
    }
}

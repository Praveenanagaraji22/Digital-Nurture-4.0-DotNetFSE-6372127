public class TaskManagement
{
    private TaskNode? head;

    public TaskManagement()
    {
        head = null;
    }

    public void AddTask(Task task)
    {
        TaskNode newNode = new TaskNode(task);
        if (head == null)
        {
            head = newNode;
            return;
        }

        TaskNode current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
    }

    public Task? SearchTask(int taskId)
    {
        TaskNode? current = head;
        while (current != null)
        {
            if (current.Data.TaskId == taskId)
                return current.Data;
            current = current.Next;
        }
        return null;
    }

    public void TraverseTasks()
    {
        TaskNode? current = head;
        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }

    public void DeleteTask(int taskId)
    {
        if (head == null) return;

        if (head.Data.TaskId == taskId)
        {
            head = head.Next;
            return;
        }

        TaskNode? current = head;
        TaskNode? previous = null;

        while (current != null && current.Data.TaskId != taskId)
        {
            previous = current;
            current = current.Next;
        }

        if (current == null)
        {
            Console.WriteLine("Task not found.");
            return;
        }

        if (previous != null)
            previous.Next = current.Next;
    }
}
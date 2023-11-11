/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue with 5 numbers with corresponding priority: (1:1),(2:2),(3:3),(4:4),(5:5).
        // Expected Result: 5, 4, 3, 2, 1
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("1", 1);
        priorityQueue.Enqueue("2", 2);
        priorityQueue.Enqueue("3", 3);
        priorityQueue.Enqueue("4", 4);
        priorityQueue.Enqueue("5", 5);

        for (int i = 0; i < 5; i++) {
            Console.WriteLine(priorityQueue.Dequeue());
        }
        // Defect(s) Found: Only starts the 4th item and skips the 5th. Found that the for loop that goes through all the numbers
        // doesn't check the first item as it starts the count - 1.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Add 5 items to the queue, the last two having the same priority: (1:1),(2:2),(3:3),(5-1:5),(5-2:5)
        // Expected Result: 5-1, 5-2, 3, 2, 1 
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("1", 1);
        priorityQueue.Enqueue("2", 2);
        priorityQueue.Enqueue("3", 3);
        priorityQueue.Enqueue("5-1", 5);
        priorityQueue.Enqueue("5-2", 5);

        for (int i = 0; i < 5; i++) {
            Console.WriteLine(priorityQueue.Dequeue());
        }
        // Defect(s) Found: Doesn't remove the item closest to the front of the queue when 2 items have same priority.
        // Only checks if priority is higher than the last one, doesn't check if they are the same.
        // Now it checks if priority level is the same and then checks the index of the item to ensure the lower index
        // is set as the highest priority index.

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
        // Test 3
        // Scenario: Run the dequeue function while the queue is empty.
        // Expected Result: Error message saying "The queue is empty."
        Console.WriteLine("Test 3");
        priorityQueue.Dequeue();
        // Defect(s) Found: None. Error messages displays as it should.
    }
}
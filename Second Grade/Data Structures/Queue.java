
//FIFO: first in, first out
public class Queue {

    private int[] queue;
    private int count = 0;
    private int capacity;

    //Constructor
    public Queue(int size) {
        queue = new int[size];
        capacity = size;
    }

    //Add data
    public void enqueue(int data) {

        if (capacity == count) {
            System.out.println("Queue is full, no place for the new data.");
        } else {
            queue[count] = data;
            count++;
        }
    }

    //Remove element 
    public void dequeue() {

        if (count == 0) {
            System.out.println("Queue is empty.");
        } else {
            count--;
            
            for (int i = 0; i < count; i++) {
                queue[i] = queue[i+1];
            }
        }
    }

    public void printData() {

        for (int i = 0; i < count; i++) {
            System.out.println(queue[i]);
        }
        System.out.println("");
    }
}

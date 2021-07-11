
//LIFO (last in, first out)
public class Stack {

    private int[] stack;
    private int count = 0;
    private int capacity;

    public Stack(int size) {
        stack = new int[size];
        capacity = size;
    }

    public void push(int data) {

        if (count == capacity) {
            System.out.println("Stack is full.");
        } else {
            stack[count] = data;
            count++;
        }
    }
    
    public int pop() {
        
        if (count == 0) {  
            System.out.println("Stack is empty.");
            return -99;
        } else {
            int temp = count - 1; 
            count--;
            return stack[temp];                      
        }
    }
    
    public void printData() {
        for (int i = 0; i < count; i++) {
            System.out.println(stack[i]);
        }
        System.out.println("");
    }
}

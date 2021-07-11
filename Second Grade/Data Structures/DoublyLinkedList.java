
public class DoublyLinkedList {

    private class Node {

        int data;
        Node next;
        Node previous;
              
        public Node(int data) {
            this.data = data;
            this.next = null;
            this.previous = null;
        }
    }

    private Node head;

    private Node tail;

    int size;

    public void insertAtBeginning(int data) {     
        
        if (head == null) {
            head = tail = new Node(data);
            size++;
        } else {
            
        Node newNode = new Node(data);
            
        newNode.next = head;
        newNode.next.previous = newNode;
        head = newNode;
            
        size++;
        }    
    }
    
    
    public void insertToEnd(int data) {
        
        if(tail == null) {
            head = tail = new Node(data);
            size++;            
        } else {
        
        Node newNode = new Node(data);
            
        newNode.previous = tail;
        newNode.previous.next = newNode;
        tail = newNode;
        
        size++;
        }     
    }

    public void deleteFromBeginning() {
        
        if (size == 1) {
            head = tail = null;
        }
        head = head.next;
        head.previous = null;     
    }
    
    public void deleteFromEnd() {
        if (size == 1) {         
            head = tail = null;            
        }
        tail = tail.previous;
        tail.next = null;
    }
    
    public void printNodeData() {
        
        Node current = head;
        
        while (current != null) {
            System.out.println(current.data);
            current = current.next;
        }
    }
}

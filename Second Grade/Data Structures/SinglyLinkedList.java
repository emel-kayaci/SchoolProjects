
public class SinglyLinkedList {

    //Node sınıfı linked liste hazırlık sınıfıdır. Node için gerekenleri oluşturur. (bilgi + bir sonraki düğümün referansı)
    private class Node {

        //Değişkenler tanımlanır.
        int data; //Veri türüne göre değişiklik gösterebilir. 
        Node next; //Düğümler birer nesnedir bu yüzden bu nesneleri işaret eden referanslara ihtiyaçları vardır. 

        //Constructor
        public Node(int data) {
            this.data = data;
            this.next = null;
        }
    }

    private Node head; //İlk düğümün referansı oluşturulur.

    int size; //Linked list boyutunu tutan değişken

    public void addFirst(int data) {

        //Listede eleman bulunmuyorsa
        if (head == null) {

            //Obje oluşturulur. (head referans edildi şimdi ise obje oluşturuluyor)
            head = new Node(data);
            size++;
            return; //metottan çıkılıyor
        }

        //head için referans bulunuyordu, burada ise hem referans hem de obje oluşturuluyor.
        Node newNode = new Node(data);
        newNode.next = head;
        head = newNode;
        size++;
    }

    public void addLast(int data) {

        if (head == null) {
            
            head = new Node(data);
            size++;
        } else {
            
            Node current = head;

            while (current.next != null) {
                current = current.next;
            }

            Node newNode = new Node(data);
            current.next = newNode;
            size++;
        }
    }

    public void removeFirst() {

        if (size == 1) {
            head = null;
            return;
        }
        head = head.next;
    }

    public void removeLast() {

        if (size == 1) {
            head = null;
            return;
        } else {
            Node current = head;
            Node prev = null; //initialize prev
            
            while (current.next != null) {
                prev = current; //data 
                current = current.next; //current null olur, yok edilir
            }            
            prev.next = null; //link           
        }      
    }

    public void yazdir() {
        
        Node current = head;
        
        while (current != null) {
            System.out.println(current.data);
            current = current.next;
        }
    }
}

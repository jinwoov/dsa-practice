const Node = require("../linkedlist/node");

class Queue {
    constructor() {
        this.front = null;
        this.rear = null;
    }

    enqueue(val) {
        let node = new Node(val);
        if(this.isEmpty()) {
            this.front = node;
            this.rear = node;
        }
        else {
            this.rear.next = node;
            this.rear = node;
        }
    }

    dequeue() {
        if(this.isEmpty())
            throw new Error("nothing in the queue");
        else {
            let temp = this.front;
            this.front = this.front.next;
            if(this.front == null) {
                this.rear == null;
            }
            return temp;
        }
    }

    isEmpty = () => this.front == null;

    print() {
            let current = this.front;
            while(current != null) {
                console.log(current.value);
                current = current.next;
            }
    }
}

let q = new Queue();

q.enqueue(5);
q.enqueue(4);
q.enqueue(3);
q.enqueue(2);
q.enqueue(1);
q.enqueue(100);

q.dequeue();
q.dequeue();
q.dequeue();
q.dequeue();
q.dequeue();
q.dequeue();


q.print();
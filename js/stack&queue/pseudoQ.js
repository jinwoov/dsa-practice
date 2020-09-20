const Stack = require("./stack");
const Node = require("../linkedlist/node");

class PseudoQ{
    constructor() {
        this.stack1 = new Stack();
        this.stack2 = new Stack();
    }

    enqueue(val) {
        let node = new Node(val);

        if(this.stack1.top == null)
            this.stack1.top = node;
        else {
            while(this.stack1.top != null)
                this.stack2.push(this.stack1.pop());
            this.stack1.top = node;
            while(this.stack2.top != null){
                this.stack1.push(this.stack2.pop());
            }
        }
    }

    dequeue = () => this.stack1.isEmpty() ? Error("nothing in this queue") : this.stack1.pop();

    print() {
        let current = this.stack1.top;
        while(current != null) {
            console.log(current.value);
            current = current.next;
        }
    }
}

let pq = new PseudoQ();

pq.enqueue(5);
pq.enqueue(5);
pq.enqueue(5);
pq.enqueue(5);
pq.enqueue(5);
pq.enqueue(5);
pq.enqueue(4);
console.log(pq.dequeue());
console.log(pq.dequeue());
console.log(pq.dequeue());
console.log(pq.dequeue());
console.log(pq.dequeue());
console.log(pq.dequeue());
console.log(pq.dequeue());
console.log(pq.dequeue());

// pq.print();

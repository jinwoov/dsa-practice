'use strict';

const Node = require('./node');

class LinkedList{
    constructor() {
        this.head = null;
    }

    insertAfter(val) {
        let nodes = new Node(val);

        if (this.head == null)
            this.head = nodes;
        else {
            let current = this.head;
            while(current.next != null){
                current = current.next;
            }
            current.next = nodes;
        }
    }

    print(){
        if(this.head == null)
            throw new Error("nothing in the linked list bub");
        else {
            let current = this.head;
            while(current != null) {
                console.log(`${current.value} => `);
                current = current.next;
            }
            console.log("END")
        }
    }
    
}


let ll = new LinkedList();
ll.insertAfter(5);
ll.insertAfter(4);
ll.insertAfter(3);

ll.print();

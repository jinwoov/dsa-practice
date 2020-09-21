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

    insertBefore(val) {
        let node = new Node(val);
        if(this.head == null)
            this.head = node;
        else {
            node.next = this.head;
            this.head = node; 
        }
    }

    insertBeforeSV(val, searchVal) {
        let node = new Node(val);
        if(this.head == null)
            throw new Error("there is nothing in the linkedlist");
        else {
            let current = this.head;
            while(current != null) {
                if(current.next.value == searchVal) {
                    node.next = current.next;
                    current.next = node;
                    break;
                }
                current = current.next;
            }
        }
    }

    insertAfterSV(val , searchVal) {
        let node = new Node(val);
        if(this.head == null)
            throw new Error("there is nothing in the linkedlist");
        else {
            let current = this.head;
            while(current != null) {
                if(current.value == searchVal) {
                    node.next = current.next;
                    current.next = node;
                }
                current = current.next;
            }
        }
    }

    kthFromEnd(k) {
        if(this.head == null)
            throw new Error("nothing in the list");
        else {
            let hare = this.head;
            let c = 0;
            while(c++ != k && hare != null) {
                hare = hare.next;
            }

            let turtle = this.head;
            while (hare.next != null) {
                turtle = turtle.next;
                hare = hare.next;
            }
            console.log(`this is at kth position ${turtle.value}`);
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
ll.insertBefore(100);
ll.insertAfter(3);
ll.insertAfter(3);
ll.insertBeforeSV(200, 3);
ll.insertAfterSV(400, 200);

ll.kthFromEnd(3);

ll.print();

module.exports = LinkedList;
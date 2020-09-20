const Node = require("../linkedlist/node");

class Stack {
    constructor(){
        this.top = null;
    }

    push(val) {
        let node = new Node(val);
        if(this.top == null)
            this.top = node;
        else {
            node.next = this.top;
            this.top = node;
        }
    }

    pop() {
        if(this.top == null)
            throw new Error("Nothing in the stack");
        else {
            let temp = this.top;
            this.top = this.top.next;
            return temp.value;
        }
    }

    peek = () => this.top == null ? Error("nothing in the stack"): this.top;

    isEmpty = () => this.top == null;
}

let s = new Stack();
s.push(5);
s.push(3);

console.log(s.pop());
console.log(s.pop());

console.log(s.peek());

console.log(s.isEmpty());


module.exports = Stack;
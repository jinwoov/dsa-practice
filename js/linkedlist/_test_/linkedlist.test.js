'use strict';

const LinkedList = require("../linkedlist");

let ll = new LinkedList();

test('check if linkedlist can add node', () => {
    ll.insertAfter(1);

    expect(ll.head.value).toBe(1); 
});

test('check if linkedlist can add to head', () => {
    ll.insertBefore(4);
    ll.insertBefore(1);
    ll.insertBefore(300);

    expect(ll.head.value).toBe(300);
})

test('check if linkedlist can add before the search value', () => {
    ll.insertBefore(4);
    ll.insertBefore(1);
    ll.insertBefore(300);

    ll.insertBeforeSV(1000, 1);

    expect(ll.head.next.value).toBe(1000);
})
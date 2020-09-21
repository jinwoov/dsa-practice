import pytest
from DSA-Practice.py.linkedlist.linkedlist import LinkedList

def test_add_to_head():
    ll = LinkedList()
    ll.insertToEnd(4)
    actual = 4
    result = ll.head.value

    assert actual == result
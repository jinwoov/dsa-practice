from nodeLL import Node

class LinkedList:
    def __init__(self):
        self.head = None
    
    def insertToEnd(self, val):
        node = Node(val)
        if(self.head is None):
            self.head = node
        else:
            current = self.head
            while(current.next != None):
                current = current.next
            current.next = node
    def printing(self):
        if(self.head is None):
            raise ValueError("nothing in the list")
        else:
            current = self.head
            while(current is not None):
                print(current.value)
                current = current.next

ll = LinkedList()
ll.insertToEnd(5)
ll.insertToEnd(5)
ll.insertToEnd(5)
ll.insertToEnd(5)
ll.insertToEnd(4)

ll.printing()
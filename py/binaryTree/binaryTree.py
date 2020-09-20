from node import Node
from queue import Queue

class BinaryTree:
    def preOrder(self, roots: Node):
        if(roots == None):
            return
        else:
            print(roots.value)
            self.preOrder(roots.left)
            self.preOrder(roots.right)

    def inOrder(self, roots):
        if(roots == None):
            return
        else:
            self.inOrder(roots.left)
            print(roots.value)
            self.inOrder(roots.right)

    def postOrder(self, roots):
        if(roots == None):
            return
        else:
            self.postOrder(roots.left)
            self.postOrder(roots.right)
            print(roots.value)

    def breadthFirst(self, roots):
        if(roots == None)
            return
        else:
            q = Queue.
            
            
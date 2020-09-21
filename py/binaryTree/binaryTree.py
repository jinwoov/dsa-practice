from node import Node
from collections import deque

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
        if(roots == None):
            return
        else:
            q = deque()
            q.append(roots)
            while(q.__len__() > 0): 
                temp = q.popleft()
                print(temp.value)
                if (temp.left != None):
                    q.append(temp.left)
                if (temp.right != None):
                    q.append(temp.right)
            


            
            
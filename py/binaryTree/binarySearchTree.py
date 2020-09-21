from node import Node
from binaryTree import BinaryTree

class BinarySearchTree:
    def __init__(self):
        self.root = None

    def insert(self, roots: Node, val):
        if(self.root is None):
            node = Node(val)
            self.root = node
        else:
            if(roots is None):
                node = Node(val)
                roots = node
                return roots
            else:
                if(roots.value >= val):
                    roots.left = self.insert(roots.left, val)
                else:
                    roots.right = self.insert(roots.right, val)
                return roots
        
    
    def contains(self, roots, searchVal):
        if(roots is None):
            return False
        else:
            if(roots.value == searchVal):
                return True
            elif(roots.value >= searchVal):
                return self.contains(roots.left, searchVal)
            else:
                return self.contains(roots.right, searchVal)


bst = BinarySearchTree()
bst.insert(bst.root, 5)
bst.insert(bst.root, 3)
bst.insert(bst.root, 4)
bst.insert(bst.root, 7)
bst.insert(bst.root, 8)

result = bst.contains(bst.root, 7)
print(result)
# bt = BinaryTree()
# #bt.preOrder(bst.root)
# #bt.inOrder(bst.root)
# # bt.postOrder(bst.root)
# bt.breadthFirst(bst.root)
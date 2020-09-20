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
            


bst = BinarySearchTree()
bst.insert(bst.root, 5)
bst.insert(bst.root, 3)
bst.insert(bst.root, 4)
bst.insert(bst.root, 7)
bst.insert(bst.root, 8)

bt = BinaryTree()
#bt.preOrder(bst.root)
#bt.inOrder(bst.root)
bt.postOrder(bst.root)
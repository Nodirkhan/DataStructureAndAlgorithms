namespace BinarySearchTree
{
    public class BinaryTree
    {
        public Node Root;
        public bool Add(int value)
        {
            Node before = null, after = this.Root; 
            while(after != null)
            {
                before = after;
                if(value < after.Data)
                {
                    after = after.LeftNode;
                }
                else if(value > after.Data)
                {
                    after = after.RightNode;
                }
                else
                {
                    return false;
                }
            }
            Node newNode = new Node();
            newNode.Data = value;
            if(this.Root == null)
            {
                Root = newNode;
            }
            else
            {
                if(value > before.Data)
                {
                    before.RightNode = newNode;
                }
                else
                {
                    before.LeftNode = newNode;
                }
            }
            return true;
        }
        public Node Find(int value)
        {
            return Find(value, this.Root);
        }
        private Node Find(int value, Node parent)
        {
            if(parent != null)
            {
                if(value == parent.Data) return parent;
                if (value < parent.Data)
                    return Find(value, parent.LeftNode);
                else 
                    return Find(value, parent.RightNode);
            }
            return null;
        }
        public void Remove(int value)
        {
            this.Root = Remove(this.Root, value);
        }

        private Node Remove(Node parent, int key)
        {
            if (parent == null)
                return parent;

            if(key < parent.Data)
            {
                parent.LeftNode = Remove(parent.LeftNode, key);
            }
            else if(key > parent.Data)
            {
                parent.RightNode = Remove(parent.RightNode, key);
            }
            else
            {
                if(parent.LeftNode == null)
                {
                    return parent.RightNode;
                }
                else if(parent.RightNode == null)
                {
                    return parent.LeftNode;
                }
                parent.Data = MinValue(parent.RightNode);
                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }
            return parent;
        }
        private int MinValue(Node node)
        {
            int minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }

    }
    public class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public int Data { get; set; }
    }
}

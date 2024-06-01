public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }
        public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        } else if (value > Data) {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        // If value == Data, do nothing (ignore duplicates)
    }

        public bool Contains(int value) {
        if (value == Data) {
            return true;
        } else if (value < Data) {
            // Search in the left subtree
            if (Left is null) {
                return false;
            } else {
                return Left.Contains(value);
            }
        } else {
            // Search in the right subtree
            if (Right is null) {
                return false;
            } else {
                return Right.Contains(value);
            }
        }
    }

    // public int GetHeight() {
    //     // TODO Start Problem 4
    //     return 0; // Replace this line with the correct return statement(s)
    // }

        public int GetHeight() {
        // If the node is a leaf (no children), its height is 1
        if (Left == null && Right == null) {
            return 1;
        }

        // Recursively get the height of the left subtree
        int leftHeight = (Left != null) ? Left.GetHeight() : 0;

        // Recursively get the height of the right subtree
        int rightHeight = (Right != null) ? Right.GetHeight() : 0;

        // The height of the tree is 1 (the current node) plus the greater height of the two subtrees
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}
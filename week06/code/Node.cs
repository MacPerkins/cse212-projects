public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value == Data) {
            return;
        }
        else if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO START PROBLEM 2 ---------------------------------------------
        if (value == Data) {
            return true;
        }

        if (value < Data && Left != null) {
            return Left.Contains(value);
        }

        if (value > Data && Right != null) {
            return Right.Contains(value);
        }

        return false;
    }

    public int GetHeight() {
        // TODO START PROBLEM 4 ---------------------------------------------
        int leftHeight = (Left == null) ? 0 : Left.GetHeight();
        int rightHeight = (Right == null) ? 0 : Right.GetHeight();

        return 1 + Math.Max(leftHeight, rightHeight); // Replace this line with the correct return statement(s)
    }
}
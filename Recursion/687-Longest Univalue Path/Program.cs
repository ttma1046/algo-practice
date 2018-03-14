namespace _687_Longest_Univalue_Path
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }

        public int max;

        public int LongestUnivaluePath(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            KeepLooking(root, null, 0);

            return max;
        }

        public void KeepLooking(TreeNode root, int? perviousNodeVal, int count)
        {
            if (perviousNodeVal != null)
            {
                if (root.val == perviousNodeVal)
                {
                    if (count == 0)
                    {
                        count = 1;
                    }
                    count++;
                }
            }

            if (count > max)
            {
                max = count;
            }

            if (root.left != null)
            {
                KeepLooking(root.left, root.val, count);
            }

            if (root.right != null)
            {
                KeepLooking(root.right, root.val, count);
            }
        }
    }
}

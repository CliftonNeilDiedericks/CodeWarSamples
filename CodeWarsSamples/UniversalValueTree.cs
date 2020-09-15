using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsSamples
{
    public static class UniversalValueTree
    {
        public static bool is_unival(Node root)
        {
            //O(n)
            if (root == null)
                return true;
            if (root.left != null && root.left.value != root.value)
                return false;
            if (root.right != null && root.right.value != root.value)
                return false;
            if (is_unival(root.left) && is_unival(root.right))
                return true;

            return false;
        }

        public class HelperResult
        {
            public int count { get; set; }
            public bool IsUnival { get; set; }
        }

        public static int count_univals(Node root)
        {
            int total_count = 0;
            bool is_unival = false;

            HelperResult helperResult = new HelperResult();
            helperResult = helper(root);
            total_count = +helperResult.count;

            return total_count;


        }

        public static HelperResult helper(Node root)
        {
            HelperResult result = new HelperResult();
            HelperResult resultleft = new HelperResult();
            HelperResult resultright= new HelperResult();
            int left_count, right_count = 0;
            bool is_left_unival, is_right_unival = false;
         


            if (root == null)
            {
                result.count = 0;
                result.IsUnival = false;
                return result;
            }
            resultleft = helper(root.left);
            left_count = resultleft.count;
            is_left_unival = resultleft.IsUnival;
            resultright = helper(root.right);
            right_count = resultright.count;
            is_right_unival = resultright.IsUnival;
            bool is_unival = true;

            if (!is_left_unival && !is_right_unival)
                is_unival = false;

            if (root.left!=null && root.left.value != root.value)
                is_unival = false;
            if (root.right != null && root.right.value != root.value)
                is_unival = false;
            if(is_unival)
            {
                result.count = left_count + right_count + 1;
                result.IsUnival = true;
                return result;
            }
            else
            {
                result.count = left_count + right_count;
                result.IsUnival = false;
                return result;
            }

        }
    }
    public  class Node
    {
        public int value;

        public Node left, right;

        public Node(int item)
        {
            value = item;
            left = right = null;
        }

    }
    public class Count
    {
        public int count = 0;
    }

    public class BinaryTree
    {
        public Node root;
        public Count ct = new Count();

        // This function increments count by number of single   
        // valued subtrees under root. It returns true if subtree   
        // under root is Singly, else false.  
        public virtual bool countSingleRec(Node node, Count c)
        {
            // Return false to indicate NULL  
            if (node == null)
            {
                return true;
            }

            // Recursively count in left and right subtrees also  
            bool left = countSingleRec(node.left, c);
            bool right = countSingleRec(node.right, c);

            // If any of the subtrees is not singly, then this  
            // cannot be singly.  
            if (left == false || right == false)
            {
                return false;
            }

            // If left subtree is singly and non-empty, but data  
            // doesn't match  
            if (node.left != null && node.value != node.left.value)
            {
                return false;
            }

            // Same for right subtree  
            if (node.right != null && node.value != node.right.value)
            {
                return false;
            }

            // If none of the above conditions is true, then  
            // tree rooted under root is single valued, increment  
            // count and return true.  
            c.count++;
            return true;
        }

        // This function mainly calls countSingleRec()  
        // after initializing count as 0  
        public virtual int countSingle()
        {
            return countSingle(root);
        }

        public virtual int countSingle(Node node)
        {
            // Recursive function to count  
            countSingleRec(node, ct);
            return ct.count;
        }

        
    }

}

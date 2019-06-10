using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Problems.Algorithms
{    
    class BreadthFirstSearch
    {
        static void TraverseTree(Node head)
        {
            if (head == null) return;
            else
            {
                Console.Write(head.data + " ");

                TraverseTree(head.left);
                TraverseTree(head.right);

                //if (head.left != null) TraverseTree(head.left);
                //if (head.right != null) TraverseTree(head.right);
            }
        }

        static Node BuildTreeFromArr(string[] arr)
        {
            Node tree = null;

            for(int i = 0; i < arr.Length; i++)
            {
                tree = new Node(arr[i++], new Node(arr[i++]), new Node(arr[i]));
            }

            return tree;
        }
    }
}

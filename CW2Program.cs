using System;
using System.Collections;
using System.Collections.Generic;

namespace exercice1
{
    //Class MyNode to hold one integer item
    //Left child leftChild 
    //Right child rightChild
    //Parent myParent (for root node myParent is NULL

    class MyNode
    {
        public int item;
        public MyNode leftChild;
        public MyNode rightChild;


        //Default Constructor
        public MyNode()
        {
            item = 0;
            leftChild = null;
            rightChild = null;
        }
        //Constructor with value parameter
        public MyNode(int value)
        {
            item = value;
            leftChild = null;
            rightChild = null;
        }
    }
    class MyBinaryTree
    {
        private MyNode root;

        //Default Constructor
        public MyBinaryTree()
        {
            root = null;
        }
        public MyNode ReturnRoot()
        {
            return root;
        }
        public void InsertNode(int id)
        {
            MyNode newNode = new MyNode(id);

            if (root == null)
            {
                //First element and it should be the root
                root = newNode;
                return;
            }
            else
            {

                //assign the node to the appropriate parent by comparing the item.
                //For example, if the given item is less then root's item then it goes to leftChild 
                //else go to the rightChild. Continue until you find a situation where

                MyNode current = root;
                while (true)
                {
                    //Add your code for building Binary tree
                    if (id < current.item)  //if id is less than the current item
                    {
                        if (current.leftChild == null)  //if left child is null
                        {
                            current.leftChild = newNode; //set the leftt child as the new node
                            break;
                        }
                        else //if not null                    
                            current = current.leftChild; //go to the left child
                    }
                    else //else the id is greater than or equal to the current item
                    {
                        if (current.rightChild == null) //if right child is null
                        {
                            current.rightChild = newNode; //set the right child as the new node
                            break;
                        }
                        else //if not null
                        {
                            current = current.rightChild; //go to the right child
                        }
                    }
                }
            }
        }

        //NOTE: USE RECURSION FOR ALL THE BELOW TRAVERSAL ALGORITHM
        public void Preorder(MyNode tmpNode) //going from the root to the left child and then to the right child
        {
            if (tmpNode == null)
                return;
            else
            {
                Console.WriteLine(tmpNode.item);  // writes the item(data) that holds one integer item and in this case that is the nodes or numbers seen in the main
                Preorder(tmpNode.leftChild); // using the pre-order method if the node / data does not equal nothing or null then order the leftchild or left side of the binary search tree which is the  lower numbers
                Preorder(tmpNode.rightChild); // using the pre-order method if the node / data does not equal nothing or null then order the right child or right side of the binary search tree which is the higher numbers

                //Add your code for Pre-order traversal
                //Look at the lecture slides for pseudocode
            }
        }
        public void Inorder(MyNode tmpNode) // from the left child then to the root node then to the right of the binary search tree 
        {
            if (tmpNode == null)
                return;
            else
            {
                Inorder(tmpNode.leftChild);
                Console.WriteLine(tmpNode.item);
                Inorder(tmpNode.rightChild);
                //Add your code for In-order traversal
                //Look at the lecture slides for pseudocode

            }
        }
        public void Postorder(MyNode tmpNode) //going from the right child to the root to the left child 
        {
            //Start from the Root
            if (tmpNode == null)
                return;
            else
            {
                Postorder(tmpNode.rightChild);
                Console.WriteLine(tmpNode.item);
                Postorder(tmpNode.leftChild);
                //Add your code for Post-order traversal
                //Look at the lecture slides for pseudocode
            }
        }
        //exercice 2 
        public void inorderstack(MyNode tmpnode) //this is my depth first search using stack for item 20 
        {
            Stack<MyNode> stack = new Stack<MyNode>();

            while (tmpnode != null && tmpnode.item !=20) //  while the node is not null tmpnode != null and does not equal 20 our item
            {
                while (tmpnode.leftChild != null) // while the leftchild is not null
                {
                    stack.Push(tmpnode); // push the stack tmpnode object to the top
                    tmpnode = tmpnode.leftChild; // tmpnode stack = the tmpnodes in the left child
                }
                Console.WriteLine(tmpnode.item); //visit node
            }
            while (tmpnode.rightChild != null && stack.Count > 0) // while the right child nodes is not null and the stack is bigger than 0 
            {
                tmpnode = stack.Pop(); //pop the desired number that we are searching for out of the stack and return it to the console
                Console.WriteLine(tmpnode.item); //visit node
            }
            tmpnode = tmpnode.rightChild; // tmpnode stack = the tmpnodes in the right child

        }
        //exercice 3 
        public void breadthfirst(MyNode tmpnode)
        {
            Queue<MyNode> q = new Queue<MyNode>(); //initalises a new queue q using mynode class 
            q.Enqueue(root); //enqueue root
            while (tmpnode.item !=30) //while the node item is not equal to 30 continue to search for the item 30 
            {
                tmpnode = q.Dequeue(); //dequeue a node
                Console.WriteLine(tmpnode.item); // this is write the nodes as it searches until it reaches 30
                if (tmpnode.leftChild != null) // if the tmpnodes in child do not equal null 
                    q.Enqueue(tmpnode.leftChild); //then queue the leftchild until reach 30
                if (tmpnode.rightChild != null) //if the tmpnodes in child do not equal null
                    q.Enqueue(tmpnode.rightChild); // then queue the right chidl until finding 30
            }
        }
        //exercice 4 
        public void rescursivesearch(MyNode tmpnode)
        {
            while (tmpnode.item != 30) //while the node is not equal to 30
                while(tmpnode.item !=20) //while the node is not equal to 20
            {
                if (tmpnode.leftChild != null) { //if the left child is not equal to null search it and write the path it takes to find 20 and 30

                    tmpnode = tmpnode.leftChild;
                    Console.WriteLine(tmpnode.item);

                    if (tmpnode.rightChild != null) // if the right child is not equal to null search it and  write the path it takes to find 20 and 30 
                    {
                        tmpnode = tmpnode.rightChild;
                        Console.WriteLine(tmpnode.item); //print the path of the search to find the items 20 and 30
                    }
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("binary Tree:");
                MyBinaryTree theTree = new MyBinaryTree(); //creating a new intialised array called the tree and we use that to invoke our order traversals on the nodes for the binary search tree
                                                           //Insert the following number to the tree and keep the order
                                                           //25,15,26,13,22,30,20,23,28,33,16,17
                theTree.InsertNode(25);
                theTree.InsertNode(15);
                theTree.InsertNode(26);
                theTree.InsertNode(13);
                theTree.InsertNode(22);
                theTree.InsertNode(30);
                theTree.InsertNode(20);
                theTree.InsertNode(23);
                theTree.InsertNode(28);
                theTree.InsertNode(33);
                theTree.InsertNode(16);
                theTree.InsertNode(17);

                /*   ADD YOUR CODE HERE */
                //Do In-order traversal of this tree and print the items
                Console.WriteLine("This is the In Order traversal:"); // this helps us organise to the console what traversal it is for easier understanding
                theTree.Inorder(theTree.ReturnRoot());
                /*   ADD YOUR CODE HERE */

                //Do Pre-order traversal of this tree and print the items
                Console.WriteLine("This is the Pre-Order traversal:"); // this helps us organise to the console what traversal it is for easier understanding
                theTree.Preorder(theTree.ReturnRoot());
                /*   ADD YOUR CODE HERE */

                //Do Post-order traversal of this tree and print the items
                Console.WriteLine("This is the Post-Order traversal:"); // this helps us organise to the console what traversal it is for easier understanding
                theTree.Postorder(theTree.ReturnRoot());
                /*   ADD YOUR CODE HERE */

                Console.WriteLine("Searching for the item 20 using depth first search"); // this is the console writeline informing us of the inorderstack search for 20 is next
                Console.WriteLine("Searching for item 30 using breadth first search ");// this is the console writeline informing us of the breadthfirst search for 30 is next
                theTree.breadthfirst(theTree.root); // we call our breadth first search method using the tree intialsed and whtihin the parthensis call the root to start the search for 30

                Console.WriteLine("searching for both items 20 and 30 using recursion");
                theTree.rescursivesearch(theTree.root); // this will call the rescrusive search method to search for items 20 and 30

            }
        }
    }
}

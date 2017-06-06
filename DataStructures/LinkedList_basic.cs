using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Example:
///   (Reference to A)          --  A {Node[data, next(Reference to B)]} --  B{Node[data, next(Reference to C)]} -- C=null   
///    A random place which          Node A which has data and also next     Node B which has data and also next    Node C is null  
/// contains Node A address          which contains Node B address            which contains Node B address       
/// </summary>

namespace Linked_List_Basic
{
    /// <summary>
    /// This class creates an object NODE with data members int data and Node next
    /// Here Node next implies an instance of Node class where the next object is referenced.
    /// IMPORTANT: It's not node inside node but the chain of nodes. 
    /// This implies a NODE consists a address which is a refernece to new node.  
    /// </summary>
    public class Node
    {
        public int data;
        public Node next;

        public Node(int i)
        {
            data = i;
            next = null;
        }
        public void print()
        {
            Console.WriteLine("the data is " + data);  // This only prints the first node 
            if (next!=null)
            {
                //here print method can be called as next is an object of NODE class too similar to mynode
                //This statement calls this print function recursively until the line ends
                next.print(); 
             }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node mynode = new Node(7);
            // Next can be accesses here as mynode is object of class NODE and hence access to data members
            //Here mynode.data can also be accessed
            mynode.next = new Node(11);  
            mynode.next.next = new Linked_List_Basic.Node(8); // this is similar to Node(8)
            mynode.next.next.data = 10;
            mynode.print();
        }
    }
}

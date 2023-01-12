using EstruturaDeDados.DataStructs;

namespace ConsoleEstruturaDeDados;

public class Programa {

    static void Main(string[] args) {

        #region Testing Stack Struct

        //Stack stack = new Stack();

        //stack.push("1");
        //stack.push("2");

        //Console.WriteLine($"stack: {stack.ToString()}");

        //Console.WriteLine($"Removing last item from stack: {stack.pop()}");

        //Console.WriteLine($"stack: {stack.ToString()}");

        //Console.WriteLine($"Removing last item from stack:: {stack.pop()}");

        //Console.WriteLine($"stack: {stack.ToString()}");

        #endregion

        #region Testing Queue Struct

        //Queue queue = new Queue();
        //queue.Push(3); //add 3
        //queue.Push(4); //add 4
        //queue.Push(5); //add 5

        //Console.WriteLine(queue.ToString()); //show 3,4,5

        //Console.WriteLine(queue.Pop()); //remove 3
        //Console.WriteLine(queue.ToString()); // show 4,5

        //queue.Push(20); //add 20
        //queue.Push(30); //add 30
        //Console.WriteLine(queue.ToString()); //show 4,5,20,30

        //queue.Push(33); //add 33
        //queue.Pop(); //remove o 4
        //Console.WriteLine(queue.ToString()); //show 5,20,30,33

        #endregion

        #region Testing Deque Struct
        //Deque deque = new Deque();

        //deque.AddFront(1); 
        //deque.AddFront(2);
        //deque.AddFront(3);
        //Console.WriteLine(deque.ToString());

        //deque.RemoveBack();
        //Console.WriteLine(deque.ToString());

        //deque.RemoveFront();
        //Console.WriteLine(deque.ToString());
        #endregion

        #region Testing Linked List Struct
        //MyLinkedList myLinkedList = new MyLinkedList();
        //myLinkedList.Add(1);
        //myLinkedList.Add(2);
        //myLinkedList.Add(3);
        //myLinkedList.Add(4);
        //myLinkedList.Add(5);
        //myLinkedList.Add(6);
        //Console.WriteLine(myLinkedList.ToString());

        //myLinkedList.Remove();
        //Console.WriteLine(myLinkedList.ToString());

        //myLinkedList.AddAt(55,3);
        //myLinkedList.AddAt(44,0);
        //Console.WriteLine(myLinkedList.ToString());
        //myLinkedList.RemoveAt(0);
        //Console.WriteLine(myLinkedList.ToString());
        #endregion

        #region Testing Double Linked List Struct
            //MyDoublyLinkedList myDoubleLinkedList = new MyDoublyLinkedList();

            //myDoubleLinkedList.Add(1);
            //myDoubleLinkedList.Add(2);
            //Console.WriteLine($"Add 1 and 2: {myDoubleLinkedList.ToString()}");

            //myDoubleLinkedList.AddAt(3,2);
            //Console.WriteLine($"Add 3 at position 2: {myDoubleLinkedList.ToString()}");

            //Console.WriteLine($"Removing a element: {myDoubleLinkedList.Remove()}");
            //Console.WriteLine($"Remove: {myDoubleLinkedList.ToString()}");

            //myDoubleLinkedList.Add(4);
            //Console.WriteLine($"Add 4: {myDoubleLinkedList.ToString()}");

            //Console.WriteLine($"Removing a element at position 2: {myDoubleLinkedList.RemoveAt(2)}");
            //Console.WriteLine($"Remove at position 2: {myDoubleLinkedList.ToString()}");
        #endregion

        #region  Testing Set Struct
            MySet newSet = new MySet();
            newSet.Add(1);
            System.Console.WriteLine($"MySet: {newSet.Values().ToString()}");
            newSet.Add(2);
            System.Console.WriteLine($"MySet: {newSet.Values().ToString()}");
            newSet.Add(2);
            System.Console.WriteLine($"MySet: {newSet.Values().ToString()}");
            newSet.Add(3);
            System.Console.WriteLine($"MySet: {newSet.Values().ToString()}");
            newSet.Remove(2);
            System.Console.WriteLine($"MySet: {newSet.Values().ToString()}");

            
        #endregion
    }
}
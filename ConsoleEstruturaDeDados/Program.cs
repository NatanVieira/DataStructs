using EstruturaDeDados;

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
            Deque deque = new Deque();

            deque.AddFront(1); 
            deque.AddFront(2);
            deque.AddFront(3);
            Console.WriteLine(deque.ToString());

            deque.RemoveBack();
            Console.WriteLine(deque.ToString());

            deque.RemoveFront();
            Console.WriteLine(deque.ToString());
        #endregion
    }
}
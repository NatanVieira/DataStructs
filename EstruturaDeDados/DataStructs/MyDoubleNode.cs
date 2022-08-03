namespace EstruturaDeDados.DataStructs;

public class MyDoubleNode {

    #region Props
        public MyDoubleNode? Next {get;set;}
        public MyDoubleNode? Previous {get;set;}
        public  object? Element {get;set;}
    #endregion

    #region  Constructors
        public MyDoubleNode() { }

        public MyDoubleNode(MyDoubleNode next, MyDoubleNode previous, object element){
            this.Next = next;
            this.Previous = previous;
            this.Element = element;
        }
    #endregion
}
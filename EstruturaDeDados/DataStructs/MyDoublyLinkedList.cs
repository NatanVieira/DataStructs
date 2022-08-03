namespace EstruturaDeDados.DataStructs;

public class MyDoublyLinkedList {

    #region Props
        public List<MyDoubleNode> Elements { get; set; }
        public int Count { get; set; }
    #endregion

    #region Constructors
    public MyDoublyLinkedList() { 
        this.Elements = new List<MyDoubleNode>();
        this.Count = 0;
    }
    #endregion

    #region Methods
    //Methods Size, IsEmpty, AddAt, RemoveAt, Add, Remove, ToString, GetNodeAt

    public int Size() => this.Count;

    public bool IsEmpty() => this.Size() == 0;

    public MyDoubleNode GetNodeAt(int index) {
        if(!this.IsEmpty()) {
            return this.Elements[index - 1];
        }
        return null;
    }
    public void Add(object element) {
        MyDoubleNode node = new MyDoubleNode();
        if(!this.IsEmpty()) {
            MyDoubleNode nodePrevius = this.GetNodeAt(this.Size());
            node.Element = element;
            node.Previous = nodePrevius;
            node.Next = null;
            nodePrevius.Next = node;
        } else {
            node.Element = element;
        }
        this.Elements.Add(node);
        this.Count++;
    }

    public override string ToString() {
        if(!this.IsEmpty()) {
            string elementsString = "";
            this.Elements.ForEach(e =>
            {
                elementsString += $"{e.Element?.ToString()},";
            });
            elementsString = elementsString.Length > 0 ? elementsString.Substring(0,elementsString.Length - 1) : "";
            return elementsString;
        }
        return "";
    }
    #endregion
}
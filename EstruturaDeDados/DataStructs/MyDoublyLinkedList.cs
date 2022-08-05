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
    //Methods RemoveAt

    public int Size() => this.Count;

    public bool IsEmpty() => this.Size() == 0;

    public MyDoubleNode GetNodeAt(int index) {
        if(!this.IsEmpty()) {
            return this.Elements[index];
        }
        return null;
    }
    public void Add(object element) {
        MyDoubleNode node = new MyDoubleNode();
        if(!this.IsEmpty()) {
            MyDoubleNode nodePrevius = this.GetNodeAt(this.Size() - 1);
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

    public void AddAt(object element, int index) {
        IndexValidation(index);
        MyDoubleNode node = new MyDoubleNode();
        if(!this.IsEmpty()) {
            MyDoubleNode nodePrevius = this.GetNodeAt(index - 1);
            node.Element = element;
            node.Previous = nodePrevius.Previous;
            node.Next = nodePrevius;
            nodePrevius.Previous = node;
            this.Add(node);
            for(int i = this.Size() - 1; i >= index;i--) {
                this.Elements[i] = this.Elements[i - 1];
            }
            this.Elements[index - 1] = node;
        } else {
            node.Element = element;
            node.Next= null;
            node.Previous = null;
            this.Add(node);
        }
    }

    public object Remove() {
        if(!this.IsEmpty()) {
            MyDoubleNode node = this.GetNodeAt(this.Size() - 1);
            node.Previous.Next = null;
            this.Elements.Remove(node);
            this.Count--;
            return node.Element;
        }
        return null;
    }

    public object RemoveAt(int index) {
        IndexValidation(index);
        if(!this.IsEmpty()) {
            MyDoubleNode node = this.GetNodeAt(index - 1);
            node.Previous.Next = node.Next;
            node.Next.Previous = node.Previous;
            this.Elements.Remove(node);
            this.Count--;
            return node.Element;
        }
        return null;
    }

    public override string ToString() {
        if(!this.IsEmpty()) {
            string elementsString = "";
            for(int i = 0; i < this.Count;i++) {
                elementsString += $"{this.Elements[i].Element?.ToString()},";
            }
            elementsString = elementsString.Length > 0 ? elementsString.Substring(0,elementsString.Length - 1) : "";
            return elementsString;
        }
        return "";
    }
    private void IndexValidation(int index) {
        if(index < 0 || index >= this.Count)
            throw new IndexOutOfRangeException();
    }

    #endregion
}
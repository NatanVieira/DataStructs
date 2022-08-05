namespace EstruturaDeDados.DataStructs {
    public class MyLinkedList {
        #region Props
            public int Count { get; set; }
            public List<MyNode> Elements { get; set; }
        #endregion

        #region Constructors
            public MyLinkedList() {
                this.Count = 0;
                this.Elements = new List<MyNode>();
            }
        #endregion

        #region Methods

            public int Size() => this.Count;
            public bool IsEmpty() => this.Size() == 0;

            private MyNode getNodeAt(int index) {
                MyNode node = this.Elements[0];
                for(int i = 1;i <= index;i++) {
                    node = this.Elements[i];
                }
                return node;
            }

            public void Add(object element) {
                MyNode node = new MyNode(element, null);
                if(!this.IsEmpty())
                    this.Elements[this.Count - 1].Next = node;
                this.Elements.Add(node);
                this.Count++;
            }

            public object Remove() {
                if(!this.IsEmpty()) {
                    object elementReturn = this.Elements[this.Count - 1].Element;
                    this.Elements[this.Count - 2].Next = null;
                    this.Elements.Remove(this.Elements[this.Count -1]);
                    this.Count--;
                    return elementReturn;
                }
                return null;
            }

            public void AddAt(object element, int index) {
                IndexValidation(index);
                MyNode node = new MyNode(element,this.getNodeAt(index));
                MyNode auxNode = this.getNodeAt(index - 1);
                auxNode.Next = node;
                this.Elements.Add(node);
                for(int i = this.Count - 1; i >= index;i--) {
                    this.Elements[i + 1] = this.Elements[i];
                }
                this.Elements[index] = node;
                this.Count++;
            }

            public object RemoveAt(int index) {
                IndexValidation(index);
                if(!this.IsEmpty()) {
                    object elementReturn = this.getNodeAt(index).Element;
                    if(index > 0) {
                        MyNode auxNode = this.getNodeAt(index - 1);
                        auxNode.Next = index == this.Count - 1 ? null : this.getNodeAt(index + 1);
                    }
                    this.Elements.RemoveAt(index);
                    this.Count--;
                    return elementReturn;
                }
                return null;
            }

            private void IndexValidation(int index) {
                if(index < 0 || index >= this.Count)
                    throw new IndexOutOfRangeException();
            }

            public override string ToString() {
                string listString = "";
                if(!this.IsEmpty()) {
                    for(int i = 0;i < this.Count;i++) {
                        listString = listString + this.getNodeAt(i).Element.ToString() + ",";
                    }
                    listString = listString.Substring(0,listString.Length - 1);
                }
                return listString;
            }

        #endregion
    }
}

namespace EstruturaDeDados.DataStructs {
    public class MyLinkedList {
        #region Props
            private int count;
            private List<MyNode> myLinkedList;
        #endregion

        #region Constructors
            public MyLinkedList() {
                this.count = 0;
                this.myLinkedList = new List<MyNode>();
            }
        #endregion

        #region Methods

            public int Size() => this.count;
            public bool IsEmpty() => this.Size() == 0;

            private MyNode getNodeAt(int index) {
                MyNode node = this.myLinkedList[0];
                for(int i = 1;i <= index;i++) {
                    node = this.myLinkedList[i];
                }
                return node;
            }

            public void Add(object element) {
                MyNode node = new MyNode(element, null);
                if(!this.IsEmpty())
                    this.myLinkedList[this.count - 1].Next = node;
                this.myLinkedList.Add(node);
                this.count++;
            }

            public object Remove() {
                if(!this.IsEmpty()) {
                    object elementReturn = this.myLinkedList[this.count - 1].Element;
                    this.myLinkedList[this.count - 2].Next = null;
                    this.myLinkedList.Remove(this.myLinkedList[this.count -1]);
                    this.count--;
                    return elementReturn;
                }
                return null;
            }

            public void AddAt(object element, int index) {
                IndexValidation(index);
                MyNode node = new MyNode(element,this.getNodeAt(index));
                MyNode auxNode = this.getNodeAt(index - 1);
                auxNode.Next = node;
                this.myLinkedList.Add(node);
                for(int i = this.count - 1; i >= index;i--) {
                    this.myLinkedList[i + 1] = this.myLinkedList[i];
                }
                this.myLinkedList[index] = node;
                this.count++;
            }

            public object RemoveAt(int index) {
                IndexValidation(index);
                if(!this.IsEmpty()) {
                    object elementReturn = this.getNodeAt(index).Element;
                    if(index > 0) {
                        MyNode auxNode = this.getNodeAt(index - 1);
                        auxNode.Next = index == this.count - 1 ? null : this.getNodeAt(index + 1);
                    }
                    this.myLinkedList.RemoveAt(index);
                    this.count--;
                    return elementReturn;
                }
                return null;
            }

            private void IndexValidation(int index) {
                if(index < 0 || index >= this.count)
                    throw new IndexOutOfRangeException();
            }

            public override string ToString() {
                string listString = "";
                if(!this.IsEmpty()) {
                    for(int i = 0;i < this.count;i++) {
                        listString = listString + this.getNodeAt(i).Element.ToString() + ",";
                    }
                    listString = listString.Substring(0,listString.Length - 1);
                }
                return listString;
            }

        #endregion
    }
}

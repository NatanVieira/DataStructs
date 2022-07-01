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
        //AddAt, RemoveAt,ToString, Remove, Add

        public int Size() => this.count;
        public bool IsEmpty() => this.Size() == 0;

        public void Add(object element) {
            MyNode node = new MyNode(element, null);
            this.myLinkedList[this.count - 1].Next = node;
            this.myLinkedList.Add(node);
            this.count++;
        }

        #endregion
    }
}

namespace EstruturaDeDados.DataStructs {
    public class MyNode {
        #region Props
        private MyNode next;
        private object element;
        #endregion

        #region Constructors

        public MyNode(object element,MyNode next) {
            this.element = element;
            this.next = next;
        }

        #endregion

        #region Methods
        public MyNode Next { get { return this.next; } set { this.next = value; } }
        public object Element {get {return this.element;} set {this.element = value; } }
        #endregion
    }
}

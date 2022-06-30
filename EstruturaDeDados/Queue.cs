namespace EstruturaDeDados {
    public class Queue {
        #region Props
            private int count;
            private List<object> queue;
        #endregion

        #region Constructors
            public Queue() {
                this.queue = new List<object>();
                this.count = 0;
            }
        #endregion

        #region Methods
            public int Size() => this.count;

            public bool IsEmpty() => this.Size() == 0;

            public void Push(object element) {
                this.queue.Add(element);
                this.count++;
            }

            public object Pop() {
                if(!this.IsEmpty()) {
                    object elementReturn = this.queue[ 0 ];
                    for(int i = 1;i < this.count;i++) {
                        this.queue[ i - 1 ] = this.queue[ i ];
                    }
                    this.queue.RemoveAt(this.count - 1);
                    this.count--;
                    return elementReturn;
                }
                return null;
            }

            public override string ToString() {
                string queueString = "";
                if(!this.IsEmpty()) {
                    for(int i = 0;i < this.count;i++) {
                        queueString = $"{queueString}{this.queue[ i ]},";
                    }
                    queueString = queueString.Substring(0,queueString.Length - 1);
                }
                return queueString;
            }
        #endregion
    }
}

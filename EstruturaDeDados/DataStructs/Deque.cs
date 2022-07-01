namespace EstruturaDeDados.DataStructs {
    public class Deque {
        #region Props
            private int count;
            private List<Object> deque;
        #endregion

        #region Constructors
            public Deque() {
                this.count = 0;
                this.deque = new List<object> ();
            }
        #endregion

        #region Methods
            public int Size() => this.count;

            public bool IsEmpty() => this.Size() == 0;

            public void AddBack(object element) {
                this.deque.Add(element);
                this.count++;
            }

            public object RemoveBack() {
                object elementReturn = this.deque[this.count - 1];
                this.deque.RemoveAt(this.count - 1);
                this.count--;
                return elementReturn;
            }

            public void AddFront(object element) {
                if(this.IsEmpty())
                    this.AddBack(element);
                else {
                    this.AddBack(this.deque[this.count - 1]);
                    for(int i = this.count - 2; i >= 0;i--) {
                        this.deque[i + 1] = this.deque[i];
                    }
                    this.deque[0] = element;
                }
            }

            public object RemoveFront() {
                if(!this.IsEmpty()) {
                    object elementReturn = this.deque[ 0 ];
                    for(int i = 1;i < this.count;i++) {
                        this.deque[i - 1] = this.deque[i];
                    }
                    this.deque.RemoveAt(this.count - 1);
                    this.count--;
                    return elementReturn;
                }
                return null;
            }

            public override string ToString() {
                if(!this.IsEmpty()) {
                    string dequeString = "";
                    for(int i = 0;i < this.count;i++) {
                        dequeString = $"{dequeString}{this.deque[i]},";
                    }
                    return dequeString.Substring(0,dequeString.Length - 1);
                }
                return "";
            }
        #endregion
    }
}

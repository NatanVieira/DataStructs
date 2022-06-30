namespace EstruturaDeDados {
    public class Deque {
        #region Atributos
            private int count;
            private List<Object> deque;
        #endregion

        #region Construtores
            public Deque() {
                this.count = 0;
                this.deque = new List<object> ();
            }
        #endregion

        #region Métodos
            public int Size() => this.count;

            public bool IsEmpty() => this.Size() == 0;

            public void AddBack(object elemento) {
                this.deque.Add(elemento);
                this.count++;
            }

            public object RemoveBack() {
                object elementoRetorno = this.deque[this.count - 1];
                this.count--;
                this.deque.RemoveAt(this.count - 1);
                return elementoRetorno;
            }

            public void AddFront(object elemento) {
                if(this.IsEmpty())
                    this.AddBack(elemento);
                else {
                    this.AddBack(this.deque[this.count - 1]);
                    for(int i = this.count - 2; i >= 0;i--) {
                        this.deque[i + 1] = this.deque[i];
                    }
                    this.deque[0] = elemento;
                }
                this.count++;
            }

            public object RemoveFront() {
                if(!this.IsEmpty()) {
                    object elementoRetorno = this.deque[ 0 ];
                    for(int i = 1;i < this.count;i++) {
                        this.deque[i - 1] = this.deque[i];
                    }
                    this.deque.RemoveAt(this.count - 1);
                    this.count--;
                    return elementoRetorno;
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

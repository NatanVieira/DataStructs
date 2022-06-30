namespace EstruturaDeDados {
    public class Fila {
        #region Atributos
            private int count;
            private List<object> fila;
        #endregion

        #region Construtores
            public Fila() {
                this.fila = new List<object>();
                this.count = 0;
            }
        #endregion

        #region Métodos
        public int Size() => this.count;

        public bool IsEmpty() => this.Size() == 0;

        public void Push(object elemento) {
            this.fila.Add(elemento);
            this.count++;
        }

        public object Pop() {
            if(!this.IsEmpty()) {
                object elementoRetorno = this.fila[ 0 ];
                for(int i = 1;i < this.count;i++) {
                    this.fila[ i - 1 ] = this.fila[ i ];
                }
                this.fila.RemoveAt(this.count - 1);
                this.count--;
                return elementoRetorno;
            }
            return null;
        }

        public override string ToString() {
            string filaString = "";
            if(!this.IsEmpty()) {
                for(int i = 0;i < this.count;i++) {
                    filaString = $"{filaString}{this.fila[ i ]},";
                }
                filaString = filaString.Substring(0,filaString.Length - 1);
            }
            return filaString;
        }
        #endregion
    }
}

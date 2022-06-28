namespace EstruturaDeDados {
    public class Fila {
        private int count;
        private List<Object> fila;

        public Fila() {
            this.fila = new List<Object>();
            this.count = 0;
        }

        public int Size() => this.count;

        public bool isEmpty() => this.Size() == 0;

        public void Push(Object elemento) {
            this.fila.Add(elemento);
            this.count++;
        }

        public object Pop() {
            if(!this.isEmpty()) {
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
            if(!this.isEmpty()) {
                string filaString = "";
                for(int i = 0;i < this.count;i++) {
                    filaString = $"{filaString}{this.fila[ i ]},";
                }
                return filaString.Substring(0,filaString.Length - 1);
            }
            return "";
        }

    }
}

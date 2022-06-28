namespace EstruturaDeDados
{
    public class Pilha
    {
        private int count;
        private List<Object> elementos;

        public int Count { get; set; }

        public int size() => this.count;

        public bool isEmpty() => this.size() == 0;

        public void push(Object elemento)
        {
            if(this.elementos == null)
                this.elementos = new List<Object>();

            if(elemento != null) {
                this.elementos.Add(elemento);
                this.count++;
            }

        }

        public Object pop()
        {
            Object elementoRetorno = this.elementos.ElementAt(this.count - 1);
            this.elementos.RemoveAt(this.count - 1);
            this.count--;
            return elementoRetorno;
        }

        public override string ToString()
        {
            string elementosString = "";
            if (!this.isEmpty()) {
                for(int i = 0; i <= this.size() - 1;i++) {
                    elementosString = $"{elementosString}{this.elementos[i]}";
                    if(!(i == this.size() - 1))
                        elementosString += ",";
                }
            }
            return elementosString;
        }
    }
}
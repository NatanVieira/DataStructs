namespace EstruturaDeDados
{
    public class Pilha
    {
        #region Atributos
            private int count;
            private List<object> pilha;
        #endregion

        #region Construtores
            public Pilha() {
            this.count = 0;
            this.pilha = new List<object>();
        }
        #endregion

        #region Métodos
            public int size() => this.count;

            public bool IsEmpty() => this.size() == 0;

            public void push(object elemento)
            {
                if(this.pilha == null)
                    this.pilha = new List<object>();

                if(elemento != null) {
                    this.pilha.Add(elemento);
                    this.count++;
                }
            }

            public object pop()
            {
                if(!this.IsEmpty()) {
                    object elementoRetorno = this.pilha.ElementAt(this.count - 1);
                    this.pilha.RemoveAt(this.count - 1);
                    this.count--;
                    return elementoRetorno;
                }
                return null;
            }

            public override string ToString()
            {
                string pilhaString = "";
                if (!this.IsEmpty()) {
                    for(int i = 0; i <= this.size() - 1;i++) {
                        pilhaString = $"{pilhaString}{this.pilha[i]}";
                        pilhaString = pilhaString.Substring(0,pilhaString.Length - 1);
                    }
                }
                return pilhaString;
            }
        #endregion
    }
}
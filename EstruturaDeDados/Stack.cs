namespace EstruturaDeDados
{
    public class Stack
    {
        #region Props
            private int count;
            private List<object> stack;
        #endregion

        #region Constructors
            public Stack() {
            this.count = 0;
            this.stack = new List<object>();
        }
        #endregion

        #region Methods
            public int size() => this.count;

            public bool IsEmpty() => this.size() == 0;

            public void push(object element)
            {
                if(this.stack == null)
                    this.stack = new List<object>();

                if(element != null) {
                    this.stack.Add(element);
                    this.count++;
                }
            }

            public object pop()
            {
                if(!this.IsEmpty()) {
                    object elementReturn = this.stack.ElementAt(this.count - 1);
                    this.stack.RemoveAt(this.count - 1);
                    this.count--;
                    return elementReturn;
                }
                return null;
            }

            public override string ToString()
            {
                string stackString = "";
                if (!this.IsEmpty()) {
                    for(int i = 0; i <= this.size() - 1;i++) {
                        stackString = $"{stackString}{this.stack[i]}";
                        stackString = stackString.Substring(0,stackString.Length - 1);
                    }
                }
                return stackString;
            }
        #endregion
    }
}
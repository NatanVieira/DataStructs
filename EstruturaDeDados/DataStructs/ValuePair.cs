
namespace EstruturaDeDados.DataStructs {

    public class ValuePair {

        #region Variables
            private object key;
            private object value;
        #endregion

        #region  methods 
            public ValuePair(object key, object value){
                this.key = key;
                this.value = value;
            }

            public object GetValue(){
                return this.value;
            }
            public object GetKey(){
                return this.key;
            }
        #endregion
    }
}
namespace EstruturaDeDados.DataStructs {

    public class Dict {

        #region variables
            private List<ValuePair> dict;
        #endregion

        #region  Constructor
            public Dict(){
                this.dict = new List<ValuePair>();
            }
        #endregion

        #region  Methoods
            public int Size(){
                return this.dict.Count;
            }
            
            public bool isEmpty(){
                return this.Size() == 0;
            }

            public bool Exists(Object key){
                for(int i = 0; i < this.Size(); i++){
                    if(this.dict[i].GetKey() == key)
                        return true;
                }
                return false;
            }

            public bool Add(ValuePair valuePair){
                if(!this.Exists(valuePair.GetKey())){
                    this.dict.Add(valuePair);
                    return true;
                }
                return false;
            }

            public bool Remove(Object key){
                if(this.Exists(key)){
                    ValuePair vp = this.GetValuePairFromKey(key);
                    if (vp != null) {
                        this.dict.Remove(vp);
                        return true;
                    }
                    return false;
                }
                return false;
            }

            public List<Object> Values(){
                List<object> values = new List<object>();
                for(int i = 0; i < this.Size(); i++){
                    values.Add(this.dict[i].GetValue());
                }
                return values;
            }
            private ValuePair GetValuePairFromKey(Object key){
                if(this.Exists(key)){
                    for(int i = 0; i < this.Size(); i++){
                        if(this.dict[i].GetKey() == key)
                            return this.dict[i];
                    }
                }
                return null;
            }
        #endregion
    }
}
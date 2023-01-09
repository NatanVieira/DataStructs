namespace EstruturaDeDados.DataStructs {

    public class MySet {
        #region  props
            private List<object> set;
        #endregion

        #region  constructor
            public MySet (){
                this.set = new List<object>();
            }
        #endregion

        #region  Methods 
            //Methods add, remove, size, values
            public bool Add(object element){
                if(!this.Exists(element)){
                    set.Add(element);
                    return true;
                }
                return false;
            }

            public bool Remove(object element){
                if(this.Exists(element)){
                    set.Remove(element);
                    return true;
                }
                return false;
            }

            public int Size(){
                return set.Count;
            }

            public List<object> Values(){
                return this.set;
            }

            public bool Exists(object element) {
                if (set.Count == 0)
                    return false;
                for(int i = 0; i < this.Size(); i++){
                    if (this.GetElementByPosition(i) == element)
                        return true;
                }
                return false;
            }
            public object GetElementByPosition(int position){
                return this.set[position];
            }
            //Operations Union, Intersection, Diference and SubSet

            public bool IsSubSet(MySet otherSet){
                if(this.Size() > otherSet.Size())
                    return false;
                for(int i = 0; i < this.Size(); i++){
                    if(!otherSet.Exists(this.GetElementByPosition(i)))
                        return false;
                }
                return true;
            }

            public MySet Union(MySet otherSet){
                MySet unionSet = new MySet();
                for(int i = 0; i < this.Size(); i++)
                    unionSet.Add(this.GetElementByPosition(i));
                for(int i = 0; i < otherSet.Size(); i++)
                    unionSet.Add(otherSet.GetElementByPosition(i));
                return unionSet;
            }

        #endregion

    }
}
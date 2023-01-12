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
            //Operations Union, Intersection, Diference and isSubSet

            public bool IsSubSet(MySet otherSet){
                if(this.Size() > otherSet.Size())
                    return false;
                for(int i = 0; i < this.Size(); i++){
                    if(!otherSet.Exists(this.GetElementByPosition(i)))
                        return false;
                }
                return true;
            }

            public MySet Union(MySet otherSet){ //Junção dos dois
                MySet unionSet = new MySet();
                for(int i = 0; i < this.Size(); i++)
                    unionSet.Add(this.GetElementByPosition(i));
                for(int i = 0; i < otherSet.Size(); i++)
                    unionSet.Add(otherSet.GetElementByPosition(i));
                return unionSet;
            }
            public MySet Intersection (MySet otherSet){ // Tem que estar em A e em B
                MySet intersectionSet = new MySet();
                List<object> smallerSet = this.Values();
                List<object> biggerSet  = otherSet.Values();
                if(smallerSet.Count > biggerSet.Count){
                    smallerSet = otherSet.Values();
                    biggerSet  = this.Values();
                }
                for(int i = 0; i < smallerSet.Count; i++){
                    Object obj = smallerSet[i];
                    if(biggerSet.Exists((System.Predicate<object>)obj))
                        intersectionSet.Add(smallerSet[i]);
                }
                return intersectionSet;
            }

            public MySet Diference (MySet otherSet){
                MySet diferenceSet = new MySet();

                for(int i = 0; i < this.Size(); i++){
                    if(!otherSet.Exists(this.GetElementByPosition(i)))
                        diferenceSet.Add(this.GetElementByPosition(i));
                }
                return diferenceSet;
            }
        #endregion

    }
}
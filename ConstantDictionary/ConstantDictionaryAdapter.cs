using System;
using System.Collections.Generic;
namespace ICT2106.ConstantDictionary
{

    class ConstantDictionaryAdapter<K, V>: IConstantDictionary<int, String> 
    {
        IDictionary <int, String> list;
       
        public ConstantDictionaryAdapter(IDictionary <int, String> dicList){
            list = dicList;
        }

        public bool ContainsKey(int key){
            bool result = false;

            foreach(var entry in list)
            {
                if(entry.Key == key){
                    result = true;
                    break;
                }
            }

            return result;
        }

        public bool ContainsValue(String value){
            bool result = false;

            foreach(var entry in list)
            {
                if(entry.Value == value){
                    result = true;
                    break;
                }
            }

            return result;
        }

        new public bool Equals(object o){
            return list.Equals(o);
        }
        
        public Dictionary<int, String>.Enumerator GetEnumerator(){
            
            Dictionary<int, String> mutableDict = new Dictionary<int, String>();
            foreach(var entry in list)
            {
                mutableDict.Add(entry.Key, entry.Value);
            }
            
            return mutableDict.GetEnumerator();
        }

        new public int GetHashCode(){
            return list.GetHashCode();
        }
        
        new public string ToString(){
            return list.ToString();
        }
        
        public bool TryGetValue(int key, out String defaultValue){
            return list.TryGetValue(key, out defaultValue);
        }
    }
}
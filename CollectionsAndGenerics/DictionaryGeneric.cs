using System.Collections.Generic;

namespace Collections
{
    public class DictionaryGeneric<TKey, TValue>
    {
        private Dictionary<TKey, TValue> dict = new Dictionary<TKey, TValue>();
        
        public void AddItem(TKey key, TValue value)
        {
            dict.Add(key, value);
        }
        
        public TValue GetItem(TKey key)
        {
            return dict[key];
        }
        
        public bool ContainsKey(TKey key)
        {
            return dict.ContainsKey(key);
        }
        
        public void RemoveItem(TKey key)
        {
            dict.Remove(key);
        }
        
        public int Count => dict.Count;
    }
}

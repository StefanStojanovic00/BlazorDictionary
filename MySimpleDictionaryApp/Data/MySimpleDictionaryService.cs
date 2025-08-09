using System;
using System.Collections.Generic;
using System.Linq;

namespace MySimpleDictionaryApp.Data
{

    public class MySimpleDictionaryService
    {
        private readonly MySimpleDictionary<string, string> dictionary = new();

        public event Action OnChange; 

        public List<KeyValuePair<string, string>> GetAll() => dictionary.ToList();

        public void Add(string key, string value)
        {
            dictionary.Add(key, value);
            NotifyStateChanged();
        }

        public bool Remove(string key)
        {
            var removed = dictionary.Remove(key);
            if (removed) NotifyStateChanged();
            return removed;
        }

        public void Clear()
        {
            dictionary.Clear();
            NotifyStateChanged();
        }

        public bool ContainsKey(string key) => dictionary.ContainsKey(key);
        public bool ContainsValue(string value) => dictionary.ContainsValue(value);

        public int Count => dictionary.Count;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

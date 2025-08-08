using System;
using System.Collections.Generic;
using System.Linq;

namespace MySimpleDictionaryApp.Data
{

    public class MySimpleDictionaryService
    {
        private readonly MySimpleDictionary<string, string> dictionary = new();

        public void Add(string key, string value)
        {
            dictionary[key] = value;
        }

        public bool TryGet(string key, out string value)
        {
            return dictionary.TryGetValue(key, out value);
        }

        public IEnumerable<KeyValuePair<string, string>> GetAll()
        {
            return dictionary.ToList();
        }

        public void Remove(string key)
        {
            dictionary.Remove(key);
        }

        public void Clear()
        {
            dictionary.Clear();
        }
    }
}

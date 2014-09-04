using System;
using System.Collections.Generic;

namespace EbInstanceModel
{
    public class P21InstanceDictionary<T> : IDictionary<uint, T>
    {
        private readonly SortedDictionary<uint, T> _internalDict = new SortedDictionary<uint, T>();

        public SortedDictionary<uint, T> Dictionary
        {
            get { return _internalDict; }
        }

        public String Name { get; set; }

        public void Add(uint key, T value)
        {
            _internalDict.Add(key, value);
        }

        public bool ContainsKey(uint key)
        {
            return _internalDict.ContainsKey(key);
        }

        public ICollection<uint> Keys
        {
            get { return _internalDict.Keys; }
        }

        public bool Remove(uint key)
        {
            return _internalDict.Remove(key);
        }

        public bool TryGetValue(uint key, out T value)
        {
            return _internalDict.TryGetValue(key, out value);
        }

        public ICollection<T> Values
        {
            get { return _internalDict.Values; }
        }

        public T this[uint key]
        {
            get
            {
                return _internalDict[key];
            }
            set
            {
                _internalDict[key] = value;
            }
        }

        #region ICollection<KeyValuePair<int,T>> Members

        public void Add(KeyValuePair<uint, T> item)
        {
            _internalDict.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            _internalDict.Clear();
        }

        public bool Contains(KeyValuePair<uint, T> item)
        {
            return (_internalDict.ContainsKey(item.Key) && _internalDict.ContainsValue(item.Value));
        }

        public void CopyTo(KeyValuePair<uint, T>[] array, int arrayIndex)
        {
            throw new NotImplementedException("do not use");
        }

        public int Count
        {
            get { return _internalDict.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(KeyValuePair<uint, T> item)
        {
            throw new NotImplementedException();
        }

        #endregion ICollection<KeyValuePair<int,T>> Members

        #region IEnumerable<KeyValuePair<uint, T>> Members

        public IEnumerator<KeyValuePair<uint, T>> GetEnumerator()
        {
            return _internalDict.GetEnumerator();
        }

        #endregion IEnumerable<KeyValuePair<uint, T>> Members

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _internalDict.GetEnumerator();
        }

        #endregion IEnumerable Members
    }
}
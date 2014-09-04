//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Collections.Specialized;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;


//namespace Sem.Service
//{

//    /// <summary>
//    /// Dictionary uses Guid
//    /// </summary>
//    /// <typeparam name="T"></typeparam>
//    public class BbInstanceDictionary<T> : IDictionary<Guid, T>, INotifyCollectionChanged, INotifyPropertyChanged
//    {
//        private readonly SortedDictionary<Guid, T> _internalDict
//            = new SortedDictionary<Guid, T>();

//        private readonly Dictionary<Type, BbInstanceTypeList<T>> _typedDic
//            = new Dictionary<Type, BbInstanceTypeList<T>>();

//        public ICollection<T> GetTypeOf(Type type)
//        {
//            if (_typedDic.ContainsKey(type))
//            {
//                return _typedDic[type];
//            }

//            throw new KeyNotFoundException();
//        }

//        public bool ContainsType(Type type)
//        {
//            return _typedDic.ContainsKey(type);
//        }

//        public SortedDictionary<Guid, T> Dictionary
//        {
//            get { return _internalDict; }
//        }

//        public String Name { get; set; }

//        public void Add(Guid key, T value)
//        {
//            _internalDict.Add(key, value);
//            OnCollectionChanged(NotifyCollectionChangedAction.Add, new KeyValuePair<Guid, T>(key, value));
//        }

//        public bool ContainsKey(Guid key)
//        {
//            return _internalDict.ContainsKey(key);
//        }

//        public ICollection<Guid> Keys
//        {
//            get { return _internalDict.Keys; }
//        }

//        public bool Remove(Guid key)
//        {
//            return _internalDict.Remove(key);
//        }

//        public bool TryGetValue(Guid key, out T value)
//        {
//            return _internalDict.TryGetValue(key, out value);
//        }

//        public ICollection<T> Values
//        {
//            get { return _internalDict.Values; }
//        }

//        public T this[Guid key]
//        {
//            get { return _internalDict[key]; }
//            set { _internalDict[key] = value; }
//        }

//        #region ICollection<KeyValuePair<Guid,T>> Members

//        public void Add(KeyValuePair<Guid, T> item)
//        {
//            Add(item.Key, item.Value);

//        }


     


//        public void Clear()
//        {
//            if (_internalDict.Count > 0)
//            {
//                _internalDict.Clear();
//                OnCollectionChanged();
//            }

//        }

//        public bool Contains(KeyValuePair<Guid, T> item)
//        {
//            return (_internalDict.ContainsKey(item.Key) && _internalDict.ContainsValue(item.Value));
//        }

//        public void CopyTo(KeyValuePair<Guid, T>[] array, int arrayIndex)
//        {
//            throw new NotImplementedException("do not use");
//        }

//        public int Count
//        {
//            get { return _internalDict.Count; }
//        }

//        public bool IsReadOnly
//        {
//            get { return true; }
//        }

//        public bool Remove(KeyValuePair<Guid, T> item)
//        {
//            //throw new NotImplementedException();
//            return _internalDict.Remove(item.Key);
//        }

//        #endregion ICollection<KeyValuePair<Guid,T>> Members

//        #region IEnumerable<KeyValuePair<Guid, T>> Members

//        public IEnumerator<KeyValuePair<Guid, T>> GetEnumerator()
//        {
//            return _internalDict.GetEnumerator();
//        }

//        #endregion IEnumerable<KeyValuePair<Guid, T>> Members

//        #region IEnumerable Members

//        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
//        {
//            return _internalDict.GetEnumerator();
//        }

//        #endregion IEnumerable Members


//        public event NotifyCollectionChangedEventHandler CollectionChanged;

//        public event PropertyChangedEventHandler PropertyChanged;

//        //private const string CountString = "Count";
//        //private const string IndexerName = "Item[]";
//        //private const string KeysName = "Keys";
//        //private const string ValuesName = "Values";

//        private void OnPropertyChanged()
//        {
//            //OnPropertyChanged(CountString);
//            //OnPropertyChanged(IndexerName);
//            //OnPropertyChanged(KeysName);
//            //OnPropertyChanged(ValuesName);
//        }

//        protected virtual void OnPropertyChanged(string propertyName)
//        {
//            if (PropertyChanged != null)
//                PropertyChanged(
//                    this,
//                    new PropertyChangedEventArgs(propertyName));
//        }
//        private void OnCollectionChanged()
//        {
//            OnPropertyChanged();
//            if (CollectionChanged != null)
//                CollectionChanged(
//                    this,
//                    new NotifyCollectionChangedEventArgs(
//                        NotifyCollectionChangedAction.Reset));

//        }
//        private void OnCollectionChanged(
//            NotifyCollectionChangedAction action,
//            KeyValuePair<Guid, T> changedItem)
//        {
//            OnPropertyChanged();
//            if (CollectionChanged != null)
//                CollectionChanged(this, new NotifyCollectionChangedEventArgs(action, changedItem));
//        }
//        private void OnCollectionChanged(
//            NotifyCollectionChangedAction action,
//            KeyValuePair<Guid, T> newItem,
//            KeyValuePair<Guid, T> oldItem)
//        {
//            OnPropertyChanged();
//            if (CollectionChanged != null)
//                CollectionChanged(this, new NotifyCollectionChangedEventArgs(action, newItem, oldItem));
//        }
//        private void OnCollectionChanged(NotifyCollectionChangedAction action, IList newItems)
//        {
//            OnPropertyChanged();
//            if (CollectionChanged != null)
//                CollectionChanged(this, new NotifyCollectionChangedEventArgs(action, newItems));
//        }
//    }

//}


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace BlackBox.Service
{
    public class BbInstanceDictionary<T> : IDictionary<uint, T>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        private readonly SortedDictionary<uint, T> _internalDict
            = new SortedDictionary<uint, T>();

        private readonly Dictionary<Type, BbInstanceTypeList<T>> _typedDic
            = new Dictionary<Type, BbInstanceTypeList<T>>();

        public ICollection<T> GetTypeOf(Type type)
        {
            if (_typedDic.ContainsKey(type))
            {
                return _typedDic[type];
            }

            throw new KeyNotFoundException();
        }

        public bool ContainsType(Type type)
        {
            return _typedDic.ContainsKey(type);
        }

        public SortedDictionary<uint, T> Dictionary
        {
            get { return _internalDict; }
        }

        public String Name { get; set; }

        public void Add(uint key, T value)
        {
            _internalDict.Add(key, value);
            OnCollectionChanged(NotifyCollectionChangedAction.Add, new KeyValuePair<uint, T>(key, value));
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
            get { return _internalDict[key]; }
            set { _internalDict[key] = value; }
        }

        #region ICollection<KeyValuePair<int,T>> Members

        public void Add(KeyValuePair<uint, T> item)
        {
            Add(item.Key, item.Value);

        }

        public void Clear()
        {
            if (_internalDict.Count > 0)
            {
                _internalDict.Clear();
                OnCollectionChanged();
            }

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
            get { return true; }
        }

        public bool Remove(KeyValuePair<uint, T> item)
        {
            //throw new NotImplementedException();
            return _internalDict.Remove(item.Key);
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


        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public event PropertyChangedEventHandler PropertyChanged;

        //private const string CountString = "Count";
        //private const string IndexerName = "Item[]";
        //private const string KeysName = "Keys";
        //private const string ValuesName = "Values";

        private void OnPropertyChanged()
        {
            //OnPropertyChanged(CountString);
            //OnPropertyChanged(IndexerName);
            //OnPropertyChanged(KeysName);
            //OnPropertyChanged(ValuesName);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(
                    this,
                    new PropertyChangedEventArgs(propertyName));
        }
        private void OnCollectionChanged()
        {
            OnPropertyChanged();
            if (CollectionChanged != null)
                CollectionChanged(
                    this,
                    new NotifyCollectionChangedEventArgs(
                        NotifyCollectionChangedAction.Reset));

        }
        private void OnCollectionChanged(
            NotifyCollectionChangedAction action,
            KeyValuePair<uint, T> changedItem)
        {
            OnPropertyChanged();
            if (CollectionChanged != null)
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(action, changedItem));
        }
        private void OnCollectionChanged(
            NotifyCollectionChangedAction action,
            KeyValuePair<uint, T> newItem,
            KeyValuePair<uint, T> oldItem)
        {
            OnPropertyChanged();
            if (CollectionChanged != null)
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(action, newItem, oldItem));
        }
        private void OnCollectionChanged(NotifyCollectionChangedAction action, IList newItems)
        {
            OnPropertyChanged();
            if (CollectionChanged != null)
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(action, newItems));
        }
    }

}





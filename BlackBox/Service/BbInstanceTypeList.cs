using System;
using System.Collections.Generic;



namespace BlackBox.Service
{
    /// <summary>
    /// DB for classifying sem accoridng to types
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BbInstanceTypeList<T> : IList<T>
    {
        private readonly List<T> _item = new List<T>();

        private readonly Type _semType = typeof(T);


        public Type SemType
        {
            get { return _semType; }
        }

        public int IndexOf(T item)
        {
            return _item.IndexOf(item);
            //            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            _item.Insert(index, item);
            //throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            _item.RemoveAt(index);
            //throw new NotImplementedException();
        }

        public T this[int index]
        {
            get
            {
                return _item[index];
                //throw new NotImplementedException();
            }
            set
            {
                _item[index] = value;
                //throw new NotImplementedException();
            }
        }

        public void Add(T item)
        {
            _item.Add(item);
            //throw new NotImplementedException();
        }

        public void Clear()
        {
            _item.Clear();
            //            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            return _item.Contains(item);
            //throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _item.CopyTo(array, arrayIndex);
            //throw new NotImplementedException();
        }

        public int Count
        {
            get
            {
                return _item.Count;
                //throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return true;
                //throw new NotImplementedException();
            }
        }

        public bool Remove(T item)
        {
            return _item.Remove(item);
            //throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _item.GetEnumerator();
            //throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _item.GetEnumerator();
            //throw new NotImplementedException();
        }
    }
}
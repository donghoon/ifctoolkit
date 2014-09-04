using System;
using System.Collections;
using System.Collections.Generic;

namespace EbInstanceModel
{
    /// <summary>
    /// for future usage
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class P21Collection<T> : ICollection<T> where T : P21Base
    {
        protected ArrayList _ArrayList;
        protected bool _IsReadOnly;

        // default constructor
        public P21Collection()
        {
            _ArrayList = new ArrayList();
        }

        // default accessro for the collection
        public virtual T this[int index]
        {
            get { return (T)_ArrayList[index]; }
            set { _ArrayList[index] = value; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            _ArrayList.Add(item);
        }

        public void Clear()
        {
            _ArrayList.Clear();
        }

        public bool Contains(T item)
        {
            //loop through the inner ArrayList
            foreach (T obj in _ArrayList)
            {
                //compare item
                if (obj == item)
                {
                    //if it matches return true
                    return true;
                }
            }
            //no match
            return false;

        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            bool result = false;

            //loop through the inner array's indices
            for (int i = 0; i < _ArrayList.Count; i++)
            {
                //store current index being checked
                T obj = (T)_ArrayList[i];

                //compare the item
                if (obj == item)
                {
                    //remove item from inner ArrayList at index i
                    _ArrayList.RemoveAt(i);
                    result = true;
                    break;
                }
            }

            return result;
        }

        public int Count
        {
            get { return _ArrayList.Count; }
        }

        public bool IsReadOnly
        {
            get { return _IsReadOnly; }
        }

    }
}
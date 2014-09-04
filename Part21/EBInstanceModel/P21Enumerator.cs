using System.Collections;
using System.Collections.Generic;

namespace EbInstanceModel
{
    /// <summary>
    /// for future usage
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class P21Enumerator<T> : IEnumerator<T> where T : P21Base
    {
        protected P21Collection<T> _collection;
        protected int index;
        protected T _current;

        // Default constructor
        public P21Enumerator()
        {
        }

        // Paramaterized constructor which takes
        // the collection which this enumerator will enumerate
        public P21Enumerator(P21Collection<T> collection)
        {
            _collection = collection;
            index = -1;
            _current = default(T);
        }

        public void Dispose()
        {
            _collection = null;
            _current = default(T);
            index = -1;
        }

        public bool MoveNext()
        {
            //make sure we are within the bounds of the collection
            if (++index >= _collection.Count)
            {
                //if not return false
                return false;
            }


            //if we are, then set the current element
            //to the next object in the collection
            _current = _collection[index];

            //return true
            return true;
        }

        public void Reset()
        {
            _current = default(T); //reset current object
            index = -1;
        }

        public T Current
        {
            get { return _current; }
        }

        object IEnumerator.Current
        {
            get { return _current; }
        }
    }
}
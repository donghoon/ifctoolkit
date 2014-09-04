using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Reflection;
using System.Text;
using EbInstanceModel;

namespace BlackBox.Service
{




    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public class BbInstanceList<TValue> : IDictionary<Guid, TValue> where TValue : BbBase
    {
        private Dictionary<Guid, TValue> _semDictionary = new Dictionary<Guid, TValue>();

        //#region specialization

        //private readonly List<TValue> _list
        //    = new List<TValue>();

        //private readonly Dictionary<Type, BbInstanceTypeList<TValue>> _typedList
        //    = new Dictionary<Type, BbInstanceTypeList<TValue>>();

        //private readonly Dictionary<Guid, BbInstanceList<TValue>> _referencedList
        //    = new Dictionary<Guid, BbInstanceList<TValue>>();





        /////// <summary>
        /////// Write p21 instances stored in EarlyBindingInstanceModel
        /////// </summary>
        /////// <param name="filename"></param>
        /////// <returns></returns>
        ////public bool WriteToP21(string filename)
        ////{
        ////    return EarlyBindingInstanceModel.Write(filename);
        ////}


        /////// <summary>
        /////// Fills the p21 instance Db with SEM instances.
        /////// </summary>
        /////// <returns><c>true</c>, if p21 instance D was filled, <c>false</c> otherwise.</returns>
        ////public bool FillP21InstanceDB()
        ////{
        ////    EarlyBindingInstanceModel.Reset();

        ////    foreach (var value in _list)
        ////    {
        ////        var v = value as BbBase;
        ////        if (v == null)
        ////        {
        ////            continue;
        ////        }
        ////        var ein = EarlyBindingInstanceModel.AddSem(v);
        ////        if (ein != 0)
        ////        {
        ////            _ifcToSemDictionary.Add(ein, v.Guid);
        ////            _semToIfcDictionary.Add(v.Guid, ein);
        ////        }
        ////    }

        ////    return true;
        ////}


        //#endregion



        ///// <summary>
        ///// Checks if 
        ///// </summary>
        ///// <param name="type"></param>
        ///// <returns></returns>
        //public bool Contains(Type type)
        //{
        //    var a = _typedList.ContainsKey(type);
        //    return a;
        //}


        //public BbInstanceTypeList<TValue> GetTypes(Type type)
        //{
        //    return Contains(type) ? _typedList[type] : null;
        //}


        //#region iarray implementation

        //public int IndexOf(TValue item)
        //{
        //    return _list.IndexOf(item);
        //}

        //public void Insert(int index, TValue item)
        //{
        //    _list.Insert(index, item);
        //}

        //public void RemoveAt(int index)
        //{
        //    _list.RemoveAt(index);
        //}

        //public TValue this[int index]
        //{
        //    get { return _list[index]; }
        //    set { _list[index] = value; }
        //}

        //public void Add(TValue item)
        //{
        //    _list.Add(item);

        //    AddToTypeList(item);

        //    //AddToP21InstanceDb(item);
        //}

        ///// <summary>
        ///// add to typed list
        ///// 20130830 donghoon
        ///// </summary>
        ///// <param name="item"></param>
        //private void AddToTypeList(TValue item)
        //{
        //    BbInstanceTypeList<TValue> add;
        //    var itemType = item.GetType();
        //    if (_typedList.ContainsKey(itemType))
        //    {
        //        add = _typedList[itemType];
        //    }
        //    else
        //    {
        //        add = new BbInstanceTypeList<TValue>();
        //        _typedList.Add(itemType, add);

        //    }

        //    add.Add(item);
        //}

        ///// <summary>
        ///// add collection
        ///// 20130830 donghoon
        ///// </summary>
        ///// <param name="items"></param>
        //private void AddToTypeList(IEnumerable<TValue> items)
        //{
        //    foreach (var value in items)
        //    {
        //        AddToTypeList(value);
        //    }
        //}

        //private void AddReferencing(TValue item)
        //{

        //}



        /////// <summary>
        /////// add ifc instance of SEM to Instance DB
        /////// </summary>
        /////// <param name="value"></param>
        ////private void AddToP21InstanceDb(TValue value)
        ////{
        ////    var v = value as BbBase;
        ////    if (v == null) return;
        ////    var ein = AddSem(v);
        ////    if (ein == 0) return;
        ////    _ifcToSemDictionary.Add(ein, v.Guid);
        ////    _semToIfcDictionary.Add(v.Guid, ein);
        ////}


        ////private void AddToP21InstanceDb(IEnumerable<TValue> items)
        ////{
        ////    foreach (var value in items)
        ////    {
        ////        AddToP21InstanceDb(value);
        ////    }
        ////}



        ///// <summary>
        ///// Add collection
        ///// 20130830 donghoon
        ///// </summary>
        ///// <param name="items"></param>
        //public void Add(IEnumerable<TValue> items)
        //{
        //    var a = items.ToList();
        //    _list.AddRange(a);
        //    AddToTypeList(a);
        //    //AddToP21InstanceDb(a);
        //}




        //public void Clear()
        //{
        //    _list.Clear();
        //    _typedList.Clear();
        //}

        //public bool Contains(TValue item)
        //{
        //    return _list.Contains(item);
        //}

        //public void CopyTo(TValue[] array, int arrayIndex)
        //{
        //    _list.CopyTo(array, arrayIndex);
        //}

        //public int Count
        //{
        //    get { return _list.Count; }
        //}

        //public bool IsReadOnly
        //{
        //    get { return ((IList<TValue>) _list).IsReadOnly; }
        //}

        //public bool Remove(TValue item)
        //{
        //    return _list.Remove(item);
        //}

        //public IEnumerator<TValue> GetEnumerator()
        //{
        //    return _list.GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}

        //#endregion


        #region specialization

        public void Add(TValue value)
        {
            _semDictionary.Add(value.Guid, value);
        }

        public void Add(IEnumerable<TValue> value)
        {
            
        }

        public bool Contains(Type type)
        {
            return false;
        }

        public BbInstanceTypeList<TValue> GetTypes(Type type)
        {
            return null;
        }

        #endregion




        #region IDictionary

        public IEnumerator<KeyValuePair<Guid, TValue>> GetEnumerator()
        {
            return _semDictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(KeyValuePair<Guid, TValue> item)
        {
            ((IDictionary<Guid, TValue>) _semDictionary).Add(item);
        }

        public void Clear()
        {
            _semDictionary.Clear();
        }

        public bool Contains(KeyValuePair<Guid, TValue> item)
        {
            return _semDictionary.Contains(item);
        }

        public void CopyTo(KeyValuePair<Guid, TValue>[] array, int arrayIndex)
        {
            ((IDictionary<Guid, TValue>) _semDictionary).CopyTo(array, arrayIndex);
            
        }

        public bool Remove(KeyValuePair<Guid, TValue> item)
        {
            return _semDictionary.Remove(item.Key);
        }

        public int Count
        {
            get { return _semDictionary.Count; }
        }
        public bool IsReadOnly { get; private set; }

        public bool ContainsKey(Guid key)
        {
            return _semDictionary.ContainsKey(key);
        }

        public void Add(Guid key, TValue value)
        {
            _semDictionary.Add(key, value);
        }

        public bool Remove(Guid key)
        {
            return _semDictionary.Remove(key);
        }

        public bool TryGetValue(Guid key, out TValue value)
        {
            return _semDictionary.TryGetValue(key, out value);
        }

        public TValue this[Guid key]
        {
            get
            {
                TValue value;
                if (!TryGetValue(key, out value))
                    throw new KeyNotFoundException();
                return value;
            }
            set
            {
                if (_semDictionary.ContainsKey(key)) throw new DuplicateKeyException(key);
                _semDictionary.Add(key, value);
            }

        }

        public ICollection<Guid> Keys
        {
            get { return _semDictionary.Keys; }
        }
        public ICollection<TValue> Values
        {
            get { return _semDictionary.Values; }
        }


        #endregion
    }
}

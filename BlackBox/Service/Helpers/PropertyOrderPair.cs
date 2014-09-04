using System;

namespace BlackBox.Service
{
    public class PropertyOrderPair : IComparable
    {
        private readonly int _order;
        public string Name { get; private set; }

        public PropertyOrderPair(string name, int order)
        {
            _order = order;
            Name = name;
        }

        public int CompareTo(object obj)
        {
            //
            // Sort the pair objects by ordering by order value
            // Equal values get the same rank
            //
            int otherOrder = ((PropertyOrderPair)obj)._order;
            if (otherOrder == _order)
            {
                //
                // If order not specified, sort by name
                //
                string otherName = ((PropertyOrderPair)obj).Name;
                return string.Compare(Name, otherName);
            }
            if (otherOrder > _order)
            {
                return -1;
            }
            return 1;
        }
    }
}